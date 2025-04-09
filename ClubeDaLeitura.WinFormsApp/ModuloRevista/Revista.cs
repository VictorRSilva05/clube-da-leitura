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
        public string NumeroDaEdicao { get; set; }
        public DateTime AnoDePublicacao { get; set; }
        public string StatusDeEmprestimo { get; set; }
        public Caixa Caixa { get; set; }

        public Revista()
        {

        }

        public void Validar()
        {

        }

        public void Emprestar()
        {

        }

        public void Devolver()
        {

        }

        public void Reservar()
        {

        }
    }
}
