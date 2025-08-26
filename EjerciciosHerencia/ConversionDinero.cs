using System;

namespace Calculadoras
{
    public class ConversionDinero : Operacion
    {
        public override void Ejecutar()
        {
            Console.WriteLine("\n--- Conversión de Dinero ---");
            Console.Write("Ingrese la cantidad en pesos colombianos (COP): ");
            double pesos = Convert.ToDouble(Console.ReadLine());

            double tasaUSD = 4000; // ejemplo: 1 USD = 4000 COP
            double tasaEUR = 4400; // ejemplo: 1 EUR = 4400 COP

            double dolares = pesos / tasaUSD;
            double euros = pesos / tasaEUR;

            Console.WriteLine($"{pesos:F2} COP equivalen a {dolares:F2} USD");
            Console.WriteLine($"{pesos:F2} COP equivalen a {euros:F2} EUR");
        }
    }
}
