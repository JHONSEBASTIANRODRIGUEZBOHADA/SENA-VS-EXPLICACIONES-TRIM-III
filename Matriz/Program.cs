using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class Program
    {
        
        int[,] mat; //declaracion de la matriz
        /*public void Cargar()
        {
            mat = new int[3, 5]; //definicion del tamañano de la matriz
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.WriteLine("Ingrese componente");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }*/

        // 
        public void Cargar2()
        {
            mat = new int[4, 4]; //definicion del tamañano de la matriz
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine("Ingrese componente");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir2()
        {
            for (int f = 0; f < 4; f ++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void ImprimirDiagonalPrincipal()
        {
            for(int k = 0; k < 4; k ++)
            {
                Console.WriteLine("La diagonal es: ");
                Console.Write(mat[k,k] + " ");
            }
            Console.ReadKey();
        }

        //////////
        public void Cargar3()
        {
            mat = new int[3, 4]; //definicion del tamañano de la matriz
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine("Ingrese componente");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        /*public void Imprimir3()
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }*/

        public void Imprimirtodo3()
        {
            for (int k = 0; k < 3; k += 2)
            {
                for(int c = 0; c < 4; c++)
                {
                    Console.WriteLine(mat[k,c]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();


            for (int k = 0; k < 3; k += 2)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine(mat[k, c]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();


            for (int d = 0; d < 4; d++)
            {
                
            }
        }






        public static void Main(string[] args)
        {
            Program matriz = new Program();
            matriz.Cargar2();
            //matriz.Imprimir3();
            matriz.Imprimirtodo3();        
        }


    }
}
