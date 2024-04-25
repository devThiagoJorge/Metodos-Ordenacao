using MetodosOrdenacao.Classes;

namespace MetodosOrdenacao
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void BtnCarregarArquivo_Click(object sender, EventArgs e)
        {
            Arquivo.LerVetor();
        }

        private void BtnFormSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGerarDados_Click(object sender, EventArgs e)
        {
            var formGerarDados = new FormGerarDados();
            formGerarDados.Show();
            Hide();
        }
    }
}