using ClubeDaLeitura.WinFormsApp.ModuloCaixa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.WinFormsApp.ModuloRevista
{
    public class RepositorioRevista
    {
        public List<Revista> revistas = new List<Revista>();

        public bool Inserir(Revista revista)
        {
            foreach (var rev in revistas)
            {
                if (rev.Titulo == revista.Titulo && rev.NumeroDaEdicao == revista.NumeroDaEdicao)
                {
                    MessageBox.Show("Revista já cadastrada");
                    return false;
                }
            }
            revistas.Add(revista);
            return true;
        }

        public void Editar()
        {

        }

        public void Excluir(Revista revista)
        {
            revistas.Remove(revista);
        }

        public void SelecionarTodos()
        {

        }

        public Revista SelecionarPorId(string auxId)
        {
            long id = Convert.ToInt64(auxId);

            var revista = revistas.Find(e => e.Id == id);

            return revista;
        }

    }
}
