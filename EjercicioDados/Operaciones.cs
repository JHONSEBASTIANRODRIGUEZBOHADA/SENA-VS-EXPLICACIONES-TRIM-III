using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDados
{
    internal class Operaciones:Getter_y_Setter
    {
        public void Jugador()
        {
            Random r = new Random();
            Getter_y_Setter letra = new Getter_y_Setter();
            

            for (int i = 0; i < 3; i++)
            {
                
                Console.WriteLine(r.Next(1, 6));
            }

            if (i)
            {
                Console.WriteLine("Gano");
            }
            else
            {
                Console.WriteLine("Perdio");
            }

        }
    }
}
