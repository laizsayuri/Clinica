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
            MedicoController medicoController = new MedicoController();
            medicoController.Listar();
            Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico
            {
                Nome = nomeValor.Text,
                Idade = int.Parse(idadeValor.Text),
                Especialidade = especialidadeValor.Text,
                Cidade = cidadeValor.Text,
                Cpf = cpfValor.Text,
                Nroa = string.IsNullOrEmpty(nroaValor.Text) ? 0 : int.Parse(nroaValor.Text),
            };

            MedicoController controller = new MedicoController();
            controller.Criar(medico);
            Hide();
        }
    }
}
