public class Motocicleta : Vehiculo
{

    public Boolean Manubrio { get; set; }
    public void endo()
    {
        Console.Writeline("Hizo un endo");
    }

    //Implementar el metodo abstract
    public override string Encender()
    {
        return "Encender con cranck";
    }

    public void VerEncender()
    {
        Console.WriteLine(Encender());
    }
    
}