class AccesoData  //1 → Definición de la clase AccesoData, que servirá para manejar datos (en este caso, de eventos).
{
    // Método público que devuelve una lista de objetos de tipo Evento
    public List<Evento> obtenerListaEventos()
    {
        // Se crea una lista vacía de eventos donde se almacenarán todos los objetos Evento
        List<Evento> eventos = new List<Evento>();

        // Se crean objetos de tipo TipoEvento con diferentes categorías
        TipoEvento cultural = new TipoEvento("Cultural");    // Tipo de evento cultural
        TipoEvento deportivo = new TipoEvento("Deportivo");  // Tipo de evento deportivo
        TipoEvento exhibicion = new TipoEvento("Exhibición");// Tipo de evento de exhibición
        TipoEvento feria = new TipoEvento("Feria");          // Tipo de evento feria
        
        // Se crean diferentes objetos Evento, cada uno con un nombre, tipo y un booleano (activo o no)
        Evento eventoUno = new Evento("Evento uno", cultural, true);   // Evento cultural activo
        Evento eventoDos = new Evento("Evento dos", deportivo, false); // Evento deportivo inactivo
        Evento eventoTres = new Evento("Evento tres", deportivo, true);// Evento deportivo activo
        Evento eventoCuatro = new Evento("Evento cuatro", feria, false);// Evento feria inactivo
        Evento eventoCinco = new Evento("Evento cinco", feria, true);  // Evento feria activo
        Evento eventoSeis = new Evento("Evento seis", exhibicion, true);// Evento exhibición activo

        // Se agregan todos los eventos creados a la lista
        eventos.Add(eventoUno);
        eventos.Add(eventoDos);
        eventos.Add(eventoTres);
        eventos.Add(eventoCuatro);
        eventos.Add(eventoCinco);
        eventos.Add(eventoSeis);

        // Finalmente, se retorna la lista de eventos completa
        return eventos;
    }
}
