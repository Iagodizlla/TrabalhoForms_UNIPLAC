namespace Trabalho_Forms
{
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPessoa telaP = new TelaPessoa(); // Cria a nova tela
            telaP.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaExemplar telaE = new TelaExemplar(); // Cria a nova tela
            telaE.ShowDialog();
        }
    }
}