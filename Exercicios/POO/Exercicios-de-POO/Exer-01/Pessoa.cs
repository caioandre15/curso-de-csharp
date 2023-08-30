namespace Exercicios_de_POO
{
    public class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static string pessoaMaisVelha(Pessoa p1, Pessoa p2)
        {
            if (p1.Age > p2.Age)
                return p1.Name;
            else
                return p2.Name;
        }
    }
}
