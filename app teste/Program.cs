using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            
            Console.WriteLine("ENTRE O VALOR DO RAIO: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          
            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de pi: " + Pi.ToString("F2",  CultureInfo.InvariantCulture));
        }

        
        static double Circunferencia(double raio)
        {
            return 2.0 * Math.PI * raio; 
        }
        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r;
        }
    }
}
