using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishShop.model
{
    internal class loaica
    {
        private int id;
        private string maCa;
        private string fishName;
        private string image;
        private string color;
        private string description;
        private string origin;
        private decimal price;
        private int soLuong;

        public loaica() { }

        public loaica(int id,string maCa, string fishName, string image, string color, string origin, decimal price, int soLuong)
        {
            this.id = id;
            this.maCa = maCa;
            this.fishName = fishName;
            this.image = image;
            this.color = color;
            this.origin = origin;
            this.price = price;
            this.soLuong = soLuong;
        }

        public int getId() { return id; }

        public void setMaCa(string maCa)
        {
            this.maCa = maCa;
        }

        public string getMaCa()
        {
            return maCa;
        }

        public void setFishName(string fishName)
        {
            this.fishName = fishName;
        }

        public string getFishName()
        {
            return fishName;
        }

        public void setImage(string image)
        {
            this.image = image;
        }

        public string getImage()
        {
            return image;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return color;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public string getDescription() 
        { 
            return description;
        }

        public void setOrigin(string origin)
        {
            this.origin = origin;
        }

        public string getOrigin()
        {
            return origin;
        }

        public void setPrice(decimal price)
        {
            this.price = price;
        }

        public decimal getPrice()
        {
            return price;
        }

        public void setSoLuong(int soLuong)
        {
            this.soLuong = soLuong;
        }

        public int getSoLuong()
        {
            return soLuong;
        }
    }
}
