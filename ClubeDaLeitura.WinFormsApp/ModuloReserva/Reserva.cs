

using ClubeDaLeitura.WinFormsApp.ModuloAmigo;
using ClubeDaLeitura.WinFormsApp.ModuloRevista;
using System.Configuration;

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
            DataDevolucao = ObterDataDevolucao();
            Situacao = ObterSituacao();
        }

        public string Validar()
        {
            string erros = "";

            if (Amigo is null)
                erros += "É necessário inserir um amigo.\n";

            if (Revista is null)
                erros += "É necessário inserir uma revista.\n";

            if (Revista.StatusDeEmprestimo == "Emprestada")
                erros += "Revista já emprestada.\n";

            if (Revista.StatusDeEmprestimo == "Reservada")
                erros += "Revista já está reservada.\n";

            if (DataRetirada == null)
                erros += "É necessário inserir uma data de retirada da reserva.\n";

            return erros;

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
                return "Ativo";
        }

    }
}
