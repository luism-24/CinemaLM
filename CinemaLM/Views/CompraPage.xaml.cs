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
    public partial class CompraPage : ContentPage
    {
        public CompraPage(Pelicula pelicula, Funcion funcion, int? cantidad)
        {
            InitializeComponent();
            compraGrid.BindingContext = pelicula;
            funcionLayout.BindingContext = funcion;
            peliculaLayout.BindingContext = pelicula;
            LblCantidad.Text = cantidad.ToString();
            LblTotal.Text = "$ "+ (funcion.Precio * cantidad).ToString();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("COMPLETADO", "La reserva se hagenerado correctamente", "Aceptar");
        }
    }
}