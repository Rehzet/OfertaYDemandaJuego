using System;
using System.Collections.Generic;
using System.Text;

namespace OfertaYDemandaJuego.Classes
{
    class City
    {

        public string Name { get; set; }

        public Stock Stock { get; set; }

        public List<Citizen> Citizens { get; set; }


        public City(string name)
        {
            Name = name;

            SetProducts();

            Citizens = new List<Citizen>();
            SetCitizens();
        }

        private void SetProducts()
        {
            Stock = new Stock();

            Stock.StappleFood.Add(new Product("Pan", 1f, Constants.CAT_STAPLE_FOOD, 200));
            Stock.StappleFood.Add(new Product("Fruta", 1.5f, Constants.CAT_STAPLE_FOOD, 500));
            Stock.StappleFood.Add(new Product("Cerveza", 1.8f, Constants.CAT_STAPLE_FOOD, 300));

        }

        private void SetCitizens()
        {
            Citizens.Add(new Citizen(this));
        }

    }
}
