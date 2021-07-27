using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OfertaYDemandaJuego
{

    public partial class Form1 : Form
    {

        private List<Classes.Citizen> _citizens;

        public Form1()
        {
            InitializeComponent();

            SetProducts();

            _citizens = new List<Classes.Citizen>();
            SetCitizens();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void SetProducts()
        {
            Classes.Stock.StappleFood.Add(new Classes.Product("Pan", 1f, Classes.Constants.CAT_STAPLE_FOOD, 200));
            Classes.Stock.StappleFood.Add(new Classes.Product("Fruta", 1.5f, Classes.Constants.CAT_STAPLE_FOOD, 500));
            Classes.Stock.StappleFood.Add(new Classes.Product("Cerveza", 1.8f, Classes.Constants.CAT_STAPLE_FOOD, 300));

        }

        private void SetCitizens()
        {
            _citizens.Add(new Classes.Citizen());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNextIter_Click(object sender, EventArgs e)
        {
            foreach(Classes.Citizen c in _citizens)
            {
                c.ConsumeProducts();
            }

            labelPan.Text = Classes.Stock.StappleFood[0].Stock.ToString();
            labelFruta.Text = Classes.Stock.StappleFood[1].Stock.ToString();
            labelCerveza.Text = Classes.Stock.StappleFood[2].Stock.ToString();

            labelMoney.Text = _citizens[0].Money.ToString() + "€";
        }
    }
}
