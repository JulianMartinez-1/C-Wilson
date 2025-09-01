internal class TipoEvento  //3 → Define la clase TipoEvento con visibilidad "internal".
                            // "internal" significa que solo puede usarse dentro del mismo proyecto/ensamblado.
{
    private string nombre; 
    // Campo privado que almacena el nombre del tipo de evento.
    // Al ser privado, solo puede accederse dentro de esta clase.

    public TipoEvento(string nombre) 
    // Constructor de la clase TipoEvento que recibe un nombre como parámetro
    {
        this.nombre = nombre; 
        // Inicializa el campo privado 'nombre' con el valor recibido al crear el objeto.
    }
}
