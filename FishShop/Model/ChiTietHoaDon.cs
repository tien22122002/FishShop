using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishShop.model
{
    internal class ChiTietHoaDon
    {
        private string maHD;
        private int maCa;
        private int soLuong;
        private Decimal donGia;

        public ChiTietHoaDon() { }

        public ChiTietHoaDon(string maHD, int maCa, int soLuong, decimal donGia)
        {
            this.maHD = maHD;
            this.maCa = maCa;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public void setMaHD(string maHD)
        {
            this.maHD = maHD;
        }

        public string getMaHD()
        {
            return maHD;
        }

        public void setMaCa(int maCa)
        {
            this.maCa = maCa;
        }

        public int getMaCa()
        {
            return maCa;
        }

        public void setSoLuong(int soLuong)
        {
            this.soLuong = soLuong;
        }

        public int getSoLuong()
        {
            return soLuong;
        }

        public void setDonGia(Decimal donGia)
        {
            this.donGia = donGia;
        }

        public Decimal getDonGia()
        {
            return donGia;
        }
    }
}
