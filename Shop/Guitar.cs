using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Guitar : Instrument
    {
        public Guitar(string name, string type, int price) : base()
        {
            this.Name = name;
            this.Type = type;
            this.Price = price;
        }
    }
}
