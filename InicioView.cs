using Clinica.Consultas;
using Clinica.Funcionarios;
using Clinica.Pacientes;
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
            PacienteController pacienteController = new PacienteController();
            pacienteController.Listar();
            Hide();
        }

        private void funcionarioBtn_Click(object sender, EventArgs e)
        {
            FuncionariosView tela = new FuncionariosView();
            tela.Show();
            Hide();
        }

        private void medicoBtn_Click(object sender, EventArgs e)
        {
            MedicosView tela = new MedicosView();
            tela.Show();
            Hide();
        }

        private void consultaBtn_Click(object sender, EventArgs e)
        {
            ConsultasView tela = new ConsultasView();
            tela.Show();
            Hide();
        }
    }
}
