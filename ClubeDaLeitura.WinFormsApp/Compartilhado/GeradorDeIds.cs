using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.WinFormsApp.Compartilhado
{
    public static  class GeradorDeIds
    {
        public static long IdAmigo = 0;

        public static long GerarIdAmigo()
        {
            IdAmigo++;
            return IdAmigo;
        }
    }
}
