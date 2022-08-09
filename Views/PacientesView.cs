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
            this.listagem.DataSource = pacientes;

            foreach (Paciente p in pacientes)
            {
                MessageBox.Show(p.ToString());
               
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filtroValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            InicioView inicio = new InicioView();
            inicio.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PacientesCriarView pacienteCriar = new PacientesCriarView();
            pacienteCriar.Show();
            this.Close();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {

        }
    }
}
