// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
// Escribe "Hello, World!" en la consola. Sirve como mensaje inicial al ejecutar el programa.

AccesoData data = new AccesoData();
// Crea una instancia de la clase AccesoData, que se encarga de proporcionar datos de eventos.

List<Evento> eventos = data.obtenerListaEventos();
// Llama al método obtenerListaEventos() de AccesoData
// y guarda la lista de eventos en la variable 'eventos'.

OrquestadorConsola.solicitarDatosPersonas();
// Llama al método solicitarDatosPersonas() de la clase estática OrquestadorConsola
// Permite al usuario ingresar personas (niños o adultos) desde la consola.

OrquestadorConsola.imprimirEventos(eventos);
// Llama al método imprimirEventos() de OrquestadorConsola
// Muestra en la consola qué personas pueden asistir a cada evento según su edad.
