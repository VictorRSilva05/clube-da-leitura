using ClubeDaLeitura.WinFormsApp.Compartilhado;
using ClubeDaLeitura.WinFormsApp.ModuloAmigo;
using ClubeDaLeitura.WinFormsApp.ModuloCaixa;
using ClubeDaLeitura.WinFormsApp.ModuloRevista;
using System.Reflection;

namespace ClubeDaLeitura.WinFormsApp
{
    public partial class Form1 : Form
    {
        public RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
        public RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
        public RepositorioRevista repositorioRevista = new RepositorioRevista();
        public Form1()
        {
            InitializeComponent();
            CargaInicialAmigos();
            CargaInicialCaixas();
            CargaInicialRevistas();
            InicializarDataGridViewAmigos();
            InicializarDataGridViewCaixas();
            InicializarDataGridViewRevistas();
            AtualizarDataGridViewAmigos();
            AtualizarDataGridViewCaixas();
            AtualizarDataGridViewRevistas();
            InicializarComboBoxEmprestimosEtiqueta();
            InicializarComboBoxCaixaRevista();
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

        private void buttonSalvarRevista_Click(object sender, EventArgs e)
        {
            string titulo = textBoxTituloRevista.Text;
            string auxNumeroDaEdicao = textBoxNumeroEdicaoRevista.Text;
            if (string.IsNullOrEmpty(auxNumeroDaEdicao))
            {
                MessageBox.Show("O campo 'Número da Edição' é obrigatório.");
                return;
            }
            int numeroDaEdicao = Convert.ToInt32(auxNumeroDaEdicao);
            DateTime anoDePublicacao = dateTimePickerAnoPublicacaoRevista.Value;
            int index = comboBoxCaixaRevista.SelectedIndex + 1;
            Caixa caixa = repositorioCaixa.SelecionarPorId(index.ToString());

            Revista revista = new Revista(titulo, numeroDaEdicao, anoDePublicacao, caixa);

            string erros = revista.Validar();

            if (erros.Length > 0)
            {
                MessageBox.Show(erros);
                return;
            }

            revista.Id = GeradorDeIds.GerarIdRevista();
            repositorioRevista.Inserir(revista);
            MessageBox.Show($"Revista {revista.Titulo} inserida!");
            LimparCamposRevista();
            AtualizarDataGridViewRevistas();
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
            AtualizarDataGridViewCaixas();

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



        private void LimparCamposRevista()
        {
            textBoxIdRevista.Clear();
            textBoxTituloRevista.Clear();
            textBoxNumeroEdicaoRevista.Clear();
            dateTimePickerAnoPublicacaoRevista.Value = DateTime.Now;
            textBoxStatusRevista.Clear();
            comboBoxCaixaRevista.SelectedIndex = -1;
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

        private void buttonDeletarRevista_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxIdRevista.Text))
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }
            else
            {
                repositorioRevista.Excluir(repositorioRevista.SelecionarPorId(textBoxIdRevista.Text));
            }
            MessageBox.Show($"Revista com o id {textBoxIdRevista.Text} foi excluída.");
            LimparCamposRevista();
            AtualizarDataGridViewRevistas();
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
            AtualizarDataGridViewCaixas();

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
        private void buttonAtualizarRevista_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdRevista.Text))
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }
            else
            {
                var revista = repositorioRevista.SelecionarPorId(textBoxIdRevista.Text);

                revista.Titulo = textBoxTituloRevista.Text;
                revista.NumeroDaEdicao = Convert.ToInt32(textBoxNumeroEdicaoRevista.Text);
                revista.AnoDePublicacao = dateTimePickerAnoPublicacaoRevista.Value;
                int index = comboBoxCaixaRevista.SelectedIndex + 1;
                revista.Caixa = repositorioCaixa.SelecionarPorId(index.ToString());

                string erros = revista.Validar();

                if (erros.Length > 0)
                {
                    MessageBox.Show(erros);
                    return;
                }

                MessageBox.Show($"Revista {revista.Titulo} atualizada!");
                LimparCamposRevista();
                AtualizarDataGridViewRevistas();
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
                AtualizarDataGridViewCaixas();
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

        private void InicializarDataGridViewCaixas()
        {
            dataGridView2.Columns.Add("Id", "Id");
            dataGridView2.Columns[0].Width = 200;
            dataGridView2.Columns.Add("Etiqueta", "Etiqueta");
            dataGridView2.Columns[1].Width = 250;
            dataGridView2.Columns.Add("Cor", "Cor");
            dataGridView2.Columns[2].Width = 250;
            dataGridView2.Columns.Add("PrazoDeEmprestimo", "Prazo de empréstimo");
            dataGridView2.Columns[3].Width = 250;
        }

        private void InicializarDataGridViewRevistas()
        {
            dataGridView3.Columns.Add("Id", "Id");
            dataGridView3.Columns[0].Width = 190;
            dataGridView3.Columns.Add("Nome", "Nome");
            dataGridView3.Columns[1].Width = 250;
            dataGridView3.Columns.Add("NúmeroEdição", "Número da Edição");
            dataGridView3.Columns.Add("AnoPublicacao", "Ano de publicação");
            dataGridView3.Columns[3].Width = 150;
            dataGridView3.Columns.Add("Status", "Status");
            dataGridView3.Columns.Add("Caixa", "Caixa");
        }
        private void AtualizarDataGridViewAmigos()
        {
            dataGridView1.Rows.Clear();
            foreach (var amigo in repositorioAmigo.amigos)
            {
                dataGridView1.Rows.Add(amigo.Id, amigo.Nome, amigo.Responsavel, amigo.Telefone);
            }
        }

        private void AtualizarDataGridViewCaixas()
        {
            dataGridView2.Rows.Clear();
            foreach (var caixa in repositorioCaixa.caixas)
            {
                dataGridView2.Rows.Add(caixa.Id, caixa.Etiqueta, caixa.Cor, caixa.DiasDeEmprestimo);
            }
        }

        private void AtualizarDataGridViewRevistas()
        {
            dataGridView3.Rows.Clear();
            foreach (var revista in repositorioRevista.revistas)
            {
                dataGridView3.Rows.Add(revista.Id, revista.Titulo, revista.NumeroDaEdicao, revista.AnoDePublicacao, revista.StatusDeEmprestimo, revista.Caixa.Etiqueta);
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

        private void CargaInicialAmigos()
        {
            Amigo amigo1 = new Amigo("Legolas", "Thranduil", "49 99999-9999");
            amigo1.Id = GeradorDeIds.GerarIdAmigo();
            repositorioAmigo.Inserir(amigo1);
            Amigo amigo2 = new Amigo("Gandalf", "Saruman", "49 88888-8888");
            amigo2.Id = GeradorDeIds.GerarIdAmigo();
            repositorioAmigo.Inserir(amigo2);
            Amigo amigo3 = new Amigo("Frodo", "Bilbo", "49 77777-7777");
            amigo3.Id = GeradorDeIds.GerarIdAmigo();
            repositorioAmigo.Inserir(amigo3);
            Amigo amigo4 = new Amigo("Sam", "Bilbo", "49 66666-6666");
            amigo4.Id = GeradorDeIds.GerarIdAmigo();
            repositorioAmigo.Inserir(amigo4);
            Amigo amigo5 = new Amigo("Aragorn", "Arwen", "49 55555-5555");
            amigo5.Id = GeradorDeIds.GerarIdAmigo();
            repositorioAmigo.Inserir(amigo5);
            Amigo amigo6 = new Amigo("Gimli", "Gloin", "49 44444-4444");
            amigo6.Id = GeradorDeIds.GerarIdAmigo();
            repositorioAmigo.Inserir(amigo6);
            Amigo amigo7 = new Amigo("Boromir", "Denethor", "49 33333-3333");
            amigo7.Id = GeradorDeIds.GerarIdAmigo();
            repositorioAmigo.Inserir(amigo7);
        }

        private void CargaInicialCaixas()
        {
            Caixa caixa1 = new Caixa("Terror", "255 0 0", 3);
            caixa1.Id = GeradorDeIds.GerarIdCaixa();
            repositorioCaixa.Inserir(caixa1);
            Caixa caixa2 = new Caixa("Aventura", "0 255 0", 5);
            caixa2.Id = GeradorDeIds.GerarIdCaixa();
            repositorioCaixa.Inserir(caixa2);
            Caixa caixa3 = new Caixa("Romance", "0 0 255", 7);
            caixa3.Id = GeradorDeIds.GerarIdCaixa();
            repositorioCaixa.Inserir(caixa3);
            Caixa caixa4 = new Caixa("Ficção", "255 255 0", 3);
            caixa4.Id = GeradorDeIds.GerarIdCaixa();
            repositorioCaixa.Inserir(caixa4);
            Caixa caixa5 = new Caixa("Fantasia", "255 0 255", 5);
            caixa5.Id = GeradorDeIds.GerarIdCaixa();
            repositorioCaixa.Inserir(caixa5);
            Caixa caixa6 = new Caixa("Mistério", "0 255 255", 7);
            caixa6.Id = GeradorDeIds.GerarIdCaixa();
            repositorioCaixa.Inserir(caixa6);
            Caixa caixa7 = new Caixa("História", "128 128 128", 3);
            caixa7.Id = GeradorDeIds.GerarIdCaixa();
            repositorioCaixa.Inserir(caixa7);
            Caixa caixa8 = new Caixa("Biografia", "255 165 0", 5);
            caixa8.Id = GeradorDeIds.GerarIdCaixa();
            repositorioCaixa.Inserir(caixa8);
            Caixa caixa9 = new Caixa("Autoajuda", "128 0 128", 7);
            caixa9.Id = GeradorDeIds.GerarIdCaixa();
            repositorioCaixa.Inserir(caixa9);

        }

        private void CargaInicialRevistas()
        {
            Revista revista1 = new Revista("Punisher", 1, DateTime.Now, repositorioCaixa.caixas[0]);
            revista1.Id = GeradorDeIds.GerarIdRevista();
            repositorioRevista.Inserir(revista1);
            Revista revista2 = new Revista("Batman", 2, DateTime.Now, repositorioCaixa.caixas[1]);
            revista2.Id = GeradorDeIds.GerarIdRevista();
            repositorioRevista.Inserir(revista2);
            Revista revista3 = new Revista("Superman", 3, DateTime.Now, repositorioCaixa.caixas[2]);
            revista3.Id = GeradorDeIds.GerarIdRevista();
            repositorioRevista.Inserir(revista3);
            Revista revista4 = new Revista("Gears Of War", 4, DateTime.Now, repositorioCaixa.caixas[3]);
            revista4.Id = GeradorDeIds.GerarIdRevista();
            repositorioRevista.Inserir(revista4);
            Revista revista5 = new Revista("Halo", 5, DateTime.Now, repositorioCaixa.caixas[4]);
            revista5.Id = GeradorDeIds.GerarIdRevista();
            repositorioRevista.Inserir(revista5);
            Revista revista6 = new Revista("God Of War", 6, DateTime.Now, repositorioCaixa.caixas[5]);
            revista6.Id = GeradorDeIds.GerarIdRevista();
            repositorioRevista.Inserir(revista6);
            Revista revista7 = new Revista("Final Fantasy", 7, DateTime.Now, repositorioCaixa.caixas[6]);
            revista7.Id = GeradorDeIds.GerarIdRevista();
            repositorioRevista.Inserir(revista7);
            Revista revista8 = new Revista("Zelda", 8, DateTime.Now, repositorioCaixa.caixas[7]);
            revista8.Id = GeradorDeIds.GerarIdRevista();
            repositorioRevista.Inserir(revista8);
        }

        private void PopularControlesCaixa(Caixa caixa)
        {
            textBoxIdEtiqueta.Text = caixa.Id.ToString();
            textBoxEtiqueta.Text = caixa.Etiqueta.ToString();
            comboBoxEmprestimoEtiqueta.SelectedItem = caixa.DiasDeEmprestimo;
            string[] cor = caixa.Cor.Split(' ');
            textBoxRed.Text = cor[0];
            textBoxGreen.Text = cor[1];
            textBoxBlue.Text = cor[2];
            panel1.BackColor = Color.FromArgb(Convert.ToInt32(cor[0]), Convert.ToInt32(cor[1]), Convert.ToInt32(cor[2]));
        }

        private void PopularControlesRevista(Revista revista)
        {
            textBoxIdRevista.Text = revista.Id.ToString();
            textBoxTituloRevista.Text = revista.Titulo.ToString();
            textBoxNumeroEdicaoRevista.Text = revista.NumeroDaEdicao.ToString();
            dateTimePickerAnoPublicacaoRevista.Value = revista.AnoDePublicacao;
            textBoxStatusRevista.Text = revista.StatusDeEmprestimo;
            comboBoxCaixaRevista.SelectedItem = revista.Caixa.Etiqueta;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControlesCaixa(repositorioCaixa.caixas[e.RowIndex]);
        }

        private void PermitirSomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxIdAmigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirSomenteNumeros(sender, e);
        }

        private void textBoxIdEtiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirSomenteNumeros(sender, e);
        }

        private void textBoxIdRevista_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirSomenteNumeros(sender, e);
        }

        private void textBoxNumeroEdicaoRevista_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirSomenteNumeros(sender, e);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControlesRevista(repositorioRevista.revistas[e.RowIndex]);
        }

        private void InicializarComboBoxCaixaRevista()
        {
            comboBoxCaixaRevista.Items.Clear();
            foreach (var caixa in repositorioCaixa.caixas)
            {
                comboBoxCaixaRevista.Items.Add(caixa.Etiqueta);
            }
        }

        private void buttonLimparRevista_Click(object sender, EventArgs e)
        {
            LimparCamposRevista();
        }

    }
}
