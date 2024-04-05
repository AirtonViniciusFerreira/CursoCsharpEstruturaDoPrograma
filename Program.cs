using System;
using EstruturaDoPrograma.Exemplos;

namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            var pilha = new Pilha();
            pilha.empilhar(1);
            pilha.empilhar(10);
            pilha.empilhar(100);
            Console.WriteLine(pilha.desempilhar());
            Console.WriteLine(pilha.desempilhar());
            Console.WriteLine(pilha.desempilhar());
            Console.WriteLine(pilha.desempilhar());
        }
    }
}
