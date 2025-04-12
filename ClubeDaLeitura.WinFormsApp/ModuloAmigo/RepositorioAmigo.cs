using ClubeDaLeitura.WinFormsApp.ModuloEmprestimo;
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
        public List<Amigo> amigos = new List<Amigo>();

        RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();
        public RepositorioAmigo()
        {

        }

        public bool Inserir(Amigo amigo)
        {

            foreach (var item in amigos)
            {
                if (item.Nome == amigo.Nome)
                {
                    MessageBox.Show("Nome já cadastrado");
                    return false;
                }
            }

            foreach (var item in amigos)
            {
                if (item.Telefone == amigo.Telefone)
                {
                    MessageBox.Show("Telefone já cadastrado");
                    return false;
                }
            }
            amigos.Add(amigo);
            return true;
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
