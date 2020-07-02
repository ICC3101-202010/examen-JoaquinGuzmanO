using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Entrenador : Person
    {
        private int PuntosTactica;
        public Entrenador(string name, int age, int salary, string nacionality, int PuntosTactica)
            : base(name, age, salary, nacionality)
        {
            this.PuntosTactica = PuntosTactica;
        }
        public void cambiarJugador()
        {
            Console.WriteLine("Haremos un cambio!");
        }
        public int getPuntosTactica()
        {
            return PuntosTactica;
        }
    }
}
