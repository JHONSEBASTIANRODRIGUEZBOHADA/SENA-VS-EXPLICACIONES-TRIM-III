using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Resta : Suma
    {
        public void Operar2()
        {
            Resultado = Valor1 - Valor2;
            Console.WriteLine($"El resultado de la resta es: {Resultado}");
        }
    }
}
