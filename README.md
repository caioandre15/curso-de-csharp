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

Propertie: public string Titular { get; set; }  
Atributos: private double _saldo;  

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
     

