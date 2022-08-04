using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class PrincipalMain
    {
        public static void Main(string[] args)
        {
            int opciones = 0;
            do
            {
                try
                {
                    Resta operaciones = new Resta();
                    Console.WriteLine("\nIngrese el valor ue desea ingresar \n1.Suma \n2. Resta");
                    opciones = int.Parse(Console.ReadLine());
                    switch (opciones)
                    {
                        case 1:
                            Console.WriteLine("SUMA");
                            Console.WriteLine("\nIngrese un numero");
                            operaciones.Valor1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el siguiente numero");
                            operaciones.Valor2 = int.Parse(Console.ReadLine());
                            operaciones.Operar();
                            break;

                        case 2:
                            Console.WriteLine("RESTA");
                            Console.WriteLine("\nIngrese un numero");
                            operaciones.Valor1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el siguiente numero");
                            operaciones.Valor2 = int.Parse(Console.ReadLine());
                            operaciones.Operar2();
                            break;

                        default:
                            Console.WriteLine("Ingreso un valor incorrecto");
                            break;
                    }
                }catch(FormatException ex)
                {
                    Console.WriteLine("Ingreso un valor incorrecto");
                }
            } while (opciones != 3);
        }
    }
}

//cuando ingresar herencia = 
