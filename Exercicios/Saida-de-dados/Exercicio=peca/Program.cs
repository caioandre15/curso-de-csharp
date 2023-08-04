using System.Globalization;

string[] peca1 = Console.ReadLine().Split(" ");
string[] peca2 = Console.ReadLine().Split(" ");

int codPeca1 = int.Parse(peca1[0]);
int qtdePeca1 = int.Parse(peca1[1]);
double valorUnitarioPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

int codPeca2 = int.Parse(peca2[0]);
int qtdePeca2 = int.Parse(peca2[1]);
double valorUnitarioPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

double total = (qtdePeca1 * valorUnitarioPeca1) + (qtdePeca2 * valorUnitarioPeca2);

Console.WriteLine($"VALOR A PAGAR: R$ { total.ToString("F2", CultureInfo.InvariantCulture)}");
