using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ejercicio 1 ===");
        var p1 = new Product(1, "Laptop", 3_500_000m, 10);
        var p2 = new Product(2, "Mouse", 50);
        Console.WriteLine(p1);
        Console.WriteLine(p2);

        Console.WriteLine("\n=== Ejercicio 2 ===");
        var per = new Person("Juan");
        var emp = new EmployeeFullTime("Ana", 4_200_000m);
        var man = new Manager("Carlos", 8_000_000m, 5);
        var con = new Contractor("Luis", 80_000m);
        Console.WriteLine(per.Describe());
        Console.WriteLine(emp.Describe());
        Console.WriteLine(man.Describe());
        Console.WriteLine(con.Describe());

        Console.WriteLine("\n=== Ejercicio 3 ===");
        var reportList = new List<IReportable>
        {
            new FullTime("Pedro", 3_500_000m),
            new Hourly("María", 60_000m, 100)
        };
        foreach (var r in reportList)
            Console.WriteLine(r.BuildReport());

        Console.WriteLine("\n=== Ejercicio 4 ===");
        var payroll = new List<IPayable>
        {
            new FullTime("Ana", 4_200_000m),
            new Hourly("Luis", 60_000m, 180)
        };

        var service = new PayrollService(new OvertimeCalculator(), new ConsoleOutput());
        service.Run(payroll);

        var fileService = new PayrollService(new OvertimeCalculator(), new FileOutput("payroll.txt"));
        fileService.Run(payroll);
        Console.WriteLine("Se generó el archivo payroll.txt con resultados.");
    }
}