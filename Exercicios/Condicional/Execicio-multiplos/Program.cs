string[] valores = Console.ReadLine().Split(" ");

int a = int.Parse(valores[0]);
int b = int.Parse(valores[0]);

if (a % b == 0 || b % a == 0)
    Console.WriteLine("SÃO MULTIPLOS");
else
    Console.WriteLine("NÃO SÃO MULTIPLOS");