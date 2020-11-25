
namespace AgendaSQL
{
    partial class FrmPesquisar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisar));
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.label_pesquisa = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(132, 66);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisa.TabIndex = 0;
            this.btn_pesquisa.Text = "Pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Location = new System.Drawing.Point(33, 40);
            this.textBox_pesquisa.MaxLength = 70;
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(278, 20);
            this.textBox_pesquisa.TabIndex = 1;
            // 
            // label_pesquisa
            // 
            this.label_pesquisa.AutoSize = true;
            this.label_pesquisa.Location = new System.Drawing.Point(30, 24);
            this.label_pesquisa.Name = "label_pesquisa";
            this.label_pesquisa.Size = new System.Drawing.Size(212, 13);
            this.label_pesquisa.TabIndex = 3;
            this.label_pesquisa.Text = "Insira o nome ou telefone a ser pesquisado:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(252, 88);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FrmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 114);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label_pesquisa);
            this.Controls.Add(this.textBox_pesquisa);
            this.Controls.Add(this.btn_pesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.FrmPesquisar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.TextBox textBox_pesquisa;
        private System.Windows.Forms.Label label_pesquisa;
        private System.Windows.Forms.Button btn_cancelar;
    }
}