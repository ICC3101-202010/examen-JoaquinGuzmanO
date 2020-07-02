using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Jugador : Person
    {
        private int PuntosAtaque;
        private int PuntosDefensa;
        private int NumeroCamiseta;
        private string Posicion;
        private int lesionado = 0; // a0 = sano ; 1 = lesionado
        public Jugador(string name, int age, int salary, string nacionality, int PuntosAtaque, int PuntosDefensa, int NumeroCamiseta, string Posicion)
            : base(name, age, salary, nacionality)
        {
            this.PuntosAtaque = PuntosAtaque;
            this.PuntosDefensa = PuntosDefensa;
            this.NumeroCamiseta = NumeroCamiseta;
            this.Posicion = Posicion;
        }

        public void lesionarse()
        {
            lesionado = 1;
            Console.WriteLine(name+": Me he lesionado");
        }
        public int getPuntosAtaque()
        {
            return PuntosAtaque;
        }
        public int getPuntosDefensa()
        {
            return PuntosDefensa;
        }
        public int getNumeroCamiseta()
        {
            return NumeroCamiseta;
        }
        public string getPosicion()
        {
            return Posicion;
        }
        public int getLesionado()
        {
            return lesionado;
        }
    }
}
