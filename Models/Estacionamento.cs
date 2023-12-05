using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentp.Models
{
    public class Estacionamento
    {
        private decimal precoInical =0;
        private decimal precoPorhora=0;
        private List<String> veiculos = new List<string>();
        
        public Estacionamento(decimal precoInical, decimal precoPorhora)
        {
            this.precoInical =precoInical;
            this.precoPorhora = precoPorhora;
        }
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja estacionar");
            string Placa = Console.ReadLine();
            veiculos.Add(Placa);
        }
        public void RemoverPlaca(){
            Console.WriteLine("Digite a Placa que deseja Remover");
            string placa =Console.ReadLine();
            if(veiculos.Any(x=>x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que desejar estacionar seu carro");
                
                int horas =0;
                decimal valorTotal =precoInical + precoPorhora + horas;
                Console.WriteLine($"O {placa} não foi removido o valor total é de {valorTotal}");


            }
            else
            {
                Console.WriteLine("O veículo que digitou não se encontra aqui, confira se informou corretamente a palca");
            }

        }
        public void ListarVeiculos(){
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos estacionados são");
                for(int contador =0; contador < veiculos.Count; contador++)
                {
                    Console.WriteLine($"{contador + 1 } {veiculos[contador]}");
                }
            }
            else{
                Console.WriteLine("Não ha Veiculos encontrados no sistema");
            }
        }
    }
}