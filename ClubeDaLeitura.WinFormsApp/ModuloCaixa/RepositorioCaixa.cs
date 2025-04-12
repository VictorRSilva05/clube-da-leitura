using ClubeDaLeitura.WinFormsApp.ModuloAmigo;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.WinFormsApp.ModuloCaixa
{
    public class RepositorioCaixa
    {
        public List<Caixa> caixas = new List<Caixa>();

        public bool Inserir(Caixa caixa)
        {
            foreach (var ca in caixas)
            {
                if (ca.Etiqueta == caixa.Etiqueta)
                {
                    MessageBox.Show("Etiqueta já cadastrada");
                    return false;
                }
            }
            caixas.Add(caixa);
            return true;
        }

        public void Editar()
        {

        }

        public void Excluir(Caixa caixa)
        {
            caixas.Remove(caixa);
        }

        public void SelecionarTodos()
        {
        }

        public Caixa SelecionarPorId(string auxId)
        {
            long id = Convert.ToInt64(auxId);

            var caixa = caixas.Find(e => e.Id == id);

            return caixa;
        }
    }
}
