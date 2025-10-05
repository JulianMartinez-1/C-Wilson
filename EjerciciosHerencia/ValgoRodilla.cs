using System;

namespace Calculadoras
{
    public class ValgoRodilla : Operacion
    {
        public override void Ejecutar()
        {
            Console.WriteLine("\n--- Evaluación de Valgo de Rodilla ---");
            Console.Write("Ingrese el ángulo Q (en grados): ");
            double angulo = Convert.ToDouble(Console.ReadLine());

            if (angulo < 10)
                Console.WriteLine("Resultado: Ángulo menor al esperado (posible varo).");
            else if (angulo <= 20)
                Console.WriteLine("Resultado: Ángulo normal.");
            else
                Console.WriteLine("Resultado: Ángulo aumentado (posible valgo).");
        }
    }
}
