
using ClubeDaLeitura.WinFormsApp.ModuloEmprestimo;

namespace ClubeDaLeitura.WinFormsApp.ModuloReserva
{
    public class RepositorioReserva
    {
        public List<Reserva> reservas = new List<Reserva>();

        public RepositorioReserva()
        {

        }

        public void Inserir(Reserva reserva)
        {
            reservas.Add(reserva);
        }

        public void RegistrarDevolucao(Reserva reserva)
        {
            reserva.Revista.StatusDeEmprestimo = "Disponível";
            reserva.Situacao = "Concluído";
        }

        public Reserva SelecionarPorId(string auxId)
        {
            long id = Convert.ToInt64(auxId);
            var reserva = reservas.Find(e => e.Id == id);
            return reserva;
        }
    }
}
