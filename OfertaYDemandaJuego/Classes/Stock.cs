using System;
using System.Collections.Generic;
using System.Text;

namespace OfertaYDemandaJuego.Classes
{
     class Stock
    {
        public  List<Product> StappleFood { get; set; }

        public Stock()
        {
            StappleFood = new List<Product>();
        }


    }
}
