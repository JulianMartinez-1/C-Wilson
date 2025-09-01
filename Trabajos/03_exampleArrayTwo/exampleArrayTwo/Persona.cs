abstract class Persona  //1 → Define una clase abstracta llamada Persona.
                        // "abstract" significa que no se pueden crear instancias directas de esta clase,
                        // solo sirve como base para otras clases (como Adulto o Ninno).
{
    public string Nombre { get; set; } 
    // Propiedad pública que almacena el nombre de la persona.
    // "get; set;" permite leer y modificar el nombre desde fuera de la clase.

    public int Edad { get; set; } 
    // Propiedad pública que almacena la edad de la persona.
    // "get; set;" permite leer y modificar la edad desde fuera de la clase.

    public Persona(string nombre, int edad) 
    // Constructor de la clase Persona que recibe nombre y edad
    {
        this.Nombre = nombre; // Inicializa la propiedad Nombre con el valor recibido
        this.Edad = edad;     // Inicializa la propiedad Edad con el valor recibido
    }
}
