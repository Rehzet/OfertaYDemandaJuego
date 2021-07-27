

namespace OfertaYDemandaJuego.Classes
{
    class Product
    {

        public string Name { get; set; }

        public float Price { get; set; }

        public int Category { get; set; }

        public int Stock { get; set; }



        public Product(string name, float price, int category, int stock)
        {
            Name = name;
            Price = price;
            Category = category;
            Stock = stock;
        }
    }
}
