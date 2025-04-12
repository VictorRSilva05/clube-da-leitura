using ClubeDaLeitura.WinFormsApp.ModuloAmigo;
using ClubeDaLeitura.WinFormsApp.ModuloRevista;
namespace ClubeDaLeitura.WinFormsApp.ModuloEmprestimo
{
    public class Emprestimo
    {
        public long Id { get; set; }
        public Amigo Amigo { get; set; }
        public Revista Revista { get; set; }
        public DateTime DataEmprestimo {  get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Situacao { get; set; }

        public Emprestimo () { }

        public Emprestimo(Amigo amigo, Revista revista)
        {
            Amigo = amigo;
            Revista = revista;
            DataEmprestimo = DateTime.Now;
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

            if(Revista.StatusDeEmprestimo == "Emprestada")
                erros += "Revista já emprestada.\n";

            return erros;
        }

        public DateTime ObterDataDevolucao()
        {
            return DataDevolucao = DataEmprestimo.AddDays(Revista.Caixa.DiasDeEmprestimo);
        }

        public string ObterSituacao()
        {
            if (DataDevolucao < DateTime.Now)
                return "Atrasado";
            else
                return "Aberto";
        }

        public void RegistrarDevolucao()
        {

        }
    }
}
