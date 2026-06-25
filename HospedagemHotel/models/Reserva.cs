using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemHotel.models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasreservados)
        {
            DiasReservados = diasreservados;
        }
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade > hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception($"A suite {Suite.TipoSuite} não comporta o numero de Hospedes. Quantidade de Hospedes: {hospedes.Count()}, Quantidade Permitida na Suite: {Suite.Capacidade}");
            }
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            if (DiasReservados < 10)
            {
                return DiasReservados * Suite.ValorDiaria;
            }
            else
            {
                decimal valorDesconto = (DiasReservados * Suite.ValorDiaria) / 10;
                return (DiasReservados * Suite.ValorDiaria) - valorDesconto;
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
    }


}