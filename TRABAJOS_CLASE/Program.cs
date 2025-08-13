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



////EJERCICIOS

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

////  EJERCICIO VALGO DE RODILLA

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

//// EJERCICIO CAJERO AUTOMÁTICO


// double saldo = 500000;

// Console.WriteLine("1. Consultar saldo");
// Console.WriteLine("2. Retirar dinero");
// Console.WriteLine("3. Salir");
// Console.Write("Elija una opción: ");
// int opcion = Convert.ToInt32(Console.ReadLine());

// if (opcion == 1)
// {
//     Console.WriteLine("Su saldo actual es: " + saldo);
// }
// else if (opcion == 2)
// {
//     Console.Write("Ingrese el monto a retirar: ");
//     double retiro = Convert.ToDouble(Console.ReadLine());

//     if (retiro > saldo)
//     {
//         Console.WriteLine("Fondos insuficientes.");
//     }
//     else
//     {
//         saldo -= retiro;
//         Console.WriteLine("Retiro exitoso. Saldo actual: " + saldo);
//     }
// }
// else if (opcion == 3)
// {
//     Console.WriteLine("Gracias por usar el cajero.");
// }
// else
// {
//     Console.WriteLine("Opción inválida.");
// }        


// ciclo while sirve para cuando no sabemos cuantas veces se va a repetir un bloque de código
// Console.WriteLine("Ciclo while");

/* int j = 0;
while (j < 6)
{
    Console.WriteLine("Ingrese su edad:");
    sbyte edad = sbyte.Parse(Console.ReadLine());
    Console.WriteLine("Edad es: " + edad);
    j += 2; // Incremento para evitar un bucle infinito
} */

/* Console.WriteLine("Edad:");
sbyte edad = sbyte.Parse(Console.ReadLine());
sbyte edad_parametro_centinela = 99;

while (edad != edad_parametro_centinela)
{
    Console.WriteLine("Puede ingresar");

    Console.WriteLine("Ingrese su edad:");
    edad = sbyte.Parse(Console.ReadLine());
}

Console.WriteLine("Pasaste el límite de la edad. ¡Hasta luego!"); */


// do while sirve para cuando no sabemos cuantas veces se va a repetir un bloque de código, pero queremos que se ejecute al menos una vez
/* Console.WriteLine("Ciclo do while");
sbyte edad_parametro_centinela = 99;
sbyte edad;

do
{
    Console.WriteLine("Ingrese su edad:");
    edad = sbyte.Parse(Console.ReadLine());

} while (edad != edad_parametro_centinela);

Console.WriteLine("Pasaste el límite de la edad. ¡Hasta luego!"); */


// Array 
/* string[] nombres = {"Ana", "Maria", "Jose", "Andres"};

foreach (var nombre in nombres) {
    Console.WriteLine(nombre);
}
 */



// Lista 
// List<string> nombres = new List<string>();

// Llenar la lista
// nombres.Capacity; // Características, en programación propiedad o atributo
// nombres.Add(); // Acciones, en programación metodos o funciones

/* nombres.Add("Ana");
nombres.Add("Maria");
nombres.Add("Jose");
nombres.Add("Andres");

foreach (string nombre in nombres) {
    Console.WriteLine(nombre);
}  */



// Lista de números 
/* List<int> numeros = new List<int>();

anios.Add(2001);
anios.Add(2010);
anios.Add(2020);
anios.Add(2024);


foreach (int anio in anios) {
    Console.Write($"{anio} - ");
} */



// Diccionario (sintaxis)
/* Dictionary<tipo dato key, value> nombre_diccionario = new Dictionary<tipo dato key, value>()
{
    {"key", value},
    {"key", value},
    {"key", value}
}; */


/* Dictionary<int, string> lista_productos = new Dictionary<int, string>()
{
    {1, "Arroz"},
    {2, "Frijoles"},
    {3, "Carne"}
};

foreach (var producto in lista_productos) {
    Console.WriteLine($"{producto.Key} - {producto.Value}");
} */

////  SISTEMA DE STOCK DE INVENTARIO



// class Inventario
// {
//     static void Main()
//     {
//         // Diccionario para guardar el inventario ( Nombre, Valor: (Cantidad, Precio))
//         Dictionary<string, (int cantidad, double precio)> inventario = new Dictionary<string, (int, double)>();

//         int opcion;
//         do
//         {
//             Console.WriteLine("\n--- SISTEMA DE INVENTARIO ---");
//             Console.WriteLine("1. Agregar producto");
//             Console.WriteLine("2. Ver productos");
//             Console.WriteLine("3. Actualizar stock");
//             Console.WriteLine("4. Salir");
//             Console.Write("Seleccione una opción: ");

//             // Convertir entrada a entero
//             opcion = Convert.ToInt32(Console.ReadLine());

//             switch (opcion)
//             {
//                 case 1:
//                     Console.Write("Ingrese el nombre del producto: ");
//                     string nombre = Console.ReadLine();

//                     Console.Write("Ingrese la cantidad: ");
//                     int cantidad = Convert.ToInt32(Console.ReadLine());

//                     Console.Write("Ingrese el precio: ");
//                     double precio = Convert.ToDouble(Console.ReadLine());

//                     // Si el producto ya existe, se suma stock y se actualiza el precio
//                     if (inventario.ContainsKey(nombre))
//                     {
//                         inventario[nombre] = (inventario[nombre].cantidad + cantidad, precio);
//                         Console.WriteLine($"Stock actualizado. Ahora hay {inventario[nombre].cantidad} unidades de {nombre} a ${inventario[nombre].precio} cada una.");
//                     }
//                     else
//                     {
//                         inventario.Add(nombre, (cantidad, precio));
//                         Console.WriteLine("Producto agregado.");
//                     }
//                     break;

//                 case 2:
//                     Console.WriteLine("\n--- LISTA DE PRODUCTOS ---");
//                     if (inventario.Count == 0)
//                     {
//                         Console.WriteLine("No hay productos registrados.");
//                     }
//                     else
//                     {
//                         foreach (var producto in inventario)
//                         {
//                             Console.WriteLine($"{producto.Key} - {producto.Value.cantidad} unidades - Precio: ${producto.Value.precio}");
//                         }
//                     }
//                     break;

//                 case 3:
//                     Console.Write("Ingrese el nombre del producto a actualizar: ");
//                     string productoActualizar = Console.ReadLine();

//                     if (inventario.ContainsKey(productoActualizar))
//                     {
//                         Console.Write("Ingrese la nueva cantidad: ");
//                         int nuevaCantidad = Convert.ToInt32(Console.ReadLine());
//                         // Mantener el precio actual
//                         double precioActual = inventario[productoActualizar].precio;
//                         inventario[productoActualizar] = (nuevaCantidad, precioActual);
//                         Console.WriteLine("Stock actualizado.");
//                     }
//                     else
//                     {
//                         Console.WriteLine("Ese producto no existe.");
//                     }
//                     break;

//                 case 4:
//                     Console.WriteLine("Saliendo del sistema...");
//                     break;

//                 default:
//                     Console.WriteLine("Opción no válida.");
//                     break;
//             }

//         } while (opcion != 4);
//     }
// }

//// SISTEMA DE CALIFICACION ENCUESTA DE SATISFACCION

// class Encuesta
// {
//     static void Main()
//     {
//         int calificacion;

//         do
//         {
//             Console.WriteLine("\n--- SISTEMA DE SATISFACCIÓN ---");
//             Console.WriteLine("Califique su experiencia (1 a 5):");
//             Console.WriteLine("1 - Muy insatisfecho");
//             Console.WriteLine("2 - Insatisfecho");
//             Console.WriteLine("3 - Neutral");
//             Console.WriteLine("4 - Satisfecho");
//             Console.WriteLine("5 - Muy satisfecho");
//             Console.WriteLine("0 - Salir");
//             Console.Write("Opción: ");

//             calificacion = Convert.ToInt32(Console.ReadLine());

//             switch (calificacion)
//             {
//                 case 1:
//                     Console.WriteLine("Lamentamos que haya tenido una mala experiencia. 😞");
//                     break;
//                 case 2:
//                     Console.WriteLine("Gracias por su opinión, trabajaremos para mejorar. 🙁");
//                     break;
//                 case 3:
//                     Console.WriteLine("Gracias por su calificación. 🙂");
//                     break;
//                 case 4:
//                     Console.WriteLine("¡Nos alegra que esté satisfecho! 😀");
//                     break;
//                 case 5:
//                     Console.WriteLine("¡Excelente! Nos encanta saberlo. 😍");
//                     break;
//                 case 0:
//                     Console.WriteLine("Saliendo del sistema...");
//                     break;
//                 default:
//                     Console.WriteLine("⚠ Opción inválida. Ingrese un número del 1 al 5.");
//                     continue;
//             }
//             break; // Salir del switch si la opción es válida

//         } while (calificacion != 0);
//     }
// }