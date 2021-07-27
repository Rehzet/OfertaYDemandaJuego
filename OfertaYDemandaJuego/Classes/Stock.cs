using System;
using System.Collections.Generic;
using System.Text;

namespace OfertaYDemandaJuego.Classes
{
    static class Stock
    {
        public static List<Product> StappleFood { get; set; }

        static Stock()
        {
            StappleFood = new List<Product>();
        }


    }
}
