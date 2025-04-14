

using ClubeDaLeitura.WinFormsApp.ModuloAmigo;
using ClubeDaLeitura.WinFormsApp.ModuloRevista;

namespace ClubeDaLeitura.WinFormsApp.ModuloReserva
{
    public class Reserva
    {
        public long Id { get; set; }
        public Amigo Amigo { get; set; }
        public Revista Revista { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Situacao { get; set; }

        public Reserva ()  { }

        public Reserva(Amigo amigo, Revista revista, DateTime dataRetirada)
        {
            Amigo = amigo;
            Revista = revista;
            DataRetirada = dataRetirada;
        }

        public DateTime ObterDataDevolucao()
        {
            return DataDevolucao = DataRetirada.AddDays(Revista.Caixa.DiasDeEmprestimo);
        }

        public string ObterSituacao()
        {
            if (DataDevolucao < DateTime.Now)
                return "Atrasado";
            else
                return "Aberto";
        }

    }
}
