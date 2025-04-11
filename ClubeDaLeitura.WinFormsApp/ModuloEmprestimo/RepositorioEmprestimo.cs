using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.WinFormsApp.ModuloEmprestimo
{
    public class RepositorioEmprestimo
    {
        public List<Emprestimo> emprestimos = new List<Emprestimo>();

        public void Inserir(Emprestimo emprestimo)
        {
            emprestimos.Add(emprestimo);
        }

        public void Editar()
        {
            
        }

        public void Excluir(Emprestimo emprestimo)
        {
            emprestimos.Remove(emprestimo);
        }

        public void VisualizarTodos()
        {

        }

        public void RegistrarDevolucao(Emprestimo emprestimo)
        {
            emprestimo.Situacao = "Concluído";
        }

        public Emprestimo SelecionarPorId(string auxId)
        {
            long id = Convert.ToInt64(auxId);
            var emprestimo = emprestimos.Find(e => e.Id == id);
            return emprestimo;
        }
    }
}
