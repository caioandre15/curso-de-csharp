using System.Globalization;

namespace Exer_03 {
    class Program {
        static void Main(string[] args) {

            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Estoque = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dados do produto: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            var qtde = int.Parse(Console.ReadLine());
            produto.AdicionarEstoqueDeProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            produto.RemoverEstoqueDeProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

        }
    }
}