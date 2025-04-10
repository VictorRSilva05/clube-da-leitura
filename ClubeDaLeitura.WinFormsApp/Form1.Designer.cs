namespace ClubeDaLeitura.WinFormsApp
{
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
            tabPageRevistas = new TabPage();
            tabPageEmprestimos = new TabPage();
            tabControl1.SuspendLayout();
            tabPageAmigos.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabPageCaixas.Location = new Point(4, 24);
            tabPageCaixas.Name = "tabPageCaixas";
            tabPageCaixas.Padding = new Padding(3);
            tabPageCaixas.Size = new Size(1872, 812);
            tabPageCaixas.TabIndex = 1;
            tabPageCaixas.Text = "Caixas";
            tabPageCaixas.UseVisualStyleBackColor = true;
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
    }
}
