using System;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace AgendaSQL
{
    //=============================================================
    public partial class FrmMenu : Form
    {
        //=============================================================
        public FrmMenu()
        {
            InitializeComponent();
            //versão
            label_version.Text = cl_static.versao;

        }

        //=============================================================
        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
        //=============================================================
        private void btn_sair_Click(object sender, EventArgs e)
        {
            //sair da aplicação
            if (MessageBox.Show("Deseja realmente sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //sair mesmo
            Application.Exit();

        }
        //=============================================================
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            //abrir o quadro para adicionar novos registros
            FrmAdicionarEditar adc = new FrmAdicionarEditar();
            adc.ShowDialog();
            // no botão adicionar eu criei aqui um objeto para que ao clicar no botao adicionar no frmMenu ele abra o FrmAdicionarEditar

        }
        //=============================================================

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            //vai abrir uma nova tela para apresentação de todos os contatos
            FrmResultado2 resultados = new FrmResultado2();
            resultados.ShowDialog();

        }
        //=============================================================
        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            //abrir a janela de pesquisa
            FrmPesquisar pesquisar = new FrmPesquisar();
            pesquisar.ShowDialog();

            //executa a pesquisa, se a janela não foi cancelado
            if (pesquisar.cancelado) 
            {
                pesquisar.Dispose();
                return;
            }

            //executa a pesquisa
            FrmResultado2 resultar = new FrmResultado2(pesquisar.texto_pesquisa);
            resultar.ShowDialog();

        }
        //=============================================================
        private void btn_reset_Click(object sender, EventArgs e)
        {
            //deleta todos os registros feito pelo usuario na base de dados

            //caso o usuario pressione NÂO, não acontece nada e volta para a janela de inicio
            if (MessageBox.Show("ATENÇÃO: Deseja eliminar todos os contatos da base de dados?",
                                "ATENÇÃO", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.No)
                return;

            //caso o usuario aperte sim executa o codigo abaixo e deleta todos os registros
            SqlCeConnection deletar = new SqlCeConnection("Data Source = " + cl_static.base_dados);
            deletar.Open();

            SqlCeCommand coman = new SqlCeCommand("DELETE FROM contatos", deletar);
            coman.ExecuteNonQuery();
            deletar.Dispose();


            //aparece a mensagem que todos os contatos foram eliminados
            MessageBox.Show("Dados eliminados com sucesso.");

        }
        //=============================================================
        private void label_titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
