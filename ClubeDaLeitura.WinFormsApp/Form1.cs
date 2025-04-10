using ClubeDaLeitura.WinFormsApp.Compartilhado;
using ClubeDaLeitura.WinFormsApp.ModuloAmigo;
using System.Reflection;

namespace ClubeDaLeitura.WinFormsApp
{
    public partial class Form1 : Form
    {
        public RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
        public Form1()
        {
            InitializeComponent();
            InicializarDataGridViewAmigos();
            AtualizarDataGridViewAmigos();
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
            repositorioAmigo.Inserir(amigo);
            MessageBox.Show($"Amigo {amigo.Nome} inserido!");
            LimparCamposAmigos();
            AtualizarDataGridViewAmigos();
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
                repositorioAmigo.Excluir(repositorioAmigo.SelecionarPorId(textBoxId.Text));
            }
            MessageBox.Show($"Amigo com o id {textBoxId.Text} foi excluído.");
            LimparCamposAmigos();
            AtualizarDataGridViewAmigos();
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
                var amigo = repositorioAmigo.SelecionarPorId(textBoxId.Text);

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
                AtualizarDataGridViewAmigos();
            }
        }

        private void InicializarDataGridViewAmigos()
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns.Add("NomeResponsável", "Nome do responsável");
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns.Add("Telefone", "Telefone");
            dataGridView1.Columns[3].Width = 250;
        }

        private void AtualizarDataGridViewAmigos()
        {
            dataGridView1.Rows.Clear();
            foreach (var amigo in repositorioAmigo.amigos)
            {
                dataGridView1.Rows.Add(amigo.Id, amigo.Nome, amigo.Responsavel, amigo.Telefone);
            }
        }

        private void PopularControlesAmigos(Amigo amigo)
        {
            textBoxId.Text = amigo.Id.ToString();
            textBoxNome.Text = amigo.Nome.ToString();
            textBoxNomeResponsavel.Text = amigo.Responsavel.ToString();
            maskedTextBoxTelefone.Text = amigo.Telefone.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControlesAmigos(repositorioAmigo.amigos[e.RowIndex]);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)pictureBox1.Image;
            if (e.X > 0 && e.Y > 0 && e.X < pixelData.Width && e.Y < pixelData.Height)
            {
                Color color = pixelData.GetPixel(e.X, e.Y);
                labelSmallScreen.BackColor = color;
                labelValues.Text = "R " + color.R.ToString() + ", " + color.G.ToString() + ", " + color.B.ToString();
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)pictureBox1.Image;
            if (e.X > 0 && e.Y > 0 && e.X < pixelData.Width && e.Y < pixelData.Height)
            {  
                Color color = pixelData.GetPixel(e.X, e.Y);
                textBoxRed.Text = color.R.ToString();
                textBoxGreen.Text = color.G.ToString();
                textBoxBlue.Text = color.B.ToString();
                panel1.BackColor = color;
            }
        }
    }
}
