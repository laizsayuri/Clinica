namespace Clinica.Funcionarios
{
    partial class DependentesView
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
            this.editarBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.filtroValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listagem = new System.Windows.Forms.DataGridView();
            this.codd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // editarBtn
            // 
            this.editarBtn.Location = new System.Drawing.Point(13, 239);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(75, 23);
            this.editarBtn.TabIndex = 26;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = true;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Nome",
            "CPF"});
            this.listBox1.Location = new System.Drawing.Point(13, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 25;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(281, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Novo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(94, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // filtroValor
            // 
            this.filtroValor.Location = new System.Drawing.Point(139, 31);
            this.filtroValor.Name = "filtroValor";
            this.filtroValor.Size = new System.Drawing.Size(100, 20);
            this.filtroValor.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listagem
            // 
            this.listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codd,
            this.nome,
            this.dataNascimento,
            this.codf});
            this.listagem.Location = new System.Drawing.Point(12, 59);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(444, 163);
            this.listagem.TabIndex = 19;
            // 
            // codd
            // 
            this.codd.HeaderText = "Codigo Dependente:";
            this.codd.Name = "codd";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // dataNascimento
            // 
            this.dataNascimento.HeaderText = "Data de Nascimento:";
            this.dataNascimento.Name = "dataNascimento";
            // 
            // codf
            // 
            this.codf.HeaderText = "Codigo Funcionario:";
            this.codf.Name = "codf";
            // 
            // DependentesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 295);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.filtroValor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listagem);
            this.Name = "DependentesView";
            this.Text = "DependentesView";
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox filtroValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView listagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn codd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codf;
    }
}