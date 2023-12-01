using FishShop.Controller;
using FishShop.model;
using FishShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishShop.View
{
    public partial class FormDSCa : Form
    {
        private string selectedImagePath;
        LoaiCaController loaiCaController;
        DongCaController dongCaController;
        List<loaica> loaicaList;
        List<dongca> dongcaList;
        loaica loaica;
        dongca dongca;
        public FormDSCa()
        {
            InitializeComponent();
        }

        private void DSCa_Load(object sender, EventArgs e)
        {
            loaiCaController = new LoaiCaController();
            dongCaController = new DongCaController();
            loaicaList = new List<loaica>();
            dongcaList = new List<dongca>();
            loaica = new loaica();
            dongca = new dongca();

            LoadData();
        }
        private void LoadData()
        {
            if (loaicaList.Count > 0)
            {
                loaicaList.Clear();
            }
            if (dongcaList.Count > 0)
            {
                dongcaList.Clear();
            }
            loaicaList = loaiCaController.Load();
            dongcaList = dongCaController.Load();

            dataGridListCa.Rows.Clear();

            foreach (loaica loaica in loaicaList)
            {
                dongca dongcaFind = dongCaController.Get(loaica.getMaCa());

                int rowIndex = dataGridListCa.Rows.Add();
                dataGridListCa.Rows[rowIndex].Cells[0].Value = loaica.getId();
                dataGridListCa.Rows[rowIndex].Cells[1].Value = loaica.getFishName();
                dataGridListCa.Rows[rowIndex].Cells[2].Value = dongcaFind.getMaCa() + "-" + dongcaFind.getTenDongCa();

                string img = loaica.getImage();
                string projectDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

                string imagePath = Path.Combine(projectDirectory, "img", img);
                Image imgs = null;
                FileStream fs = null;
                try
                {
                    fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                    imgs = Image.FromStream(fs);
                    dataGridListCa.Rows[rowIndex].Cells[3].Value = imgs;
                }
                catch (ArgumentException ex)
                {
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                        fs.Dispose();
                    }
                }
                dataGridListCa.Rows[rowIndex].Cells[4].Value = loaica.getColor();
                dataGridListCa.Rows[rowIndex].Cells[5].Value = loaica.getOrigin();
                dataGridListCa.Rows[rowIndex].Cells[6].Value = FormattedVND(loaica.getPrice());
                dataGridListCa.Rows[rowIndex].Cells[7].Value = loaica.getSoLuong();
            }
            cbbMaCa.Items.Clear();
            foreach (dongca dongca in dongcaList)
            {
                cbbMaCa.Items.Add(dongca.getMaCa() + "-" + dongca.getTenDongCa());
            }
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {

            string maca = SplitId(cbbMaCa.Text);
            loaica = new loaica(0, maca, txtTenCa.Text.ToString(),
            txtImage.Text.ToString(), txtColor.Text.ToString(),
            txtNguonGoc.Text.ToString(),
            decimal.Parse(txtDonGia.Text.ToString()),
            int.Parse(numberUpDown.Value.ToString()));
            if (loaiCaController.Insert(loaica))
            {
                AddImage();
                MessageBox.Show("Đã cập nhật thành công !");
                LoadData();
                ClearTxt();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridListCa.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridListCa.SelectedRows)
                {
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    loaica = loaiCaController.Get(id);
                    if (loaica != null)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn xóa loại cá " + loaica.getFishName() + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            if (loaiCaController.isExist(id))
                            {
                                if (loaiCaController.Delete(id))
                                {
                                    MessageBox.Show("Đã xóa loại cá " + loaica.getFishName() + " !");
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Lỗi khi xóa cá " + loaica.getFishName() + " !");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cá không tồn tại !");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 đối tượng muốn xóa !");
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {

            if (dataGridListCa.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridListCa.SelectedRows)
                {
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    string maca = SplitId(cbbMaCa.Text);
                    loaica = new loaica(id, maca, txtTenCa.Text.ToString(),
                        txtImage.Text.ToString(), txtColor.Text.ToString(),
                        txtNguonGoc.Text.ToString(),
                        decimal.Parse(txtDonGia.Text.ToString()),
                        int.Parse(numberUpDown.Value.ToString()));
                    if (loaiCaController.isExist(id))
                    {
                        if (loaiCaController.Update(loaica))
                        {
                            if (!txtImage.Text.Equals(loaiCaController.Get(id).getImage()))
                            {
                                AddImage();
                            }
                            MessageBox.Show("Đã cập nhật thành công !");
                            LoadData();
                            ClearTxt();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cá không tồn tại !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đối lượng để cập nhật !");
            }
        }
        private void btn_choosefile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                string selectedImageName = Path.GetFileName(selectedImagePath);
                txtImage.Text = selectedImageName;
            }
        }
        private void dataGridListCa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridListCa.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridListCa.SelectedRows)
                {
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    loaica loaica = loaiCaController.Get(id);
                    txtTenCa.Text = row.Cells[1].Value.ToString();
                    txtImage.Text = loaica.getImage();
                    cbbMaCa.SelectedItem = row.Cells[2].Value.ToString();
                    txtColor.Text = row.Cells[4].Value.ToString();
                    txtNguonGoc.Text = row.Cells[5].Value.ToString();
                    txtDonGia.Text = loaica.getPrice().ToString();
                    numberUpDown.Value = int.Parse(row.Cells[7].Value.ToString());

                }
            }
        }
        private void AddImage()
        {

            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                // Thư mục đích để lưu tệp hình ảnh
                string destinationDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\img\\";

                try
                {
                    // Kiểm tra xem thư mục đích có tồn tại chưa, nếu không thì tạo mới
                    if (!Directory.Exists(destinationDirectory))
                    {
                        Directory.CreateDirectory(destinationDirectory);
                    }
                    // Lấy tên tệp hình ảnh đã chọn
                    string selectedImageName = Path.GetFileName(selectedImagePath);

                    // Tạo đường dẫn đầy đủ của tệp hình ảnh trong thư mục đích
                    string destinationFilePath = Path.Combine(destinationDirectory, selectedImageName);

                    // Kiểm tra xem tệp đã tồn tại chưa, nếu có thì đổi tên
                    if (File.Exists(destinationFilePath))
                    {
                        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(selectedImageName);
                        string fileExtension = Path.GetExtension(selectedImageName);
                        int count = 1;

                        // Tạo một tên mới cho tệp
                        while (File.Exists(destinationFilePath))
                        {
                            selectedImageName = $"{fileNameWithoutExtension}_{count}{fileExtension}";
                            destinationFilePath = Path.Combine(destinationDirectory, selectedImageName);
                            count++;
                        }
                    }

                    // Sao chép tệp hình ảnh đã chọn vào thư mục đích
                    File.Copy(selectedImagePath, destinationFilePath, true);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu hình ảnh: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tệp hình ảnh trước.");
            }
        }
        private void ClearTxt()
        {
            txtTenCa.Clear();
            txtImage.Clear();
            txtColor.Clear();
            txtNguonGoc.Clear();
            txtDonGia.Clear();
            cbbMaCa.SelectedItem = "";
            numberUpDown.Value = 0;
        }

        private string SplitId(string text)
        {
            string[] parts = text.Split('-');
            if (parts.Length >= 2)
            {
                return parts[0].Trim();
            }
            return "";
        }
        private string FormattedVND(decimal tien)
        {
            string tienFormatted = tien.ToString("C", new CultureInfo("vi-VN"));
            return tienFormatted;
        }
        private void dgv_listFish_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                int newWidth = 80; // Độ rộng mới
                int newHeight = 80; // Độ cao mới
                dataGridListCa.Rows[e.RowIndex].Height = newHeight;
                // Lấy hình ảnh từ ô cột
                System.Drawing.Image originalImage = (System.Drawing.Image)dataGridListCa.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Kiểm tra xem hình ảnh không null và có đúng kiểu dữ liệu
                if (originalImage != null && originalImage is System.Drawing.Image)
                {
                    // Thay đổi kích thước của hình ảnh
                    System.Drawing.Image resizedImage = ResizeImage(originalImage, newWidth, newHeight);

                    // Hiển thị hình ảnh đã thay đổi kích thước
                    e.Value = resizedImage;
                }
            }
        }
        private Image ResizeImage(Image image, int newWidth, int newHeight)
        {
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return resizedImage;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_search.Text))
            {
                string search = tb_search.Text;
                loaicaList.Clear();

                loaicaList = loaiCaController.GetFishByName(search);

                dataGridListCa.Rows.Clear();
                foreach (loaica loaica in loaicaList)
                {
                    dongca dongcaFind = dongCaController.Get(loaica.getMaCa());

                    int rowIndex = dataGridListCa.Rows.Add();
                    dataGridListCa.Rows[rowIndex].Cells[0].Value = loaica.getId();
                    dataGridListCa.Rows[rowIndex].Cells[1].Value = loaica.getFishName();
                    dataGridListCa.Rows[rowIndex].Cells[2].Value = dongcaFind.getMaCa() + "-" + dongcaFind.getTenDongCa();

                    string img = loaica.getImage();
                    string projectDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

                    string imagePath = Path.Combine(projectDirectory, "img", img);
                    Image imgs = null;
                    FileStream fs = null;
                    try
                    {
                        fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                        imgs = Image.FromStream(fs);
                        dataGridListCa.Rows[rowIndex].Cells[3].Value = imgs;
                    }
                    catch (ArgumentException ex)
                    {
                    }
                    finally
                    {
                        if (fs != null)
                        {
                            fs.Close();
                            fs.Dispose();
                        }
                    }
                    dataGridListCa.Rows[rowIndex].Cells[4].Value = loaica.getColor();
                    dataGridListCa.Rows[rowIndex].Cells[5].Value = loaica.getOrigin();
                    dataGridListCa.Rows[rowIndex].Cells[6].Value = FormattedVND(loaica.getPrice());
                    dataGridListCa.Rows[rowIndex].Cells[7].Value = loaica.getSoLuong();
                }
            }
            else
            {
                LoadData();
            }
        }
    }
}
