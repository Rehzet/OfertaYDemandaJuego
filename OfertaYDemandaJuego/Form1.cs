using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OfertaYDemandaJuego
{

    public partial class Form1 : Form
    {

        private List<Classes.City> _cities;
        

        public Form1()
        {
            InitializeComponent();
            
            createCities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNextIter_Click(object sender, EventArgs e)
        {
            simulateDay();
        }

        private void createCities()
        {
            _cities = new List<Classes.City>();

            _cities.Add(new Classes.City("Madrid"));

        }

        private void simulateDay()
        {

            foreach (Classes.City city in _cities)
            {
                foreach (Classes.Citizen citizen in _cities[0].Citizens)
                {
                    citizen.ConsumeProducts();
                }

                labelPan.Text = city.Stock.StappleFood[0].Stock.ToString();
                labelFruta.Text = city.Stock.StappleFood[1].Stock.ToString();
                labelCerveza.Text = city.Stock.StappleFood[2].Stock.ToString();

                labelMoney.Text = city.Citizens[0].Money.ToString() + "€";
            }

        }
    }
}
