
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
    }
}
