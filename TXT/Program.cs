using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace TXT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"D:\Programacion\Proyectos\Consolas\txt\archivo.xml");
        }

        private static void leerXML() 
        { 

        }


        /// <summary>
        /// Escribir Txt
        /// </summary>

        private static void escribirTXT()
        {
            // creación del archivo
            TextWriter archivo = new StreamWriter("D:\\Programacion\\Proyectos\\Consolas\\txt\\archivo.txt");
            //  Console.WriteLine("Ingresa el texto");
            // string texto = Console.ReadLine().ToString();
            string texto1 = "ZONA1";
            archivo.WriteLine(texto1);
            archivo.Close();
        }
    }
}
