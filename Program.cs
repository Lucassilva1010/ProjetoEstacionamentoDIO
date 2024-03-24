using ProjetoEstacionamentoDIO.Models;
using System;

namespace ProjetoEstacionamentoDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            decimal precoInicial = 0;
            decimal precoHora = 0;
            bool mostraMenu = true;
            string opc = string.Empty;


            //entrada de dados para futuros calculos
            Console.Write("Seja bem vindo ao sistema de Estacionamento da DIO!\n" +
                                    "Digete O valor da Inicial: ");
            precoInicial = Convert.ToDecimal(Console.ReadLine());

            Console.Write($@"Agora digite o valor do preço por Hora: ");
            precoHora = Convert.ToDecimal(Console.ReadLine());

            //É preciso instanciar apenas depois de receber os valores iniciais, para que seja alocados na memória
            Estacionamento esta = new Estacionamento(precoInicial, precoHora); 

            //Isso faz com que o menu sempre apareça
            while (mostraMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        esta.AdicionarVeiculo();
                        break;

                    case "2":
                        esta.RemoverVeiculo();
                        break;

                    case "3":
                        esta.ListarVeiculos();
                        break;

                    case "4":
                        esta.Mostravagas();
                        break;
                    case "5":
                        mostraMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }

                Console.WriteLine("Pressione uma tecla para continuar");
                
                Console.ReadLine();
            }

        }
    }
}
