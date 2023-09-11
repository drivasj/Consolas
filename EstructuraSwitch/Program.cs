using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige el medio de transporte (coche, tren, bus)");

            string medioTransporte = Console.ReadLine();

            switch (medioTransporte) // si switch = case muestra el resultado 
            {
                case "coche":
                    Console.WriteLine("Velocidad media 100 KM/H");
                    break;
                case "tren":
                    Console.WriteLine("Velocidad media 150 KM/H");
                    break;
                case "bus":
                    Console.WriteLine("Velocidad media 150 KM/H");
                    break;
            }
        }
    }
}
