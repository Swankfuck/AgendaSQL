using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class FrmResultado2 : Form
    {
        int id_contato;
        string item_pesquisa;
        //=======================================================================
        public FrmResultado2(string item_pesquisa = "")
        {
            InitializeComponent();
            this.item_pesquisa = item_pesquisa;
        }
        //=======================================================================
        private void FrmResultado2_Load(object sender, EventArgs e)
        {
            ConstruirTabela();
        }
        //=======================================================================
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            //fecha o quadro e volta para o menu inicial
            this.Close();

        }
        //=======================================================================
        private void ConstruirTabela()
        {
            //constroi a tabela de registros

            //conectar a base de dados
            SqlCeConnection on = new SqlCeConnection("Data Source = " + cl_static.base_dados);
            on.Open();

            string query = "SELECT * FROM contatos";
            if (item_pesquisa != "")
                query = "SELECT * FROM contatos " +
                        "WHERE nome LIKE @item OR telefone LIKE @item";

            SqlCeCommand comand = new SqlCeCommand();
            comand.Parameters.AddWithValue("@item", "%" + item_pesquisa + "%");
            comand.CommandText = query;
            comand.Connection = on;



            SqlCeDataAdapter adapter = new SqlCeDataAdapter();
            adapter.SelectCommand = comand;
            DataTable dado = new DataTable();
            adapter.Fill(dado);

            database_resultado2.DataSource = dado;
            
            //apresenta o numero de registros da data base

            label_quantidade.Text = "Nº de Registros: " + database_resultado2.Rows.Count;

            //esconder colunas como por exemplo não quero que apareça data e hora(atualização) e id_contato
            //database_resultado2.Columns[0].Visible = false; //id_contato 0 / nome 1 / telefone 2 / atualizaçao 3
            //database_resultado2.Columns[3].Visible = false; //olhe a database para contar
            // ou posso fazer colocando o nome que é o mais seguro e correto (por conta de não interferir na ordem que esta colocando)
            database_resultado2.Columns["id_contato"].Visible = false;
            database_resultado2.Columns["atualizacao"].Visible = false;

            //alterar as dimensoes das colunas
            database_resultado2.Columns["nome"].Width = CalcularLarguraDaCedula(60); //60% de largura
            database_resultado2.Columns["telefone"].Width = CalcularLarguraDaCedula(40); //40% de largura
            // preciso deixar um resultado que de 100% ou seja 60% para nome e 40% restante para telefone
            //por isso criei um metodo "CalcularLarguraDaCedula" para que deixe 60% de largura o nome 40% de largura o telefone e -20pixel para a scroll bar
            //OBS SEMPRE UTILIZAR ESSE MODO DE REDIMENSIONAR AS CEDULAS POIS MESMO DIMINUINDO A JANELA ELE FAZ O CALCULO PARA FICAR PROPORCIONAL



            //-------------------------------------------------------------------------------------------------------
            //para selecionar a linha inteira (exemplo ao clicar no nome selecionar o telefone tambem)
            //no design procure "SelectionMode" e coloque como "FullRowSelect"
            //MulltiSelect = o usuario vai conseguir selecionar mais de uma linha, então cuidado
            //pois se deixar ele como true é preciso configurar um botão para apagar tudo de uma vez quando ele quiser selecionar mais de 1x linha
            //usa-lo no true somente quando necessario
            //-------------------------------------------------------------------------------------------------------


            //deixa os botões "apagar" e "editar" como ocultos pois ele só vai aparecer se o usuario clicar numa cedula (para isso criei um evento ali em baixo do "cellclick")
            btn_apagar.Enabled = false;
            btn_editar_contato.Enabled = false;
        }
        //=======================================================================
        private void btn_apagar_Click(object sender, EventArgs e)
        {
            //apagar a linha selecionada(vai apagar da base de dados tambem ! )
            SqlCeConnection abrir = new SqlCeConnection("Data Source = " + cl_static.base_dados);
            abrir.Open();
            SqlCeCommand comandar = new SqlCeCommand("DELETE FROM contatos WHERE id_contato = " + id_contato, abrir);
            comandar.ExecuteNonQuery();
            comandar.Dispose();
            abrir.Dispose();

            //reconstruir a tabela de contatos
            ConstruirTabela();

        }
        //=======================================================================
        private void database_resultado2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //evento "cellclick" para ativar os botões "apagar" e "editar"
            id_contato = Convert.ToInt16(database_resultado2.Rows[e.RowIndex].Cells["id_contato"].Value);
            btn_apagar.Enabled = true;
            btn_editar_contato.Enabled = true;

        }
        //=======================================================================
        private void btn_editar_contato_Click(object sender, EventArgs e)
        {
            //edita o contato selecionado
            //para isso preciso criar um objeto com a janela do "FrmAdicionarEditar" para que a tabela de registro apareça
            FrmAdicionarEditar editar = new FrmAdicionarEditar(id_contato);
            editar.ShowDialog();

            //atualizar a tabela de contatos
            ConstruirTabela();

        }
        //=======================================================================
        private void btn_verTudo_Click(object sender, EventArgs e)
        {
            //volta a apresentar todos os registros salvos
            item_pesquisa = "";
            ConstruirTabela();
        }
        //=======================================================================
        private int CalcularLarguraDaCedula(int porcentagem)
        {
            //-20 pois a barra de scroll lateral tem 20 pixel de largura
            int largura_tabela = database_resultado2.Width - 20;
            int resultado = (largura_tabela * porcentagem) / 100;
            return resultado;
        }



    }
}

/*
 Regra da proporcionalidade
    
    largura da tabela ->100% (pixel)
    largura da coluna ->???  (pixel)   valor x
 
    x = (largura da tabela X porcentagem)/100
 
 */
