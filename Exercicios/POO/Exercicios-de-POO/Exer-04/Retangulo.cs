namespace Exer_04;

public class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public double Area()
    {
        return Largura * Altura;
    }

    public double Perimetro()
    {
        return (Largura * 2) + (Altura * 2);
    }

    public double Diagonal()
    {
        return Math.Sqrt(Math.Pow(Largura, 2.0) + Math.Pow(Altura, 2.0));
    }
}