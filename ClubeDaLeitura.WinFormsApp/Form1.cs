using ClubeDaLeitura.WinFormsApp.Compartilhado;
using ClubeDaLeitura.WinFormsApp.ModuloAmigo;
using ClubeDaLeitura.WinFormsApp.ModuloCaixa;
using ClubeDaLeitura.WinFormsApp.ModuloEmprestimo;
using ClubeDaLeitura.WinFormsApp.ModuloMulta;
using ClubeDaLeitura.WinFormsApp.ModuloReserva;
using ClubeDaLeitura.WinFormsApp.ModuloRevista;

namespace ClubeDaLeitura.WinFormsApp
{
    public partial class Form1 : Form
    {
        public RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
        public RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
        public RepositorioRevista repositorioRevista = new RepositorioRevista();
        public RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();
        public RepositorioReserva repositorioReserva = new RepositorioReserva();
        public Form1()
        {
            InitializeComponent();
            CargaInicialAmigos();
            CargaInicialCaixas();
            CargaInicialRevistas();
            CargaInicialEmprestimos();
            InicializarDataGridViewAmigos();
            InicializarDataGridViewCaixas();
            InicializarDataGridViewRevistas();
            InicializarDataGridViewEmprestimos();
            InicializarDataGridViewReservas();
            AtualizarDataGridViewAmigos();
            AtualizarDataGridViewCaixas();
            AtualizarDataGridViewRevistas();
            AtualizarDataGridViewEmprestimos();
            AtualizarDataGridViewReservas();
            InicializarComboBoxEmprestimosEtiqueta();
            InicializarComboBoxCaixaRevista();
            InicializarComboBoxAmigosEmprestimos();
            InicializarComboBoxRevistasEmprestimos();
        }

        private void CargaInicialEmprestimos()
        {
            string auxId = "1";
            var amigo = repositorioAmigo.SelecionarPorId(auxId);
            var revista = repositorioRevista.SelecionarPorId(auxId);
            DateTime dataEmprestimo = DateTime.Parse("07/04/2025");
            Emprestimo emprestimo = new Emprestimo(amigo, revista, dataEmprestimo);
            emprestimo.Id = GeradorDeIds.GerarIdEmprestimo();
            repositorioEmprestimo.Inserir(emprestimo);
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposAmigos();
        }

        private void buttonLimparCaixa_Click(object sender, EventArgs e)
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
            if (repositorioAmigo.Inserir(amigo))
            {
                MessageBox.Show($"Amigo {amigo.Nome} inserido!");
                LimparCamposAmigos();
                AtualizarDataGridViewAmigos();
                InicializarComboBoxAmigosEmprestimos();
            }
        }

        private void buttonSalvarRevista_Click(object sender, EventArgs e)
        {
            string titulo = textBoxTituloRevista.Text;
            string auxNumeroDaEdicao = textBoxNumeroEdicaoRevista.Text;
            if (string.IsNullOrEmpty(auxNumeroDaEdicao))
            {
                MessageBox.Show("O campo 'N�mero da Edi��o' � obrigat�rio.");
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
            if (repositorioRevista.Inserir(revista))
            {
                MessageBox.Show($"Revista {revista.Titulo} inserida!");
                LimparCamposRevista();
                AtualizarDataGridViewRevistas();
                InicializarComboBoxRevistasEmprestimos();
            }
        }

        private void buttonEmprestarEmprestimo_Click(object sender, EventArgs e)
        {
            int indexAmigo = comboBoxAmigoEmprestimo.SelectedIndex + 1;
            int indexRevista = comboBoxRevistaEmprestimo.SelectedIndex + 1;

            if (indexAmigo == 0 || indexRevista == 0)
            {
                MessageBox.Show("Selecione um amigo e uma revista.");
                return;
            }

            Amigo amigo = repositorioAmigo.SelecionarPorId(indexAmigo.ToString());
            Revista revista = repositorioRevista.SelecionarPorId(indexRevista.ToString());

            Emprestimo emprestimo = new Emprestimo(amigo, revista);

            string erros = emprestimo.Validar();

            if (erros.Length > 0)
            {
                MessageBox.Show(erros);
                return;
            }

            emprestimo.Id = GeradorDeIds.GerarIdEmprestimo();
            if (VerificarEmprestimoAtivo(amigo))
            {
                MessageBox.Show("Amigo j� possui um empr�stimo ativo.");
                return;
            }
            repositorioEmprestimo.Inserir(emprestimo);
            MessageBox.Show($"Empr�stimo de {revista.Titulo} para {amigo.Nome} registrado!");
            LimparCamposEmprestimo();
            AtualizarDataGridViewEmprestimos();
            AtualizarDataGridViewRevistas();
        }

        private void buttonReservar_Click(object sender, EventArgs e)
        {
            int indexAmigo = comboBoxAmigoEmprestimo.SelectedIndex + 1;
            int indexRevista = comboBoxRevistaEmprestimo.SelectedIndex + 1;

            if (indexAmigo == 0 || indexRevista == 0)
            {
                MessageBox.Show("Selecione um amigo e uma revista.");
                return;
            }

            DateTime dataRetirada = dateTimePickerEmprestimoEmprestimo.Value;

            Amigo amigo = repositorioAmigo.SelecionarPorId(indexAmigo.ToString());
            Revista revista = repositorioRevista.SelecionarPorId(indexRevista.ToString());

            Reserva reserva = new Reserva(amigo, revista, dataRetirada);

            string erros = reserva.Validar();

            if (erros.Length > 0)
            {
                MessageBox.Show(erros);
                return;
            }

            if (VerificarReservaAtiva(amigo))
            {
                MessageBox.Show("Amigo j� possui uma reserva ativa.");
                return;
            }

            reserva.Revista.Reservar();
            reserva.Id = GeradorDeIds.GerarIdReserva();

            repositorioReserva.Inserir(reserva);
            MessageBox.Show($"Reserva de {revista.Titulo} para {amigo.Nome} registrada!");
            LimparCamposEmprestimo();
            AtualizarDataGridViewReservas();
            AtualizarDataGridViewRevistas();
        }

        private bool VerificarReservaAtiva(Amigo amigo)
        {
            foreach (var item in repositorioReserva.reservas)
            {
                if (item.Amigo == amigo && item.Situacao == "Ativo")
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonDevolverEmprestimo_Click(object sender, EventArgs e)
        {
            string index = textBoxIdEmprestimo.Text;
            if (string.IsNullOrEmpty(index))
            {
                MessageBox.Show("Por favor, insira um ID v�lido.");
                return;
            }
            var emprestimo = repositorioEmprestimo.SelecionarPorId(index);
            repositorioEmprestimo.RegistrarDevolucao(emprestimo);
            emprestimo.DataDevolucao = DateTime.Now;
            if (emprestimo.DataDevolucao > emprestimo.DataPrevista)
            {
                int dias = (int)(emprestimo.DataDevolucao - emprestimo.DataPrevista).TotalDays;
                Multa multa = new Multa(dias, emprestimo);
                emprestimo.Amigo.Multas.Add(multa);
            }
            MessageBox.Show($"Emprestimo de {emprestimo.Revista.Titulo} de {emprestimo.Amigo.Nome} foi devolu�do!");
            AtualizarDataGridViewEmprestimos();
            AtualizarDataGridViewRevistas();
            LimparCamposEmprestimo();
        }

        private void buttonConcluirReserva_Click(object sender, EventArgs e)
        {
            string index = textBoxIdEmprestimo.Text;
            if (string.IsNullOrEmpty(index))
            {
                MessageBox.Show("Por favor, insira um ID v�lido.");
                return;
            }
            var reserva = repositorioReserva.SelecionarPorId(index);
            repositorioReserva.RegistrarDevolucao(reserva);

            Emprestimo emprestimo = new Emprestimo(reserva);
            repositorioEmprestimo.Inserir(emprestimo);

            MessageBox.Show($"Reserva de {reserva.Revista.Titulo} de {reserva.Amigo.Nome} foi conclu�da!");
            AtualizarDataGridViewReservas();
            AtualizarDataGridViewEmprestimos();
            AtualizarDataGridViewRevistas();
            LimparCamposEmprestimo();
        }

        private void buttonSalvarCaixa_Click(object sender, EventArgs e)
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
            if (repositorioCaixa.Inserir(caixa))
            {
                MessageBox.Show($"Caixa {caixa.Etiqueta} inserida!");
                LimparCamposCaixa();
                AtualizarDataGridViewCaixas();
                InicializarComboBoxCaixaRevista();
            }
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

        private void LimparCamposEmprestimo()
        {
            textBoxIdEmprestimo.Clear();
            comboBoxAmigoEmprestimo.SelectedIndex = -1;
            comboBoxRevistaEmprestimo.SelectedIndex = -1;
            dateTimePickerEmprestimoEmprestimo.Value = DateTime.Now;
            dateTimePickerDevolucaoEmprestimo.Value = DateTime.Now;
            textBoxStatusEmprestimo.Clear();
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
                MessageBox.Show("Por favor, insira um ID v�lido.");
                return;
            }
            else
            {
                if (VerificarEmprestimoAtivo(repositorioAmigo.SelecionarPorId(textBoxIdAmigo.Text)))
                {
                    MessageBox.Show("N�o � poss�vel excluir um amigo com empr�stimos ativos.");
                    return;
                }
                repositorioAmigo.Excluir(repositorioAmigo.SelecionarPorId(textBoxIdAmigo.Text));
            }
            MessageBox.Show($"Amigo com o id {textBoxIdAmigo.Text} foi exclu�do.");
            LimparCamposAmigos();
            AtualizarDataGridViewAmigos();
            InicializarComboBoxAmigosEmprestimos();
        }

        public bool VerificarEmprestimoAtivo(Amigo amigo)
        {
            foreach (var item in repositorioEmprestimo.emprestimos)
            {
                if (item.Amigo == amigo && item.Situacao == "Aberto" || item.Situacao == "Atrasado")
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonDeletarRevista_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdRevista.Text))
            {
                MessageBox.Show("Por favor, insira um ID v�lido.");
                return;
            }
            else
            {
                repositorioRevista.Excluir(repositorioRevista.SelecionarPorId(textBoxIdRevista.Text));
            }
            MessageBox.Show($"Revista com o id {textBoxIdRevista.Text} foi exclu�da.");
            LimparCamposRevista();
            AtualizarDataGridViewRevistas();
            InicializarComboBoxRevistasEmprestimos();
        }

        private void buttonDeletarCaixa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdEtiqueta.Text))
            {
                MessageBox.Show("Por favor, insira um ID v�lido");
                return;
            }
            else
            {
                if (VerificarCaixaEmUso(repositorioCaixa.SelecionarPorId(textBoxIdEtiqueta.Text)))
                {
                    MessageBox.Show("N�o � poss�vel excluir uma caixa com revistas associadas.");
                    return;
                }
                repositorioCaixa.Excluir(repositorioCaixa.SelecionarPorId(textBoxIdEtiqueta.Text));
                MessageBox.Show($"Caixa com o id {textBoxIdEtiqueta.Text} foi exclu�do.");
                LimparCamposCaixa();
                AtualizarDataGridViewCaixas();
            }
        }

        private bool VerificarCaixaEmUso(Caixa caixa)
        {
            foreach (var item in repositorioRevista.revistas)
            {
                if (item.Caixa == caixa)
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdAmigo.Text))
            {
                MessageBox.Show("Por favor, insira um ID v�lido.");
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
                MessageBox.Show("Por favor, insira um ID v�lido.");
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
                InicializarComboBoxRevistasEmprestimos();
            }
        }

        private void buttonAtualizarEtiqueta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdEtiqueta.Text))
            {
                MessageBox.Show("Por favor, insira um ID v�lido.");
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
            dataGridView1.Columns.Add("NomeRespons�vel", "Nome do respons�vel");
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
            dataGridView2.Columns.Add("PrazoDeEmprestimo", "Prazo de empr�stimo");
            dataGridView2.Columns[3].Width = 250;
        }

        private void InicializarDataGridViewRevistas()
        {
            dataGridView3.Columns.Add("Id", "Id");
            dataGridView3.Columns[0].Width = 190;
            dataGridView3.Columns.Add("Nome", "Nome");
            dataGridView3.Columns[1].Width = 250;
            dataGridView3.Columns.Add("N�meroEdi��o", "N�mero da Edi��o");
            dataGridView3.Columns.Add("AnoPublicacao", "Ano de publica��o");
            dataGridView3.Columns[3].Width = 150;
            dataGridView3.Columns.Add("Status", "Status");
            dataGridView3.Columns.Add("Caixa", "Caixa");
        }

        private void InicializarDataGridViewEmprestimos()
        {
            dataGridView4.Columns.Add("Id", "Id");
            dataGridView4.Columns.Add("Amigo", "Amigo");
            dataGridView4.Columns[1].Width = 140;
            dataGridView4.Columns.Add("Revista", "Revista");
            dataGridView4.Columns[2].Width = 140;
            dataGridView4.Columns.Add("DataEmprestimo", "Data de empr�stimo");
            dataGridView4.Columns[3].Width = 140;
            dataGridView4.Columns.Add("DataPrevista", "Data prevista");
            dataGridView4.Columns[4].Width = 140;
            dataGridView4.Columns.Add("DataDevolucao", "Data de devolu��o");
            dataGridView4.Columns[5].Width = 140;
            dataGridView4.Columns.Add("Situacao", "Situa��o");
        }

        private void InicializarDataGridViewReservas()
        {
            dataGridView5.Columns.Add("Id", "Id");
            dataGridView5.Columns.Add("Amigo", "Amigo");
            dataGridView5.Columns[1].Width = 150;
            dataGridView5.Columns.Add("Revista", "Revista");
            dataGridView5.Columns[2].Width = 150;
            dataGridView5.Columns.Add("DataEmprestimo", "Data de empr�stimo");
            dataGridView5.Columns[3].Width = 195;
            dataGridView5.Columns.Add("DataDevolucao", "Data de devolu��o");
            dataGridView5.Columns[4].Width = 195;
            dataGridView5.Columns.Add("Situacao", "Situa��o");
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

        private void AtualizarDataGridViewEmprestimos()
        {
            dataGridView4.Rows.Clear();
            foreach (var emprestimo in repositorioEmprestimo.emprestimos)
            {
                dataGridView4.Rows.Add(emprestimo.Id, emprestimo.Amigo.Nome, emprestimo.Revista.Titulo,
                    emprestimo.DataEmprestimo, emprestimo.DataPrevista, emprestimo.DataDevolucao, emprestimo.Situacao);
            }
        }

        private void AtualizarDataGridViewReservas()
        {
            dataGridView5.Rows.Clear();
            foreach (var reserva in repositorioReserva.reservas)
            {
                dataGridView5.Rows.Add(reserva.Id, reserva.Amigo.Nome, reserva.Revista.Titulo, reserva.DataRetirada, reserva.DataDevolucao, reserva.Situacao);
            }
        }

        private void PopularControlesAmigos(Amigo amigo)
        {
            textBoxIdAmigo.Text = amigo.Id.ToString();
            textBoxNomeAmigo.Text = amigo.Nome.ToString();
            textBoxResponsavelAmigo.Text = amigo.Responsavel.ToString();
            maskedTextBoxTelefone.Text = amigo.Telefone.ToString();
        }

        private void PopularControlesEmprestimo(Emprestimo emprestimo)
        {
            textBoxIdEmprestimo.Text = emprestimo.Id.ToString();
            comboBoxAmigoEmprestimo.SelectedItem = emprestimo.Amigo.Nome;
            comboBoxRevistaEmprestimo.SelectedItem = emprestimo.Revista.Titulo;
            dateTimePickerEmprestimoEmprestimo.Value = emprestimo.DataEmprestimo;
            dateTimePickerDevolucaoEmprestimo.Value = emprestimo.DataPrevista;
            textBoxStatusEmprestimo.Text = emprestimo.Situacao;
        }

        private void PopularControlesReserva(Reserva reserva)
        {
            textBoxIdEmprestimo.Text = reserva.Id.ToString();
            comboBoxAmigoEmprestimo.SelectedItem = reserva.Amigo.Nome;
            comboBoxRevistaEmprestimo.SelectedItem = reserva.Revista.Titulo;
            dateTimePickerEmprestimoEmprestimo.Value = reserva.DataRetirada;
            dateTimePickerDevolucaoEmprestimo.Value = reserva.DataDevolucao;
            textBoxStatusEmprestimo.Text = reserva.Situacao;
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

        private void InicializarComboBoxAmigosEmprestimos()
        {
            comboBoxAmigoEmprestimo.Items.Clear();
            foreach (var amigo in repositorioAmigo.amigos)
            {
                comboBoxAmigoEmprestimo.Items.Add(amigo.Nome);
            }
        }

        private void InicializarComboBoxRevistasEmprestimos()
        {
            comboBoxRevistaEmprestimo.Items.Clear();
            foreach (var rev in repositorioRevista.revistas)
            {
                comboBoxRevistaEmprestimo.Items.Add(rev.Titulo);
            }
        }

        private void CargaInicialAmigos()
        {
            Amigo amigo1 = new Amigo("Legolas", "Thranduil", "(49) 99999-9999");
            amigo1.Id = GeradorDeIds.GerarIdAmigo();
            repositorioAmigo.Inserir(amigo1);
            Amigo amigo2 = new Amigo("Gandalf", "Saruman", "(49) 88888-8888");
            amigo2.Id = GeradorDeIds.GerarIdAmigo();
            repositorioAmigo.Inserir(amigo2);
            Amigo amigo3 = new Amigo("Frodo", "Bilbo", "(49) 77777-7777");
            amigo3.Id = GeradorDeIds.GerarIdAmigo();
            repositorioAmigo.Inserir(amigo3);
            Amigo amigo4 = new Amigo("Sam", "Bilbo", "(49) 66666-6666");
            amigo4.Id = GeradorDeIds.GerarIdAmigo();
            repositorioAmigo.Inserir(amigo4);
            Amigo amigo5 = new Amigo("Aragorn", "Arwen", "(49) 55555-5555");
            amigo5.Id = GeradorDeIds.GerarIdAmigo();
            repositorioAmigo.Inserir(amigo5);
            Amigo amigo6 = new Amigo("Gimli", "Gloin", "(49) 44444-4444");
            amigo6.Id = GeradorDeIds.GerarIdAmigo();
            repositorioAmigo.Inserir(amigo6);
            Amigo amigo7 = new Amigo("Boromir", "Denethor", "(49) 33333-3333");
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
            Caixa caixa4 = new Caixa("Fic��o", "255 255 0", 3);
            caixa4.Id = GeradorDeIds.GerarIdCaixa();
            repositorioCaixa.Inserir(caixa4);
            Caixa caixa5 = new Caixa("Fantasia", "255 0 255", 5);
            caixa5.Id = GeradorDeIds.GerarIdCaixa();
            repositorioCaixa.Inserir(caixa5);
            Caixa caixa6 = new Caixa("Mist�rio", "0 255 255", 7);
            caixa6.Id = GeradorDeIds.GerarIdCaixa();
            repositorioCaixa.Inserir(caixa6);
            Caixa caixa7 = new Caixa("Hist�ria", "128 128 128", 3);
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

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControlesEmprestimo(repositorioEmprestimo.emprestimos[e.RowIndex]);
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

        private void buttonLimparEmprestimo_Click(object sender, EventArgs e)
        {
            LimparCamposEmprestimo();
        }

        private void textBoxIdEmprestimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirSomenteNumeros(sender, e);
        }

        private void dataGridView4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                if (e.Value.ToString() == "Atrasado")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else
                {
                    e.CellStyle.BackColor = Color.White;
                }
            }
        }
        private void buttonVisualizarEmprestimos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIdAmigo.Text))
            {
                MessageBox.Show("Por favor, insira um ID v�lido.");
                return;
            }
            else
            {
                var amigo = repositorioAmigo.SelecionarPorId(textBoxIdAmigo.Text);
                var emprestimosAtivos = repositorioEmprestimo.emprestimos.Where(e => e.Amigo == amigo).ToList();
                if (emprestimosAtivos.Count > 0)
                {
                    string emprestimos = string.Join(Environment.NewLine, emprestimosAtivos.Select(e => $"ID: {e.Id}, Revista: {e.Revista.Titulo}, Situa��o: {e.Situacao}"));
                    MessageBox.Show($"Empr�stimos ativos para {amigo.Nome}:{Environment.NewLine}{emprestimos}");
                }
                else
                {
                    MessageBox.Show($"Nenhum empr�stimo ativo encontrado para {amigo.Nome}.");
                }
            }
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControlesReserva(repositorioReserva.reservas[e.RowIndex]);
        }

        private void buttonVisualizarMultas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIdAmigo.Text))
            {
                MessageBox.Show("Por favor, insira um ID v�lido.");
                return;
            }
            else
            {
                var amigo = repositorioAmigo.SelecionarPorId(textBoxIdAmigo.Text);
                var multas = amigo.Multas.ToList();
                if (multas.Count > 0)
                {
                    string multasInfo = string.Join(Environment.NewLine, multas.Select(m => $"ID: {m.Id}, Valor: {m.Valor.ToString("C2")}"));
                    MessageBox.Show($"Multas para {amigo.Nome}:{Environment.NewLine}{multasInfo}");
                }
                else
                {
                    MessageBox.Show($"Nenhuma multa encontrada para {amigo.Nome}.");
                }
            }
        }
    }
}