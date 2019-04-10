using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoUX.Models
{
    public class Peliculas
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string[] Genero { get; set; }
        public string[] Actores { get; set; }
        public string Poster { get; set; }
        public int Anio { get; set; }
    }
}
