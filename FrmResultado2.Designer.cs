namespace AgendaSQL
{
    partial class FrmResultado2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResultado2));
            this.database_resultado2 = new System.Windows.Forms.DataGridView();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.label_quantidade = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_editar_contato = new System.Windows.Forms.Button();
            this.btn_verTudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database_resultado2)).BeginInit();
            this.SuspendLayout();
            // 
            // database_resultado2
            // 
            this.database_resultado2.AllowUserToAddRows = false;
            this.database_resultado2.AllowUserToDeleteRows = false;
            this.database_resultado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.database_resultado2.Location = new System.Drawing.Point(12, 12);
            this.database_resultado2.Name = "database_resultado2";
            this.database_resultado2.ReadOnly = true;
            this.database_resultado2.RowHeadersVisible = false;
            this.database_resultado2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.database_resultado2.Size = new System.Drawing.Size(479, 301);
            this.database_resultado2.TabIndex = 0;
            this.database_resultado2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.database_resultado2_CellClick);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(416, 325);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // label_quantidade
            // 
            this.label_quantidade.AutoSize = true;
            this.label_quantidade.Location = new System.Drawing.Point(12, 330);
            this.label_quantidade.Name = "label_quantidade";
            this.label_quantidade.Size = new System.Drawing.Size(29, 13);
            this.label_quantidade.TabIndex = 2;
            this.label_quantidade.Text = "label";
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(335, 325);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(75, 23);
            this.btn_apagar.TabIndex = 3;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_editar_contato
            // 
            this.btn_editar_contato.Location = new System.Drawing.Point(254, 325);
            this.btn_editar_contato.Name = "btn_editar_contato";
            this.btn_editar_contato.Size = new System.Drawing.Size(75, 23);
            this.btn_editar_contato.TabIndex = 4;
            this.btn_editar_contato.Text = "Editar";
            this.btn_editar_contato.UseVisualStyleBackColor = true;
            this.btn_editar_contato.Click += new System.EventHandler(this.btn_editar_contato_Click);
            // 
            // btn_verTudo
            // 
            this.btn_verTudo.Location = new System.Drawing.Point(173, 325);
            this.btn_verTudo.Name = "btn_verTudo";
            this.btn_verTudo.Size = new System.Drawing.Size(75, 23);
            this.btn_verTudo.TabIndex = 5;
            this.btn_verTudo.Text = "Ver lista";
            this.btn_verTudo.UseVisualStyleBackColor = true;
            this.btn_verTudo.Click += new System.EventHandler(this.btn_verTudo_Click);
            // 
            // FrmResultado2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 361);
            this.Controls.Add(this.btn_verTudo);
            this.Controls.Add(this.btn_editar_contato);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.label_quantidade);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.database_resultado2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmResultado2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendaSQL";
            this.Load += new System.EventHandler(this.FrmResultado2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database_resultado2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView database_resultado2;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label_quantidade;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_editar_contato;
        private System.Windows.Forms.Button btn_verTudo;
    }
}