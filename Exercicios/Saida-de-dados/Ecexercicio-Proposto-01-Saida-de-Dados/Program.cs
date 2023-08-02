using System.Globalization;

Console.WriteLine("Entre com seu nome completo:");
string nomeCompleto = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa?");
int qtdeQuartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto:");
double preco1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
string[] dados = Console.ReadLine().Split(' ');

string nome = dados[0];
int idade = int.Parse(dados[1]);
double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

Console.WriteLine(nomeCompleto);
Console.WriteLine(qtdeQuartos);
Console.WriteLine(preco1.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));