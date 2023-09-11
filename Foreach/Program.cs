using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "daniel";

            foreach (char letra in nombre)
            {
                Console.WriteLine(letra);
            }

            Console.ReadKey();
        }
    }
}
