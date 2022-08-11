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

namespace Clinica.Funcionarios
{
    public partial class DependentesEditarView : Form
    {
        public DependentesEditarView(Dependente dependente)
        {
            InitializeComponent();

            codigoDValor.Text = dependente.Codd.ToString();
            nomeValor.Text = dependente.Nome;
            dataNascimentoValor.Text = dependente.DataNascimento;
            codigoFValor.Text = dependente.Codf;
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Dependente dependente = new Dependente
            {
                Codd = int.Parse(codigoDValor.Text),
                Nome = nomeValor.Text,
                DataNascimento = dataNascimentoValor.Text,
                Codf = codigoFValor.Text,
            };

            ArrayList dependentes = new ArrayList();
            dependentes.Add(dependente);

            DependentesView listagem = new DependentesView(dependentes);
            listagem.Show();
            Close();
        }
    }
}
