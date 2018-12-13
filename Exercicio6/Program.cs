using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*escreva um programa para mostrar o sucessor e o antecessor de um número qualquer informado pelo usuário. Exiba na tela nos números seguindo o exemplo da mensagem “ O antecessor do número 10 é 9, e o sucessor é 11”.*/

	 //declaração das variáveis tipo int
            int numero, sucessor, antecessor;
	// pede para escrever um número para depois saber o sucessor e o antecessor 
            Console.WriteLine("Insira o numero para saber o antecessor e o sucessor");
	//converte o numero para int32
            numero = Convert.ToInt32(Console.ReadLine());
	//variavel antecessor 
            antecessor = numero - 1;
	//variavel sucessor 
            sucessor = numero + 1;
// formula a frase e mostra o numero que voce digitou seu sucessor e antecessor 
            Console.WriteLine("O sucessor do numero " + numero + " é " + sucessor + " e o antecessor é " + antecessor);

        }
    }
}
