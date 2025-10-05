class Adulto : Persona  //2 → Se define una clase llamada "Adulto" que hereda de la clase "Persona".
{
    // Constructor de la clase Adulto que recibe dos parámetros: nombre y edad.
    // Usa ": base(nombre, edad)" para llamar al constructor de la clase padre (Persona)
    // y así inicializar los atributos heredados.
    public Adulto(string nombre, int edad) : base(nombre, edad)
    {
        // El cuerpo está vacío porque toda la inicialización se hace en la clase base (Persona).
    }
}
