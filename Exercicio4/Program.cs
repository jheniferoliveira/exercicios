using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
                  /*escreva um programa que armazene o valor 999 na variável A e o valor 555 na variável B. A seguir troque seus conteúdos fazendo com que o valor que está em A passe para B e vice-versa utilizando uma variável C para realizar a troca*/

            //declaração das variáveis tipo int
            int a = 999, b = 555, c;

            //fala os valores das variáveis antes de serem alterados 
            Console.WriteLine("Os valores das variáveis são: a: 999, b: 555, c: sem valor");

            c = a;
            a = b;
            b = c;
            c = 0;

            //o valor de a após ser alterado
            Console.WriteLine("Agora o valor de a é " + a);

            //o valor de b após ser alterado
            Console.WriteLine("Agora o valor de b é " + b);

            //o valor de c apó ser alterado
            Console.WriteLine("Agora o valor de c é " + c);

            //para realizar o teste das variáveis 

            Console.Read();

        }
    }
}
