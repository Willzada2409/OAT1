using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 1: Qual a diferença entre Polimorfismo, Herança, Encapsulamento e Abstração?");
            Console.WriteLine("");
            Console.WriteLine("Polimorfismo - é a capacidade de objetos de classes diferentes responderem a uma mesma mensagem de maneiras diferentes.  É um conceito fundamental da programação orientada a objetos e permite a criação de códigos mais flexíveis e reutilizáveis.\r\n    Herança - é a relação entre duas classes em que uma classe filha herda os atributos e métodos de uma classe mãe.  Isso permite a criação de novas classes a partir de outras já existentes, sem a necessidade de reescrever todo o código.\r\n    Encapsulamento - é a técnica que permite esconder detalhes de implementação de uma classe e expor apenas as interfaces necessárias para o uso dessa classe. Isso torna o código mais seguro, flexível e fácil de manter.\r\n    Abstração - é a capacidade de identificar as características essenciais de um objeto e criar uma classe que represente essas características de forma genérica. Isso permite a criação de códigos mais abstratos e reutilizáveis.\r\n");
            Console.ReadKey();
        }
    }
}
