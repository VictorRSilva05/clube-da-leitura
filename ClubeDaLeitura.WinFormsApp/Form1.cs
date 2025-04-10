namespace ClubeDaLeitura.WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposAmigos();
        }

        private void LimparCamposAmigos()
        {
            textBoxId.Clear();
            textBoxNome.Clear();
            textBoxNomeResponsavel.Clear();
            maskedTextBoxTelefone.Clear();
        }
    }
}
