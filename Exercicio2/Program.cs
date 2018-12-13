using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Faça um algoritmo capas de calcular a média de 5 notas de um aluno. O sistema, além das notas deve pedir o nome do aluno e depois de calcular a média, informar o nome e a média do aluno */

           //declaração das variáveis do tipo double
           double nota1, nota2, nota3, nota4, nota5, media;

           //declaração da variável de nome do tipo string(texto)
           string nome;

           //pede o nome do aluno no console
           Console.WriteLine("Informe o nome do aluno");

           //lê  a informação digitada no console e guarda na variável
           nome = Console.ReadLine();

           //escreve no console pedindo a nota do aluno
           Console.WriteLine("Informe a 1° nota");

           //escreve no console a nota do aluno
           nota1 = Convert.ToDouble(Console.ReadLine());

            //escreve no console pedindo a nota do aluno
           Console.WriteLine("Informe a 2° nota");

           //escreve no console a nota do aluno
           nota2 = Convert.ToDouble(Console.ReadLine());

            //escreve no console pedindo a nota do aluno
           Console.WriteLine("Informe a 3° nota");

           //escreve no console a nota do aluno
           nota3 = Convert.ToDouble(Console.ReadLine());

            //escreve no console pedindo a nota do aluno
           Console.WriteLine("Informe a 4° nota");
           nota4 = Convert.ToDouble(Console.ReadLine());

            //escreve no console pedindo a nota do aluno
           Console.WriteLine("Informe a 5° nota");

           //escreve no console a nota do aluno
           nota5 = Convert.ToDouble(Console.ReadLine());
           //faz a soma das botas, e divide pela quantidade de notas
           media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

           //escreve no console o resultado da media junto com uma mensagem
           Console.WriteLine("a media do aluno(a) é:" + media);

        }
    }
}
