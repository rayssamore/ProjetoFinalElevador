using System;
using static NmElevador.Models.Programa;

namespace ProjetoElevador
{
    internal class Program
    {
        public static class tipos
        {
            public static int pessoasTotal;
            public static int andarAtual;

        }
        static void Main(string[] args)
        {
            //Definindo a capacidade máxima de pessoas permitidas no elevador e o total de andares no prédio
            Elevador novoElevador = new Elevador();
            Console.WriteLine("Digite a capacidade máxima de pessoas permitida no Elevador:");
            Elevador.PElevador.capacidadePessoasElevador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o total de andares do prédio:");
            Elevador.CMaxPredio.qtdAndares = Convert.ToInt32(Console.ReadLine());

            //Utilizando o método Inicializar
            novoElevador.Inicializar(Elevador.PElevador.capacidadePessoasElevador, Elevador.CMaxPredio.qtdAndares);
            bool continuar = true;
            
            do
            {
                //Definindo lista para auxiliar o usuário nas ações que ele pode utilizar
                Console.WriteLine(@"Escolha uma opção:
                        1 - Entrar
                        2 - Subir
                        3 - Sair
                        4 - Descer
                        5 - Sair do programa
                        ");
                string opcaoEscolhida = Console.ReadLine();

                // Limpando o console
                Console.Clear();
                //Quando a opção escolhida for 1, o programa direciona para o método de entrar um usuário no elevador
                if (opcaoEscolhida == "1")
                {
                    novoElevador.Entrar(Elevador.CMaxPredio.qtdAndares, Elevador.PElevador.capacidadePessoasElevador, Elevador.PElevador.pessoasElevador);


                    Console.WriteLine("total de pessoas elevador : " + Elevador.PElevador.pessoasElevador);

                }
                //Quando a opção escolhida for 2, o programa direciona para o método para subir um andar no elevador
                if (opcaoEscolhida == "2")
                {
                    novoElevador.subirAndar(Elevador.CMaxPredio.qtdAndares, Elevador.PElevador.andarAtual);
                    //tipos.andarAtual = +1;
                }
                //Quando a opção escolhida for 3, o programa direciona para o método para sair um usuário do elevador
                if (opcaoEscolhida == "3")
                {
                    novoElevador.Sair(Elevador.PElevador.pessoasElevador);

                }
                //Quando a opção escolhida for 4, o programa direciona para o método para descer um andar no elevador
                if (opcaoEscolhida == "4")
                {
                    novoElevador.descerAndar(Elevador.PElevador.andarAtual);
                   
                }
                //Quando a opção escolhida for 5, o programa direciona para sair do programa
                if (opcaoEscolhida == "5")
                {
                    continuar = false;
                }


            }

            while (continuar);

        }

    



    }

}

