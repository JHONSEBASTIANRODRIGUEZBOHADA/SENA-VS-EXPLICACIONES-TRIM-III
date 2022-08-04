using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Carro
    {
        static void Main(string[] args)
        {
            Persona informacion = new Persona();
            informacion.Cargar();
            informacion.Imprimir();
        }



        public void Cargar()
        {
            string name;
            int age;
            Console.WriteLine("ingrese nombre");
            name = Console.ReadLine();

            bool Error = false;
            while (!Error)
            {
                try
                {
                    Console.WriteLine("ingrese edad");
                    age = int.Parse(Console.ReadLine());
                    if (!Error)
                    {
                        Error = true;
                        if (age < 0)
                        {
                            Console.WriteLine("ingreso la edad negativa");
                            Error = false;
                        }
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Incorrecto");
                    Error = false;
                }
            }
            if (age <= 17)
            {
                Console.WriteLine($"la persona: {name} es menor de edad");
            }
            else
            {
                Console.WriteLine($"la persona: {name} es mayor de edad");
            }
        }

        public void Imprimir()
        {
            Console.WriteLine($"su nombre: {name} y su edad: {age}");
        }
    }
}
