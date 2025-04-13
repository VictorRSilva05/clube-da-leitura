using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.WinFormsApp.ModuloCaixa
{
    public class Caixa
    {
        public long Id { get; set; }
        public string Etiqueta { get; set; }
        public string Cor { get; set; }
        public int DiasDeEmprestimo { get; set; }

        public Caixa() { }

        public Caixa(string etiqueta, string cor, int diasDeEmprestimo)
        {
            Etiqueta = etiqueta;
            Cor = cor;
            DiasDeEmprestimo = diasDeEmprestimo;
        }

        public string Validar()
        {
            string erros = "";
            if (string.IsNullOrWhiteSpace(Etiqueta))
                erros += "É necessário inserir uma etiqueta.\n";

            if (Etiqueta.Length > 50)
                erros += "O nome da etiqueta é muito grande.\n";

            if (string.IsNullOrWhiteSpace(Cor))
                erros += "É necessário inserir uma cor.\n";

            if (DiasDeEmprestimo == 0)
                erros += "É necessário estipular uma data de empréstimo.\n";

            if (string.IsNullOrWhiteSpace(Cor))
                erros += "É necessário inserir uma cor.\n";

            return erros;
        }

        public Color ExtrairCor()
        {
            byte r, g, b = default;
            string[] cores = Cor.Split(' ');
            r = Convert.ToByte(cores[0]);
            g = Convert.ToByte(cores[1]);
            b = Convert.ToByte(cores[2]);
            return Color.FromArgb(r, g, b);
        }
    }
}
