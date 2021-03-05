using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appN
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double resultado = Convert.ToDouble(res.Text);
            double R = (resultado / 5 - 8) / 2;
            DisplayAlert("el numero que estas pensando es ", R.ToString(),"salir");
        }
    }
}
