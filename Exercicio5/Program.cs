using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*crie um programa que solicite ao usuário a temperatura em celsius e converta para fahrenheit  com uma mensagem amigável.
Fórmula para cálculo F= 1.8* Celsius + 32*/

            //declaração das variáveis tipo Double
            Double celsius, fahrenheit;

            //Pede pra escrever a temperatura em celsius para ser transformada em fahrenheit
            Console.WriteLine("coloque a temperatura em celsius para transforma-lá em fahrenheit");

            //converte a temperatura em celsius para Double
            celsius = Convert.ToDouble(Console.ReadLine());

            //Fórmula de fahrenheit
            fahrenheit = 1.8 * celsius + 32;

            //escreve a temperatura de fahrenheit
            Console.WriteLine("A temperatura em fahrenheit é: " + fahrenheit);

            Console.Read();

        }
    }
}
