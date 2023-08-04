using System.Globalization;

int numeroDoFuncionario = int.Parse(Console.ReadLine());
int numeroDeHorasTrabalhadas = int.Parse(Console.ReadLine());
double valorPorHoraTrabalhada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double salario = numeroDeHorasTrabalhadas * valorPorHoraTrabalhada;

Console.WriteLine($"NUMBER = {numeroDoFuncionario}");
Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");