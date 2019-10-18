using CinemaLM.Helpers;
using Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CinemaLM.Services
{
    public static class PeliculaService
    {
        public static ObservableCollection<Pelicula> GetPeliculas()
        {
            return ApiHelper.Get<ObservableCollection<Pelicula>>("/api/Cartelera");
        }
    }
}
