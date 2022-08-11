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

namespace Clinica.Consultas
{
    public partial class ConsultasView : Form
    {
        public ConsultasView()
        {
            InitializeComponent();
        }

        public ConsultasView(ArrayList consultas)
        {
            InitializeComponent();
            listagem.DataSource = consultas;

            foreach (Consulta c in consultas)
            {
                MessageBox.Show(c.ToString());
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
            ConsultasCriarView consultaCriar = new ConsultasCriarView();
            consultaCriar.Show();
            Close();
        }
    }
}
