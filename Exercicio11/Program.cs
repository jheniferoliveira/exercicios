using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração da variavel
        	double juros, capital, taxa;
        	int periodo;
	
//pede para informal a capital inicial
        	Console.WriteLine("informe o capital inicial");

	//converte a capital para double
        	capital = Convert.ToDouble(Console.ReadLine());

	//pede para informar a taxa
        	Console.WriteLine("informe a taxa");

	//converte a taxa para double
        	taxa = Convert.ToDouble(Console.ReadLine());

	//pede para informar o periodo
        	Console.WriteLine("informe o periodo");

	//converte o periodo para double
        	periodo = Convert.ToInt32(Console.ReadLine());

	//calcular o juros 
        	juros = capital * taxa * periodo;

        	Console.WriteLine("resultado: " + juros);

        }
    }
}
