using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSQL
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //tudo que for colocado aqui sera as primeiras coisas a serem executadas
            //lembrando que o banco de dados é super importante inicializar aqui !!!
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //tudo que eu colocar aqui em cima vai ser executado antes de abrir a interface ou menu inicial !!!!


            //=============================================================
            //tudo que eu colocar aqui abaixo vai ser executado com o menu inicial ou interface
            
            cl_static.iniciar();//o banco de dados vai ser iniciado aqui junto com o menu
            
            //essa linha é aonde vai iniciar o programa \/ (apresenta o menu inicial)
            Application.Run(new FrmMenu());
        }
    }
}
