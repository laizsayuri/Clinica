using Clinica.Funcionarios.Dependentes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.Funcionarios
{
    public partial class DependentesView : Form
    {
        public DependentesView()
        {
            InitializeComponent();
        }
        public DependentesView(ArrayList dependentes)
        {
            InitializeComponent();
            int x = 0;

            foreach (Dependente d in dependentes)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = d.Codd;
                this.listagem.Rows[x].Cells[1].Value = d.Nome;
                this.listagem.Rows[x].Cells[2].Value = d.DataNascimento;
                this.listagem.Rows[x].Cells[3].Value = d.Codf;                
                x++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InicioView inicio = new InicioView();
            inicio.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DependentesCriarView dependenteCriar = new DependentesCriarView();
            dependenteCriar.Show();
            Close();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            int rowindex = listagem.CurrentCell.RowIndex;

            string codd = listagem.Rows[rowindex].Cells[0].Value.ToString();
            string nome = listagem.Rows[rowindex].Cells[1].Value.ToString();
            string dataNascimento = listagem.Rows[rowindex].Cells[2].Value.ToString();
            string codf = listagem.Rows[rowindex].Cells[3].Value.ToString();

            Dependente dependente = new Dependente();

            dependente.Codd = int.Parse(codd);
            dependente.Nome = nome;
            dependente.DataNascimento = DateTime.Parse(dataNascimento);
            dependente.Codf = int.Parse(codf);

            DependenteController controller = new DependenteController();
            controller.Alterar(dependente);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = listagem.CurrentCell.RowIndex;

            string codd = listagem.Rows[rowindex].Cells[0].Value.ToString();
            string nome = listagem.Rows[rowindex].Cells[1].Value.ToString();
            string dataNascimento = listagem.Rows[rowindex].Cells[2].Value.ToString();
            string codf = listagem.Rows[rowindex].Cells[3].Value.ToString();

            Dependente dependente = new Dependente();

            dependente.Codd = int.Parse(codd);
            dependente.Nome = nome;
            dependente.DataNascimento = DateTime.Parse(dataNascimento);
            dependente.Codf = int.Parse(codf);

            DependenteController controller = new DependenteController();
            controller.Deletar(dependente);
            Close();
        }
    }
}
