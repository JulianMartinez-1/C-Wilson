using System;

namespace Calculadoras
{
    public class IMC : Operacion
    {
        public override void Ejecutar()
        {
            Console.WriteLine("\n--- Cálculo de IMC ---");
            Console.Write("Ingrese su peso en kg: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese su altura en metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine($"Su IMC es: {imc:F2}");

            if (imc < 18.5)
                Console.WriteLine("Clasificación: Bajo peso");
            else if (imc < 25)
                Console.WriteLine("Clasificación: Normal");
            else if (imc < 30)
                Console.WriteLine("Clasificación: Sobrepeso");
            else
                Console.WriteLine("Clasificación: Obesidad");
        }
    }
}
