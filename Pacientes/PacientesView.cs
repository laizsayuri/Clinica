using System;
using System.Collections;
using System.Windows.Forms;

namespace Clinica
{
    public partial class PacientesView : Form
    {
        public PacientesView()
        {
            InitializeComponent();
            
        }

        public PacientesView(ArrayList pacientes)
        {
            InitializeComponent();
            int x = 0;

            foreach (Paciente p in pacientes)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = p.Codp;
                this.listagem.Rows[x].Cells[1].Value = p.Nome;
                this.listagem.Rows[x].Cells[2].Value = p.Idade;
                this.listagem.Rows[x].Cells[3].Value = p.Cpf;
                this.listagem.Rows[x].Cells[4].Value = p.Cidade;
                this.listagem.Rows[x].Cells[5].Value = p.Doenca;
                x++;
            }
        }

        // filtrar
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            InicioView inicio = new InicioView();
            inicio.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PacientesCriarView pacienteCriar = new PacientesCriarView();
            pacienteCriar.Show();
            Close();
        }
    }
}
