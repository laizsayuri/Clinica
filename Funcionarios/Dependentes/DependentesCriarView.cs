using Clinica.Funcionarios.Dependentes;
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
            DependenteController dependenteController = new DependenteController();
            dependenteController.Listar();
            Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Dependente dependente = new Dependente
            {
                Nome = nomeValor.Text,
                DataNascimento = dataNascValor.Value,
                Codf = int.Parse(codigoFValor.Text),
            };

            DependenteController controller = new DependenteController();
            controller.Criar(dependente);
            Hide();
        }
    }
}
