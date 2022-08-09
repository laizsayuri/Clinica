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
            this.Close();
        }

        private void PacientesCriar_Load(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.Codp = int.Parse(this.codigoValor.Text);
            paciente.Nome = this.nomeValor.Text;
            paciente.Idade = int.Parse(this.idadeValor.Text);
            paciente.Cidade = this.cidadeValor.Text;
            paciente.Cpf = this.cpfValor.Text;
            paciente.Doenca = this.doencaValor.Text;

            PacientesEditarView pacienteEditar = new PacientesEditarView(paciente);

            pacienteEditar.Show();
            this.Close();
        }
    }
}
