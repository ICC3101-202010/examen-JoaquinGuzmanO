using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Examen
{
    class Equipo
    {
        List<Jugador> jugadores;
        private Medico medico;
        private Entrenador entrenador;
        private string name; // Chile, Barcelona
        private string tipo; //nacional o liga 
        public Equipo(List<Jugador> jugadores, Medico medico, Entrenador entrenador, string name, string tipo)
        {
            this.jugadores = jugadores;
            this.medico = medico;
            this.entrenador = entrenador;
            this.name = name;
            this.tipo = tipo;
        }
        public void corroborarNacionalidad() //solo puede implementarse si es tipo nacional el equipo
        {
            int a = 0;
            foreach (var jugador in jugadores)
            {
                if(jugador.getNacionality() != name && tipo == "nacional")
                {
                    a = 1;
                }
            }
            if (tipo == "nacional")
            {
                if (a == 1)
                {
                    Console.WriteLine("No todos los jugadores son de la nacionalidad de la seleccion");
                }
                else
                {
                    Console.WriteLine("Todos los jugadores son de la misma nacionalidad");
                }
            }
            else
            {
                Console.WriteLine("Este equipo pertenece a una liga");
            }
        }
        public void agregarJugador(Jugador jugador)
        {
            if (jugadores.Count < 15)
            {
                jugadores.Add(jugador);
            }
            else
            {
                Console.WriteLine("No se puede agregar más jugadores, ya esta lleno el plantel");
            }     
        }
        public void CambioLesion()
        {
            foreach (var jugador in jugadores)
            {
                if (jugador.getLesionado() == 1)
                {
                    entrenador.cambiarJugador();
                }
            }
        }
        public void CurarJugador()
        {
            foreach (var jugador in jugadores)
            {
                if (jugador.getLesionado() == 1)
                {
                    medico.curar(jugador);
                }
            }
        }
        public void AnalisarLesiones()
        {
            medico.evaluar(jugadores);
        }
        public void Informacion()
        {
            Console.WriteLine("Informacion equipo: " + name + "\nEl entrenador es: "+entrenador.getName()+"\nEl Medico es: "
                + medico.getName()+"\nLos jugadores son: ");
            foreach(var j in jugadores)
            {
                Console.WriteLine(j.getName()+" Con el numero: "+j.getNumeroCamiseta()+" En la posicion ");
            }
        }


    }
}
