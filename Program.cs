using System.Diagnostics;
using DesafioFundamentp.Models;
Console.OutputEncoding= System. Text.Encoding.UTF8;

decimal precoInical=0;
decimal precoPorhora=0;
Console.WriteLine("Seja Bem vindo ao sistema de estacioanmento do Juan Miguel de Oliveira \n Digite agora o preço Inicial");
precoInical = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Agora digite o Preco por hora");
precoPorhora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento= new Estacionamento(precoInical,precoPorhora);

string opção = string.Empty;
bool ExibirMenu =  true;
while(ExibirMenu){
    Console.Clear();
    Console.WriteLine("1-Cadastar Veiculo");
    Console.WriteLine("2-Remover Veiculos");
    Console.WriteLine("3 Listar Veiculos");
    Console.WriteLine("4 Encerrar");

    switch(Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverPlaca();
            break;
        case "3":
            estacionamento.ListarVeiculos();
            break;
        case "4":
            ExibirMenu = false;
            break;
    }
}