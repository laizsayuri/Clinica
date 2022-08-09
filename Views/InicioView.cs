using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class InicioView : Form
    {
        public InicioView()
        {
            InitializeComponent();
            this.SetVisibleCore(true);
        }

        private void pacienteBtn_Click(object sender, EventArgs e)
        {
            PacientesView tela =  new PacientesView();
            tela.Show();
            this.Hide();
        }

        private void InicioView_Load(object sender, EventArgs e)
        {

        }
    }
}
