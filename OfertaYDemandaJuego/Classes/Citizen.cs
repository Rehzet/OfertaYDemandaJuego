using System;
using System.Collections.Generic;

namespace OfertaYDemandaJuego.Classes
{
    class Citizen
    {

#region PROPERTIES

        public float Salary { get; set; }

        public City City { get; set; }

        public float Money
        {
            get
            {
                return _money;
            }
        }

#endregion

#region PRIVATE FIELDS

        private Random _rnd;
        private float _money;
#endregion

        public Citizen(City city)
        {

            City = city;

            _rnd = new Random();

            GenerateSocialStatus();

            _money = Salary;

        }

#region PRIVATE METHODS

        private void GenerateSocialStatus()
        {
            double number = _rnd.NextDouble();

            if (number <= 0.05) // Rich people
            {
                Salary = GenerateSalary(5000, 30000);
            }
            else if (number > 0.05 && number <= 0.8) // Normal people.
            {
                Salary = GenerateSalary(800, 2000);
            }
            else // Poor people.
            {
                Salary = GenerateSalary(1, 300);
            }
        }

        private int GenerateSalary(int min, int max) 
        {
           return _rnd.Next(min, max);
        }

#endregion

#region PUBLIC METHODS

        public void Promote() // Increases citizen salary.
        {
            Salary += GenerateSalary(100, 300);
        }

        public void ConsumeProducts()
        {
            // First of all, the citizen has to consume staple food. 
            // A citizen consumes 60% of all possible staple food every day.
            HashSet<int> dailyStapleFood = new HashSet<int>();

            while(dailyStapleFood.Count < City.Stock.StappleFood.Count * 0.6)
            {
                dailyStapleFood.Add(City.Stock.StappleFood.IndexOf(City.Stock.StappleFood[_rnd.Next(0, City.Stock.StappleFood.Count)] ));
            }

            foreach(int i in dailyStapleFood)
            {
                if (_money >= City.Stock.StappleFood[i].Price && City.Stock.StappleFood[i].Stock > 0)
                {
                    City.Stock.StappleFood[i].Stock--;
                    _money -= City.Stock.StappleFood[i].Price;
                }
            }

        }

#endregion
    }
}
