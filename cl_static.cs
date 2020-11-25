using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe; //SqlClient é o sql normal.
using System.IO;
using System.Threading.Tasks;

namespace AgendaSQL
{
    //=============================================================
    //classe statica para criação / inicialização / base dados e versão
    public static partial class cl_static
    {
        public static string versao = "Version 1.0.0";
        public static string pasta_dados;//criar o nome da e a pasta do banco de dados
        public static string base_dados;//criar o caminho para a pasta da banco de dados( que eu defini a base de dados como pasta_dados )

        //=============================================================

        public static void iniciar()//colocar no Program.cs
        {
            //criação da pasta aonde vai ficar o banco de dados
            //lembrando que como o windows não da permissão de certas pastas (tem que ser administrador) faremos no meus documentos só para exemplo
            pasta_dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AgendaSQL\";
            // em qual pasta a base de dados vai ser criada /\

            //verifica se a pasta de dados existe, se não existir cria a base de dados
            if (!Directory.Exists(pasta_dados)) //quando for perguntar se uma pasta existe, lembre-se sempre de colocar "!"
                Directory.CreateDirectory(pasta_dados);

            //verifica se a base de dados existe 
            base_dados = pasta_dados + "dados.sdf";
            if (!File.Exists(base_dados))//se não existir a pasta base de dados, aqui vai criar
                CriarBaseDados();

        }

        //=============================================================
        public static void CriarBaseDados()
        {
            //criação da base de dados          "Data source" é a connection string !!!
            SqlCeEngine motor = new SqlCeEngine("Data source = " + base_dados); //sempre coloque "Data source" se não, não da certo
            motor.CreateDatabase();            // dentro desse () /\ é uma string de conexao para criar o banco de dados

            //conectar a base de dados
            SqlCeConnection conectar = new SqlCeConnection(); 
            conectar.ConnectionString = "Data source = " + base_dados;
            conectar.Open();

            //criar o operario para criar as estruturas(colunas) de dentro da base de dados como nome,telefone,endereço etc
            SqlCeCommand operario = new SqlCeCommand();
            operario.CommandText =
                "CREATE TABLE contatos(" +
                "id_contato           int not null primary key, " +
                "nome                 nvarchar(50), " +
                "telefone             nvarchar(20), " +
                "atualizacao          DateTime)";
            //coloquei assim acima para organização, mas pode ser feito em uma linha apenas(mas não é indicado)
            operario.Connection = conectar;
            operario.ExecuteNonQuery(); //não retorna resultados

            operario.Dispose();//sempre colocar
            conectar.Dispose();//esses dois comandos não deixa o app na memoria, ele apaga então ao abrir de novo ele vai carregar todo denovo


        }
    }

}
