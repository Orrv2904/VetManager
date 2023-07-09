using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;




namespace VetManager
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private void GoToLoginPageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync(); 
        }

        private void SaveCommand_Execute()
        {
            string nombre = nombreEntry.Text;
            string apellido = apellidoEntry.Text;
            string correo = correoEntry.Text;
            string contrasena = contrasenaEntry.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contrasena))
            {
                DisplayAlert("Error", "Por favor, complete todos los campos requeridos.", "Aceptar");
            }
            else
            {
                
            }
        }
    }
}