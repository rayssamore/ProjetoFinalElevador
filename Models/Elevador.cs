using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NmElevador.Models
{
	public class Programa
	{


		//Classe Elevador
		public class Elevador
		{
			//Definindo variaveis globais para pessoas
			public  class PElevador
			{
				public static int capacidadePessoasElevador;
				public static int pessoasElevador;
				public static int andarAtual;
			}
			//Definindo variaveis globais para o prédio
			public static class CMaxPredio
			{
				public static int qtdAndares;

			}

			//Definindo método para inicializar e obter valores da capacidade de pessoas e qtd de andares do prédio
			public void Inicializar(int capacidadePessoasElevador,int qtdAndares)
			{
				//int andarElevador = 0;
				PElevador.pessoasElevador = 0;
				PElevador.andarAtual = 0;
			}
			//Definindo método para inserir pessoas no elevador considerando a quantidade máxima permitida
			public int Entrar(int qtdAndares, int capacidadePessoasElevador, int pessoasElevador)
			{
				if (pessoasElevador  < capacidadePessoasElevador)
				{
					PElevador.pessoasElevador ++;
					//int pessoasTotal =+ 1;
				}
				else
				{
					Console.WriteLine("O elevador atingiu a capacidade maxima de pessoas");
				}
				return PElevador.pessoasElevador;

			}
			//Definindo método para retirar pessoas no elevador considerando a quantidade mínima permitida
			public int Sair(int pessoasTotal)
			{
				if (pessoasTotal != 0)
				{
					Elevador.PElevador.pessoasElevador --;
					Console.WriteLine("Total de pessoas no elevador: " + pessoasTotal);
				}
				else
				{
					Console.WriteLine("Não existe ninguém no elevador!");
					
				}
				return PElevador.pessoasElevador;
			}
			//Definindo método para subir andares do prédio considerando o andar atual para iterar e a quantidade máxima permitida
			public int subirAndar(int capacidadeMax, int andarAtual)
			{
				if (andarAtual < capacidadeMax)
				{
					PElevador.andarAtual ++; 
					Console.WriteLine("Você está no " + PElevador.andarAtual + " andar");
				}
				else
				{
					Console.WriteLine("Você está tentando subir mais do que a quantidade de andares do prédio.");
				} return andarAtual;

			}
			//Definindo método para descer andares do prédio considerando o andar atual para diminuir e a quantidade mínima permitida
			public void descerAndar(int andarAtual)
			{
				if (andarAtual != 0 && andarAtual > 0)
				{
					Elevador.PElevador.andarAtual --;
					Console.WriteLine("Você está no " + PElevador.andarAtual + " andar");
				}
				else
				{
					Console.WriteLine("Não é possível descer mais andares do que o térreo.");

				}
			}



		}
	}
}
