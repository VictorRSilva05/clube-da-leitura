using ClubeDaLeitura.WinFormsApp.Compartilhado;
using ClubeDaLeitura.WinFormsApp.ModuloAmigo;
using ClubeDaLeitura.WinFormsApp.ModuloReserva;
using ClubeDaLeitura.WinFormsApp.ModuloRevista;
using System.Security.Cryptography.X509Certificates;
namespace ClubeDaLeitura.WinFormsApp.ModuloEmprestimo
{
    public class Emprestimo
    {
        public long Id { get; set; }
        public Amigo Amigo { get; set; }
        public Revista Revista { get; set; }
        public DateTime DataEmprestimo {  get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Situacao { get; set; }

        public Emprestimo () { }

        public Emprestimo(Amigo amigo, Revista revista)
        {
            Amigo = amigo;
            Revista = revista;
            DataEmprestimo = DateTime.Now;
            DataPrevista = ObterDataDevolucao();
            Situacao = ObterSituacao();
        }

        public Emprestimo(Reserva reserva)
        {
            this.Id = GeradorDeIds.GerarIdEmprestimo();
            this.Amigo = reserva.Amigo;
            this.Revista = reserva.Revista;
            this.DataEmprestimo = reserva.DataRetirada;
            this.DataPrevista= reserva.DataDevolucao;
            this.DataDevolucao = DateTime.Now;
            this.Situacao = "Concluído";
        }

        public Emprestimo(Amigo amigo, Revista revista, DateTime dataEmprestimo) : this(amigo, revista)
        {
            DataEmprestimo = dataEmprestimo;
            DataPrevista = ObterDataDevolucao();
            Situacao = ObterSituacao();
        }

        public string Validar()
        {
            string erros = "";

            if (Amigo is null)
                erros += "É necessário inserir um amigo.\n";

            if (Revista is null)
                erros += "É necessário inserir uma revista.\n";

            if(Revista.StatusDeEmprestimo == "Emprestada")
                erros += "Revista já emprestada.\n";

            if (Revista.StatusDeEmprestimo == "Reservada")
                erros += "Revista já está reservada.\n";

            return erros;
        }

        public DateTime ObterDataDevolucao()
        {
            return DataPrevista = DataEmprestimo.AddDays(Revista.Caixa.DiasDeEmprestimo);
        }

        public string ObterSituacao()
        {
            if (DataPrevista < DateTime.Now)
                return "Atrasado";
            else
                return "Aberto";
        }

        public void RegistrarDevolucao()
        {

        }
    }
}
