using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ColeccionQueu
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue MiQ = new Queue();

            MiQ.Enqueue("Hola");
            MiQ.Enqueue("Mundo");
            MiQ.Enqueue("Marco");

            foreach (string Fruta in MiQ)
            {
                Console.WriteLine("->{0}", Fruta);
            }
            Console.WriteLine("------");

            MiQ.Dequeue();

            MiQ.Enqueue("Limon");
            MiQ.Enqueue("Pera");
            MiQ.Enqueue("Manzana");

            Console.WriteLine("Peek {0}", MiQ.Peek());
            Console.WriteLine("Cantidad {0}", MiQ.Count);
            Console.ReadKey();
        }
    }
}
