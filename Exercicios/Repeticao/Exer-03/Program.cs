var codigo = int.Parse(Console.ReadLine());

var qtdeAlcool = 0;
var qtdeGasolina = 0;
var qtdeDiesel = 0;

while (codigo != 4)
{
    if (codigo == 1)
        qtdeAlcool++;
    if (codigo == 2)
        qtdeGasolina++;
    if (codigo == 3)
        qtdeDiesel++;

    codigo = int.Parse(Console.ReadLine());
}

Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine("Alcool: " + qtdeAlcool);
Console.WriteLine("Gasolina: " + qtdeGasolina);
Console.WriteLine("Diesel: " + qtdeDiesel);