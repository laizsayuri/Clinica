using System;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.SetVisibleCore(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pacienteBtn_Click(object sender, EventArgs e)
        {
            Pacientes tela =  new Pacientes();
            tela.Show();
            this.Hide();
        }
    }
}
