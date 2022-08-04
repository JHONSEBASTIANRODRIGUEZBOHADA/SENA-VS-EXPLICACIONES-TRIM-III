using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDados
{
    internal class PrincipalMain
    {
        public static void Main(string[] args)
        {
            int Opciones = 0;
            do
            {
                Operaciones jugadores = new Operaciones();
                Console.WriteLine("\nIngrese el jugador \n1.JUGADOR11 \n2.jUGADOR2");
                Opciones = int.Parse(Console.ReadLine());
                switch(Opciones)
                {
                    case 1:
                        jugadores.Jugador();
                        break;

                    case 2:

                        break;

                    default:
                        Console.WriteLine("ingreso un valor incorrecto");
                        break;
                }

            } while (Opciones != 4);

        }
    }
}
