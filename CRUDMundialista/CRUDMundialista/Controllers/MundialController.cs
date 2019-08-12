using CRUDMundialista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDMundialista.Controllers
{
    public class MundialController : Controller
    {
        // GET: Mundial
        public ActionResult Equipos()
        {
            var listado = ConsultarEquipos();
            return View(listado);
        }

        public ActionResult Detalle(int idEquipo)
        {
            var listadoEquipos = ConsultarEquipos();
            var equipo = listadoEquipos.FirstOrDefault(x=> x.IdEquipo == idEquipo);
            return View(equipo);
        }

        private List<Equipo> ConsultarEquipos()
        {
            var listadoEquipos = new List<Equipo>();
            var listadoJugadores = new List<Jugador>();

            for (int i = 0; i < 10; i++)
            {
                listadoJugadores.Add(new Jugador
                {
                    Nombre = "Jugador "+ i.ToString(),
                    Imagen = "jugador.png",
                    Posicion = i%2==0? "Delantero":"Defensa"
                });
            }

            listadoEquipos.Add(new Equipo
            {
                IdEquipo = 1,
                Nombre = "Colombia",
                Imagen = "colombia.png",
                Jugadores = listadoJugadores
            });

            listadoEquipos.Add(new Equipo
            {
                IdEquipo = 1,
                Nombre = "Brazil",
                Imagen = "brasil.png",
                Jugadores = listadoJugadores
            });

            listadoEquipos.Add(new Equipo
            {
                IdEquipo = 1,
                Nombre = "Holanda",
                Imagen = "holanda.png",
                Jugadores = listadoJugadores
            });

            return listadoEquipos;
        }
    }
}