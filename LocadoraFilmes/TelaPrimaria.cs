using ApiFilmes.Model;

namespace LocadoraFilmes

{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            Filme teste = await conexao.ObterInformacoesFilme();
            lbl_teste.Text = teste.Nome;
            img_Box.Image = teste.ExibirImagem();
        }

        private async void btn_imagem_Click(object sender, EventArgs e)
        {
            Conexao conexao2 = new Conexao();
            Filme teste2 = await conexao2.ObterInformacoesFilme();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            TelaSecundaria telaSecundaria = new TelaSecundaria();
            Menu menu = new Menu();
            
            this.Hide();

            telaSecundaria.Show();

            
        }
    }
}
