using System.Globalization;

double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double pi = 3.14159;
double area = pi * Math.Pow(raio, 2.0);

Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
