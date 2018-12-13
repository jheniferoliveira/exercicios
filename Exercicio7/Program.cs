using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
           	/* Faça um programa que calcule a média simples (aritmética) de 3 valores quaisquer informado pelo usuário. utilize as variáveis valor1, valor2, e valor3. Exiba a média na tela para o usuário*/

//declaração das variáveis tipo Double 
        	Double valor1, valor2, valor3, media;
        	//Pede pra digitar um valor 
        	Console.WriteLine("digite um valor");
	//converte o valor 1 para Double
        	valor1 = Convert.ToDouble(Console.ReadLine());
//pede pra digitar mais um valor
        	Console.WriteLine("digite um segundo valor");
	// converte o valor 2 para Double 
        	valor2 = Convert.ToDouble(Console.ReadLine());
	//pede pra digitar um terceiro valor 
        	Console.WriteLine("digite um terceiro valor");
	//converte o valor 3 para Double 
        	valor3 = Convert.ToDouble(Console.ReadLine());
	// mostra a média
        	media = (valor1 + valor2 + valor3) / 3;
// mostra o resultado da média mais uma frase 
        	Console.WriteLine("a media é de " + media);
        	Console.Read();

        }
    }
}
