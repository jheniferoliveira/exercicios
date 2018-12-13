using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
           // O custo de um carro novo ao consumidor é obtido com a seguinte fórmula: custo_final = custo de fábrica +(custo de fábrica * porcentual do distribuidor )+ (custo de fábrica * porcentual de impostos)

//declaração das variáveis tipo Double 
 	 double custo_fabrica = 0, porc_distribuidor = 0, porc_imposto = 0, valor_venda = 0;

	// pede para informar o custo de fabricação do carro
           Console.WriteLine("informe o custo de fabricação do carro");

// converte a custo_fabrica  para double
           custo_fabrica = Convert.ToDouble(Console.ReadLine());

	// pede a porcentagem do distribuidor
           Console.WriteLine("informe a porcentagem do distribuidor");

	// converte a porc_distribuidor para double 
           porc_distribuidor = Convert.ToDouble(Console.ReadLine());


	// pede a porcentagem, de imposto 
           Console.WriteLine("Informe a porcentagem do imposto");

	// converte a porc_imposto para double 
           porc_imposto = Convert.ToDouble(Console.ReadLine());
	
	// faz o cálculo da média 
           valor_venda = custo_fabrica + (custo_fabrica + porc_distribuidor) + (custo_fabrica * 
porc_imposto);

	// fala a frase mais o total da média
           Console.WriteLine("O valor de venda do carro é " + valor_venda);

        }
    }
}
