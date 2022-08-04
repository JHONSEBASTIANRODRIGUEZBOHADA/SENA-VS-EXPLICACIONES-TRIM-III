using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Suma:Getter_y_Setter
    {
        
        public void Operar()
        {
            Resultado = Valor1 + Valor2;
            Console.WriteLine($"\nEl resultado de la suma es: {Resultado}");
        }
    }
}
