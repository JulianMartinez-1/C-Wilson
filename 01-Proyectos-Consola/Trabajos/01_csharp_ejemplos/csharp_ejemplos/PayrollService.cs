using System;
using System.Collections.Generic;
using System.IO;

// Interfaces
public interface IPayable { decimal CalculatePayment(); }
public interface IPaymentCalculator { decimal Calc(IPayable e); }
public interface IOutput { void WriteLine(string text); }

// Calculadora normal
public class DefaultPaymentCalculator : IPaymentCalculator
{
    public decimal Calc(IPayable e) => e.CalculatePayment();
}

// Salida en consola
public class ConsoleOutput : IOutput
{
    public void WriteLine(string t) => Console.WriteLine(t);
}

// Salida en archivo
public class FileOutput : IOutput
{
    private readonly string _path;
    public FileOutput(string path) => _path = path;

    public void WriteLine(string text)
    {
        File.AppendAllText(_path, text + Environment.NewLine);
    }
}

// Calculadora con horas extra
public class OvertimeCalculator : IPaymentCalculator
{
    public decimal Calc(IPayable e)
    {
        if (e is Hourly h)
        {
            var normalPay = h.CalculatePayment();
            var overtime = h.Hours > 160 ? (h.Hours - 160) * h.Rate * 0.5m : 0;
            return normalPay + overtime;
        }
        return e.CalculatePayment();
    }
}

// Servicio de nómina
public class PayrollService
{
    private readonly IPaymentCalculator _calc;
    private readonly IOutput _out;

    public PayrollService(IPaymentCalculator calc, IOutput output)
    {
        _calc = calc;
        _out = output;
    }

    public void Run(IEnumerable<IPayable> items)
    {
        foreach (var it in items)
            _out.WriteLine($"{it.GetType().Name}: {_calc.Calc(it):C0}");
    }
}

/* Ejercicio 4
   Implementa FileOutput : IOutput que escriba a un .txt.
   Crea OvertimeCalculator : IPaymentCalculator que agregue horas extra a Hourly.
   Inyecta ambas en PayrollService y ejecuta.
*/
