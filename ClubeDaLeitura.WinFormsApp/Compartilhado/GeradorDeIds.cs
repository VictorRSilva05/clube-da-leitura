using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.WinFormsApp.Compartilhado
{
    public static class GeradorDeIds
    {
        public static long IdAmigo = 0;
        public static long IdCaixa = 0;
        public static long IdRevista = 0;
        public static long IdEmprestimo = 0;
        public static long IdReserva = 0;
        public static long IdMulta = 0;

        public static long GerarIdAmigo()
        {
            IdAmigo++;
            return IdAmigo;
        }

        public static long GerarIdCaixa()
        {
            IdCaixa++;
            return IdCaixa;
        }

        public static long GerarIdRevista()
        {
            IdRevista++;
            return IdRevista;
        }

        public static long GerarIdEmprestimo()
        {
            IdEmprestimo++;
            return IdEmprestimo;
        }

        public static long GerarIdReserva()
        {
            IdReserva++;
            return IdReserva;
        }
        public static long GerarIdMulta()
        {
            IdMulta++;
            return IdMulta;
        }
    }
}
