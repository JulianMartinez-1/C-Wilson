class Evento  //2 → Define la clase Evento, que representa un evento con su nombre, tipo y restricción de edad.
{
    public static int numeroDeEventos = 0; 
    // Variable estática que cuenta el número total de eventos creados.
    // Al ser estática, pertenece a la clase, no a cada instancia individual.

    public string NombreEvento { get; set; } 
    // Propiedad pública que almacena el nombre del evento.
    // "get; set;" permite leer y modificar este valor desde fuera de la clase.

    public TipoEvento Tipo { get; set; } 
    // Propiedad pública que almacena el tipo del evento (Cultural, Deportivo, etc.)
    // TipoEvento es otra clase que representa la categoría del evento.

    public bool SoloAdultos { get; set; } 
    // Propiedad pública que indica si el evento es solo para adultos (true) o no (false).

    // Constructor de la clase Evento
    public Evento(string nombreEvento, TipoEvento tipo, bool soloAdultos)
    {
        this.NombreEvento = nombreEvento; // Inicializa el nombre del evento con el valor recibido
        this.Tipo = tipo;                 // Inicializa el tipo del evento con el valor recibido
        this.SoloAdultos = soloAdultos;   // Inicializa si es solo para adultos con el valor recibido
        numeroDeEventos++;                // Incrementa el contador de eventos cada vez que se crea un nuevo objeto
    }
}
