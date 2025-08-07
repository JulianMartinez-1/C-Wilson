// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Ejemplos estructuras condicionales");

// Console.WriteLine("");

// If simple

// sbyte EDAD_PARAMETRO = 18;
// Console.WriteLine("Ingrese su edad:");
// sbyte edad = sbyte.Parse(Console.ReadLine());

// if (edad >= EDAD_PARAMETRO)
// {
//     Console.WriteLine("Es es mayor de Edad");
// }

//if compuesto

// Console.WriteLine("Ingrese la calificación del estudiante:");
// double calificacion = double.Parse(Console.ReadLine());

// if (calificacion >= 7)
// {
//     Console.WriteLine("¡Aprobado!");
// }
// else if (calificacion >= 5)
// {
//     Console.WriteLine("Debe hacer recuperación.");
// }
// else
// {
//     Console.WriteLine("Reprobado.");
// }

//if anidado

// Console.Write("Estado civil: ");
// string estado_civil = Console.ReadLine();
// Console.Write("Edad: ");
// sbyte edad = sbyte.Parse(Console.ReadLine());
// Console.Write("Responsable: ");
// bool responsable = bool.Parse(Console.ReadLine());
// Console.Write("Hijos: ");
// string hijos = Console.ReadLine();

// string PARAMETRO_ESTADO_CIVIL = "Soltero";
// sbyte PARAMETRO_EDAD = 20;
// bool PARAMETRO_RESPONSABLE = true;
// string PARAMETRO_HIJOS = "Sin hijos";


// if (estado_civil == PARAMETRO_ESTADO_CIVIL)
// {
//     if (edad >= PARAMETRO_EDAD)
//     {
//         if (responsable == PARAMETRO_RESPONSABLE)
//         {
//             if (hijos == PARAMETRO_HIJOS)
//             {
//                 Console.WriteLine("Hoombre ideal");
//             }
//             else
//             {
//                 Console.WriteLine("No es hombre ideal porque tiene hijos");
//             }
//         }
//         else
//         {
//             Console.WriteLine("No es hombre ideal porque no es responsable");
//         }
//     }
//     else
//     {
//         Console.WriteLine("No es hombre ideal porque es menor de edad");
//     }
// }
// else
// {
//     Console.WriteLine("No es hombre ideal porque no es soltero");
// }


//Using switch

//Console.WriteLine("Estructura SWITCH");

//sintaxis

// switch (expresión)
// {
//     case valor1
//         // Código a ejecutar si la expresión es igual a valor1
//         break;
//     case valor2
//         // Código a ejecutar si la expresión es igual a valor2
//         break;
//     default:
//         // Código a ejecutar si la expresión no coincide con ningún caso
//         break;
// }

// Console.WriteLine("Ingrese un número del 1 al 7:");
// int dia = int.Parse(Console.ReadLine());
// switch (dia)
// {
//     case 1:
//         Console.WriteLine("Lunes");
//         break;
//     case 2:
//         Console.WriteLine("Martes");
//         break;
//     case 3:
//         Console.WriteLine("Miércoles");
//         break;
//     case 4:
//         Console.WriteLine("Jueves");
//         break;
//     case 5:
//         Console.WriteLine("Viernes");
//         break;
//     case 6:
//         Console.WriteLine("Sábado");
//         break;
//     case 7:
//         Console.WriteLine("Domingo");
//         break;
//     default:
//         Console.WriteLine("Número no válido. Debe ser del 1 al 7.");
//         break;
// }



//EJERCICIOS

// Console.WriteLine("Seleccione una opción:");
// Console.WriteLine("1. Mostrar fecha");
// Console.WriteLine("2. Mostrar nombre");
// Console.WriteLine("3. Mostrar mensaje motivador");

// int opcion = Convert.ToInt32(Console.ReadLine());

// switch (opcion)
// {
//     case 1:
//         Console.WriteLine($"La fecha de hoy es: {DateTime.Now.ToShortDateString()}");
//         break;
//     case 2:
//         Console.WriteLine("Mi nombre es: Julian");
//         break;
//     case 3:
//         Console.WriteLine("¡Sigue adelante, no te rindas!");
//         break;
//     default:
//         Console.WriteLine("Opción no válida.");
//         break;
// }

//  EJERCICIO VALGO DE RODILLA

// Console.WriteLine("Ingrese el valor del valgo de rodilla (en grados):");
// double valgoRodilla = Convert.ToDouble(Console.ReadLine());

//  Validación del valor ingresado
// if (valgoRodilla < 10)
// {
//     Console.WriteLine("Valgo de rodilla normal.");
// }
// else if (valgoRodilla >= 10 && valgoRodilla < 20)
// {
//     Console.WriteLine("Valgo de rodilla leve.");
// }
// else if (valgoRodilla >= 20 && valgoRodilla < 30)
// {
//     Console.WriteLine("Valgo de rodilla moderado.");
// }
// else
// {
//     Console.WriteLine("Valgo de rodilla severo.");
// }

// EJERCICIO CAJERO AUTOMÁTICO


double saldo = 500000;

Console.WriteLine("1. Consultar saldo");
Console.WriteLine("2. Retirar dinero");
Console.WriteLine("3. Salir");
Console.Write("Elija una opción: ");
int opcion = Convert.ToInt32(Console.ReadLine());

if (opcion == 1)
{
    Console.WriteLine("Su saldo actual es: " + saldo);
}
else if (opcion == 2)
{
    Console.Write("Ingrese el monto a retirar: ");
    double retiro = Convert.ToDouble(Console.ReadLine());

    if (retiro > saldo)
    {
        Console.WriteLine("Fondos insuficientes.");
    }
    else
    {
        saldo -= retiro;
        Console.WriteLine("Retiro exitoso. Saldo actual: " + saldo);
    }
}
else if (opcion == 3)
{
    Console.WriteLine("Gracias por usar el cajero.");
}
else
{
    Console.WriteLine("Opción inválida.");
}
