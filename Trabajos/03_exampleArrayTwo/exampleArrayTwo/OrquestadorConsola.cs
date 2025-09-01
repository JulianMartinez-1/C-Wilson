static class OrquestadorConsola
// Clase estática que funciona como "orquestador" para la consola.
// Al ser estática, no se pueden crear instancias de esta clase; todos sus métodos y variables son estáticos.
{
    private static List<Persona> personas = new List<Persona>();
    // Lista estática que almacenará todas las personas registradas (niños y adultos).

    public static void solicitarDatosPersonas()
    // Método estático para solicitar datos de personas desde la consola.
    {
        int opcion = -1; // Variable para controlar la opción del usuario en el bucle.
        do
        {
            Console.WriteLine("Acá puede inscribir las personas para saber a cuales eventos pueden asistir.");
            Console.WriteLine("Si desea inscribir una persona digite un número diferente al 0. Si desea salir digite el número 0");
            opcion = Int32.Parse(Console.ReadLine()); 
            // Lee la opción ingresada por el usuario y la convierte a entero.

            if (opcion != 0) // Si la opción no es 0, se procede a registrar una persona.
            {
                Console.WriteLine("Por favor digite el nombre completo de la persona (presione enter) y la edad (presione enter)");
                string nombre = Console.ReadLine(); // Se lee el nombre de la persona
                int edad = Int32.Parse(Console.ReadLine()); // Se lee la edad de la persona y se convierte a entero

                Persona persona; // Se declara una variable de tipo Persona
                if (edad < 18)
                {
                    persona = new Ninno(nombre, edad); // Si es menor de 18, se crea un objeto Ninno
                }
                else
                {
                    persona = new Adulto(nombre, edad); // Si es 18 o mayor, se crea un objeto Adulto
                }

                personas.Add(persona); // Se agrega la persona a la lista de personas
            }

        } while (opcion != 0); // Se repite el bucle mientras el usuario no ingrese 0

        imprimirPersonas(); // Llama al método para mostrar la lista de personas registradas
    }

    public static void imprimirPersonas()
    // Método para imprimir información de las personas registradas
    {
        Console.WriteLine("La cantidad de personas registradas es:" + personas.Count); 
        // Muestra la cantidad total de personas

        int numeroNinnos = 0; // Contador de niños
        int numeroAdultos = 0; // Contador de adultos

        foreach (Persona persona in personas) // Recorre cada persona en la lista
        {
            if (persona is Ninno)
            {
                numeroNinnos++; // Incrementa el contador si es un niño
            }
            else
            {
                numeroAdultos++; // Incrementa el contador si es un adulto
            }
        }

        Console.WriteLine("La cantidad de niños registrados es: " + numeroNinnos);
        Console.WriteLine("La cantidad de adultos registrados es: " + numeroAdultos);
    }

    public static void imprimirEventos(List<Evento> eventos)
    // Método para mostrar información de los eventos y quiénes pueden asistir
    {
        foreach (Evento evento in eventos) // Recorre todos los eventos
        {
            string variante = evento.SoloAdultos ? "no" : "si"; 
            // Determina si los niños pueden asistir según la propiedad SoloAdultos

            Console.WriteLine("En el evento: " + evento.NombreEvento + " " + variante + " pueden asistir niños");

            if (evento.SoloAdultos) // Si el evento es solo para adultos
            {
                Console.WriteLine("Es decir las siguientes personas no podrán asistir:");

                foreach (Persona persona in personas) // Recorre todas las personas
                {
                    if (persona is Ninno) // Si la persona es un niño
                    {
                        Console.WriteLine(persona.Nombre); // Imprime su nombre
                    }
                }
            }
        }
    }
}
