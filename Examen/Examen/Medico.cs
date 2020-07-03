using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Medico : Person
    {
        private int PuntosExperiencia;
        public Medico(string name, int age, int salary, string nacionality,int PuntosExperiencia)
           : base(name, age, salary, nacionality)
        {
            this.PuntosExperiencia = PuntosExperiencia;
        }

        public void curar(Jugador jugador)
        {
            jugador.Sanar();
            Console.WriteLine("Quedaste sanado, ve a jugar");
        }

        public void evaluar(List<Jugador> jugadores)
        {
            Console.WriteLine("Estoy evaluando...");
            foreach(var jugador in jugadores)
            {
                if(jugador.getLesionado() == 1)
                {
                    Console.WriteLine("El jugador " + jugador.getName() + " Esta lesionado");
                }
                else
                {
                    Console.WriteLine("No hay jugadores lesionados");
                }
            }
        }
        public int getPuntosExperiencia()
        {
            return PuntosExperiencia;
        }
    }
}
