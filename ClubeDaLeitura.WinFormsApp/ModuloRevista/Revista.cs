using ClubeDaLeitura.WinFormsApp.ModuloCaixa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.WinFormsApp.ModuloRevista
{
    public class Revista
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public int NumeroDaEdicao { get; set; }
        public DateTime AnoDePublicacao { get; set; }
        public string StatusDeEmprestimo { get; set; }
        public Caixa Caixa { get; set; }

        public Revista()
        {

        }

        public Revista(string titulo, int numeroDaEdicao, DateTime anoDePublicacao, Caixa caixa)
        {
            Titulo = titulo;
            NumeroDaEdicao = numeroDaEdicao;
            AnoDePublicacao = anoDePublicacao;
            StatusDeEmprestimo = "Disponível";
            Caixa = caixa;
        }

        public string Validar()
        {
            string erros = "";

            if(string.IsNullOrWhiteSpace(Titulo))
                erros += "O campo 'Título' é obrigatório\n";

            if (Titulo.Length < 3)
                erros += "O campo 'Título' deve ter pelo menos 3 caracteres\n";

            if (NumeroDaEdicao <= 0)
                erros += "O campo 'Número da Edição' deve ser maior que zero\n";

            if (AnoDePublicacao == null)
                erros += "O campo 'Ano de Publicação' é obrigatório\n";

            if (Caixa == null)
                erros += "O campo 'Caixa' é obrigatório\n";

            return erros;
        }

        public void Emprestar()
        {

        }

        public void Devolver()
        {

        }

        public void Reservar()
        {
            StatusDeEmprestimo = "Reservada";
        }
    }
}
