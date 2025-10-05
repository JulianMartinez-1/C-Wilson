public class Taxi : Vehiculo
{
    //propiedades (atributos)

    public int Banderazo { get; set; }
    public string Flota { get; set; }

    //metodos (funciones)

    public int taximetro(int Banderazo)
    {
        int result = 0;
        int countkm = 10;
        result = Banderazo + countkm;
        return result;
    }

    public override string Encender()
    {
        return "Encender con llave";
    }


    // public void EncenderTaximetro()
    // {
    //     Console.WriteLine("El taximetro esta encendido");
    // }
    // public void ApagarTaximetro()
    // {
    //     Console.WriteLine("El taximetro esta apagado");
    // }
}