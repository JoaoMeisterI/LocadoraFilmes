using ApiFilmes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraFilmes
{
    public partial class TelaSecundaria : Form
    {
        public TelaSecundaria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btn_buscar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            Filme InfoFilme = await conexao.ObterInformacoesFilme();
            lbl_Poster.Visible = true;
            lbl_infoFilme.Visible = true;
            img_Filme.Image = InfoFilme.ExibirImagem();
            lbl_Nome.Text = InfoFilme.Nome;
            lbl_Elenco.Text = InfoFilme.Elenco;
            lbl_anoLancamento.Text = InfoFilme.Ano;

        }
    }
}
