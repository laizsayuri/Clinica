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
            listagem.DataSource = dependentes;

            foreach (Dependente d in dependentes)
            {
                MessageBox.Show(d.ToString());
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
    }
}
