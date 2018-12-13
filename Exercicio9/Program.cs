using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração das variáveis tipo int
           int n1, n2, n3, n4, n5, media;


           //escreve algo na tela
           Console.WriteLine("informe o primeiro numero");
           n1 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("informe o segundo numero");
           n2 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("informe o terceiro numero");
           n3 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("informe o quarto numero");
           n4 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("informe o quinto numero");
           n5 = Convert.ToInt32(Console.ReadLine());


           //calcula a media
           media = (n1 + n2 + n3 + n4 + n5)/5;
           Console.WriteLine("a media é de: " + media);
           Console.WriteLine("exercicio 9");


        }
    }
}
