using FishShop.model;
using FishShop.Model;
using FishShop.Utils;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishShop.Controller
{

    internal class HDController
    {
        List<hoadon> hoadonList;
        hoadon hoadon;
        ChiTietHoaDon cthd;
        List<ChiTietHoaDon> cthdList;
        public HDController()
        {
            hoadon = new hoadon();
            hoadonList = new List<hoadon>();
            cthd = new ChiTietHoaDon();
            cthdList = new List<ChiTietHoaDon>();

        }

        public List<hoadon> Load()
        {
            hoadonList.Clear();
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM HOADON", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            string mahd = reader["MaHoaDon"].ToString();
                            DateTime ngayhd = DateTime.Parse(reader["NgayHoaDon"].ToString());
                            string namekh = reader["TenKhachHang"].ToString();

                            
                            hoadon = new hoadon(mahd, ngayhd, namekh, null);
                            hoadonList.Add(hoadon);
                        }
                    }
                }
                foreach(hoadon hoadon in hoadonList)
                {
                    string mahd = hoadon.getMaHD();
                    using (SqlCommand commandct = new SqlCommand("SELECT * FROM CHITIETHOADON WHERE MaHoaDon = '" + mahd + "'", conn))
                    {
                        using (SqlDataReader readerct = commandct.ExecuteReader())
                        {
                            cthdList = new List<ChiTietHoaDon>();
                            while (readerct.Read())
                            {

                                int maca = int.Parse(readerct["MaCa"].ToString());
                                int soluong = int.Parse(readerct["SoLuong"].ToString());
                                decimal dongia = decimal.Parse(readerct["DonGia"].ToString());

                                cthd = new ChiTietHoaDon(mahd, maca, soluong, dongia);
                                cthdList.Add(cthd);
                            }
                            hoadon.setcthds(cthdList);
                        }
                    }
                }
            }

            return hoadonList;
        }
        public List<hoadon> GetHoadonToDay(DateTime dateTime)
        {
            string datefind = dateTime.ToString("yyyy-MM-dd");
            hoadonList.Clear();
            hoadonList = Load();
            List<hoadon> list = new List<hoadon>();
            foreach(hoadon hoadon in hoadonList)
            {
                string date = hoadon.getNgayHD().ToString("yyyy-MM-dd");
                if(datefind == date)
                {
                    list.Add(hoadon);
                }
            }
            return list;
        }
        public hoadon? Get(string maHd)
        {
            hoadonList.Clear();
            hoadonList = Load();
            foreach (hoadon hoadon in hoadonList)
            {
                if(hoadon.getMaHD() == maHd){
                    return hoadon;
                }
            }
            return null;
        }
        
        public bool Add(hoadon hoadon)
        {
            if (hoadon == null)
            {
                return false;
            }
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                try
                {
                    DateTime ngayHD = hoadon.getNgayHD();
                    string tenKH = hoadon.getTenKH();
                    string selectCountQuery = "SELECT COUNT(*) FROM HOADON WHERE CONVERT(DATE, NgayHoaDon) = @ngayhd";
                    using (SqlCommand selectCountCommand = new SqlCommand(selectCountQuery, conn))
                    {
                        selectCountCommand.Parameters.AddWithValue("@ngayhd", ngayHD.ToString("yyyy-MM-dd"));
                        int count = (int)selectCountCommand.ExecuteScalar() + 1;

                        string maHD;
                        do
                        { 
                            maHD = "HD" + hoadon.getNgayHD().ToString("yyMMdd") + count.ToString("000");
                            count ++;
                        } while (isExist(maHD));
                        

                        hoadon.setMaHD(maHD);
                        string insertHoaDonQuery = "INSERT INTO HOADON (MaHoaDon, NgayHoaDon, TenKhachHang) VALUES (@mahd, @ngayhd, @tenkh)";
                        string updateLoaiCaQuery = "UPDATE loai_ca SET SoLuong = SoLuong - @soluong WHERE id = @maca";
                        using (SqlCommand insertHoaDonCommand = new SqlCommand(insertHoaDonQuery, conn))
                        {
                            insertHoaDonCommand.Parameters.AddWithValue("@mahd", maHD);
                            insertHoaDonCommand.Parameters.AddWithValue("@ngayhd", ngayHD);
                            insertHoaDonCommand.Parameters.AddWithValue("@tenkh", tenKH);
                            int rowsAffected = insertHoaDonCommand.ExecuteNonQuery();
                            if (rowsAffected > 0) {
                                string insertChiTietQuery = "INSERT INTO CHITIETHOADON (MaHoaDon, MaCa, SoLuong, DonGia) VALUES (@mahd, @maca, @soluong, @dongia)";
                                foreach (ChiTietHoaDon cthd in hoadon.getcthds())
                                {
                                    using (SqlCommand insertChiTietCommand = new SqlCommand(insertChiTietQuery, conn))
                                    {
                                        insertChiTietCommand.Parameters.AddWithValue("@mahd", maHD);
                                        insertChiTietCommand.Parameters.AddWithValue("@maca", cthd.getMaCa());
                                        insertChiTietCommand.Parameters.AddWithValue("@soluong", cthd.getSoLuong());
                                        insertChiTietCommand.Parameters.AddWithValue("@dongia", cthd.getDonGia());
                                        int rowsCT = insertChiTietCommand.ExecuteNonQuery();
                                        if (rowsCT == 0)
                                        {
                                            conn.Close();
                                            return Delete(maHD);
                                        }
                                        else
                                        {
                                            using (SqlCommand updateLoaiCaCommand = new SqlCommand(updateLoaiCaQuery, conn))
                                            {
                                                updateLoaiCaCommand.Parameters.AddWithValue("@soluong", cthd.getSoLuong());
                                                updateLoaiCaCommand.Parameters.AddWithValue("@maca", cthd.getMaCa());
                                                updateLoaiCaCommand.ExecuteNonQuery();
                                            }
                                        }
                                    }
                                }
                            }
                            
                            conn.Close();
                            return rowsAffected > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                    return false;
                }
            }
        }
        public bool Delete(String maHD)
        {
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "DELETE FROM CHITIETHOADON WHERE MaHoaDon = @mahd";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mahd", maHD);
                    int rowsAffected = command.ExecuteNonQuery();
                    
                    string deleteQuery = "DELETE FROM HOADON WHERE MaHoaDon = @mahd";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCommand.Parameters.AddWithValue("@mahd", maHD);
                        deleteCommand.ExecuteNonQuery();
                    }

                    
                    conn.Close();
                    return rowsAffected > 0;
                }
            }
        }
        public bool isExist(string maHD)
        {
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM HOADON WHERE MAHOADON = @mahd";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mahd", maHD);
                    int rowCount = (int)command.ExecuteScalar();
                    conn.Close();
                    return rowCount > 0;
                }
            }
        }
    }
}
