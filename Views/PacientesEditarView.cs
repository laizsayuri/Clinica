using System;
using System.Collections;
using System.Windows.Forms;

namespace Clinica
{
    public partial class PacientesEditarView : Form
    {                      
        public PacientesEditarView(object paciente)
        {
            InitializeComponent();
            Paciente p = (Paciente) paciente;

            codigoValor.Text = p.Codp.ToString();
            nomeValor.Text = p.Nome;
            idadeValor.Text = p.Idade.ToString();
            cpfValor.Text = p.Cpf;
            doencaValor.Text = p.Doenca;
            cidadeValor.Text = p.Cidade;
        }

        private void PacientesEditar_Load(object sender, EventArgs e)
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

            ArrayList pacientes = new ArrayList();
            pacientes.Add(paciente);

            PacientesView listagem = new PacientesView(pacientes);
            listagem.Show();
            this.Close();
            
        }
    }
}
