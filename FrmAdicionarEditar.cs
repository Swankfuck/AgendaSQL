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
    public partial class FrmAdicionarEditar : Form
    {

        int id_contato; // o id_contato começa com -1 para poder gravar novos sem que começe do 0
        bool editar; //se for verdadeira vai editar um registro, se for falsa vai criar um novo registro !! 
        //ou seja se o editar(bool) for -1 vai ser falso e vou editar o contato
        //se o adicionar(bool) for verdadeiro vai ser igual a -1

        //=============================================================

        public FrmAdicionarEditar(int id_contato = -1)
        {
            InitializeComponent();
            this.id_contato = id_contato;
            //primeiro id_contato é de ali de cima e o segundo id_contato é de dentro do ()


            //definir se vou adicionar ou editar registros
            if (id_contato == -1)
                editar = false;
            else
                editar = true;

            //posso fazer esse código acima desta maneira tambem
            // editar = id_contato == -1 ? false : true;
            // : = "caso contrario"

        }
        //=============================================================

        private void FrmAdicionarEditar_Load(object sender, EventArgs e)
        {
            //apresenta os dados do contato se necessario se for editado
            if (editar)
                ApresentarContato();
        }
        //=============================================================
        private void ApresentarContato()
        {
            //apresentar o contato que vai ser editado
            SqlCeConnection edição = new SqlCeConnection("Data Source = " + cl_static.base_dados);
            edição.Open();
            DataTable dados = new DataTable();
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM contatos WHERE id_contato = " + id_contato, edição);
            adaptador.Fill(dados);
            edição.Dispose();

            //colocar os dados no textbox
            textBox_nome.Text = dados.Rows[0]["nome"].ToString();
            textBox_telefone.Text = dados.Rows[0]["telefone"].ToString();


        }
        //=============================================================

        private void btn_gravar_Click(object sender, EventArgs e)
        {

            SqlCeConnection conexao = new SqlCeConnection("Data source = " + cl_static.base_dados);
            conexao.Open();



            //grava novo registro ou edita registro existente

            #region verificações...(para ver se o contato esta sem preencher ou contato duplicados)
            //verifica se os campos estão preenchidos
            if (textBox_nome.Text == "" || textBox_telefone.Text =="")
            {
                MessageBox.Show("Falta preencher todos os campos.");
                return;
            }

            

            #endregion


            //=============================================================
            #region Novo contato 
            if (!editar) //se for igual a falso cria um novo contato
            {
                //buscar o id_contato disponivel (para isso criei um objeto logo acima como "conexao"
                SqlCeDataAdapter adptador = new SqlCeDataAdapter("SELECT MAX(id_contato) AS maxid FROM contatos", conexao);
                DataTable dados = new DataTable();
                adptador.Fill(dados);

                //verifica se o valor é nulo(null) \/
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                    id_contato = 0;
                
                //se sim o valor for nulo ele vai parar o codigo acima/\ e vai aparecer a Messagebox criada nas verificações
                //se nao for nulo ele continua o código abaixo \/
                //nulo que digo é a pessoa não preencher os campos, se ela preencher não vai ser nulo
                else
                {
                    id_contato = Convert.ToInt16(dados.Rows[0][0]) + 1; 
                    //se o valor nao for nulo ele vai pegar o valor acima e vai acrescentar mais uma unidade
                }

                //DBNull = data base null(nulo) usados para ver valores nulos duma base de dados
                //"!" = diferente

                // -------------------------------------------------------------------------------

                //gravar o novo contato na base de dados
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                //modo seguro de realizar o sql sem correr o risco de SQLINJETION \/

                //parametros(enviar para o meu comando cada um dos dados que quero gravar na base de dados e cada um dos dados vai ser um parametro)
                comando.Parameters.AddWithValue("@id_contato", id_contato);
                comando.Parameters.AddWithValue("@nome", textBox_nome.Text);
                comando.Parameters.AddWithValue("@telefone", textBox_telefone.Text);
                comando.Parameters.AddWithValue("@atualizacao", DateTime.Now);

                //verifica se ja existe um contato com o mesmo nome e telefone
                //veja como nao precisei criar um novo objeto eu simplesmente peguei o criado ali em cima (abaixo de if(editar))
                //peguei os mesmos nomes e abri o objeto
                adptador = new SqlCeDataAdapter();
                dados = new DataTable();
                comando.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND telefone = @telefone"; //preciso definir o "comando" dessa forma pois se nao implica logo abaixo com o "texto da query"
                adptador.SelectCommand = comando; //eu falo que o adptador é igual comando para não ter que criar esse codigo igual acima "comando.Parameters.AddWithValue("@atualizacao", DateTime.Now);" se nao teria que por todos
                adptador.Fill(dados);
                if(dados.Rows.Count!=0)//se a contagem de linha for diferente de 0 (ou seja se ja existir um contato em outra linha)
                {
                    //ja existe um registro com o mesmo nome e telefone
                    //MessageBox.Show("Já existe um registro com o mesmo nome e telefone !");
                    //return; === esse exemplo aqui é para mostar ao usuario que ja existe nome e telefone e impedir ele de prosseguir.
                    // ja o exemplo abaixo não, mesmo se tiver contatos iguais ele tem a chance de prosseguir

                    //se ainda sim quer que o contato seja salvo
                    if (MessageBox.Show("Já existe um registro com o mesmo nome e telefone." + Environment.NewLine +
                                        "Deseja salvar o contato mesmo assim ?", "ATENÇÃO", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.No) 
                    
                    return;
                    //Environment.NewLine = para colocar a frase em uma nova linha (paragrafo)(ou mudar de linha)
                    //se ele apertar "No" o procedimento para, mas se ele aperta "Yes" o procedimento continua nos códigos abaixo.


                }

                //texto da query
                comando.CommandText = "INSERT INTO contatos VALUES(" +
                    "@id_contato,@nome,@telefone,@atualizacao)";

                MessageBox.Show("Contato adicionado!");

                //limpa o textbox apos adicionar o contato
                textBox_nome.Text = "";
                textBox_telefone.Text = "";
                textBox_nome.Focus();

                
                comando.ExecuteNonQuery(); // não executa informação, mas vai guardar informação na base de dados
                comando.Dispose();
                conexao.Dispose();

                //modo não seguro de realizar o sql com risco de SQLINJETION \/
                //--------------------------------------------------(primeiro eu fiz assim aqui em cima /\)
                /* SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                comando.CommandText =                       //todo esse código criado aqui não é seguro
                    "INSERT INTO contatos VALUES(" +        //pode ser facilmente estragado por SQLINJETION
                    "'" + id_contato + ", " +               //NAO REALIZAR ELE DESSA FORMA QUE ESTA AQUI
                    "'" +textBox_nome.Text + "', " +
                    textBox_telefone.Text + "', " +
                    DateTime.Now + ")"; */

                /* /\ estou fazendo isso acima 
                INSERT INTO contatos VALUES
               id_contato,
               nome,
               telefone,
               atualização                                          
                */
                //-------------------------------------
                //OBSERVAÇÃO MUITO IMPORTANTE, O CÓDIGO ACIMA NÃO ESTA SEGURO
                //CASO ALGUEM COLOQUE NO NOME "DELETE FROM ALL" ELE VAI INSERIR UMA QUERY E VAI EXECUTAR
                //OU SE A PESSOA COLOCAR UM CODIGO HACKER ELA VAI TER ACESSO AO BANCO DE DADOS
                //É O QUE CHAMAN DE SQLINJECTION !!!

            }

            #endregion

            //=============================================================

            #region Editar contato
            else
                {
                //se for verdadeiro edita o contato na base de dados


                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                //modo seguro de realizar o sql sem correr o risco de SQLINJETION \/

                //criando parametros no sql
                comando.Parameters.AddWithValue("@id_contato", id_contato);
                comando.Parameters.AddWithValue("@nome", textBox_nome.Text);
                comando.Parameters.AddWithValue("@telefone", textBox_telefone.Text);
                comando.Parameters.AddWithValue("@atualizacao", DateTime.Now);


                //verifica se existe um registro com o mesmo nome 
                DataTable verifica = new DataTable();
                comando.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND id_contato <> @id_contato";
                SqlCeDataAdapter adaptadorzinho = new SqlCeDataAdapter();
                adaptadorzinho.SelectCommand = comando;
                adaptadorzinho.Fill(verifica);
                if(verifica.Rows.Count !=0)
                {
                    //foi encontrado um contato com o mesmo nome, pergunta se o usuario quer editar ou salvar igual o mesmo contato
                    if (MessageBox.Show("Já existe um registro com o mesmo nome." + Environment.NewLine +
                                        "Deseja salvar o contato mesmo assim ?", "ATENÇÃO", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }

                //editar o contato selecionado 
                comando.CommandText = "UPDATE contatos SET " +
                                        "nome = @nome, " +
                                        "telefone = @telefone, " +
                                        "atualizacao = @atualizacao " +
                                        "WHERE id_contato = @id_contato";
                comando.ExecuteNonQuery();

                //fecha o quadro e volta para a tela da tabela
                this.Close();


            }
            #endregion
        }
        //=============================================================

        private void btn_fechar_Click(object sender, EventArgs e)
                {
                //fecha o quadro
                this.Close();//vai fechar e voltar para o menu iniciar
                }

    }
}
