

namespace OfertaYDemandaJuego.Classes
{
    class Product
    {

        public string Name { get; set; }

        public float Price { get; set; }

        public int Category { get; set; }


        public Product(string name, float price, int category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
