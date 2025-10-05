class Ninno : Persona  //3 → Define la clase Ninno que hereda de la clase Persona.
{
    // Constructor de la clase Ninno que recibe nombre y edad
    // ": base(nombre, edad)" llama al constructor de la clase padre (Persona)
    // para inicializar los atributos heredados.
    public Ninno(string nombre, int edad) : base(nombre, edad)
    {
        // El cuerpo está vacío porque toda la inicialización se realiza en la clase base (Persona).
    }
}
