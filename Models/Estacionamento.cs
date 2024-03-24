using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstacionamentoDIO.Models
{
    class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        List<string> veiculo = new List<string>();//10 vagas

        public Estacionamento(decimal pInicial, decimal pHora)
        {
            precoInicial = pInicial;
            precoPorHora = pHora;

        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculo.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            string placa;
            decimal valor = 0;

            Console.WriteLine("Digte a placa do veiculo que deseja remover:");
            placa = Console.ReadLine();

            if (veiculo.Contains(placa))
            {
                Console.Write("Quantas horas o de Estacionamento: ");
                int hora = int.Parse(Console.ReadLine());
                valor = precoInicial + (precoPorHora * hora);
                veiculo.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valor.ToString("f2")}, por {hora} hora(s)");
            
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }

        }

        public void ListarVeiculos()
        {
            if (veiculo.Count !=0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var item in veiculo)
                {
                    Console.WriteLine($"Veiculo: {item}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
        public void Mostravagas()
        {
        }
    }

    //Pensar como fazer essa logica
}

