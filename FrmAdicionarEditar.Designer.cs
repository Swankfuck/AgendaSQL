namespace AgendaSQL
{
    partial class FrmAdicionarEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdicionarEditar));
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_telefone = new System.Windows.Forms.TextBox();
            this.label_telefone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_gravar
            // 
            this.btn_gravar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_gravar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_gravar.Location = new System.Drawing.Point(175, 189);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(91, 23);
            this.btn_gravar.TabIndex = 0;
            this.btn_gravar.Text = "Salvar";
            this.btn_gravar.UseVisualStyleBackColor = false;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_fechar.Location = new System.Drawing.Point(272, 189);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // label_nome
            // 
            this.label_nome.BackColor = System.Drawing.Color.Transparent;
            this.label_nome.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_nome.Location = new System.Drawing.Point(63, 3);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(100, 23);
            this.label_nome.TabIndex = 2;
            this.label_nome.Text = "Nome* :";
            this.label_nome.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(66, 29);
            this.textBox_nome.MaxLength = 50;
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(234, 20);
            this.textBox_nome.TabIndex = 3;
            // 
            // textBox_telefone
            // 
            this.textBox_telefone.Location = new System.Drawing.Point(66, 103);
            this.textBox_telefone.MaxLength = 20;
            this.textBox_telefone.Name = "textBox_telefone";
            this.textBox_telefone.Size = new System.Drawing.Size(138, 20);
            this.textBox_telefone.TabIndex = 5;
            // 
            // label_telefone
            // 
            this.label_telefone.BackColor = System.Drawing.Color.Transparent;
            this.label_telefone.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telefone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_telefone.Location = new System.Drawing.Point(63, 77);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(100, 23);
            this.label_telefone.TabIndex = 4;
            this.label_telefone.Text = "Telefone* :";
            this.label_telefone.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(10, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Os campos com * são obrigatórios seu preenchimento.";
            // 
            // FrmAdicionarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 224);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_telefone);
            this.Controls.Add(this.label_telefone);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_gravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdicionarEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdicionarEditar";
            this.Load += new System.EventHandler(this.FrmAdicionarEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.TextBox textBox_telefone;
        private System.Windows.Forms.Label label_telefone;
        private System.Windows.Forms.Label label1;
    }
}