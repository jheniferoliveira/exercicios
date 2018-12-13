using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração das variáveis
           Double meses, resultado;

           //escreve algo na tela
           Console.WriteLine("informe a quantidade de meses para saber quantos dias tem");
           meses = Convert.ToDouble(Console.ReadLine());

           //calcula o resultado
           resultado = 30 * meses;
           Console.WriteLine("a quantidade de dias é de: " + resultado);
           Console.WriteLine("exercicio 8");

        }
    }
}
