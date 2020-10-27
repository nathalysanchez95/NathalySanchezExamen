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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre,string usuario, double total)
        {
            InitializeComponent();
            string us = lblMensajeIni.Text;
            lblMensajeIni.Text = us + usuario;
            string nombreM = txtNombre.Text;
            txtNombre.Text = nombreM + nombre;
            string totalP = txtPago.Text;
            txtPago.Text = totalP + total.ToString();

        }
    }
}