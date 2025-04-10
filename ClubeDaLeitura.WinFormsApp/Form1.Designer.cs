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
            textBoxId = new TextBox();
            label3 = new Label();
            maskedTextBoxTelefone = new MaskedTextBox();
            label2 = new Label();
            textBoxNomeResponsavel = new TextBox();
            textBoxNome = new TextBox();
            label1 = new Label();
            label4 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            buttonDeletar = new Button();
            buttonAtualizar = new Button();
            buttonSalvar = new Button();
            buttonLimpar = new Button();
            dataGridView1 = new DataGridView();
            tabPageCaixas = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
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
            tabPageEmprestimos = new TabPage();
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
            tableLayoutPanel3.Controls.Add(textBoxId, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 3);
            tableLayoutPanel3.Controls.Add(maskedTextBoxTelefone, 1, 3);
            tableLayoutPanel3.Controls.Add(label2, 0, 2);
            tableLayoutPanel3.Controls.Add(textBoxNomeResponsavel, 1, 2);
            tableLayoutPanel3.Controls.Add(textBoxNome, 1, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
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
            // textBoxId
            // 
            textBoxId.Font = new Font("Segoe UI", 16F);
            textBoxId.Location = new Point(235, 3);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(367, 36);
            textBoxId.TabIndex = 7;
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
            // textBoxNomeResponsavel
            // 
            textBoxNomeResponsavel.Font = new Font("Segoe UI", 16F);
            textBoxNomeResponsavel.Location = new Point(235, 99);
            textBoxNomeResponsavel.Name = "textBoxNomeResponsavel";
            textBoxNomeResponsavel.Size = new Size(367, 36);
            textBoxNomeResponsavel.TabIndex = 4;
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Segoe UI", 16F);
            textBoxNome.Location = new Point(235, 51);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(367, 36);
            textBoxNome.TabIndex = 3;
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(buttonDeletar, 3, 0);
            tableLayoutPanel4.Controls.Add(buttonAtualizar, 2, 0);
            tableLayoutPanel4.Controls.Add(buttonSalvar, 1, 0);
            tableLayoutPanel4.Controls.Add(buttonLimpar, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 403);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(921, 100);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // buttonDeletar
            // 
            buttonDeletar.Location = new Point(693, 3);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(224, 94);
            buttonDeletar.TabIndex = 3;
            buttonDeletar.Text = "Deletar";
            buttonDeletar.UseVisualStyleBackColor = true;
            buttonDeletar.Click += buttonDeletar_Click;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(463, 3);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(224, 94);
            buttonAtualizar.TabIndex = 2;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(233, 3);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(224, 94);
            buttonSalvar.TabIndex = 1;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(3, 3);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(224, 94);
            buttonLimpar.TabIndex = 0;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
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
            tabPageCaixas.Controls.Add(tableLayoutPanel5);
            tabPageCaixas.Location = new Point(4, 24);
            tabPageCaixas.Name = "tabPageCaixas";
            tabPageCaixas.Padding = new Padding(3);
            tabPageCaixas.Size = new Size(1872, 812);
            tabPageCaixas.TabIndex = 1;
            tabPageCaixas.Text = "Caixas";
            tabPageCaixas.UseVisualStyleBackColor = true;
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
            tableLayoutPanel8.Controls.Add(button1, 3, 0);
            tableLayoutPanel8.Controls.Add(button2, 2, 0);
            tableLayoutPanel8.Controls.Add(button3, 1, 0);
            tableLayoutPanel8.Controls.Add(button4, 0, 0);
            tableLayoutPanel8.Location = new Point(3, 403);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(921, 100);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(693, 3);
            button1.Name = "button1";
            button1.Size = new Size(224, 94);
            button1.TabIndex = 3;
            button1.Text = "Deletar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(463, 3);
            button2.Name = "button2";
            button2.Size = new Size(224, 94);
            button2.TabIndex = 2;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(233, 3);
            button3.Name = "button3";
            button3.Size = new Size(224, 94);
            button3.TabIndex = 1;
            button3.Text = "Salvar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(224, 94);
            button4.TabIndex = 0;
            button4.Text = "Limpar";
            button4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.19001F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.80999F));
            tableLayoutPanel7.Controls.Add(comboBox2, 1, 2);
            tableLayoutPanel7.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel7.Controls.Add(label6, 0, 2);
            tableLayoutPanel7.Controls.Add(label7, 0, 1);
            tableLayoutPanel7.Controls.Add(label8, 0, 0);
            tableLayoutPanel7.Controls.Add(comboBox1, 1, 1);
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
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 16F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(235, 133);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(367, 38);
            comboBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(235, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(367, 36);
            textBox1.TabIndex = 7;
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
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 16F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(235, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(367, 38);
            comboBox1.TabIndex = 8;
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
            groupBox2.Text = "groupBox2";
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
            // 
            // tabPageRevistas
            // 
            tabPageRevistas.Location = new Point(4, 24);
            tabPageRevistas.Name = "tabPageRevistas";
            tabPageRevistas.Padding = new Padding(3);
            tabPageRevistas.Size = new Size(1872, 812);
            tabPageRevistas.TabIndex = 2;
            tabPageRevistas.Text = "Revistas";
            tabPageRevistas.UseVisualStyleBackColor = true;
            // 
            // tabPageEmprestimos
            // 
            tabPageEmprestimos.Location = new Point(4, 24);
            tabPageEmprestimos.Name = "tabPageEmprestimos";
            tabPageEmprestimos.Padding = new Padding(3);
            tabPageEmprestimos.Size = new Size(1872, 812);
            tabPageEmprestimos.TabIndex = 3;
            tabPageEmprestimos.Text = "Emprestimos";
            tabPageEmprestimos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
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
            ResumeLayout(false);
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
        private TextBox textBoxNomeResponsavel;
        private TextBox textBoxNome;
        private MaskedTextBox maskedTextBoxTelefone;
        private TableLayoutPanel tableLayoutPanel4;
        private Button buttonLimpar;
        private Button buttonDeletar;
        private Button buttonAtualizar;
        private Button buttonSalvar;
        private TextBox textBoxId;
        private Label label4;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TableLayoutPanel tableLayoutPanel8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
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
    }
}
