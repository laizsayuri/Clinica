using System;
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
    public partial class DependentesCriarView : Form
    {
        public DependentesCriarView()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DependentesView dependente = new DependentesView();
            dependente.Show();
            Close();
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

            DependentesEditarView dependenteEditar = new DependentesEditarView(dependente);

            dependenteEditar.Show();
            Close();
        }
    }
}
