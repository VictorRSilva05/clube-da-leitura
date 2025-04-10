using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.WinFormsApp.ModuloAmigo
{
    public class RepositorioAmigo
    {
        private List<Amigo> amigos;

        public RepositorioAmigo()
        {
            amigos = new List<Amigo>();
        }

        public void Inserir(Amigo amigo)
        {
            amigos.Add(amigo);
        }

        public void Editar()
        {

        }

        public void Excluir(Amigo amigo)
        {
            amigos.Remove(amigo);
        }

        public void SelecionarTodos()
        {

        }

        public Amigo SelecionarPorId(string auxId)
        {
            long id = Convert.ToInt64(auxId);

            var amigo = amigos.Find(e => e.Id == id);

            return amigo;
        }
    }
}
