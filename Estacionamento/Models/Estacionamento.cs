namespace ProjetoEstacionamento.Models;

public class Estacionamento
{
    private decimal precoIncial = 0;
    private decimal precoPorHora = 0;

    private List<string> veiculos = new List<string>();


    public Estacionamento(decimal precoIncial, decimal precoPorHora)
    {
        this.precoIncial = precoIncial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Informe a placa do veiculo");
        string placa = Console.ReadLine();
        veiculos.Add(placa);
        Console.WriteLine($"Veiculo da placa: {placa} entrou no estacionamento");
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Informe a placa do veiculo à ser retirado");
        string placa = Console.ReadLine();
        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado");
            int horasEstacionado = Convert.ToInt32(Console.ReadLine());
            decimal valorTotal = (horasEstacionado * precoPorHora) + precoIncial;

            Console.WriteLine($"Veiculo da placa {placa} foi removido do estacionamento. Total a pagar: {valorTotal}");
        }
        else
        {
            Console.WriteLine("Veiculo não encontrado");
        }

    }
    public void ListarVeiculos()
    {
        if (veiculos.Any())
        {
            Console.WriteLine("Veiculos estacionados:");
            int contador = 0;
            foreach (string carro in veiculos)
            {
                Console.WriteLine($"{contador + 1} - Carro da placa: {carro}");
                contador++;
            }
        }
        else
        {
            Console.WriteLine("Não há carros estacionados");
        }
    }
}