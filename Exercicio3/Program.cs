using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo para “Calcular o estoque médio de uma peça”, sendo que ESTOQUEMÉDIO = (QUANTIDADE MÍNIMA+QUANTIDADE MÁXIMA)/2 */

            //declaração das variáveis do tipo double
            Double qtdmax, qtdmin, qtdmed;

            //pede a quantidade minima de peças
            Console.WriteLine("Informe a quantidade mínima de peças");

            //lê a informação e guarda na váriavel
            qtdmin = Convert.ToDouble(Console.ReadLine());

             //pede a quantidade máxima de peças
            Console.WriteLine("Informe a quantidade máxima de peças");

            //lê a informação e guarda na váriavel
            qtdmax = Convert.ToDouble(Console.ReadLine());

            //faz a soma das quantidades e divide por 2
            qtdmed= (qtdmin + qtdmax)/2;

            //escreve no console o resultado da media junto com uma mensagem
            Console.WriteLine("o valor médio das peças é " + qtdmed);
        }
    }
}
