using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementacion
{
    internal class Metodos
    {
        public static void Main(string[] args)
        {
            PrimerMetodo();
            SegundoMetodo("\nLiam");
            SegundoMetodo("Jenny");
            SegundoMetodo("Anja");
            TercerMetodo("\nSweden");
            TercerMetodo("India");
            TercerMetodo();
            TercerMetodo("USA");
            CuartoMetodo("\nLiam", 5);
            CuartoMetodo("Jenny", 8);
            CuartoMetodo("Anja", 31);
            Console.WriteLine($"\n{QuintoMetodo(3)}");
            int z = SextoMetodo(5,3);
            Console.WriteLine(z);
            PrimerEjercicio();

        }

        public static void PrimerMetodo()
        {
            Console.WriteLine("Linea ejecutada");
        } 
        
        public static void SegundoMetodo(string fname)
        {
            Console.WriteLine($"{fname} Apellido");
        }

        public static void TercerMetodo(string Country = "Noruega")
        {
            Console.WriteLine(Country);
        }

        public static void CuartoMetodo(string fname, int age)
        {
            Console.WriteLine($"{fname} tiene {age} años");
        }

        public static int QuintoMetodo(int x)
        {
            return 5 + x;
        }

        public static int SextoMetodo(int x,int y)
        {
            return x + y;
        }

        public static void PrimerEjercicio()
        {
            string[] Nombres = new string[5];
            int[] Edades = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese su nombre");
                Nombres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese sun edad");
                Edades[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < Nombres.Length; i++)
            {
                if (Edades[i] >= 18)
                {
                    Console.WriteLine($"\nEl nombre del mayor de edad es : {Nombres[i]}");
                }
            }
        }
    }
}
