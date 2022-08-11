using Clinica.Pacientes;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class PacientesCriarView : Form
    {
        public PacientesCriarView()
        {
            InitializeComponent();            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PacientesView paciente = new PacientesView();
            paciente.Show();
            Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente
            {
                Nome = nomeValor.Text,
                Idade = int.Parse(idadeValor.Text),
                Cidade = cidadeValor.Text,
                Cpf = cpfValor.Text,
                Doenca = doencaValor.Text
            };

            PacienteController controller = new PacienteController();
            controller.Criar(paciente);
            Hide();
           
        }
    }
}
