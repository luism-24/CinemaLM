using Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaLM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FuncionesPage : ContentPage
    {
        Pelicula pelicula; 

        public FuncionesPage(Pelicula peliculaEntrante)
        {
            InitializeComponent();
            gridFunciones.BindingContext = peliculaEntrante;
            lsFunciones.ItemsSource = peliculaEntrante.Funciones;
            pelicula = peliculaEntrante;
        }

        async private void LsFunciones_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(cantidad.Text == null)
            {
                await DisplayAlert("Acción no permitida", "La cantidad mínima de boletas es 1", "OK");
            }
            
            else
            {
                if (cantidad.Text.Equals("0") || cantidad.Text.Equals(""))
                {
                    await DisplayAlert("Acción no permitida", "La cantidad mínima de boletas es 1", "OK");

                }
                else
                {

                await Navigation.PushAsync(new CompraPage(pelicula, (Funcion) e.SelectedItem, Int32.Parse(cantidad.Text)));
                }
                
            }
        }
    }
}