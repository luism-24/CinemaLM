using CinemaLM.Services;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaLM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {

            LoginBody loginBody = new LoginBody();
            loginBody.Usuario = UserEntry.Text;
            loginBody.Password = PasswordEntry.Text;
            loginBody.Password = PasswordEntry.Text;

            LoginResponse loginResponse = LoginService.PostLogin(loginBody);


            if (loginResponse.EsPermitido)
            {
                Navigation.InsertPageBefore(new CarteleraPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("UPS!", loginResponse.Mensaje, "Aceptar");
            }

        }
    }
}