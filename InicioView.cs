using Clinica.Funcionarios;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class InicioView : Form
    {
        public InicioView()
        {
            InitializeComponent();
            SetVisibleCore(true);
        }

        private void pacienteBtn_Click(object sender, EventArgs e)
        {
            PacientesView tela = new PacientesView();
            tela.Show();
            Hide();
        }

        private void funcionarioBtn_Click(object sender, EventArgs e)
        {
            FuncionariosView tela = new FuncionariosView();
            tela.Show();
            Hide();
        }
    }
}
