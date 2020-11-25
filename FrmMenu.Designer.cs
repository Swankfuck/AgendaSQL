namespace AgendaSQL
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.label_titulo = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.label_version = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pesquisar.Location = new System.Drawing.Point(12, 9);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(98, 23);
            this.btn_pesquisar.TabIndex = 0;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.BackColor = System.Drawing.Color.Transparent;
            this.label_titulo.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_titulo.Location = new System.Drawing.Point(7, 70);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(115, 27);
            this.label_titulo.TabIndex = 1;
            this.label_titulo.Text = "Agenda SQL";
            this.label_titulo.Click += new System.EventHandler(this.label_titulo_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_sair.Location = new System.Drawing.Point(12, 129);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(98, 23);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_adicionar.Location = new System.Drawing.Point(133, 70);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(89, 23);
            this.btn_adicionar.TabIndex = 3;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_visualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_visualizar.Location = new System.Drawing.Point(60, 41);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(98, 23);
            this.btn_visualizar.TabIndex = 4;
            this.btn_visualizar.Text = "Visualizar tudo";
            this.btn_visualizar.UseVisualStyleBackColor = false;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // label_version
            // 
            this.label_version.BackColor = System.Drawing.Color.Transparent;
            this.label_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_version.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_version.Location = new System.Drawing.Point(36, 154);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(186, 17);
            this.label_version.TabIndex = 5;
            this.label_version.Text = "Version";
            this.label_version.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_reset
            // 
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_reset.Location = new System.Drawing.Point(60, 100);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(98, 23);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Apagar tudo";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 180);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.btn_pesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Button btn_reset;
    }
}

