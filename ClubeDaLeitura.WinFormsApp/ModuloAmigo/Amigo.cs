using ClubeDaLeitura.WinFormsApp.ModuloMulta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.WinFormsApp.ModuloAmigo
{
    public class Amigo
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public List<Multa> Multas = new List<Multa>();

        public Amigo() { }

        public Amigo(string nome, string responsavel, string telefone)
        {
            Nome = nome;
            Responsavel = responsavel;
            Telefone = telefone;
        }

        public string Validar()
        {
            string erros = "";

            if (string.IsNullOrWhiteSpace(Nome))
                erros += "É necessário inserir um nome.\n";

            if (string.IsNullOrWhiteSpace(Responsavel))
                erros += "É necessário inserir um responsável.\n";

            if (Nome.Length < 3)
                erros += "O nome é muito curto.\n";

            if (Responsavel.Length < 3)
                erros += "O nome do responsável é muito curto.\n";

            if (string.IsNullOrWhiteSpace(Telefone))
                erros += "É necessário inserir um telefone.\n";

            return erros;
        }

        public void ObterEmprestimos()
        {

        }
    }
}
