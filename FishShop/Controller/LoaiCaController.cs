using FishShop.model;
using FishShop.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishShop.Controller
{
    internal class LoaiCaController
    {
        loaica loaica;
        List<loaica> loaicaList;
        public LoaiCaController()
        {
            loaicaList = new List<loaica>();
            loaica = new loaica();
        }
        public List<loaica> Load()
        {
            loaicaList.Clear();
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM loai_ca", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = int.Parse(reader["ID"].ToString());
                            string maca = reader["MaCa"].ToString();
                            string name = reader["fish_name"].ToString();
                            string img = reader["Image"].ToString();
                            string color = reader["Color"].ToString();
                            string NguonGoc = reader["NguonGoc"].ToString();
                            decimal DonGia = decimal.Parse(reader["Price"].ToString());
                            int soluong = int.Parse(reader["SoLuong"].ToString());
                            loaica = new loaica(id, maca, name, img, color, NguonGoc, DonGia, soluong);
                            loaicaList.Add(loaica);
                        }
                    }
                }
            }

            return loaicaList;
        }

        public loaica Get(int id)
        {
            foreach (loaica loaica in loaicaList)
            {
                if (loaica.getId() == id)
                {
                    return loaica;
                }
            }
            return null;
        }
        public List<loaica> GetFishByName(string name)
        {
            List<loaica> loaicas = new List<loaica>();
            loaicaList.Clear();
            loaicaList = Load();
            
            foreach(loaica loaica in loaicaList)
            {
                if (loaica.getFishName().ToLower().Contains(name.ToLower()))
                {
                    loaicas.Add(loaica);
                }
            }
            return loaicas;
        }
        public bool Insert(loaica loaica)
        {
            string maCa = loaica.getMaCa();
            string fishName = loaica.getFishName();
            string image = loaica.getImage();
            string color = loaica.getColor();
            string origin = loaica.getOrigin();
            decimal price = loaica.getPrice();
            int soLuong = loaica.getSoLuong();

            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "INSERT INTO loai_ca (MaCa, fish_name, Image, Color, NguonGoc, Price, SoLuong) VALUES (@maca, @fishname, @image, @color, @origin, @price, @soluong)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@maca", maCa);
                    command.Parameters.AddWithValue("@fishname", fishName);
                    command.Parameters.AddWithValue("@image", image);
                    command.Parameters.AddWithValue("@color", color);
                    command.Parameters.AddWithValue("@origin", origin);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@soluong", soLuong);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        public bool Update(loaica loaica)
        {
            int id = loaica.getId();
            string maCa = loaica.getMaCa();
            string fishName = loaica.getFishName();
            string image = loaica.getImage();
            string color = loaica.getColor();
            string origin = loaica.getOrigin();
            decimal price = loaica.getPrice();
            int soLuong = loaica.getSoLuong() ;
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "UPDATE loai_ca SET MaCa = @maca, fish_name = @fishname, Image = @image, Color = @color, NguonGoc = @origin,Price = @price, SoLuong = @soluong  WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@maca", maCa);
                    command.Parameters.AddWithValue("@fishname", fishName);
                    command.Parameters.AddWithValue("@image", image);
                    command.Parameters.AddWithValue("@color", color);
                    command.Parameters.AddWithValue("@origin", origin);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@soluong", soLuong);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool Delete(loaica loaica)
        {
            int id = loaica.getId();
            string maCa = loaica.getMaCa();
            string fishName = loaica.getFishName();
            string image = loaica.getImage();
            string color = loaica.getColor();
            string description = loaica.getDescription();
            string origin = loaica.getOrigin();
            decimal price = loaica.getPrice();
            int soLuong = loaica.getSoLuong();
            try 
            { 
                using (SqlConnection conn = DatabaseHelper.getConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM loai_ca WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex) 
            { 
                return false;
            }
            
        }
        public bool Delete(int id)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.getConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM loai_ca WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool isExist(int id)
        {
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM loai_ca WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int rowCount = (int)command.ExecuteScalar();
                    return rowCount > 0;
                }
            }
        }
        public bool isExist(loaica loaica)
        {
            int id = loaica.getId();
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM loai_ca WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int rowCount = (int)command.ExecuteScalar();
                    return rowCount > 0;
                }
            }
        }
    }
}
