using System.Globalization;

var n = int.Parse(Console.ReadLine());
var listaDeResultados = new List<string>();

for (int i = 1; i <= n; i++)
{
    var valores = Console.ReadLine().Split(" ");
    var valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
    var valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
	
    if (valor2 == 0)
    {
        listaDeResultados.Add("Divisão impossível!");
        continue;
    }
    var resultado = valor1 / valor2;
    listaDeResultados.Add(resultado.ToString("F1", CultureInfo.InvariantCulture));
}

foreach (var valor in listaDeResultados)
    Console.WriteLine(valor);