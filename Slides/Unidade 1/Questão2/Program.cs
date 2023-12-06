using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 2: O que é Associação, Agregação, Composição e Generalização?");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Associação - é a relação entre duas classes em que uma classe utiliza objetos de outra classe como atributos ou parâmetros de métodos.");
            Console.WriteLine("");
            Console.WriteLine("Agregação - é a relação entre duas classes em que uma classe possui objetos de outra classe como parte de sua estrutura, mas esses objetos podem existir independentemente da classe que os contém.");
            Console.WriteLine("");
            Console.WriteLine("Composição - é uma relação de agregação mais forte, em que a existência do objeto contido depende da existência da classe que o contém. Se a classe contenedora for destruída, o objeto contido também será.");
            Console.WriteLine("");
            Console.WriteLine("Generalização - é a relação entre duas classes em que uma classe filha herda os atributos e métodos de uma classe mãe, como na herança. No entanto, a generalização é usada para representar relações entre classes mais abstratas e genéricas. Por exemplo, a classe \"Mamífero\" pode ser generalizada para \"Cão\" e \"Gato\".");
            Console.ReadKey();
        }
    }
}
