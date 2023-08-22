using Exercicios_de_POO;

Pessoa pessoa1 = new Pessoa();
Pessoa pessoa2 = new Pessoa();

Console.WriteLine("Dados da primeira pessoa: ");
Console.Write("Nome: ");
pessoa1.Name = Console.ReadLine();
Console.Write("Idade: ");
pessoa1.Age = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa: ");
Console.Write("Nome: ");
pessoa2.Name = Console.ReadLine();
Console.Write("Idade: ");
pessoa2.Age = int.Parse(Console.ReadLine());

Console.Write("Pessoa mais velha: " + Pessoa.pessoaMaisVelha(pessoa1, pessoa2));