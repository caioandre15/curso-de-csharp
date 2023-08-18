var n = int.Parse(Console.ReadLine());
var qdteIn = 0;
var qdteOut = 0;

for (int i = 1; i<= n; i++)
{
    var valor = int.Parse(Console.ReadLine());
    if (valor >= 10 && valor <= 20)
        qdteIn++;
    if (valor < 10 || valor > 20)
        qdteOut++;
}

Console.WriteLine(qdteIn + " in");
Console.WriteLine(qdteOut + " out");