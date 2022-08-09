namespace Clinica
{
    partial class Inicio
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
            this.pacienteBtn = new System.Windows.Forms.Button();
            this.consultaBtn = new System.Windows.Forms.Button();
            this.funcionarioBtn = new System.Windows.Forms.Button();
            this.medicoBtn = new System.Windows.Forms.Button();
            this.inicioLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pacienteBtn
            // 
            this.pacienteBtn.Location = new System.Drawing.Point(198, 174);
            this.pacienteBtn.Name = "pacienteBtn";
            this.pacienteBtn.Size = new System.Drawing.Size(75, 23);
            this.pacienteBtn.TabIndex = 0;
            this.pacienteBtn.Text = "Pacientes";
            this.pacienteBtn.UseVisualStyleBackColor = true;
            this.pacienteBtn.Click += new System.EventHandler(this.pacienteBtn_Click);
            // 
            // consultaBtn
            // 
            this.consultaBtn.Location = new System.Drawing.Point(346, 174);
            this.consultaBtn.Name = "consultaBtn";
            this.consultaBtn.Size = new System.Drawing.Size(75, 23);
            this.consultaBtn.TabIndex = 1;
            this.consultaBtn.Text = "Consultas";
            this.consultaBtn.UseVisualStyleBackColor = true;
            // 
            // funcionarioBtn
            // 
            this.funcionarioBtn.Location = new System.Drawing.Point(346, 224);
            this.funcionarioBtn.Name = "funcionarioBtn";
            this.funcionarioBtn.Size = new System.Drawing.Size(75, 23);
            this.funcionarioBtn.TabIndex = 3;
            this.funcionarioBtn.Text = "Funcionários";
            this.funcionarioBtn.UseVisualStyleBackColor = true;
            // 
            // medicoBtn
            // 
            this.medicoBtn.Location = new System.Drawing.Point(198, 224);
            this.medicoBtn.Name = "medicoBtn";
            this.medicoBtn.Size = new System.Drawing.Size(75, 23);
            this.medicoBtn.TabIndex = 2;
            this.medicoBtn.Text = "Médicos";
            this.medicoBtn.UseVisualStyleBackColor = true;
            // 
            // inicioLbl
            // 
            this.inicioLbl.AutoSize = true;
            this.inicioLbl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioLbl.Location = new System.Drawing.Point(237, 113);
            this.inicioLbl.Name = "inicioLbl";
            this.inicioLbl.Size = new System.Drawing.Size(147, 26);
            this.inicioLbl.TabIndex = 4;
            this.inicioLbl.Text = "Bem vindo(a)!";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 356);
            this.Controls.Add(this.inicioLbl);
            this.Controls.Add(this.funcionarioBtn);
            this.Controls.Add(this.medicoBtn);
            this.Controls.Add(this.consultaBtn);
            this.Controls.Add(this.pacienteBtn);
            this.Name = "Inicio";
            this.Text = "Sistema Clinica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pacienteBtn;
        private System.Windows.Forms.Button consultaBtn;
        private System.Windows.Forms.Button funcionarioBtn;
        private System.Windows.Forms.Button medicoBtn;
        private System.Windows.Forms.Label inicioLbl;
    }
}

