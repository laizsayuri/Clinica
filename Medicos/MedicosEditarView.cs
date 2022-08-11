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
            nroaValor.Text = medico.Nroa;

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

            ArrayList medicos = new ArrayList();
            medicos.Add(medico);

            MedicosView listagem = new MedicosView(medicos);
            listagem.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MedicosView paciente = new MedicosView();
            paciente.Show();
            Close();
        }
    }
}
