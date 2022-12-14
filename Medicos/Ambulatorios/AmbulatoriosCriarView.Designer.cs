namespace Clinica.Medicos
{
    partial class AmbulatoriosCriarView
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
            this.nroaValor = new System.Windows.Forms.TextBox();
            this.capacidadeValor = new System.Windows.Forms.TextBox();
            this.capacidade_label = new System.Windows.Forms.Label();
            this.andarValor = new System.Windows.Forms.TextBox();
            this.andar_label = new System.Windows.Forms.Label();
            this.codA_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 46;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(286, 258);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 45;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(110, 51);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(227, 24);
            this.titulo_label.TabIndex = 44;
            this.titulo_label.Text = "Criar novo ambulatório:";
            // 
            // nroaValor
            // 
            this.nroaValor.Enabled = false;
            this.nroaValor.Location = new System.Drawing.Point(138, 120);
            this.nroaValor.Name = "nroaValor";
            this.nroaValor.Size = new System.Drawing.Size(223, 20);
            this.nroaValor.TabIndex = 43;
            // 
            // capacidadeValor
            // 
            this.capacidadeValor.Location = new System.Drawing.Point(138, 205);
            this.capacidadeValor.Name = "capacidadeValor";
            this.capacidadeValor.Size = new System.Drawing.Size(223, 20);
            this.capacidadeValor.TabIndex = 37;
            // 
            // capacidade_label
            // 
            this.capacidade_label.AutoSize = true;
            this.capacidade_label.Location = new System.Drawing.Point(49, 212);
            this.capacidade_label.Name = "capacidade_label";
            this.capacidade_label.Size = new System.Drawing.Size(67, 13);
            this.capacidade_label.TabIndex = 36;
            this.capacidade_label.Text = "Capacidade:";
            // 
            // andarValor
            // 
            this.andarValor.Location = new System.Drawing.Point(138, 161);
            this.andarValor.Name = "andarValor";
            this.andarValor.Size = new System.Drawing.Size(223, 20);
            this.andarValor.TabIndex = 35;
            // 
            // andar_label
            // 
            this.andar_label.AutoSize = true;
            this.andar_label.Location = new System.Drawing.Point(49, 168);
            this.andar_label.Name = "andar_label";
            this.andar_label.Size = new System.Drawing.Size(38, 13);
            this.andar_label.TabIndex = 34;
            this.andar_label.Text = "Andar:";
            // 
            // codA_label
            // 
            this.codA_label.AutoSize = true;
            this.codA_label.Location = new System.Drawing.Point(49, 123);
            this.codA_label.Name = "codA_label";
            this.codA_label.Size = new System.Drawing.Size(80, 13);
            this.codA_label.TabIndex = 32;
            this.codA_label.Text = "Nº Ambulatório:";
            this.codA_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AmbulatoriosCriarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 308);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.nroaValor);
            this.Controls.Add(this.capacidadeValor);
            this.Controls.Add(this.capacidade_label);
            this.Controls.Add(this.andarValor);
            this.Controls.Add(this.andar_label);
            this.Controls.Add(this.codA_label);
            this.Name = "AmbulatoriosCriarView";
            this.Text = "AmbulatoriosCriarView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox nroaValor;
        private System.Windows.Forms.TextBox capacidadeValor;
        private System.Windows.Forms.Label capacidade_label;
        private System.Windows.Forms.TextBox andarValor;
        private System.Windows.Forms.Label andar_label;
        private System.Windows.Forms.Label codA_label;
    }
}