using Exer_02;
using System.Globalization;

public class Program
{
    private static void Main(string[] args)
    {
        Funcionario funcionario1 = new Funcionario();
        Funcionario funcionario2 = new Funcionario();

        Console.WriteLine("Dados do primeiro funcionário: ");
        Console.Write("Nome: ");
        funcionario1.Name = Console.ReadLine();
        Console.Write("Salário: ");
        funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Dados do segundo funcionário: ");
        Console.Write("Nome: ");
        funcionario2.Name = Console.ReadLine();
        Console.Write("Salário: ");
        funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Salário Médio = " + Funcionario.SalarioMedio(funcionario1, funcionario2).ToString("F2", CultureInfo.InvariantCulture));
    }
}