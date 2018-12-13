using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, salario_reajustado, salariototal;

        	Console.WriteLine("informe o seu salario");
        	salario = Convert.ToDouble(Console.ReadLine());

        	Console.WriteLine("informe a porcentagem que sera reajustada");
        	reajuste = Convert.ToDouble(Console.ReadLine());

        	salario_reajustado = salario * (reajuste/100);

        	salariototal = salario + salario_reajustado;

        	Console.WriteLine("o reajuste é de: " + salario_reajustado);

        	Console.WriteLine("o salario total reajustado é de: " + salariototal);
        }
    }
}
