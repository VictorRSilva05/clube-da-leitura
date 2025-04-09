using ClubeDaLeitura.WinFormsApp.ModuloAmigo;
using ClubeDaLeitura.WinFormsApp.ModuloRevista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.WinFormsApp.ModuloEmprestimo
{
    public class Emprestimo
    {
        public Amigo Amigo { get; set; }
        public Revista Revista { get; set; }
        public DateTime Data {  get; set; }
        public string Situacao { get; set; }

        public Emprestimo () { }

        public void Validar()
        {

        }

        public void ObterDataDevolucao()
        {

        }

        public void RegistrarDevolucao()
        {

        }
    }
}
