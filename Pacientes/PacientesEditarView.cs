using System;
using System.Collections;
using System.Windows.Forms;

namespace Clinica
{
    public partial class PacientesEditarView : Form
    {
        public PacientesEditarView(Paciente paciente)
        {
            InitializeComponent();

            codigoValor.Text = paciente.Codp.ToString();
            nomeValor.Text = paciente.Nome;
            idadeValor.Text = paciente.Idade.ToString();
            cpfValor.Text = paciente.Cpf;
            doencaValor.Text = paciente.Doenca;
            cidadeValor.Text = paciente.Cidade;
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente
            {
                Codp = int.Parse(codigoValor.Text),
                Nome = nomeValor.Text,
                Idade = int.Parse(idadeValor.Text),
                Cidade = cidadeValor.Text,
                Cpf = cpfValor.Text,
                Doenca = doencaValor.Text
            };

            ArrayList pacientes = new ArrayList();
            pacientes.Add(paciente);

            PacientesView listagem = new PacientesView(pacientes);
            listagem.Show();
            Close();
        }
    }
}
