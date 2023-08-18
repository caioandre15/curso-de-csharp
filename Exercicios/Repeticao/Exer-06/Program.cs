using System.Globalization;

var n = int.Parse(Console.ReadLine());

var medias = new List<double>();
var peso1 = 2.0;
var peso2 = 3.0;
var peso3 = 5.0;
var somaDosPesos = peso1 + peso2 + peso3;

for (int i = 1; i <= n; i++)
{
    var valores = Console.ReadLine().Split(" ");
    var valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
    var valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
    var valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
    var somaProdutoPorPeso = (valor1 * peso1) + (valor2 * peso2) + (valor3 * peso3);
    medias.Add(somaProdutoPorPeso / somaDosPesos);
}

foreach (var media in medias)
{
    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
}
