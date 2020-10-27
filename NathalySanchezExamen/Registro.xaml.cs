using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NathalySanchezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string user)
        {
            InitializeComponent();
            string us = lblMensajeIni.Text;
            lblMensajeIni.Text = us + user;
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double p1 = 1800;
            string user = lblMensajeIni.Text;
            string nombre = txtNombre.Text;
            double monto = Convert.ToDouble(txtPagoI.Text);
            double abono = Convert.ToDouble(txtPagoMen.Text);

            try { 
                if(monto < p1)
                {
                    double x1 =  p1 - monto;
                    double porcen = (x1 / 3) * 0.05;
                    double total = ((x1 / 3) + porcen) * 3;
                    txtPagoMen.Text = x1.ToString();
                    await Navigation.PushModalAsync(new Resumen(nombre,user,total));
                }
                else
                {
                    DisplayAlert("Alerta", "El monto debe ser menor que 1800", "Aceptar");
                }
            } catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Aceptar");
            }

        }
    }
}