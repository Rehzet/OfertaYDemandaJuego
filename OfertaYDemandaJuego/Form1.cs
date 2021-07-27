using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace OfertaYDemandaJuego
{

    public partial class Form1 : Form
    {

        private int _citiIndex;

        private List<Classes.City> _cities;
        private BindingList<Classes.Product> _bindingList;

        public Form1()
        {
            InitializeComponent();
            
            createCities();

            _citiIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changeCity();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNextIter_Click(object sender, EventArgs e)
        {
            simulateDay();
            dataGridView1.Refresh();
        }

        private void buttonPrevCity_Click(object sender, EventArgs e)
        {
            if (_citiIndex > 0)
            {
                _citiIndex--;
                changeCity();
            }
        }

        private void buttonNextCity_Click(object sender, EventArgs e)
        {
            if (_citiIndex < _cities.Count - 1)
            {
                _citiIndex++;
                changeCity();
            }
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

            }

        }

        private void changeCity()
        {
            _bindingList = new BindingList<Classes.Product>(_cities[_citiIndex].Stock.StappleFood);
            bindingSource1.DataSource = _bindingList;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Refresh();
            labelCityName.Text = _cities[_citiIndex].Name;
        }
    }
}
