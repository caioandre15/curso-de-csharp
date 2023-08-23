using System.Globalization;

namespace Exer_03
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Estoque;

        public double ValorTotalEmEstoque()
        {
            return Estoque;
        }

        public void AdicionarEstoqueDeProdutos(int quantidade)
        {
            Estoque += quantidade;
        }

        public void RemoverEstoqueDeProdutos(int quantidade)
        {
            Estoque -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Estoque + " unidades, Total: $ " + (Preco * Estoque).ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
