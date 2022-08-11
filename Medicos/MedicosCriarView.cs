using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.Medicos
{
    public partial class MedicosCriarView : Form
    {
        public MedicosCriarView()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MedicosView medico = new MedicosView();
            medico.Show();
            Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico
            {
                Codm = int.Parse(codigoValor.Text),
                Nome = nomeValor.Text,
                Idade = int.Parse(idadeValor.Text),
                Especialidade = especialidadeValor.Text,
                Cidade = cidadeValor.Text,
                Cpf = cpfValor.Text,
                Nroa = nroaValor.Text,
            };

            MedicosEditarView medicoEditar = new MedicosEditarView(medico);

            medicoEditar.Show();
            Close();
        }
    }
}
