using System.Text;
using HospedagemHotel.models;


Console.OutputEncoding = Encoding.UTF8;


// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Maria", sobrenome: "Joaquina");
Pessoa p2 = new Pessoa(nome: "Cirilo", sobrenome: "Santos");

hospedes.Add(p1);
hospedes.Add(p2);

//Cria a Suite

Suite suite = new Suite(tipoSuite: "Master", capacidade: 2, valorDiaria: 30);

//Criar reserva 
Reserva reserva = new Reserva(diasreservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

//Exibe a quantidade de Hóspedes e o valor da diaria
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da Diaria: {reserva.CalcularValorDiaria()}");