using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class FrmPesquisar : Form
    {
        public string texto_pesquisa { get; set; }
        public bool cancelado { get; set; }


        //=============================================================
        public FrmPesquisar()
        {
            InitializeComponent();
        }
       
        //=============================================================
        private void FrmPesquisar_Load(object sender, EventArgs e)
        {

        }
        //=============================================================
        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            //executa a pesquisa mais se apenas existir o texto na textbox
            if(textBox_pesquisa.Text =="")
            {
                cancelado = true;

            }
            else
            {
                texto_pesquisa = textBox_pesquisa.Text;
            }
            this.Close();
        }
        //=============================================================
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //fecha a janela cancelando a operação de pesquisa
            cancelado = true;
            this.Close();
        }
    }
}
