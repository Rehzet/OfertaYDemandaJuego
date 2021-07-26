using System;

namespace OfertaYDemandaJuego.Classes
{
    class Citizen
    {

#region PROPERTIES

        public int Salary { get; set; }

#endregion

#region PRIVATE FIELDS

        private Random _rnd;

#endregion

        public Citizen()
        {
            _rnd = new Random();

            GenerateSocialStatus();

        }

#region PRIVATE METHODS

        private void GenerateSocialStatus()
        {
            double number = _rnd.NextDouble();

            if (number <= 0.05) // Rich people
            {
                Salary = GenerateSalary(4001, 30000);
            }
            else if (number > 0.05 && number <= 0.4) // Normal people.
            {
                Salary = GenerateSalary(800, 4000);
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

#endregion
    }
}
