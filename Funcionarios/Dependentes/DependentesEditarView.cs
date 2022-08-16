using Clinica.Funcionarios.Dependentes;
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
            dataNascValor.Value = dependente.DataNascimento;
            codigoFValor.Text = dependente.Codf.ToString();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Dependente dependente = new Dependente
            {
                Codd = int.Parse(codigoDValor.Text),
                Nome = nomeValor.Text,
                DataNascimento = dataNascValor.Value,
                Codf = int.Parse(codigoFValor.Text),
            };
                        
            DependenteController controller = new DependenteController();
            controller.Salvar(dependente);
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DependenteController dependenteController = new DependenteController();
            dependenteController.Listar();
            Close();
        }
    }
}
