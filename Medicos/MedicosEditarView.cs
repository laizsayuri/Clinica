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

namespace Clinica.Medicos
{
    public partial class MedicosEditarView : Form
    {
        public MedicosEditarView(Medico medico)
        {
            InitializeComponent();

            codigoValor.Text = medico.Codm.ToString();
            nomeValor.Text = medico.Nome;
            idadeValor.Text = medico.Idade.ToString();
            especialidadeValor.Text = medico.Especialidade;
            cpfValor.Text = medico.Cpf;
            cidadeValor.Text = medico.Cidade;
            nroaValor.Text = medico.Nroa.ToString();

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
                Nroa = int.Parse(nroaValor.Text),
            };

            MedicoController controller = new MedicoController();
            controller.Salvar(medico);

            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MedicoController medicoController = new MedicoController();
            medicoController.Listar();
            Close();
        }
    }
}