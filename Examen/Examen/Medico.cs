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

        public void curar()
        {
            Console.WriteLine("Quedaste sanado, ve a jugar");
        }

        public void evaluar()
        {
            Console.WriteLine("Te estoy evaluando...");
        }
        public int getPuntosExperiencia()
        {
            return PuntosExperiencia;
        }
    }
}
