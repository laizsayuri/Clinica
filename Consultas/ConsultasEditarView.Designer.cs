namespace Clinica.Consultas
{
    partial class ConsultasEditarView
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
            this.data_label = new System.Windows.Forms.Label();
            this.codigoP_label = new System.Windows.Forms.Label();
            this.codigoM_label = new System.Windows.Forms.Label();
            this.dataHoraConsulta = new System.Windows.Forms.DateTimePicker();
            this.codigoMValor = new System.Windows.Forms.ComboBox();
            this.codPValor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 40;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(365, 240);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 39;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(163, 28);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(154, 24);
            this.titulo_label.TabIndex = 38;
            this.titulo_label.Text = "Editar consulta:";
            // 
            // data_label
            // 
            this.data_label.AutoSize = true;
            this.data_label.Location = new System.Drawing.Point(71, 169);
            this.data_label.Name = "data_label";
            this.data_label.Size = new System.Drawing.Size(68, 13);
            this.data_label.TabIndex = 34;
            this.data_label.Text = "Data e Hora:";
            // 
            // codigoP_label
            // 
            this.codigoP_label.AutoSize = true;
            this.codigoP_label.Location = new System.Drawing.Point(71, 125);
            this.codigoP_label.Name = "codigoP_label";
            this.codigoP_label.Size = new System.Drawing.Size(88, 13);
            this.codigoP_label.TabIndex = 32;
            this.codigoP_label.Text = "Codigo Paciente:";
            // 
            // codigoM_label
            // 
            this.codigoM_label.AutoSize = true;
            this.codigoM_label.Location = new System.Drawing.Point(71, 80);
            this.codigoM_label.Name = "codigoM_label";
            this.codigoM_label.Size = new System.Drawing.Size(81, 13);
            this.codigoM_label.TabIndex = 30;
            this.codigoM_label.Text = "Codigo Medico:";
            this.codigoM_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataHoraConsulta
            // 
            this.dataHoraConsulta.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dataHoraConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataHoraConsulta.Location = new System.Drawing.Point(167, 162);
            this.dataHoraConsulta.Name = "dataHoraConsulta";
            this.dataHoraConsulta.Size = new System.Drawing.Size(223, 20);
            this.dataHoraConsulta.TabIndex = 41;
            // 
            // codigoMValor
            // 
            this.codigoMValor.FormattingEnabled = true;
            this.codigoMValor.Location = new System.Drawing.Point(167, 80);
            this.codigoMValor.Name = "codigoMValor";
            this.codigoMValor.Size = new System.Drawing.Size(223, 21);
            this.codigoMValor.TabIndex = 42;
            // 
            // codPValor
            // 
            this.codPValor.FormattingEnabled = true;
            this.codPValor.Location = new System.Drawing.Point(167, 125);
            this.codPValor.Name = "codPValor";
            this.codPValor.Size = new System.Drawing.Size(223, 21);
            this.codPValor.TabIndex = 43;
            // 
            // ConsultasEditarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 279);
            this.Controls.Add(this.codPValor);
            this.Controls.Add(this.codigoMValor);
            this.Controls.Add(this.dataHoraConsulta);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.data_label);
            this.Controls.Add(this.codigoP_label);
            this.Controls.Add(this.codigoM_label);
            this.Name = "ConsultasEditarView";
            this.Text = "ConsultasEditarView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.Label data_label;
        private System.Windows.Forms.Label codigoP_label;
        private System.Windows.Forms.Label codigoM_label;
        private System.Windows.Forms.DateTimePicker dataHoraConsulta;
        private System.Windows.Forms.ComboBox codigoMValor;
        private System.Windows.Forms.ComboBox codPValor;
    }
}