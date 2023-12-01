using FishShop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishShop.Model
{
    internal class hoadon
    {
        private string maHD;
        private DateTime ngayHD;
        private string tenKH;
        private List<ChiTietHoaDon> cthds = new List<ChiTietHoaDon>();

        public hoadon() { }

        public hoadon(DateTime ngayHD, string tenKH, List<ChiTietHoaDon> cthds)
        {
            this.ngayHD = ngayHD;
            this.tenKH = tenKH;
            this.cthds = cthds;
        }
        public hoadon(string mahd, DateTime ngayHD, string tenKH, List<ChiTietHoaDon> cthds)
        {
            this.maHD = mahd;
            this.ngayHD = ngayHD;
            this.tenKH = tenKH;
            this.cthds = cthds;
        }
        public List<ChiTietHoaDon> getcthds() {  return cthds; }
        public void setcthds(List<ChiTietHoaDon> cthds) {  this.cthds = cthds;}
        public void setMaHD(string maHD)
        {
            this.maHD = maHD;
        }

        public string getMaHD()
        {
            return maHD;
        }

        public void setNgayHD(DateTime ngayHD)
        {
            this.ngayHD = ngayHD;
        }

        public DateTime getNgayHD()
        {
            return ngayHD;
        }

        public void setTenKH(string tenKH)
        {
            this.tenKH = tenKH;
        }

        public string getTenKH()
        {
            return tenKH;
        }
        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (ChiTietHoaDon cthd in cthds)
            {
                total += cthd.getSoLuong() * cthd.getDonGia();
            }
            return total;
        }

    }
}
