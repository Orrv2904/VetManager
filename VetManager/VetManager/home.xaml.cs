using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VetManager
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class home : ContentPage
    {
        public home()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void MenuButton_Tapped(object sender, EventArgs e)
        {
            // Código para manejar el evento del botón del menú
        }

        private void ToggleMenuButton_Clicked(object sender, EventArgs e)
        {
            menuFrame.IsVisible = !menuFrame.IsVisible;
            Button toggleMenuButton = (Button)sender;

            if (menuFrame.IsVisible)
            {
                toggleMenuButton.BackgroundColor = Color.White;
                menuFrame.Opacity = 0.7; // Ajusta el valor de opacidad aquí
            }
            else
            {
                toggleMenuButton.BackgroundColor = Color.FromHex("#2196F3");
                menuFrame.Opacity = 1.0; // Restaura la opacidad original
            }
        }
    }
}