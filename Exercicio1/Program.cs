using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
           //declaração das variáveis do tipo int (número inteiro)
           int numero1, numero2, resultado;

           //exibe uma mensagem na tela
           Console.WriteLine("Informe o 1° número");
           //converte o que o usuário digitar para int32 e coloca na variável numero1
           numero1= Convert.ToInt32(Console.ReadLine());

           //exibe uma mensagem na tela
           Console.WriteLine("Informe o 2° número");
           //converte o que o usuário digitar para int32 e coloca na variável número 2
           numero2= Convert.ToInt32(Console.ReadLine());

           //realiza a conta que aparece na fórmula
           resultado= (numero1 + numero2) * numero1;
           // revela o resultado
           Console.WriteLine(+ resultado);
            Console.Read();
        }
    }
}
