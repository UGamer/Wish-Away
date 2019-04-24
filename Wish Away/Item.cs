using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wish_Away
{
    class Item
    {
        public Image image;
        public string URL;
        public string name;
        public int rating;
        public double price;
        public int deliveryTime;
        public string description;

        public Item(Image image, string URL, string name, int rating, double price,
            int deliveryTime, string description)
        {
            this.image = image;
            this.URL = URL;
            this.name = name;
            this.rating = rating;
            this.price = price;
            this.deliveryTime = deliveryTime;
            this.description = description;
        }
    }
}
