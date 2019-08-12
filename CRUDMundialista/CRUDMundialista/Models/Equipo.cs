using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDMundialista.Models
{
    public class Equipo
    {
        public int IdEquipo { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public List<Jugador> Jugadores { get; set; }

    }
}