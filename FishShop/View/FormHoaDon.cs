using FishShop.Controller;
using FishShop.In;
using FishShop.model;
using FishShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FishShop.View
{
    public partial class FormHoaDon : Form
    {
        hoadon hoadon;
        HDController hDController;
        ChiTietHoaDon cthd;
        List<ChiTietHoaDon> cthdList;
        LoaiCaController loaiCaController;
        List<loaica> loaicaList;
        decimal tongHoaDon;
        public FormHoaDon()
        {
            InitializeComponent();

        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            hoadon = new hoadon();
            hDController = new HDController();
            cthd = new ChiTietHoaDon();
            cthdList = new List<ChiTietHoaDon>();
            loaiCaController = new LoaiCaController();
            loaicaList = new List<loaica>();
            loaicaList = loaiCaController.Load();
            dataGridCTHD.Rows.Clear();
            foreach (loaica c in loaicaList)
            {
                //kiểm tra số lượng và load combobox trong datagridView
                if (c.getSoLuong() == 0)
                {
                    columeNameFish.Items.Add(c.getId() + "-" + c.getFishName() + "\n(đã hết)");
                }
                else
                {
                    columeNameFish.Items.Add(c.getId() + "-" + c.getFishName() + "\n-" + c.getSoLuong());
                }
            }
            tongHoaDon = 0;
        }

        private void dataGridCTHD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Load dữ liệu cho image, price and thông tin
            if (e.ColumnIndex == 0)
            {
                if (dataGridCTHD.Rows[e.RowIndex].Cells[0].Value != null)
                {

                    String Name = dataGridCTHD.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    if (Name.EndsWith("(đã hết)"))
                    {
                        MessageBox.Show("Cá này đã hết. Vui lòng chọn cá khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridCTHD.Rows[e.RowIndex].Cells[2].Value = null;
                        dataGridCTHD.Rows[e.RowIndex].Cells[3].Value = null;
                        dataGridCTHD.Rows[e.RowIndex].Cells[4].Value = null;
                        dataGridCTHD.Rows[e.RowIndex].Cells[5].Value = null;
                        dataGridCTHD.Rows[e.RowIndex].Cells[6].Value = null;


                    }
                    else
                    {
                        int id = int.Parse(SplitId(Name)[0]);

                        //Load Image
                        string img = loaiCaController.Get(id).getImage();
                        string projectDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                        string imagePath = Path.Combine(projectDirectory, "img", img);
                        LoadTongTien();

                        Image imgs = null;
                        FileStream fs = null;
                        try
                        {
                            fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                            imgs = Image.FromStream(fs);
                            dataGridCTHD.Rows[e.RowIndex].Cells[2].Value = imgs;
                        }
                        finally
                        {
                            if (fs != null)
                            {
                                fs.Close();
                                fs.Dispose();
                            }
                        }
                        dataGridCTHD.Rows[e.RowIndex].Cells[3].Value = loaiCaController.Get(id).getColor();
                        dataGridCTHD.Rows[e.RowIndex].Cells[4].Value = loaiCaController.Get(id).getOrigin();
                        dataGridCTHD.Rows[e.RowIndex].Cells[5].Value = loaiCaController.Get(id).getPrice();
                        //kiểm tra và load price
                        if (dataGridCTHD.Rows[e.RowIndex].Cells[1].Value != null)
                        {
                            CheckFishAndLoad(id, e.RowIndex);
                        }
                    }


                }
            }
            if (e.ColumnIndex == 1)
            {
                if (dataGridCTHD.Rows[e.RowIndex].Cells[1].Value != null && dataGridCTHD.Rows[e.RowIndex].Cells[5].Value != null)
                {
                    String Name = dataGridCTHD.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    int id = int.Parse(SplitId(Name)[0]);
                    CheckFishAndLoad(id, e.RowIndex);
                }
            }
        }
        // Kiểm tra number và load thành tiền, tổng tiền
        private void dataGridCTHD_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == Column_number.Index)
            {
                string value = e.FormattedValue.ToString();
                if (!string.IsNullOrWhiteSpace(value))
                {
                    int number;
                    if (!int.TryParse(value, out number))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Vui lòng chỉ nhập số vào cột Số lượng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (int.Parse(value) <= 0)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //Kiểm tra số lượng trong kho và load thành tiền, tổng tiền
        private void CheckFishAndLoad(int id, int rowIndex)
        {
            loaica loaica = loaiCaController.Get(id);
            int soLuong = int.Parse(dataGridCTHD.Rows[rowIndex].Cells[1].Value.ToString().Trim());
            decimal price = decimal.Parse(dataGridCTHD.Rows[rowIndex].Cells[5].Value.ToString().Trim());
            if (loaica != null)
            {
                if (loaica.getSoLuong() < soLuong)
                {
                    MessageBox.Show("Cá này vượt số lượng trong bể !");
                    dataGridCTHD.Rows[rowIndex].Cells[1].Value = null;
                    dataGridCTHD.Rows[rowIndex].Cells[6].Value = null;
                }
                else
                {
                    dataGridCTHD.Rows[rowIndex].Cells[6].Value = soLuong * price;
                    LoadTongTien();
                }
            }
        }
        // Load thành tiền, tổng tiền
        private void LoadTongTien()
        {

            tongHoaDon = 0;
            for (int i = 0; i < dataGridCTHD.Rows.Count; i++)
            {
                if (dataGridCTHD.Rows[i].Cells[6].Value != null)
                {
                    tongHoaDon += decimal.Parse(dataGridCTHD.Rows[i].Cells[6].Value.ToString());
                }
            }
            lbTongTien.Text = "Tổng hóa đơn: " + tongHoaDon.ToString("C");
            if (!string.IsNullOrEmpty(txtTienMat.Text))
            {
                decimal TienThua = decimal.Parse(txtTienMat.Text) - tongHoaDon;
                lb_Money.Text = "Tiền thối lại: " + TienThua.ToString("C");
            }
        }
        // Add and Print Bill
        private void btn_addHD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTienMat.Text))
            {
                bool check = false;
                DateTime date = DateTime.Now;
                cthdList.Clear();
                for (int i = 0; i < dataGridCTHD.Rows.Count - 1; i++)
                {
                    if (dataGridCTHD.Rows[i].Cells[0].Value != null && dataGridCTHD.Rows[i].Cells[1].Value != null)
                    {
                        String Name = dataGridCTHD.Rows[i].Cells[0].Value.ToString().Trim();
                        int id = int.Parse(SplitId(Name)[0]);
                        cthd = new ChiTietHoaDon();
                        cthd.setMaCa(id);
                        cthd.setSoLuong(int.Parse(dataGridCTHD.Rows[i].Cells[1].Value.ToString().Trim()));
                        cthd.setDonGia(decimal.Parse(dataGridCTHD.Rows[i].Cells[5].Value.ToString().Trim()));

                        cthdList.Add(cthd);
                    }
                    else if (dataGridCTHD.Rows[i].Cells[0].Value != null && dataGridCTHD.Rows[i].Cells[1].Value == null)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng cho " + dataGridCTHD.Rows[i].Cells[0].Value.ToString() + " !");
                        check = true;
                        break;
                    }
                    else if (dataGridCTHD.Rows[i].Cells[0].Value == null && dataGridCTHD.Rows[i].Cells[1].Value != null)
                    {
                        MessageBox.Show("Vui lòng chọn loại cá cho sản phẩm thứ " + (i + 1) + " !");
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    return;
                }
                if (dataGridCTHD.Rows[0].Cells[0].Value != null && dataGridCTHD.Rows[0].Cells[1].Value != null)
                {
                    if (!string.IsNullOrEmpty(txtNameKH.Text))
                    {
                        hoadon = new hoadon(date, txtNameKH.Text, cthdList);
                        hoadon hoadonNew = hoadon;
                        if (hDController.Add(hoadon))
                        {
                            MessageBox.Show("Lưu thành công !");
                            PrintHoaDon.CreateAndSavePDF(hoadonNew, decimal.Parse(txtTienMat.Text.ToString()));
                            FormHoaDon_Load(sender, e);
                            txtNameKH.Clear();
                            lbTongTien.Text = "Tổng hóa đơn: 0VNĐ";
                            lb_Money.Text = "Tiền thối lại: 0VNĐ";
                            txtTienMat.Clear();
                        }
                        else
                        {
                            MessageBox.Show("lỗi không lưu được hóa đơn !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập tên khách hàng !");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có sản phẩm nào !");
                }
            }
            else
            {
                MessageBox.Show("Hãy thu tiền khách hàng trước khi xuất hóa đơn !");
            }
        }

        //Cắt lấy list bằng ký tự "-"
        private string[] SplitId(string text)
        {
            string[] parts = text.Split('-');
            if (parts.Length >= 2)
            {
                return parts;
            }
            return null;
        }
        //Formatted money VNĐ
        private string FormattedVND(decimal tien)
        {
            string tienFormatted = tien.ToString("C", new CultureInfo("vi-VN"));
            return tienFormatted;
        }

        //Căn chỉnh lại image và kích thước Row
        private void dataGridCTHD_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                int newWidth = 80; // Độ rộng mới
                int newHeight = 80; // Độ cao mới
                dataGridCTHD.Rows[e.RowIndex].Height = newHeight;
                // Lấy hình ảnh từ ô cột
                System.Drawing.Image originalImage = (System.Drawing.Image)dataGridCTHD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

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
        // Edit Size Image
        private Image ResizeImage(Image image, int newWidth, int newHeight)
        {
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return resizedImage;
        }

        private void txtTienMat_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTienMat.Text))
            {
                if (!int.TryParse(txtTienMat.Text, out _))
                {
                    MessageBox.Show("Vui lòng nhập số tiền.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Xoá nội dung không hợp lệ
                    txtTienMat.Text = "";
                }
                else
                {
                    if (tongHoaDon != 0)
                    {
                        decimal TienThua = decimal.Parse(txtTienMat.Text) - tongHoaDon;
                        lb_Money.Text = "Tiền thối lại: " + TienThua.ToString("C");
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
