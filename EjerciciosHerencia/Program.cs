using System;
using Calculadoras;

class Program
{
    static void Main(string[] args)
    {
        Operacion operacion;

        while (true)
        {
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Calcular IMC");
            Console.WriteLine("2. Conversión de Dinero (COP a USD/EUR)");
            Console.WriteLine("3. Evaluar Valgo de Rodilla");
            Console.WriteLine("4. Salir");

            Console.Write("Elija una opción (1-4): ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    operacion = new IMC();
                    operacion.Ejecutar();
                    break;
                case "2":
                    operacion = new ConversionDinero();
                    operacion.Ejecutar();
                    break;
                case "3":
                    operacion = new ValgoRodilla();
                    operacion.Ejecutar();
                    break;
                case "4":
                    Console.WriteLine("¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción inválida, intente de nuevo.");
                    break;
            }
        }
    }
}
