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
    

    internal class DongCaController
    {
        dongca dongca;
        List<dongca> dongcaList;
        public DongCaController()
        {
            dongca = new dongca();
            dongcaList = new List<dongca>();
        }
        public List<dongca> Load()
        {
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM dong_ca", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maca = reader["MaCa"].ToString();
                            string name = reader["TenDongCa"].ToString();
                            dongca = new dongca(maca, name);
                            dongcaList.Add(dongca);
                        }
                    }
                }
            }

            return dongcaList;
        }
        public dongca Get(string id)
        {
            foreach (dongca c in dongcaList)
            {
                if (c.getMaCa().Equals(id))
                {
                    return c;
                }
            }
            return null;
        }
    }
}
