using ProjetoEstacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoIncial = 0;
decimal precoPorHora = 0;


Console.WriteLine("Seja bem vindo ao sistema de estacionamento! \n" + "Digite o preço inicial:");
precoIncial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o valor por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoIncial, precoPorHora);

bool saida = true;
string opcao = string.Empty;

while (saida)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar Veiculo");
    Console.WriteLine("2 - Remover Veiculo");
    Console.WriteLine("3 - Listar Veiculos");
    Console.WriteLine("4 - Sair");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculos();
            break;
        case "4":
            saida = false;
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
    Console.WriteLine("Precione uma tecla para continuar");
    Console.ReadLine();
}
Console.WriteLine("Programa encerrado");