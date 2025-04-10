using ClubeDaLeitura.WinFormsApp.Compartilhado;
using ClubeDaLeitura.WinFormsApp.ModuloAmigo;

namespace ClubeDaLeitura.WinFormsApp
{
    public partial class Form1 : Form
    {
        public RepositorioAmigo amigos = new RepositorioAmigo();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposAmigos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string NomeResponsavel = textBoxNomeResponsavel.Text;
            string telefone = maskedTextBoxTelefone.Text;

            Amigo amigo = new Amigo(nome, NomeResponsavel, telefone);

            string erros = amigo.Validar();

            if (erros.Length > 0)
            {
                MessageBox.Show(erros);
                return;
            }

            amigo.Id = GeradorDeIds.GerarIdAmigo();
            amigos.Inserir(amigo);
            MessageBox.Show($"Amigo {amigo.Nome} inserido!");
            LimparCamposAmigos();
        }

        private void LimparCamposAmigos()
        {
            textBoxId.Clear();
            textBoxNome.Clear();
            textBoxNomeResponsavel.Clear();
            maskedTextBoxTelefone.Clear();
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }
            else
            {
                amigos.Excluir(amigos.SelecionarPorId(textBoxId.Text));
            }
            MessageBox.Show($"Amigo com o id {textBoxId.Text} foi excluído.");
            LimparCamposAmigos();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }
            else
            {
                var amigo = amigos.SelecionarPorId(textBoxId.Text);

                amigo.Nome = textBoxNome.Text;
                amigo.Responsavel = textBoxNomeResponsavel.Text;
                amigo.Telefone = maskedTextBoxTelefone.Text;

                string erros = amigo.Validar();

                if (erros.Length > 0)
                {
                    MessageBox.Show(erros);
                    return;
                }

                MessageBox.Show($"Amigo {amigo.Nome} foi atualizado.");
                LimparCamposAmigos();
            }
        }

    }
}
