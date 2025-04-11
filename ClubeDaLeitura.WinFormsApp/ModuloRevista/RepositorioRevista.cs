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

        public void Inserir(Revista revista)
        {
            revistas.Add(revista);
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
