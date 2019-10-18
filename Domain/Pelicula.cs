using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain
{
    public class Pelicula
    {
        public string Nombre { get; set; }
        public DateTime? FechaEstreno { get; set; }
        public string Genero { get; set; }
        public string Recomendacion { get; set; }
        public double? Duracion { get; set; }
        public string Imagen { get; set; }

        public ObservableCollection<Funcion> Funciones { get; set; }
    }
}
