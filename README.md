# Curso de C#
## Recapitulação de Lógica de Programação
### Tipos básicos de C# - Parte 1  

Tipos mais usados:  

Números inteiros:  
int  - com sinal - 4 Bytes   
long - com sinal - 8 Bytes  

Numeros decimais:  
float - com sinal - 4 Bytes  
double - com sinal - 8 bytes  
decimal - com sinal - 12 bytes  

Char - 2 bytes  
string - O tipo string é uma cadeia de caracteres Unicode IMUTÁVEL (segurança, simplicidade, thread safe).  
bool - 1/2 tue or false  

Conceito de overflow:  
É quando o valor recebido ultrapassa o valor limite da variável. Quando este valor é ultrapassado o valor da variavel se torna o limite oposto.  

Ao utilizar o tipo Long é recomendavel utilizar o L maiusculo no final do valor recebido.  

### Tipos básicos de C# - Parte 2  

O tipo char deve ser setado com aspas simples.  
ex.: char genero = 'F';  

Também pode ser setado a partir de um código unicode:  
ex.: char letra = '\u0041'; o \u é necessário para dizer que é um código unicode.  

O tipo float precisa de adicionar o f no final do valor recebido.  
ex.: float n5 = 4.5f;  

O tipo string necessita de adicionar aspas duplas no valor.  
ex: string nome = "Caio";  

As variaveis numericas possuem duas propriedades para sabermos o minimo e o maximo de valor limite para armazenamento.  
ex.: int n1 = int.MinValue;  
     int n2 = int.MaxValuel;

### Restrições e convenções para nomes de variáveis

- Não pode começar com dígito: use uma letra ou _  
- Não pode usar acentos ou til  
- Não pode ter espaço em branco  
- Use nomes que tenham um significado claro  

#### Convenções:  

- Camel Case: lastName (parâmetros de métodos, variáveis dentro de métodos)  
- Pascal Case: LastName (namespaces, classe, properties e métodos)  
- Padrão _lastName (atributos "internos" da classe) 

Diferença entre properties e atributos:   

Propertie: ````public string Titular { get; set; }````  
Atributos: ````private double _saldo;````  

ex. de classe seguindo as convenções:  
````
namespace Curso
{
  class ContaBancaria
  {
    public string Titular { get; set; }
    private double _saldo;
    public void Deposito(double quantia)
    {
       _saldo += quantia;
    }
    public double GetSaldo()
    {
      return _saldo;
    }
  }
}
````

### Saída de dados em C#  

#### Imprimir na saída padrão (console)  

- Comandos  
  - Console.WriteLine(valor); *com quebra de linha*  
  - Console.Write(valor) *sem quebra de linha*  

No caso da apresentação de variáveis com ponto flutuante, podemos querer limitar as casas decimais.  
No exemplo abaixo foi limitado para duas casas decimais.  

````
double saldo = 10.35784;
Console.WriteLine(saldo.ToString("F2"));
````

Para alterar a forma de exibição do valor representado como (,) que está no padrão de formatação brasileiro, devemos adicionar o namespace Globalization, conforme abaixo.  

````
using System.Globalization;
````

Depois adicionar o InvariantCulture para que desconsidere qualquer formatação de pais.
````
Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
````

#### Placeholders, concatenação e interpolação  

ex.
````
int idade = 32;
double saldo = 10.35784;
String nome = "Maria";
// Placeholders
Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
// Interpolação
Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
// Concatenação
Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
+ saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
````
### Operadores aritméticos  


| Operador | Significado      |
|----------|------------------|
| +        | adição           |
| -        | subtração        |
| *        | multiplicação    |
| /        | divisão          |
| %        | resto da divisão |

1) ``*`` / % tem precedência maior que + -  
2) Exemplos:  
3 + 4 ``*`` 2 Resultado: 11  
(3 + 4) ``*`` 2 Resultado: 14  
3) Pode-se usar parêntesis à vontade  
4) Exemplo com mod:  
17 % 3 Resultado: 2  
17 / 3  
Resto igual a 2.  

### Operadores de atribuição  

| Operador | Exemplo | Significado     |
|----------|---------|-----------------|
| =        | a = 10; | a RECEBE 10     |
| +=       | a += 2; | a RECEBE a + 2; |
| -=       | a -= 2; | a RECEBE a - 2; |
| ``*``=       | a *= 2; | a RECEBE a * 2; |
| /=       | a /= 2; | a RECEBE a / 2; |
| %=       | a %= 3; | a RECEBE a % 3; |

O operador ??= é um operador de atribuição condicional introduzido no C# 8.0, 
que permite atribuir um valor a uma variável somente se essa variável ainda não tiver um valor (ou seja, é nula). 
Ele combina o operador de coalescência nula ?? com o operador de atribuição =, 
oferecendo uma maneira concisa de atribuir um valor padrão a uma variável se essa variável estiver atualmente com valor nulo.

Sintaxe:  
````
variavel ??= valorPadrao;
````

Exemplo:  
````
using System;

class Program {
    static void Main() {
        int? numero = null;
        Console.WriteLine($"Valor atual de 'numero': {numero}");

        numero ??= 10; // Se 'numero' for nulo, atribua o valor 10
        Console.WriteLine($"Valor atual de 'numero' após a atribuição: {numero}");

        numero ??= 20; // Como 'numero' já tem um valor (10), a atribuição não é feita
        Console.WriteLine($"Valor atual de 'numero' após a segunda tentativa de atribuição: {numero}");
    }
}
````
Neste exemplo, a variável numero é inicializada como nula. Na primeira atribuição usando ??=, como a variável é nula, o valor 10 é atribuído a ela.  
Na segunda atribuição, como a variável numero já tem um valor (10), a atribuição não ocorre e o valor permanece inalterado.  

O operador ??= é especialmente útil quando se deseja atribuir um valor padrão a uma variável apenas se ela ainda não tiver sido inicializada. Isso pode ajudar a simplificar o código e torná-lo mais legível.

### Operadores aritméticos / atribuição  

| Operador | Exemplo      | Significado     |
|----------|--------------|-----------------|
| ++       | a++; ou ++a; | a = a + 1;      |
| --       | a--; ou --a; | a = a - 1;      |


### Operadores Lógicos  

| Operador | Significado |
|----------|-------------|
| &&       | E           |
| ||       | OU          |
| !        | Não         |

1) Precedência: ! > && > ||  
2) Pode-se usar parêntesis à vontade  
3) Exemplos:  
2 > 3 || 4 != 5 Resultado: true  
C1 C2 C1 E C2 !(2>3) && 4 != 5 Resultado: true  

### Operadores Comparativos  

| Operador | Significado    |  
|----------|----------------|
| >        | maior          |
| <        | menor          |
| >=       | maior ou igual | 
| <=       | menor ou igual | 
| ==       | igual          | 
| !=       | diferente      |

### Condicionais  

As estruturas condicionais servem para mudar o fluxo de um programa através de uma condição caso ela seja verdadeira em tempo de execução.
Simples
````
if ( condição ) {
comando 1
comando 2
}
````
Composta  
````
if ( condição ) {
comando 1
comando 2
}
else {
comando 3
comando 4
}
````
Encadeada  
````
if ( condição 1 ) {
comando 1
comando 2
}
else if ( condição 2 ) {
comando 3
comando 4
}
else if ( condição 3 ) {
comando 5
comando 6
}
else {
comando 7
comando 8
}
````  

### Casting  

Em C#, a conversão de tipos é uma operação importante que permite que você transforme um valor de um tipo em outro. 
Existem dois tipos principais de conversões de tipos: conversão implícita (também conhecida como coerção) e conversão explícita (ou casting).

1. Conversão Implícita (Coerção):  
A conversão implícita ocorre automaticamente pelo compilador quando 
não há perda de dados envolvida e não há risco de estouro ou distorção de valores. 
Isso ocorre quando você atribui um valor de um tipo a uma variável de outro tipo compatível, sem a necessidade de fazer nada além de simplesmente atribuir.

Exemplo de conversão implícita:  
````
int numeroInteiro = 42;
double numeroDecimal = numeroInteiro; // Conversão implícita de int para double

````
2. Conversão Explícita (Casting):  
A conversão explícita (ou casting) é necessária quando há a possibilidade de perda de dados, 
risco de estouro ou quando você deseja converter entre tipos incompatíveis. Você deve sinalizar explicitamente ao compilador 
que está ciente dessa conversão e deseja realizar a operação. Isso é feito colocando o tipo desejado entre parênteses antes do valor a ser convertido.

Exemplo de conversão explícita:  

````
double numeroDecimal = 3.14159;
int numeroInteiro = (int)numeroDecimal; // Conversão explícita de double para int
````

É importante notar que a conversão explícita pode levar a perda de dados, 
truncamento ou comportamento inesperado, especialmente quando ocorre estouro de valores. 
Sempre tenha cuidado ao realizar conversões explícitas e verifique se você está ciente das implicações.
Além disso, em C#, é possível verificar se uma conversão explícita é possível usando o operador as 
(para tipos de referência) ou os métodos TryParse (para conversão segura de tipos numéricos) e Convert (para conversão entre diversos tipos).
Exemplo:  
````
string numeroTexto = "123";
int numero;
bool sucesso = int.TryParse(numeroTexto, out numero);

if (sucesso) {
    // A conversão foi bem-sucedida
}
````
Resumindo, a conversão implícita é mais fácil e segura, pois ocorre automaticamente em situações onde não há perda de dados. 
Já a conversão explícita (casting) é necessária quando você precisa converter explicitamente entre tipos incompatíveis ou quando há riscos de perda de dados. 
Sempre considere as implicações ao realizar conversões explícitas.

### Escopo e inicialização  
Escopo de uma variável: é a região do programa onde a variável é
válida, ou seja, onde ela pode ser referenciada.  
• Uma variável não pode ser usada se não for iniciada.  

### Funções  

Principais vantagens: modularização, delegação e reaproveitamento.  
Dados de entrada e saída  
• Funções podem receber dados de entrada (parâmetros ou argumentos)  
• Funções podem ou não retornar uma saída  

Ex:  
````
static void Soma(int a, int b){  
  int resultado;  
  resultado = a + b;  
  return resultado  
}  
````

Em C#, funções (também conhecidas como métodos) são blocos de código que realizam uma tarefa específica. Elas permitem que você divida a lógica do seu programa em partes mais gerenciáveis e reutilizáveis. Funções podem receber argumentos, executar um conjunto de instruções e retornar um valor (ou não retornar nada, no caso de funções "void"). Aqui estão os principais conceitos relacionados a funções em C#:  

1. Declaração de Função:  
A declaração de uma função envolve especificar seu nome, os tipos de argumentos que ela recebe (se houver), o tipo de retorno (ou "void" se não houver retorno) e o corpo da função, que contém as instruções que serão executadas.

Exemplo de declaração de função:  
````
public int Soma(int a, int b) {
    int resultado = a + b;
    return resultado;
}
````
2. Argumentos:  
Funções podem receber argumentos, que são valores que você passa para a função para que ela os utilize em sua lógica. Argumentos podem ser de vários tipos (inteiros, strings, objetos, etc.) e podem ser usados dentro da função como variáveis locais.

3. Retorno:  
Uma função pode ou não retornar um valor. Se ela retornar um valor, você precisa especificar o tipo do valor de retorno na declaração da função. Se uma função não tiver um valor para retornar, seu tipo de retorno é definido como "void".

4. Chamada de Função:  
Para usar uma função, você precisa chamá-la usando seu nome seguido por parênteses. Se a função tiver argumentos, você os passa dentro dos parênteses.

Exemplo de chamada de função:  
````
int resultado = Soma(5, 3); // Chamando a função 'Soma' com argumentos 5 e 3
````
5. Funções Void:
Uma função "void" não retorna um valor. Ela é usada quando você deseja apenas executar uma ação sem a necessidade de obter um resultado.

Exemplo de função "void":
````
public void ImprimirMensagem(string mensagem) {
    Console.WriteLine(mensagem);
}
````
6. Métodos Estáticos:
Métodos estáticos pertencem à classe em vez de uma instância específica da classe. Eles podem ser chamados usando o nome da classe, sem a necessidade de criar uma instância dela.

Exemplo de método estático:
````
public static int Dobro(int numero) {
    return numero * 2;
}
````
7. Recursão:  
Em C#, você pode criar funções recursivas, ou seja, funções que chamam a si mesmas. Isso pode ser útil para resolver problemas que podem ser divididos em subproblemas menores.
A recursão é um conceito em programação onde uma função chama a si mesma para resolver um problema. Em outras palavras, uma função recursiva é uma função que se auto-invoca repetidamente até atingir uma condição de parada, momento em que a recursão é interrompida.

A recursão é frequentemente usada para resolver problemas que podem ser divididos em subproblemas menores, onde cada subproblema é uma versão menor e mais simples do problema original. A ideia principal por trás da recursão é quebrar um problema complexo em subproblemas mais simples e resolver cada subproblema até que todos eles estejam resolvidos.

Principais elementos da recursão:

1. Caso Base: É o ponto de parada da recursão. Quando um caso base é alcançado, a recursão para e a função começa a retornar valores.  

2. Caso Recursivo: É onde a função se chama a si mesma com um conjunto de argumentos diferentes, muitas vezes reduzindo o problema original para um subproblema menor.  

Vamos ver um exemplo clássico de função recursiva: o cálculo do fatorial de um número.
````
public static int Fatorial(int n) {
    // Caso base: fatorial de 0 é 1
    if (n == 0) {
        return 1;
    }
    // Caso recursivo: chama a função Fatorial() com um valor menor
    else {
        return n * Fatorial(n - 1);
    }
}

````
Neste exemplo, o caso base é quando n é igual a 0, retornando 1. No caso recursivo, a função Fatorial() chama a si mesma com n - 1 e multiplica o valor de n atual pelo resultado da chamada recursiva.

É importante notar que, ao usar recursão, é crucial garantir que haja um caminho claro para atingir o caso base. Caso contrário, a recursão continuará indefinidamente, resultando em um estouro de pilha (stack overflow).

Recursão pode ser poderosa, mas também pode ser ineficiente para alguns problemas, devido à pilha de chamadas. Em muitos casos, é possível otimizar a solução usando abordagens iterativas (loops). A escolha entre recursão e iteração depende do problema em questão e da clareza da solução.
As funções são uma parte fundamental da programação em C# (e em muitas outras linguagens). Elas ajudam a organizar o código, facilitam a reutilização de lógica e permitem a modularização do programa em partes menores e mais gerenciáveis.

### Debug Visual Studio  
Teclas  
• F9 - marcar/desmarcar breakpoint  
• F5 - iniciar/continuar o debug  
• F10 - executar um passo (pula função)  
• F11 - executar um passo (entra na função)  
• SHIFT+F11 - sair do método em execução  
• SHIFT+F5 - parar debug  
• Janelas  
• Watch (expressões personalizadas)  
• Autos (expressões "interessantes" detectadas pelo Visual Studio)  
• Locals (variáveis locais do metodo em execução)  

### Estruturas de repetição  

Estrutura "enquanto"  
````
 while ( condição ) {
   comando 1
   comando 2
 }
````
Regra:  
V: executa e volta  
F: pula fora  

Em C#, as estruturas de repetição, também conhecidas como loops, permitem que você execute um bloco de código repetidamente enquanto uma condição específica for verdadeira. Essas estruturas são úteis quando você deseja realizar tarefas repetitivas, como percorrer uma lista de itens, calcular somas, imprimir sequências e muito mais. Existem duas principais estruturas de repetição em C#: for e while, além de uma variação do for chamada foreach. Aqui estão as principais informações sobre cada uma delas:

1. For Loop:
O loop for é usado quando você conhece o número exato de iterações que deseja realizar. Ele consiste em três partes: a inicialização (executada uma vez no início), a condição (verificada antes de cada iteração) e a atualização (executada após cada iteração).

Exemplo de for loop:  

````
for (int i = 0; i < 5; i++) {
    Console.WriteLine($"Iteração {i}");
}
````

2. While Loop:  
O loop while é usado quando você deseja repetir um bloco de código enquanto uma condição for verdadeira. A condição é verificada antes de cada iteração.

Exemplo de while loop:  

````
int contador = 0;
while (contador < 5) {
    Console.WriteLine($"Contador: {contador}");
    contador++;
}
````

3. Do-While Loop:  
O loop do-while é semelhante ao while, mas a condição é verificada após cada iteração, garantindo que o bloco de código seja executado pelo menos uma vez.

Exemplo de do-while loop:  

````
int numero = 10;
do {
    Console.WriteLine($"Número: {numero}");
    numero--;
} while (numero > 0);
````

4. Foreach Loop:  
O loop foreach é usado para percorrer elementos em uma coleção, como arrays, listas, dicionários, etc. Ele é especialmente útil quando você não precisa acompanhar um contador ou índice.

Exemplo de foreach loop:  
````
int[] numeros = { 1, 2, 3, 4, 5 };
foreach (int num in numeros) {
    Console.WriteLine($"Número: {num}");
}
````
É importante escolher a estrutura de repetição que melhor se adapte ao seu cenário específico. O for é ideal quando o número de iterações é conhecido antecipadamente, o while é útil quando a condição de parada pode variar e o foreach é excelente para percorrer coleções sem a necessidade de rastrear índices ou contadores. 

## Programação Orientada a Objetos (POO):  
A programação orientada a objetos é um paradigma de programação que se baseia na organização de código em torno de "objetos", que são instâncias de classes. Uma classe é um modelo que define atributos (variáveis) e métodos (funções) que operam sobre esses atributos. As vantagens da programação orientada a objetos incluem:  

- Abstração: Permite modelar objetos do mundo real de forma mais direta, tornando o código mais compreensível e reutilizável.  
- Encapsulamento: As informações sobre o objeto são encapsuladas dentro da classe, o que protege os dados internos e limita o acesso a eles.  
- Herança: Permite criar novas classes baseadas em classes existentes, compartilhando características e comportamentos comuns, o que economiza tempo e reduz redundâncias.  
- Polimorfismo: Permite que diferentes objetos respondam de maneira diferente a chamadas de métodos com o mesmo nome, tornando o código mais flexível e extensível.  
  
Programação Procedural:  
A programação procedural é um paradigma mais antigo e se concentra em uma abordagem linear, onde o código é organizado em funções/procedimentos que manipulam dados. Embora seja menos abstrata que a POO, ainda é amplamente usada para tarefas mais simples e diretas.  

Agora, sobre a diferença entre a memória Stack e Heap:  

Memória Stack (Pilha):  
A memória Stack é usada para armazenar variáveis locais e informações de contexto de execução durante a chamada de funções. Ela opera em uma estrutura de pilha, onde a alocação e desalocação de memória são eficientes, seguindo a regra "último a entrar, primeiro a sair" (LIFO - Last In, First Out). No entanto, a capacidade de armazenamento na Stack é limitada e a alocação é rápida, mas rígida em termos de tamanho.  

Memória Heap (Monte):  
A memória Heap é uma área de memória usada para armazenar dados de tamanho variável e objetos que podem ser alocados dinamicamente durante a execução do programa. Ao contrário da Stack, a alocação na Heap é mais flexível, mas também pode ser mais lenta e requer gerenciamento explícito (alocação e liberação de memória). A memória Heap é usada, por exemplo, quando se cria objetos grandes ou quando a quantidade de memória necessária é desconhecida durante a compilação.  

Em resumo, a programação orientada a objetos oferece uma maneira mais estruturada e modular de organizar o código, permitindo a criação de sistemas mais flexíveis e reutilizáveis. A escolha entre os paradigmas POO e procedural depende das necessidades do projeto. A diferença entre a memória Stack e Heap reside na forma como a memória é alocada e desalocada, com a Stack sendo mais eficiente e a Heap sendo mais flexível, mas exigindo um gerenciamento cuidadoso.  

### Pilares de POO com código C#:  
1. Encapsulamento:  
O encapsulamento é a prática de esconder os detalhes internos de uma classe e fornecer uma interface controlada para interagir com ela. Isso ajuda a proteger os dados e garante que eles sejam acessados e modificados apenas de maneira controlada. Em C#, o encapsulamento é alcançado usando modificadores de acesso (public, private, protected) e propriedades.  
````
class Car
{
    private int speed;

    public int Speed
    {
        get { return speed; }
        set { speed = value > 0 ? value : 0; }
    }
}
````
2. Abstração:  
A abstração envolve a criação de modelos simplificados que representam objetos do mundo real em um programa. Ela ajuda a focar nos aspectos relevantes do objeto e a ocultar os detalhes irrelevantes. Em C#, a abstração é realizada usando classes abstratas e interfaces.  
````
abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}
````
3. Herança:  
A herança permite criar novas classes baseadas em classes existentes, compartilhando características e comportamentos. A classe derivada herda os membros da classe base e pode adicionar ou substituir comportamentos. Em C#, a herança é implementada usando a palavra-chave class e a indicação de uma classe base com :.
````
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}
````
4. Polimorfismo:  
O polimorfismo permite que um mesmo método tenha diferentes implementações em classes diferentes, baseadas em herança. Isso permite tratar objetos de diferentes classes de forma uniforme através de interfaces comuns. Em C#, o polimorfismo é frequentemente visto em substituições de métodos.
````
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square.");
    }
}
````

### Object e ToString  

Toda classe em C# é uma subclasse da classe Object  
• Object possui os seguintes métodos:  
• GetType - retorna o tipo do objeto  
• Equals - compara se o objeto é igual a outro  
• GetHashCode - retorna um código hash do objeto  
• ToString - converte o objeto para string  

Configurar a exbição de uma classe quando for exibida com o método ToString:  

````
using System.Globalization;
namespace Course {
  class Produto {
     public string Nome;
     public double Preco;
     public int Quantidade;
     public double ValorTotalEmEstoque() {
        return Preco * Quantidade;
     }
     public override string ToString() {
        return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
     }
  }
}
````

Métodos comuns herdados da classe Object com explicação e exemplos:  

1. ToString():  
O método ToString() é usado para retornar uma representação em formato de string do objeto. Ele é frequentemente sobrescrito para fornecer uma representação mais significativa do objeto. Se não for sobrescrito, a implementação padrão retornará o nome completo da classe.  
Exemplo:
````
public class Pessoa
{
    public string Nome { get; set; }
    
    public override string ToString()
    {
        return Nome;
    }
}
````

2. Equals():  
O método Equals() é usado para comparar se dois objetos são iguais. A implementação padrão verifica se os objetos referenciam a mesma instância na memória. No entanto, geralmente é necessário sobrescrever esse método para comparar o conteúdo dos objetos.  
Exemplo:
````
public class Ponto
{
    public int X { get; set; }
    public int Y { get; set; }
    
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;
            
        Ponto outroPonto = (Ponto)obj;
        return X == outroPonto.X && Y == outroPonto.Y;
    }
}
````

3. GetHashCode():  
O método GetHashCode() retorna um valor numérico que representa o objeto. Esse valor é frequentemente usado em algoritmos de hashing e em coleções que armazenam objetos únicos.  
Exemplo:
````
public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    
    public override int GetHashCode()
    {
        return Titulo.GetHashCode() ^ Autor.GetHashCode();
    }
}
````

4. GetType():  
O método GetType() retorna o tipo do objeto em tempo de execução. Ele retorna um objeto da classe Type, que contém informações sobre a classe.  
Exemplo:
````
Pessoa pessoa = new Pessoa();
Type tipo = pessoa.GetType();
Console.WriteLine($"O tipo do objeto é: {tipo.Name}");
````

5. MemberwiseClone():  
O método MemberwiseClone() cria uma cópia superficial do objeto, copiando os valores dos campos para um novo objeto. Os campos de referência são copiados, mas eles ainda apontam para os mesmos objetos na memória.  
Exemplo:
````
public class Exemplo
{
    public int Valor { get; set; }
    
    public Exemplo Clone()
    {
        return (Exemplo)MemberwiseClone();
    }
}
````

### Membros estáticos:  

• Também chamados membros de classe  
  • Em oposição a membros e instância  
• São membros que fazem sentido independentemente de objetos. Não precisam de objeto para serem chamados. São chamados a partir do próprio nome da classe.  
• Aplicações comuns:  
  • Classes utilitárias  
  • Declaração de constantes  
• Uma classe que possui somente membros estáticos, pode ser uma classe estática também. Esta classe não poderá ser instanciada.  

Ex: Math.Sqrt(double)  

Explicação com exemplos em C#:  

Em C#, membros estáticos são elementos de uma classe que pertencem à própria classe em vez de pertencerem a instâncias individuais dessa classe. Eles são declarados usando o modificador "static" e são compartilhados por todas as instâncias da classe e podem ser acessados diretamente através do nome da classe, sem a necessidade de criar uma instância.
Existem dois tipos principais de membros estáticos: campos estáticos e métodos estáticos.

1. Campos Estáticos:  
Um campo estático é uma variável que pertence à classe, em vez de pertencer a uma instância específica dessa classe. Todos os objetos (instâncias) da classe compartilham o mesmo valor de campo estático. Isso pode ser útil para armazenar informações que precisam ser compartilhadas entre todas as instâncias da classe. Campos estáticos são inicializados apenas uma vez, quando a classe é carregada.
Exemplo de declaração de campo estático:
````
class MinhaClasse
{
    public static int contador = 0;
}
````
Acesso a um campo estático:  
````
int valorDoContador = MinhaClasse.contador;
````
2. Métodos Estáticos:  
Um método estático é um método que pertence à classe em vez de pertencer a uma instância. Eles são chamados usando o nome da classe e não requerem que você crie uma instância da classe para acessá-los. Métodos estáticos geralmente são usados para realizar operações que não dependem do estado de instância da classe.  
Exemplo de declaração de método estático:
````
class MinhaClasse
{
    public static void MetodoEstatico()
    {
        Console.WriteLine("Este é um método estático.");
    }
}
````
Chamando um método estático:  
````
MinhaClasse.MetodoEstatico();
````
Membros estáticos são particularmente úteis para utilitários, funções auxiliares, constantes compartilhadas e outros casos em que você deseja ter algo que seja comum a todas as instâncias da classe, sem precisar criar objetos separados.
É importante notar que membros estáticos não podem acessar membros de instância diretamente, pois eles não têm uma instância específica a partir da qual podem acessar tais membros.
