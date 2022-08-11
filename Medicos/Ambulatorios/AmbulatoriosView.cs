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

namespace Clinica.Medicos
{
    public partial class AmbulatoriosView : Form
    {
        public AmbulatoriosView()
        {
            InitializeComponent();
        }
        public AmbulatoriosView(ArrayList ambulatorios)
        {
            InitializeComponent();
            listagem.DataSource = ambulatorios;

            foreach (Ambulatorio A in ambulatorios)
            {
                MessageBox.Show(A.ToString());
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
            AmbulatoriosCriarView ambulatorioCriar = new AmbulatoriosCriarView();
            ambulatorioCriar.Show();
            Close();
        }
    }
}
