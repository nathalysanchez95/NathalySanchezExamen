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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngreso_Clicked(object sender, EventArgs e)
        {
            string us = "estudiante2020";
            string clave = "uisrael2020";
            string user = txtUsuario.Text;
            string pass = txtClave.Text;
            if (user == us && clave == pass)
            {
                await Navigation.PushModalAsync(new Registro(user));
            }
            else
            {
                DisplayAlert("Error", "Usuario o Contraseña Incorrecto", "Aceptar");
            }
        }
    }
}