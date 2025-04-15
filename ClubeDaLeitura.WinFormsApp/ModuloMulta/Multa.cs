using ClubeDaLeitura.WinFormsApp.ModuloEmprestimo;
using ClubeDaLeitura.WinFormsApp.ModuloRevista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.WinFormsApp.ModuloMulta
{
    public class Multa
    {
        public long Id { get; set; }
        public Emprestimo Emprestimo { get; set; }
        public decimal Valor { get; set; }

        public Multa(int dias, Emprestimo emprestimo)
        {
            Emprestimo = emprestimo;
            Valor = dias * 2;
        }


    }
}
