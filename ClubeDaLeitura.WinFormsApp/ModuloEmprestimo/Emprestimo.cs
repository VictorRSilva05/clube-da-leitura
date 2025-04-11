using ClubeDaLeitura.WinFormsApp.ModuloAmigo;
using ClubeDaLeitura.WinFormsApp.ModuloRevista;
namespace ClubeDaLeitura.WinFormsApp.ModuloEmprestimo
{
    public class Emprestimo
    {
        public long Id { get; set; }
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
