namespace ClubeDaLeitura.WinFormsApp
{
    using System.IO;
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPageAmigos = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBoxIdAmigo = new TextBox();
            label3 = new Label();
            maskedTextBoxTelefone = new MaskedTextBox();
            label2 = new Label();
            textBoxResponsavelAmigo = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textBoxNomeAmigo = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            buttonDeletarAmigo = new Button();
            buttonAtualizarAmigo = new Button();
            buttonSalvarAmigo = new Button();
            buttonLimparAmigo = new Button();
            dataGridView1 = new DataGridView();
            tabPageCaixas = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            buttonDeletarEtiqueta = new Button();
            buttonAtualizarEtiqueta = new Button();
            buttonSalvarEtiqueta = new Button();
            buttonLimparEtiqueta = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            textBoxEtiqueta = new TextBox();
            comboBoxEmprestimoEtiqueta = new ComboBox();
            textBoxIdEtiqueta = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            labelValues = new Label();
            labelSmallScreen = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            textBoxBlue = new TextBox();
            textBoxGreen = new TextBox();
            textBoxRed = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            tabPageRevistas = new TabPage();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel13 = new TableLayoutPanel();
            label15 = new Label();
            textBoxIdRevista = new TextBox();
            label11 = new Label();
            label12 = new Label();
            textBoxNumeroEdicaoRevista = new TextBox();
            label13 = new Label();
            label14 = new Label();
            textBoxTituloRevista = new TextBox();
            label16 = new Label();
            dateTimePickerAnoPublicacaoRevista = new DateTimePicker();
            textBoxStatusRevista = new TextBox();
            comboBoxCaixaRevista = new ComboBox();
            tableLayoutPanel12 = new TableLayoutPanel();
            buttonDeletarRevista = new Button();
            buttonAtualizarRevista = new Button();
            buttonLimparRevista = new Button();
            buttonSalvarRevista = new Button();
            dataGridView3 = new DataGridView();
            tabPageEmprestimos = new TabPage();
            tableLayoutPanel14 = new TableLayoutPanel();
            tableLayoutPanel15 = new TableLayoutPanel();
            tableLayoutPanel17 = new TableLayoutPanel();
            buttonDevolverEmprestimo = new Button();
            buttonLimparEmprestimo = new Button();
            buttonEmprestarEmprestimo = new Button();
            tableLayoutPanel16 = new TableLayoutPanel();
            comboBoxRevistaEmprestimo = new ComboBox();
            label22 = new Label();
            comboBoxAmigoEmprestimo = new ComboBox();
            textBoxIdEmprestimo = new TextBox();
            label20 = new Label();
            label21 = new Label();
            label17 = new Label();
            textBoxStatusEmprestimo = new TextBox();
            dateTimePickerDevolucaoEmprestimo = new DateTimePicker();
            label18 = new Label();
            dateTimePickerEmprestimoEmprestimo = new DateTimePicker();
            label19 = new Label();
            dataGridView4 = new DataGridView();
            label23 = new Label();
            label24 = new Label();
            tabControl1.SuspendLayout();
            tabPageAmigos.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageCaixas.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPageRevistas.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPageEmprestimos.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageAmigos);
            tabControl1.Controls.Add(tabPageCaixas);
            tabControl1.Controls.Add(tabPageRevistas);
            tabControl1.Controls.Add(tabPageEmprestimos);
            tabControl1.Location = new Point(12, 112);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1880, 840);
            tabControl1.TabIndex = 0;
            // 
            // tabPageAmigos
            // 
            tabPageAmigos.Controls.Add(tableLayoutPanel1);
            tabPageAmigos.Location = new Point(4, 24);
            tabPageAmigos.Name = "tabPageAmigos";
            tabPageAmigos.Padding = new Padding(3);
            tabPageAmigos.Size = new Size(1872, 812);
            tabPageAmigos.TabIndex = 0;
            tabPageAmigos.Text = "Amigos";
            tabPageAmigos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Azure;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1866, 806);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(927, 800);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.19001F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.80999F));
            tableLayoutPanel3.Controls.Add(textBoxIdAmigo, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 3);
            tableLayoutPanel3.Controls.Add(maskedTextBoxTelefone, 1, 3);
            tableLayoutPanel3.Controls.Add(label2, 0, 2);
            tableLayoutPanel3.Controls.Add(textBoxResponsavelAmigo, 1, 2);
            tableLayoutPanel3.Controls.Add(label1, 0, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(textBoxNomeAmigo, 1, 1);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(921, 194);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // textBoxIdAmigo
            // 
            textBoxIdAmigo.Font = new Font("Segoe UI", 16F);
            textBoxIdAmigo.Location = new Point(235, 3);
            textBoxIdAmigo.Name = "textBoxIdAmigo";
            textBoxIdAmigo.Size = new Size(367, 36);
            textBoxIdAmigo.TabIndex = 7;
            textBoxIdAmigo.KeyPress += textBoxIdAmigo_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 144);
            label3.Name = "label3";
            label3.Size = new Size(96, 30);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Font = new Font("Segoe UI", 16F);
            maskedTextBoxTelefone.Location = new Point(235, 147);
            maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(367, 36);
            maskedTextBoxTelefone.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 96);
            label2.Name = "label2";
            label2.Size = new Size(220, 30);
            label2.TabIndex = 1;
            label2.Text = "Nome do responsável:";
            // 
            // textBoxResponsavelAmigo
            // 
            textBoxResponsavelAmigo.Font = new Font("Segoe UI", 16F);
            textBoxResponsavelAmigo.Location = new Point(235, 99);
            textBoxResponsavelAmigo.Name = "textBoxResponsavelAmigo";
            textBoxResponsavelAmigo.Size = new Size(367, 36);
            textBoxResponsavelAmigo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 48);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 30);
            label4.TabIndex = 6;
            label4.Text = "Id:";
            // 
            // textBoxNomeAmigo
            // 
            textBoxNomeAmigo.Font = new Font("Segoe UI", 16F);
            textBoxNomeAmigo.Location = new Point(235, 51);
            textBoxNomeAmigo.Name = "textBoxNomeAmigo";
            textBoxNomeAmigo.Size = new Size(367, 36);
            textBoxNomeAmigo.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(buttonDeletarAmigo, 3, 0);
            tableLayoutPanel4.Controls.Add(buttonAtualizarAmigo, 2, 0);
            tableLayoutPanel4.Controls.Add(buttonSalvarAmigo, 1, 0);
            tableLayoutPanel4.Controls.Add(buttonLimparAmigo, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 403);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(921, 100);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // buttonDeletarAmigo
            // 
            buttonDeletarAmigo.Location = new Point(693, 3);
            buttonDeletarAmigo.Name = "buttonDeletarAmigo";
            buttonDeletarAmigo.Size = new Size(224, 94);
            buttonDeletarAmigo.TabIndex = 3;
            buttonDeletarAmigo.Text = "Deletar";
            buttonDeletarAmigo.UseVisualStyleBackColor = true;
            buttonDeletarAmigo.Click += buttonDeletar_Click;
            // 
            // buttonAtualizarAmigo
            // 
            buttonAtualizarAmigo.Location = new Point(463, 3);
            buttonAtualizarAmigo.Name = "buttonAtualizarAmigo";
            buttonAtualizarAmigo.Size = new Size(224, 94);
            buttonAtualizarAmigo.TabIndex = 2;
            buttonAtualizarAmigo.Text = "Atualizar";
            buttonAtualizarAmigo.UseVisualStyleBackColor = true;
            buttonAtualizarAmigo.Click += buttonAtualizar_Click;
            // 
            // buttonSalvarAmigo
            // 
            buttonSalvarAmigo.Location = new Point(233, 3);
            buttonSalvarAmigo.Name = "buttonSalvarAmigo";
            buttonSalvarAmigo.Size = new Size(224, 94);
            buttonSalvarAmigo.TabIndex = 1;
            buttonSalvarAmigo.Text = "Salvar";
            buttonSalvarAmigo.UseVisualStyleBackColor = true;
            buttonSalvarAmigo.Click += buttonSalvar_Click;
            // 
            // buttonLimparAmigo
            // 
            buttonLimparAmigo.Location = new Point(3, 3);
            buttonLimparAmigo.Name = "buttonLimparAmigo";
            buttonLimparAmigo.Size = new Size(224, 94);
            buttonLimparAmigo.TabIndex = 0;
            buttonLimparAmigo.Text = "Limpar";
            buttonLimparAmigo.UseVisualStyleBackColor = true;
            buttonLimparAmigo.Click += buttonLimpar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(936, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(927, 800);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tabPageCaixas
            // 
            tabPageCaixas.BackColor = Color.Azure;
            tabPageCaixas.Controls.Add(tableLayoutPanel5);
            tabPageCaixas.Location = new Point(4, 24);
            tabPageCaixas.Name = "tabPageCaixas";
            tabPageCaixas.Padding = new Padding(3);
            tabPageCaixas.Size = new Size(1872, 812);
            tabPageCaixas.TabIndex = 1;
            tabPageCaixas.Text = "Caixas";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Controls.Add(dataGridView2, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1866, 806);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(927, 800);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 4;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.Controls.Add(buttonDeletarEtiqueta, 3, 0);
            tableLayoutPanel8.Controls.Add(buttonAtualizarEtiqueta, 2, 0);
            tableLayoutPanel8.Controls.Add(buttonSalvarEtiqueta, 1, 0);
            tableLayoutPanel8.Controls.Add(buttonLimparEtiqueta, 0, 0);
            tableLayoutPanel8.Location = new Point(3, 403);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(921, 100);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // buttonDeletarEtiqueta
            // 
            buttonDeletarEtiqueta.Location = new Point(693, 3);
            buttonDeletarEtiqueta.Name = "buttonDeletarEtiqueta";
            buttonDeletarEtiqueta.Size = new Size(224, 94);
            buttonDeletarEtiqueta.TabIndex = 3;
            buttonDeletarEtiqueta.Text = "Deletar";
            buttonDeletarEtiqueta.UseVisualStyleBackColor = true;
            buttonDeletarEtiqueta.Click += buttonDeletarCaixa_Click;
            // 
            // buttonAtualizarEtiqueta
            // 
            buttonAtualizarEtiqueta.Location = new Point(463, 3);
            buttonAtualizarEtiqueta.Name = "buttonAtualizarEtiqueta";
            buttonAtualizarEtiqueta.Size = new Size(224, 94);
            buttonAtualizarEtiqueta.TabIndex = 2;
            buttonAtualizarEtiqueta.Text = "Atualizar";
            buttonAtualizarEtiqueta.UseVisualStyleBackColor = true;
            buttonAtualizarEtiqueta.Click += buttonAtualizarEtiqueta_Click;
            // 
            // buttonSalvarEtiqueta
            // 
            buttonSalvarEtiqueta.Location = new Point(233, 3);
            buttonSalvarEtiqueta.Name = "buttonSalvarEtiqueta";
            buttonSalvarEtiqueta.Size = new Size(224, 94);
            buttonSalvarEtiqueta.TabIndex = 1;
            buttonSalvarEtiqueta.Text = "Salvar";
            buttonSalvarEtiqueta.UseVisualStyleBackColor = true;
            buttonSalvarEtiqueta.Click += buttonSalvarCaixa_Click;
            // 
            // buttonLimparEtiqueta
            // 
            buttonLimparEtiqueta.Location = new Point(3, 3);
            buttonLimparEtiqueta.Name = "buttonLimparEtiqueta";
            buttonLimparEtiqueta.Size = new Size(224, 94);
            buttonLimparEtiqueta.TabIndex = 0;
            buttonLimparEtiqueta.Text = "Limpar";
            buttonLimparEtiqueta.UseVisualStyleBackColor = true;
            buttonLimparEtiqueta.Click += buttonLimparCaixa_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.19001F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.80999F));
            tableLayoutPanel7.Controls.Add(textBoxEtiqueta, 1, 1);
            tableLayoutPanel7.Controls.Add(comboBoxEmprestimoEtiqueta, 1, 2);
            tableLayoutPanel7.Controls.Add(textBoxIdEtiqueta, 1, 0);
            tableLayoutPanel7.Controls.Add(label6, 0, 2);
            tableLayoutPanel7.Controls.Add(label7, 0, 1);
            tableLayoutPanel7.Controls.Add(label8, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel9, 1, 3);
            tableLayoutPanel7.Controls.Add(groupBox1, 0, 3);
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 4;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6332664F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6332664F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6332664F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50.1002F));
            tableLayoutPanel7.Size = new Size(921, 394);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // textBoxEtiqueta
            // 
            textBoxEtiqueta.Font = new Font("Segoe UI", 16F);
            textBoxEtiqueta.Location = new Point(235, 68);
            textBoxEtiqueta.Name = "textBoxEtiqueta";
            textBoxEtiqueta.Size = new Size(367, 36);
            textBoxEtiqueta.TabIndex = 12;
            // 
            // comboBoxEmprestimoEtiqueta
            // 
            comboBoxEmprestimoEtiqueta.Font = new Font("Segoe UI", 16F);
            comboBoxEmprestimoEtiqueta.FormattingEnabled = true;
            comboBoxEmprestimoEtiqueta.Location = new Point(235, 133);
            comboBoxEmprestimoEtiqueta.Name = "comboBoxEmprestimoEtiqueta";
            comboBoxEmprestimoEtiqueta.Size = new Size(367, 38);
            comboBoxEmprestimoEtiqueta.TabIndex = 9;
            // 
            // textBoxIdEtiqueta
            // 
            textBoxIdEtiqueta.Font = new Font("Segoe UI", 16F);
            textBoxIdEtiqueta.Location = new Point(235, 3);
            textBoxIdEtiqueta.Name = "textBoxIdEtiqueta";
            textBoxIdEtiqueta.Size = new Size(367, 36);
            textBoxIdEtiqueta.TabIndex = 7;
            textBoxIdEtiqueta.KeyPress += textBoxIdEtiqueta_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 130);
            label6.Name = "label6";
            label6.Size = new Size(203, 30);
            label6.TabIndex = 1;
            label6.Text = "Dias de empréstimo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 65);
            label7.Name = "label7";
            label7.Size = new Size(94, 30);
            label7.TabIndex = 0;
            label7.Text = "Etiqueta:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(37, 30);
            label8.TabIndex = 6;
            label8.Text = "Id:";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel9.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel9.Location = new Point(235, 198);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(683, 193);
            tableLayoutPanel9.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 187);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelValues);
            groupBox2.Controls.Add(labelSmallScreen);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(344, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 187);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Posição atual";
            // 
            // labelValues
            // 
            labelValues.Location = new Point(45, 57);
            labelValues.Name = "labelValues";
            labelValues.Size = new Size(100, 23);
            labelValues.TabIndex = 7;
            // 
            // labelSmallScreen
            // 
            labelSmallScreen.Location = new Point(45, 97);
            labelSmallScreen.Name = "labelSmallScreen";
            labelSmallScreen.Size = new Size(100, 23);
            labelSmallScreen.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(textBoxBlue);
            groupBox1.Controls.Add(textBoxGreen);
            groupBox1.Controls.Add(textBoxRed);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 193);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cor selecionada:";
            // 
            // panel1
            // 
            panel1.Location = new Point(31, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(139, 52);
            panel1.TabIndex = 6;
            // 
            // textBoxBlue
            // 
            textBoxBlue.Location = new Point(70, 97);
            textBoxBlue.Name = "textBoxBlue";
            textBoxBlue.ReadOnly = true;
            textBoxBlue.Size = new Size(100, 23);
            textBoxBlue.TabIndex = 5;
            // 
            // textBoxGreen
            // 
            textBoxGreen.Location = new Point(70, 68);
            textBoxGreen.Name = "textBoxGreen";
            textBoxGreen.ReadOnly = true;
            textBoxGreen.Size = new Size(100, 23);
            textBoxGreen.TabIndex = 4;
            // 
            // textBoxRed
            // 
            textBoxRed.Location = new Point(70, 39);
            textBoxRed.Name = "textBoxRed";
            textBoxRed.ReadOnly = true;
            textBoxRed.Size = new Size(100, 23);
            textBoxRed.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 97);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 2;
            label10.Text = "Blue";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 68);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 1;
            label9.Text = "Green";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 39);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 0;
            label5.Text = "Red";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(936, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(927, 800);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // tabPageRevistas
            // 
            tabPageRevistas.BackColor = Color.Azure;
            tabPageRevistas.Controls.Add(tableLayoutPanel10);
            tabPageRevistas.Location = new Point(4, 24);
            tabPageRevistas.Name = "tabPageRevistas";
            tabPageRevistas.Padding = new Padding(3);
            tabPageRevistas.Size = new Size(1872, 812);
            tabPageRevistas.TabIndex = 2;
            tabPageRevistas.Text = "Revistas";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(tableLayoutPanel11, 0, 0);
            tableLayoutPanel10.Controls.Add(dataGridView3, 1, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(1866, 806);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(tableLayoutPanel13, 0, 0);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 0, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(927, 800);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.19001F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.80999F));
            tableLayoutPanel13.Controls.Add(label15, 0, 4);
            tableLayoutPanel13.Controls.Add(textBoxIdRevista, 1, 0);
            tableLayoutPanel13.Controls.Add(label11, 0, 3);
            tableLayoutPanel13.Controls.Add(label12, 0, 2);
            tableLayoutPanel13.Controls.Add(textBoxNumeroEdicaoRevista, 1, 2);
            tableLayoutPanel13.Controls.Add(label13, 0, 1);
            tableLayoutPanel13.Controls.Add(label14, 0, 0);
            tableLayoutPanel13.Controls.Add(textBoxTituloRevista, 1, 1);
            tableLayoutPanel13.Controls.Add(label16, 0, 5);
            tableLayoutPanel13.Controls.Add(dateTimePickerAnoPublicacaoRevista, 1, 3);
            tableLayoutPanel13.Controls.Add(textBoxStatusRevista, 1, 4);
            tableLayoutPanel13.Controls.Add(comboBoxCaixaRevista, 1, 5);
            tableLayoutPanel13.Location = new Point(3, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 6;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel13.Size = new Size(921, 259);
            tableLayoutPanel13.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(3, 172);
            label15.Name = "label15";
            label15.Size = new Size(74, 30);
            label15.TabIndex = 8;
            label15.Text = "Status:";
            // 
            // textBoxIdRevista
            // 
            textBoxIdRevista.Font = new Font("Segoe UI", 16F);
            textBoxIdRevista.Location = new Point(235, 3);
            textBoxIdRevista.Name = "textBoxIdRevista";
            textBoxIdRevista.Size = new Size(367, 36);
            textBoxIdRevista.TabIndex = 7;
            textBoxIdRevista.KeyPress += textBoxIdRevista_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 129);
            label11.Name = "label11";
            label11.Size = new Size(191, 30);
            label11.TabIndex = 2;
            label11.Text = "Ano de publicação:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 86);
            label12.Name = "label12";
            label12.Size = new Size(190, 30);
            label12.TabIndex = 1;
            label12.Text = "Número da edição:";
            // 
            // textBoxNumeroEdicaoRevista
            // 
            textBoxNumeroEdicaoRevista.Font = new Font("Segoe UI", 16F);
            textBoxNumeroEdicaoRevista.Location = new Point(235, 89);
            textBoxNumeroEdicaoRevista.Name = "textBoxNumeroEdicaoRevista";
            textBoxNumeroEdicaoRevista.Size = new Size(367, 36);
            textBoxNumeroEdicaoRevista.TabIndex = 4;
            textBoxNumeroEdicaoRevista.KeyPress += textBoxNumeroEdicaoRevista_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 43);
            label13.Name = "label13";
            label13.Size = new Size(70, 30);
            label13.TabIndex = 0;
            label13.Text = "Título:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16F);
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(37, 30);
            label14.TabIndex = 6;
            label14.Text = "Id:";
            // 
            // textBoxTituloRevista
            // 
            textBoxTituloRevista.Font = new Font("Segoe UI", 16F);
            textBoxTituloRevista.Location = new Point(235, 46);
            textBoxTituloRevista.Name = "textBoxTituloRevista";
            textBoxTituloRevista.Size = new Size(367, 36);
            textBoxTituloRevista.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(3, 215);
            label16.Name = "label16";
            label16.Size = new Size(68, 30);
            label16.TabIndex = 9;
            label16.Text = "Caixa:";
            // 
            // dateTimePickerAnoPublicacaoRevista
            // 
            dateTimePickerAnoPublicacaoRevista.CustomFormat = "";
            dateTimePickerAnoPublicacaoRevista.Font = new Font("Segoe UI", 16F);
            dateTimePickerAnoPublicacaoRevista.Location = new Point(235, 132);
            dateTimePickerAnoPublicacaoRevista.Name = "dateTimePickerAnoPublicacaoRevista";
            dateTimePickerAnoPublicacaoRevista.Size = new Size(367, 36);
            dateTimePickerAnoPublicacaoRevista.TabIndex = 10;
            // 
            // textBoxStatusRevista
            // 
            textBoxStatusRevista.Font = new Font("Segoe UI", 16F);
            textBoxStatusRevista.Location = new Point(235, 175);
            textBoxStatusRevista.Name = "textBoxStatusRevista";
            textBoxStatusRevista.ReadOnly = true;
            textBoxStatusRevista.Size = new Size(367, 36);
            textBoxStatusRevista.TabIndex = 11;
            // 
            // comboBoxCaixaRevista
            // 
            comboBoxCaixaRevista.Font = new Font("Segoe UI", 16F);
            comboBoxCaixaRevista.FormattingEnabled = true;
            comboBoxCaixaRevista.Location = new Point(235, 218);
            comboBoxCaixaRevista.Name = "comboBoxCaixaRevista";
            comboBoxCaixaRevista.Size = new Size(367, 38);
            comboBoxCaixaRevista.TabIndex = 12;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 4;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel12.Controls.Add(buttonDeletarRevista, 3, 0);
            tableLayoutPanel12.Controls.Add(buttonAtualizarRevista, 2, 0);
            tableLayoutPanel12.Controls.Add(buttonLimparRevista, 0, 0);
            tableLayoutPanel12.Controls.Add(buttonSalvarRevista, 1, 0);
            tableLayoutPanel12.Location = new Point(3, 403);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(921, 100);
            tableLayoutPanel12.TabIndex = 3;
            // 
            // buttonDeletarRevista
            // 
            buttonDeletarRevista.Location = new Point(693, 3);
            buttonDeletarRevista.Name = "buttonDeletarRevista";
            buttonDeletarRevista.Size = new Size(224, 94);
            buttonDeletarRevista.TabIndex = 3;
            buttonDeletarRevista.Text = "Deletar";
            buttonDeletarRevista.UseVisualStyleBackColor = true;
            buttonDeletarRevista.Click += buttonDeletarRevista_Click;
            // 
            // buttonAtualizarRevista
            // 
            buttonAtualizarRevista.Location = new Point(463, 3);
            buttonAtualizarRevista.Name = "buttonAtualizarRevista";
            buttonAtualizarRevista.Size = new Size(224, 94);
            buttonAtualizarRevista.TabIndex = 2;
            buttonAtualizarRevista.Text = "Atualizar";
            buttonAtualizarRevista.UseVisualStyleBackColor = true;
            buttonAtualizarRevista.Click += buttonAtualizarRevista_Click;
            // 
            // buttonLimparRevista
            // 
            buttonLimparRevista.Location = new Point(3, 3);
            buttonLimparRevista.Name = "buttonLimparRevista";
            buttonLimparRevista.Size = new Size(224, 94);
            buttonLimparRevista.TabIndex = 0;
            buttonLimparRevista.Text = "Limpar";
            buttonLimparRevista.UseVisualStyleBackColor = true;
            buttonLimparRevista.Click += buttonLimparRevista_Click;
            // 
            // buttonSalvarRevista
            // 
            buttonSalvarRevista.Location = new Point(233, 3);
            buttonSalvarRevista.Name = "buttonSalvarRevista";
            buttonSalvarRevista.Size = new Size(224, 94);
            buttonSalvarRevista.TabIndex = 1;
            buttonSalvarRevista.Text = "Salvar";
            buttonSalvarRevista.UseVisualStyleBackColor = true;
            buttonSalvarRevista.Click += buttonSalvarRevista_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(936, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(927, 800);
            dataGridView3.TabIndex = 1;
            dataGridView3.CellClick += dataGridView3_CellClick;
            // 
            // tabPageEmprestimos
            // 
            tabPageEmprestimos.Controls.Add(tableLayoutPanel14);
            tabPageEmprestimos.Location = new Point(4, 24);
            tabPageEmprestimos.Name = "tabPageEmprestimos";
            tabPageEmprestimos.Padding = new Padding(3);
            tabPageEmprestimos.Size = new Size(1872, 812);
            tabPageEmprestimos.TabIndex = 3;
            tabPageEmprestimos.Text = "Emprestimos";
            tabPageEmprestimos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.BackColor = Color.Azure;
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Controls.Add(tableLayoutPanel15, 0, 0);
            tableLayoutPanel14.Controls.Add(dataGridView4, 1, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(3, 3);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Size = new Size(1866, 806);
            tableLayoutPanel14.TabIndex = 0;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 1;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Controls.Add(tableLayoutPanel17, 0, 1);
            tableLayoutPanel15.Controls.Add(tableLayoutPanel16, 0, 0);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(3, 3);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 2;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Size = new Size(927, 800);
            tableLayoutPanel15.TabIndex = 0;
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.ColumnCount = 3;
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel17.Controls.Add(buttonDevolverEmprestimo, 2, 0);
            tableLayoutPanel17.Controls.Add(buttonLimparEmprestimo, 0, 0);
            tableLayoutPanel17.Controls.Add(buttonEmprestarEmprestimo, 1, 0);
            tableLayoutPanel17.Location = new Point(3, 403);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 1;
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel17.Size = new Size(921, 100);
            tableLayoutPanel17.TabIndex = 6;
            // 
            // buttonDevolverEmprestimo
            // 
            buttonDevolverEmprestimo.Location = new Point(617, 3);
            buttonDevolverEmprestimo.Name = "buttonDevolverEmprestimo";
            buttonDevolverEmprestimo.Size = new Size(224, 94);
            buttonDevolverEmprestimo.TabIndex = 2;
            buttonDevolverEmprestimo.Text = "Devolver";
            buttonDevolverEmprestimo.UseVisualStyleBackColor = true;
            buttonDevolverEmprestimo.Click += buttonDevolverEmprestimo_Click;
            // 
            // buttonLimparEmprestimo
            // 
            buttonLimparEmprestimo.Location = new Point(3, 3);
            buttonLimparEmprestimo.Name = "buttonLimparEmprestimo";
            buttonLimparEmprestimo.Size = new Size(224, 94);
            buttonLimparEmprestimo.TabIndex = 0;
            buttonLimparEmprestimo.Text = "Limpar";
            buttonLimparEmprestimo.UseVisualStyleBackColor = true;
            buttonLimparEmprestimo.Click += buttonLimparEmprestimo_Click;
            // 
            // buttonEmprestarEmprestimo
            // 
            buttonEmprestarEmprestimo.Location = new Point(310, 3);
            buttonEmprestarEmprestimo.Name = "buttonEmprestarEmprestimo";
            buttonEmprestarEmprestimo.Size = new Size(224, 94);
            buttonEmprestarEmprestimo.TabIndex = 1;
            buttonEmprestarEmprestimo.Text = "Emprestar";
            buttonEmprestarEmprestimo.UseVisualStyleBackColor = true;
            buttonEmprestarEmprestimo.Click += buttonEmprestarEmprestimo_Click;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 2;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.19001F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.80999F));
            tableLayoutPanel16.Controls.Add(comboBoxRevistaEmprestimo, 1, 2);
            tableLayoutPanel16.Controls.Add(label22, 0, 2);
            tableLayoutPanel16.Controls.Add(comboBoxAmigoEmprestimo, 1, 1);
            tableLayoutPanel16.Controls.Add(textBoxIdEmprestimo, 1, 0);
            tableLayoutPanel16.Controls.Add(label20, 0, 1);
            tableLayoutPanel16.Controls.Add(label21, 0, 0);
            tableLayoutPanel16.Controls.Add(label17, 0, 5);
            tableLayoutPanel16.Controls.Add(textBoxStatusEmprestimo, 1, 5);
            tableLayoutPanel16.Controls.Add(dateTimePickerDevolucaoEmprestimo, 1, 4);
            tableLayoutPanel16.Controls.Add(label18, 0, 4);
            tableLayoutPanel16.Controls.Add(dateTimePickerEmprestimoEmprestimo, 1, 3);
            tableLayoutPanel16.Controls.Add(label19, 0, 3);
            tableLayoutPanel16.Location = new Point(3, 3);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 6;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel16.Size = new Size(921, 259);
            tableLayoutPanel16.TabIndex = 5;
            // 
            // comboBoxRevistaEmprestimo
            // 
            comboBoxRevistaEmprestimo.Font = new Font("Segoe UI", 16F);
            comboBoxRevistaEmprestimo.FormattingEnabled = true;
            comboBoxRevistaEmprestimo.Location = new Point(235, 89);
            comboBoxRevistaEmprestimo.Name = "comboBoxRevistaEmprestimo";
            comboBoxRevistaEmprestimo.Size = new Size(367, 38);
            comboBoxRevistaEmprestimo.TabIndex = 16;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(3, 86);
            label22.Name = "label22";
            label22.Size = new Size(83, 30);
            label22.TabIndex = 15;
            label22.Text = "Revista:";
            // 
            // comboBoxAmigoEmprestimo
            // 
            comboBoxAmigoEmprestimo.Font = new Font("Segoe UI", 16F);
            comboBoxAmigoEmprestimo.FormattingEnabled = true;
            comboBoxAmigoEmprestimo.Location = new Point(235, 46);
            comboBoxAmigoEmprestimo.Name = "comboBoxAmigoEmprestimo";
            comboBoxAmigoEmprestimo.Size = new Size(367, 38);
            comboBoxAmigoEmprestimo.TabIndex = 13;
            // 
            // textBoxIdEmprestimo
            // 
            textBoxIdEmprestimo.Font = new Font("Segoe UI", 16F);
            textBoxIdEmprestimo.Location = new Point(235, 3);
            textBoxIdEmprestimo.Name = "textBoxIdEmprestimo";
            textBoxIdEmprestimo.Size = new Size(367, 36);
            textBoxIdEmprestimo.TabIndex = 7;
            textBoxIdEmprestimo.KeyPress += textBoxIdEmprestimo_KeyPress;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(3, 43);
            label20.Name = "label20";
            label20.Size = new Size(74, 30);
            label20.TabIndex = 0;
            label20.Text = "Amigo";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 16F);
            label21.Location = new Point(3, 0);
            label21.Name = "label21";
            label21.Size = new Size(37, 30);
            label21.TabIndex = 6;
            label21.Text = "Id:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(3, 215);
            label17.Name = "label17";
            label17.Size = new Size(74, 30);
            label17.TabIndex = 8;
            label17.Text = "Status:";
            // 
            // textBoxStatusEmprestimo
            // 
            textBoxStatusEmprestimo.Font = new Font("Segoe UI", 16F);
            textBoxStatusEmprestimo.Location = new Point(235, 218);
            textBoxStatusEmprestimo.Name = "textBoxStatusEmprestimo";
            textBoxStatusEmprestimo.ReadOnly = true;
            textBoxStatusEmprestimo.Size = new Size(367, 36);
            textBoxStatusEmprestimo.TabIndex = 11;
            // 
            // dateTimePickerDevolucaoEmprestimo
            // 
            dateTimePickerDevolucaoEmprestimo.CustomFormat = "";
            dateTimePickerDevolucaoEmprestimo.Font = new Font("Segoe UI", 16F);
            dateTimePickerDevolucaoEmprestimo.Location = new Point(235, 175);
            dateTimePickerDevolucaoEmprestimo.Name = "dateTimePickerDevolucaoEmprestimo";
            dateTimePickerDevolucaoEmprestimo.Size = new Size(367, 36);
            dateTimePickerDevolucaoEmprestimo.TabIndex = 10;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(3, 172);
            label18.Name = "label18";
            label18.Size = new Size(192, 30);
            label18.TabIndex = 2;
            label18.Text = "Data de devolução:";
            // 
            // dateTimePickerEmprestimoEmprestimo
            // 
            dateTimePickerEmprestimoEmprestimo.CustomFormat = "";
            dateTimePickerEmprestimoEmprestimo.Font = new Font("Segoe UI", 16F);
            dateTimePickerEmprestimoEmprestimo.Location = new Point(235, 132);
            dateTimePickerEmprestimoEmprestimo.Name = "dateTimePickerEmprestimoEmprestimo";
            dateTimePickerEmprestimoEmprestimo.Size = new Size(367, 36);
            dateTimePickerEmprestimoEmprestimo.TabIndex = 14;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(3, 129);
            label19.Name = "label19";
            label19.Size = new Size(208, 30);
            label19.TabIndex = 1;
            label19.Text = "Data do empréstimo:";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(936, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(927, 800);
            dataGridView4.TabIndex = 1;
            dataGridView4.CellClick += dataGridView4_CellClick;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(22, 40);
            label23.Name = "label23";
            label23.Size = new Size(305, 50);
            label23.TabIndex = 1;
            label23.Text = "Clube da Leitura";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Segoe UI", 12F);
            label24.Location = new Point(12, 995);
            label24.Name = "label24";
            label24.Size = new Size(339, 21);
            label24.TabIndex = 2;
            label24.Text = "Victor R. Silva. Academia do programador 2025";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maxresdefault;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabPageAmigos.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageCaixas.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPageRevistas.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPageEmprestimos.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageAmigos;
        private TabPage tabPageCaixas;
        private TabPage tabPageRevistas;
        private TabPage tabPageEmprestimos;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxResponsavelAmigo;
        private TextBox textBoxNomeAmigo;
        private MaskedTextBox maskedTextBoxTelefone;
        private TableLayoutPanel tableLayoutPanel4;
        private Button buttonLimparAmigo;
        private Button buttonDeletarAmigo;
        private Button buttonAtualizarAmigo;
        private Button buttonSalvarAmigo;
        private TextBox textBoxIdAmigo;
        private Label label4;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox textBoxIdEtiqueta;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxEmprestimoEtiqueta;
        private TableLayoutPanel tableLayoutPanel8;
        private Button buttonDeletarEtiqueta;
        private Button buttonAtualizarEtiqueta;
        private Button buttonSalvarEtiqueta;
        private Button buttonLimparEtiqueta;
        private DataGridView dataGridView2;
        private TableLayoutPanel tableLayoutPanel9;
        private GroupBox groupBox1;
        private TextBox textBoxBlue;
        private TextBox textBoxGreen;
        private TextBox textBoxRed;
        private Label label10;
        private Label label9;
        private Label label5;
        private PictureBox pictureBox1;
        private Label labelSmallScreen;
        private GroupBox groupBox2;
        private Label labelValues;
        private Panel panel1;
        private TextBox textBoxEtiqueta;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private Button buttonDeletarRevista;
        private Button buttonAtualizarRevista;
        private Button buttonLimparRevista;
        private Button buttonSalvarRevista;
        private DataGridView dataGridView3;
        private TableLayoutPanel tableLayoutPanel13;
        private TextBox textBoxIdRevista;
        private Label label11;
        private Label label12;
        private TextBox textBoxNumeroEdicaoRevista;
        private Label label13;
        private Label label14;
        private TextBox textBoxTituloRevista;
        private Label label15;
        private Label label16;
        private DateTimePicker dateTimePickerAnoPublicacaoRevista;
        private TextBox textBoxStatusRevista;
        private ComboBox comboBoxCaixaRevista;
        private TableLayoutPanel tableLayoutPanel14;
        private TableLayoutPanel tableLayoutPanel15;
        private DataGridView dataGridView4;
        private TableLayoutPanel tableLayoutPanel16;
        private Label label17;
        private TextBox textBoxIdEmprestimo;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private DateTimePicker dateTimePickerDevolucaoEmprestimo;
        private TextBox textBoxStatusEmprestimo;
        private ComboBox comboBoxRevistaEmprestimo;
        private Label label22;
        private ComboBox comboBoxAmigoEmprestimo;
        private DateTimePicker dateTimePickerEmprestimoEmprestimo;
        private TableLayoutPanel tableLayoutPanel17;
        private Button buttonDevolverEmprestimo;
        private Button buttonLimparEmprestimo;
        private Button buttonEmprestarEmprestimo;
        private Label label23;
        private Label label24;
    }
}
