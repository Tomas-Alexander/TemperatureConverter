using System;
using System.IO;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduca la ubicación del archivo destino: ");
            string path = Console.ReadLine();
            Console.WriteLine("Introduzca la ruta del archivo con la ubicación destino(junto con nombre del archivo):");
            string outpath = Console.ReadLine();
            string converted = TempConverter.Convert(path);
            File.WriteAllText(outpath, converted);
        }
    }
}
