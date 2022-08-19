namespace Clinica
{
    partial class MedicosView
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
            this.listagem = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.filtrarBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ambulatoriosBtn = new System.Windows.Forms.Button();
            this.campoFiltro = new System.Windows.Forms.ComboBox();
            this.valorFiltro = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.codm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // listagem
            // 
            this.listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codm,
            this.Nome,
            this.idade,
            this.especialidade,
            this.CPF,
            this.cidade,
            this.nroa});
            this.listagem.Location = new System.Drawing.Point(2, 56);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(549, 251);
            this.listagem.TabIndex = 4;
            this.listagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // filtrarBtn
            // 
            this.filtrarBtn.Location = new System.Drawing.Point(279, 25);
            this.filtrarBtn.Name = "filtrarBtn";
            this.filtrarBtn.Size = new System.Drawing.Size(75, 23);
            this.filtrarBtn.TabIndex = 9;
            this.filtrarBtn.Text = "Filtrar";
            this.filtrarBtn.UseVisualStyleBackColor = true;
            this.filtrarBtn.Click += new System.EventHandler(this.filtrarBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(458, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Novo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ambulatoriosBtn
            // 
            this.ambulatoriosBtn.Location = new System.Drawing.Point(458, 24);
            this.ambulatoriosBtn.Name = "ambulatoriosBtn";
            this.ambulatoriosBtn.Size = new System.Drawing.Size(95, 23);
            this.ambulatoriosBtn.TabIndex = 15;
            this.ambulatoriosBtn.Text = "Ver Ambulatórios";
            this.ambulatoriosBtn.UseVisualStyleBackColor = true;
            this.ambulatoriosBtn.Click += new System.EventHandler(this.ambulatoriosBtn_Click);
            // 
            // campoFiltro
            // 
            this.campoFiltro.FormattingEnabled = true;
            this.campoFiltro.Items.AddRange(new object[] {
            "Nome",
            "CPF"});
            this.campoFiltro.Location = new System.Drawing.Point(2, 27);
            this.campoFiltro.Name = "campoFiltro";
            this.campoFiltro.Size = new System.Drawing.Size(121, 21);
            this.campoFiltro.TabIndex = 16;
            // 
            // valorFiltro
            // 
            this.valorFiltro.Location = new System.Drawing.Point(129, 27);
            this.valorFiltro.Name = "valorFiltro";
            this.valorFiltro.Size = new System.Drawing.Size(144, 20);
            this.valorFiltro.TabIndex = 17;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(360, 24);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "Limpar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // codm
            // 
            this.codm.HeaderText = "Codigo";
            this.codm.Name = "codm";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "nome";
            this.Nome.Name = "Nome";
            // 
            // idade
            // 
            this.idade.HeaderText = "Idade";
            this.idade.Name = "idade";
            // 
            // especialidade
            // 
            this.especialidade.HeaderText = "Especialidade";
            this.especialidade.Name = "especialidade";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "cpf";
            this.CPF.Name = "CPF";
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            // 
            // nroa
            // 
            this.nroa.HeaderText = "Ambulatório";
            this.nroa.Name = "nroa";
            // 
            // MedicosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 369);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.valorFiltro);
            this.Controls.Add(this.campoFiltro);
            this.Controls.Add(this.ambulatoriosBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.filtrarBtn);
            this.Controls.Add(this.listagem);
            this.Name = "MedicosView";
            this.Text = "Medicos";
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView listagem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button filtrarBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ambulatoriosBtn;
        private System.Windows.Forms.ComboBox campoFiltro;
        private System.Windows.Forms.TextBox valorFiltro;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn codm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroa;
    }
}