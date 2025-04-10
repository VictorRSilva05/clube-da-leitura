using ClubeDaLeitura.WinFormsApp.Compartilhado;
using ClubeDaLeitura.WinFormsApp.ModuloAmigo;
using ClubeDaLeitura.WinFormsApp.ModuloCaixa;
using System.Reflection;

namespace ClubeDaLeitura.WinFormsApp
{
    public partial class Form1 : Form
    {
        public RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
        public RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
        public Form1()
        {
            InitializeComponent();
            InicializarDataGridViewAmigos();
            AtualizarDataGridViewAmigos();
            InicializarComboBoxEmprestimosEtiqueta();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposAmigos();
        }

        private void buttonLimparEtiqueta_Click(object sender, EventArgs e)
        {
            LimparCamposCaixa();
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomeAmigo.Text;
            string NomeResponsavel = textBoxResponsavelAmigo.Text;
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

        private void buttonSalvarEtiqueta_Click(object sender, EventArgs e)
        {
            string etiqueta = textBoxEtiqueta.Text;
            int diasDeEmprestimo = Convert.ToInt32(comboBoxEmprestimoEtiqueta.SelectedItem);
            string cor = textBoxRed.Text + " " + textBoxGreen.Text + " " + textBoxBlue.Text;

            Caixa caixa = new Caixa(etiqueta, cor, diasDeEmprestimo);

            string erros = caixa.Validar();

            if (erros.Length > 0)
            {
                MessageBox.Show(erros);
                return;
            }

            caixa.Id = GeradorDeIds.GerarIdCaixa();
            repositorioCaixa.Inserir(caixa);
            MessageBox.Show($"Caixa {caixa.Etiqueta} inserida!");
            LimparCamposCaixa();

        }
        private void LimparCamposAmigos()
        {
            textBoxIdAmigo.Clear();
            textBoxNomeAmigo.Clear();
            textBoxResponsavelAmigo.Clear();
            maskedTextBoxTelefone.Clear();
        }

        private void LimparCamposCaixa()
        {
            textBoxIdEtiqueta.Clear();
            textBoxEtiqueta.Clear();
            comboBoxEmprestimoEtiqueta.SelectedIndex = -1;
            Color color = new Color();
            color = Color.White;
            textBoxRed.Text = color.R.ToString();
            textBoxGreen.Text = color.G.ToString();
            textBoxBlue.Text = color.B.ToString();
            panel1.BackColor = color;
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdAmigo.Text))
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }
            else
            {
                repositorioAmigo.Excluir(repositorioAmigo.SelecionarPorId(textBoxIdAmigo.Text));
            }
            MessageBox.Show($"Amigo com o id {textBoxIdAmigo.Text} foi excluído.");
            LimparCamposAmigos();
            AtualizarDataGridViewAmigos();
        }

        private void buttonDeletarEtiqueta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdEtiqueta.Text))
            {
                MessageBox.Show("Por favor, insira um ID válido");
                return;
            }
            else
            {
                repositorioCaixa.Excluir(repositorioCaixa.SelecionarPorId(textBoxIdEtiqueta.Text));
            }
            MessageBox.Show($"Caixa com o id {textBoxIdEtiqueta.Text} foi excluído.");
            LimparCamposCaixa();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdAmigo.Text))
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }
            else
            {
                var amigo = repositorioAmigo.SelecionarPorId(textBoxIdAmigo.Text);

                amigo.Nome = textBoxNomeAmigo.Text;
                amigo.Responsavel = textBoxResponsavelAmigo.Text;
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
        private void buttonAtualizarEtiqueta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdEtiqueta.Text))
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }
            else
            {
                var caixa = repositorioCaixa.SelecionarPorId(textBoxIdEtiqueta.Text);

                caixa.Etiqueta = textBoxEtiqueta.Text;
                caixa.DiasDeEmprestimo = Convert.ToInt32(comboBoxEmprestimoEtiqueta.SelectedItem);
                caixa.Cor = textBoxRed.Text + " " + textBoxGreen.Text + " " + textBoxBlue.Text;

                string erros = caixa.Validar();

                if (erros.Length > 0)
                {
                    MessageBox.Show(erros);
                    return;
                }

                MessageBox.Show($"Caixa {caixa.Etiqueta} Atualizada!");
                LimparCamposCaixa();
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
            textBoxIdAmigo.Text = amigo.Id.ToString();
            textBoxNomeAmigo.Text = amigo.Nome.ToString();
            textBoxResponsavelAmigo.Text = amigo.Responsavel.ToString();
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
                labelValues.Text = "R " + color.R.ToString() + ",G " + color.G.ToString() + ",B " + color.B.ToString();
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

        private void InicializarComboBoxEmprestimosEtiqueta()
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(5);
            list.Add(7);

            comboBoxEmprestimoEtiqueta.DataSource = list;
            comboBoxEmprestimoEtiqueta.SelectedIndex = -1;
        }
    }
}
