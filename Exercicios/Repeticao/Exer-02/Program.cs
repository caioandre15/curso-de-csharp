using System.ComponentModel.Design;

var coordenadas = Console.ReadLine().Split(" ");

var x = Double.Parse(coordenadas[0]);
var y = Double.Parse(coordenadas[1]);

while (x != 0 && y != 0)
{
    if (x > 0)
    {
        if (y > 0)
            Console.WriteLine("primeiro");
        else
            Console.WriteLine("quarto");
    }
    if (x < 0)
    {
        if (y > 0)
            Console.WriteLine("segundo");
        else
            Console.WriteLine("terceiro");
    }

    coordenadas = Console.ReadLine().Split(" ");

    x = Double.Parse(coordenadas[0]);
    y = Double.Parse(coordenadas[1]);
}


