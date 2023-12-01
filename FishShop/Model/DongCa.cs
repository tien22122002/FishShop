using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishShop.model
{
    internal class dongca
    {
        private string maCa;
        private string tenDongCa;

        public dongca() { }

        public dongca(string maCa, string tenDongCa)
        {
            this.maCa = maCa;
            this.tenDongCa = tenDongCa;
        }

        public void setMaCa(string maCa)
        {
            this.maCa = maCa;
        }

        public string getMaCa()
        {
            return maCa;
        }

        public void setTenDongCa(string tenDongCa)
        {
            this.tenDongCa = tenDongCa;
        }

        public string getTenDongCa()
        {
            return tenDongCa;
        }
    }
}
