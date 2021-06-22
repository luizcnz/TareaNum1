using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Tarea1.Modelos;

namespace Tarea1
{
    public partial class MainPage : ContentPage
    {

        public double m1, m2, m3;

        public MainPage()
        {
            InitializeComponent();
        }

        private async  void btn_suma_Clicked(object sender, EventArgs e)
        {

            m1 = Convert.ToDouble(num1.Text);
            m2 = Convert.ToDouble(num2.Text);
            m3 = Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text);


            var datos = new numeros
            {
                n1 = m1,
                n2 = m2,
                n3 = m3
            };

            var inf = new res(); inf.BindingContext = datos; await Navigation.PushAsync(inf);
        }

        private async void btn_resta_Clicked(object sender, EventArgs e)
        {
            m1 = Convert.ToDouble(num1.Text);
            m2 = Convert.ToDouble(num2.Text);
            m3 = Convert.ToDouble(num1.Text) - Convert.ToDouble(num2.Text);

            var datos = new numeros
            {
                n1 = m1,
                n2 = m2,
                n3 = m3
            };

            var inf = new res(); inf.BindingContext = datos; await Navigation.PushAsync(inf);
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            num1.Text = null;
            num2.Text = null;
        }

        private async void btn_mult_Clicked(object sender, EventArgs e)
        {
            m1 = Convert.ToDouble(num1.Text);
            m2 = Convert.ToDouble(num2.Text);
            m3 = Convert.ToDouble(num1.Text) * Convert.ToDouble(num2.Text);

            var datos = new numeros
            {
                n1 = m1,
                n2 = m2,
                n3 = m3
            };

            var inf = new res(); inf.BindingContext = datos; await Navigation.PushAsync(inf);
        }

        private async void btn_div_Clicked(object sender, EventArgs e)
        {
            m1 = Convert.ToDouble(num1.Text);
            m2 = Convert.ToDouble(num2.Text);

            if (m2 <= 0)
            {
                DisplayAlert("Error", "No Puedes dividir un numero entre 0!", "ok");
            }
            else
            {
                m3 = Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text);

                var datos = new numeros
                {
                    n1 = m1,
                    n2 = m2,
                    n3 = m3
                };

                var inf = new res(); inf.BindingContext = datos; await Navigation.PushAsync(inf);
            }
        }
            
    }
}
