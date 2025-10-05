Console.WriteLine("Concesionario JCMV");

Console.WriteLine("Tipo de vehiculo? 1)Taxi o 2) Motocicleta");
short tipo_vehi = short.Parse(Console.ReadLine());

Console.WriteLine("Marca: ");
string marca = Console.ReadLine();

Console.WriteLine("Linea: ");
string linea = Console.ReadLine();

Console.WriteLine("Modelo: ");
short modelo = short.Parse(Console.ReadLine());

Console.WriteLine("Placa: ");
string placa = Console.ReadLine();

Taxi taxi1 = new Taxi() { Modelo = modelo };

Motocicleta moto = new Motocicleta() { Placa = placa };

if (tipo_vehi == 1)
{
    taxi1.VerEncender;
} else
{
    moto.VerEncender;
}