using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Partido
    {
        private Equipo equipo1;
        private Equipo equipo2;
        public Partido(Equipo equipo1, Equipo equipo2)
        {
            this.equipo1 = equipo1;
            this.equipo2 = equipo2;
        }
        public void Comenzar()
        {
            Console.WriteLine("Comienza el partido");
        }
        public void Cambio()
        {
            equipo1.CambioLesion();
            equipo2.CambioLesion();
        }
        public void VerLesiones()
        {
            equipo1.AnalisarLesiones();
            equipo2.AnalisarLesiones();
        }
    }
}
