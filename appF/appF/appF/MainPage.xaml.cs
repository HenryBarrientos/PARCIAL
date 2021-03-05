using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            int f = Convert.ToInt32(resultado.Text);
            int f1 = f - 365;
            string m = f1.ToString();
            int a = m.Length;
            string c = f1.ToString();
            int b = c.Length;
            string A = m.Substring(0, 2);
            string B = c.Substring(2, 2);
            DisplayAlert("Dia de nacimiento es ", A,"cancelar  ");
            DisplayAlert("Mes  de nacimiento es ", B, "dia ");
        }
    }
}
