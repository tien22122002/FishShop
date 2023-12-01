using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishShop.model
{
    internal class admin
    {
        private string userAdmin;
        private string password;
        private string hoTen;

        public admin() { }

        public admin(string userAdmin, string password, string hoTen)
        {
            this.userAdmin = userAdmin;
            this.password = password;
            this.hoTen = hoTen;
        }

        public void setUserAdmin(string userAdmin)
        {
            this.userAdmin = userAdmin;
        }

        public string getUserAdmin()
        {
            return userAdmin;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPassword()
        {
            return password;
        }

        public void setHoTen(string hoTen)
        {
            this.hoTen = hoTen;
        }

        public string getHoTen()
        {
            return hoTen;
        }
    }
}
