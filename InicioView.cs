using Clinica.Consultas;
using Clinica.Funcionarios;
using Clinica.Medicos;
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
            FuncionarioController funcionarioController = new FuncionarioController();
            funcionarioController.Listar();
            Hide();
        }

        private void medicoBtn_Click(object sender, EventArgs e)
        {
            MedicoController medicoController = new MedicoController();
            medicoController.Listar();
            Hide();
        }

        private void consultaBtn_Click(object sender, EventArgs e)
        {
            ConsultaController consultaController = new ConsultaController();
            consultaController.Listar();
            Hide();
        }
    }
}
