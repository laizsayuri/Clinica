namespace Clinica.Funcionarios
{
    partial class DependentesCriarView
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
            this.button5 = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.titulo_label = new System.Windows.Forms.Label();
            this.codigoFValor = new System.Windows.Forms.TextBox();
            this.codigoF_label = new System.Windows.Forms.Label();
            this.dataNascimentoValor = new System.Windows.Forms.TextBox();
            this.dataNasc_label = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.codigoDValor = new System.Windows.Forms.TextBox();
            this.codigoD_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 49;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(314, 295);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 47;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // titulo_label
            // 
            this.titulo_label.AutoEllipsis = true;
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(138, 57);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(231, 24);
            this.titulo_label.TabIndex = 45;
            this.titulo_label.Text = "Criar novo dependente:";
            // 
            // codigoFValor
            // 
            this.codigoFValor.Location = new System.Drawing.Point(166, 253);
            this.codigoFValor.Name = "codigoFValor";
            this.codigoFValor.Size = new System.Drawing.Size(223, 20);
            this.codigoFValor.TabIndex = 40;
            // 
            // codigoF_label
            // 
            this.codigoF_label.AutoSize = true;
            this.codigoF_label.Location = new System.Drawing.Point(40, 256);
            this.codigoF_label.Name = "codigoF_label";
            this.codigoF_label.Size = new System.Drawing.Size(101, 13);
            this.codigoF_label.TabIndex = 39;
            this.codigoF_label.Text = "Codigo Funcionario:";
            // 
            // dataNascimentoValor
            // 
            this.dataNascimentoValor.Location = new System.Drawing.Point(166, 211);
            this.dataNascimentoValor.Name = "dataNascimentoValor";
            this.dataNascimentoValor.Size = new System.Drawing.Size(223, 20);
            this.dataNascimentoValor.TabIndex = 38;
            // 
            // dataNasc_label
            // 
            this.dataNasc_label.AutoSize = true;
            this.dataNasc_label.Location = new System.Drawing.Point(40, 214);
            this.dataNasc_label.Name = "dataNasc_label";
            this.dataNasc_label.Size = new System.Drawing.Size(107, 13);
            this.dataNasc_label.TabIndex = 37;
            this.dataNasc_label.Text = "Data de Nascimento:";
            // 
            // nomeValor
            // 
            this.nomeValor.Location = new System.Drawing.Point(166, 167);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(223, 20);
            this.nomeValor.TabIndex = 36;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(40, 170);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 35;
            this.nome_label.Text = "Nome:";
            // 
            // codigoDValor
            // 
            this.codigoDValor.Location = new System.Drawing.Point(166, 122);
            this.codigoDValor.Name = "codigoDValor";
            this.codigoDValor.Size = new System.Drawing.Size(223, 20);
            this.codigoDValor.TabIndex = 34;
            // 
            // codigoD_label
            // 
            this.codigoD_label.AutoSize = true;
            this.codigoD_label.Location = new System.Drawing.Point(40, 125);
            this.codigoD_label.Name = "codigoD_label";
            this.codigoD_label.Size = new System.Drawing.Size(105, 13);
            this.codigoD_label.TabIndex = 33;
            this.codigoD_label.Text = "Codigo Dependente:";
            this.codigoD_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DependentesCriarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 337);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.codigoFValor);
            this.Controls.Add(this.codigoF_label);
            this.Controls.Add(this.dataNascimentoValor);
            this.Controls.Add(this.dataNasc_label);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.codigoDValor);
            this.Controls.Add(this.codigoD_label);
            this.Name = "DependentesCriarView";
            this.Text = "DependentesCriarView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox codigoFValor;
        private System.Windows.Forms.Label codigoF_label;
        private System.Windows.Forms.TextBox dataNascimentoValor;
        private System.Windows.Forms.Label dataNasc_label;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.TextBox codigoDValor;
        private System.Windows.Forms.Label codigoD_label;
    }
}