using FishShop.Controller;
using FishShop.model;
using FishShop.Model;
using FishShop.view;
using FishShop.View;
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

namespace FishShop
{
    public partial class FormFishShop : Form
    {
        HDController hDController;
        hoadon hoadon;
        ChiTietHoaDon cthd;
        List<hoadon> hoadonList;
        List<ChiTietHoaDon> cthdList;
        LoaiCaController loaiCaController;
        List<loaica> loaicaList;
        loaica loaica;
        public FormFishShop()
        {
            InitializeComponent();
        }

        private void btnAddHD_Click(object sender, EventArgs e)
        {
            FormHoaDon form = new FormHoaDon();
            form.Show();
        }

        private void FishShop_Load(object sender, EventArgs e)
        {
            hDController = new HDController();
            hoadon = new hoadon();
            cthd = new ChiTietHoaDon();
            hoadonList = new List<hoadon>();
            cthdList = new List<ChiTietHoaDon>();
            loaiCaController = new LoaiCaController();
            loaicaList = new List<loaica>();
            loaica = new loaica();

            loaicaList = loaiCaController.Load();
            //load dữ liệu lần đầu
            btnLoadAll_Click(sender, e);
        }

        //Đăng xuất
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin login = new FormLogin();
            login.Show();
        }

        // Load dữ liệu
        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            hoadonList.Clear();
            hoadonList = hDController.Load();
            LoadList(hoadonList);

        }
        // Chuyển decimal sang kiểu tiền việt nam
        private string FormattedVND(decimal tien)
        {
            string tienFormatted = tien.ToString("C", new CultureInfo("vi-VN"));
            return tienFormatted;
        }

        // Hàm load dữ liệu lên dataGridHd
        private void LoadList(List<hoadon> list_hoaDon)
        {
            dataGridHD.Rows.Clear();
            dataGridCTHD.Rows.Clear();

            foreach (hoadon hoadon in list_hoaDon)
            {
                int rowIndex = dataGridHD.Rows.Add();
                dataGridHD.Rows[rowIndex].Cells[0].Value = hoadon.getMaHD();
                dataGridHD.Rows[rowIndex].Cells[1].Value = hoadon.getNgayHD();
                dataGridHD.Rows[rowIndex].Cells[2].Value = hoadon.getTenKH();
                decimal total = 0;
                foreach (ChiTietHoaDon cthd in hoadon.getcthds())
                {
                    total += cthd.getSoLuong() * cthd.getDonGia();
                }
                dataGridHD.Rows[rowIndex].Cells[3].Value = FormattedVND(total);

            }
        }

        // Tìm kiếm tất cả hóa đơn theo ngày
        private void dateSearch_ValueChanged(object sender, EventArgs e)
        {
            hoadonList.Clear();
            hoadonList = hDController.GetHoadonToDay(dateSearch.Value);
            LoadList(hoadonList);
        }

        //Load chi tiết hóa đơn lên datagridCTHD
        private void dataGridHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridHD.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridHD.SelectedRows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string maHD = row.Cells[0].Value.ToString();
                        hoadon = hDController.Get(maHD);
                        if (hoadon != null)
                        {
                            dataGridCTHD.Rows.Clear();
                            foreach (ChiTietHoaDon cthd in hoadon.getcthds())
                            {
                                int rowIndex = dataGridCTHD.Rows.Add();
                                dataGridCTHD.Rows[rowIndex].Cells[0].Value = loaiCaController.Get(cthd.getMaCa()).getFishName();

                                string img = loaiCaController.Get(cthd.getMaCa()).getImage();
                                string projectDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                                string imagePath = Path.Combine(projectDirectory, "img", img);
                                Image imgs = null;
                                FileStream fs = null;
                                try
                                {
                                    fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                                    imgs = Image.FromStream(fs);
                                    dataGridCTHD.Rows[rowIndex].Cells[1].Value = imgs;
                                }
                                finally
                                {
                                    if (fs != null)
                                    {
                                        fs.Close();
                                        fs.Dispose();
                                    }
                                }
                                dataGridCTHD.Rows[rowIndex].Cells[2].Value = cthd.getSoLuong();
                                dataGridCTHD.Rows[rowIndex].Cells[3].Value = FormattedVND(cthd.getDonGia());
                            }
                        }
                    }
                }
            }

        }
        private void btnDeleteHD_Click(object sender, EventArgs e)
        {
            if (dataGridHD.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridHD.SelectedRows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string maHD = row.Cells[0].Value.ToString();
                        hoadon = hDController.Get(maHD);
                        if (hoadon != null)
                        {
                            DialogResult result = MessageBox.Show("Bạn có muốn xóa hóa đơn với mã hóa đơn là " + maHD + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                if (hDController.isExist(maHD))
                                {
                                    if (hDController.Delete(maHD))
                                    {
                                        MessageBox.Show("Đã xóa phiếu nhập với số phiếu là " + maHD + " !");
                                        btnLoadAll_Click(sender, e);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Lỗi khi xóa phiếu nhập !");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Phiếu nhập không tồn tại !");
                                }
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
        private void dataGridCTHD_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
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
        private Image ResizeImage(Image image, int newWidth, int newHeight)
        {
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return resizedImage;
        }

        private void btnQLCa_Click(object sender, EventArgs e)
        {
            FormDSCa dSCa = new FormDSCa();
            dSCa.Show();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            FormResetPass form = new FormResetPass();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
