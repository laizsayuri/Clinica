using System;
using System.Windows.Forms;

namespace Clinica.Funcionarios
{
    public partial class FuncionariosCriarView : Form
    {
        public FuncionariosCriarView()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FuncionariosView funcionario = new FuncionariosView();
            funcionario.Show();
            Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario
            {
                Codf = int.Parse(codigoValor.Text),
                Nome = nomeValor.Text,
                Idade = int.Parse(idadeValor.Text),
                Cidade = cidadeValor.Text,
                Cpf = cpfValor.Text,
                Salario = decimal.Parse(salarioValor.Text),
                Cargo = cargoValor.Text
            };

            FuncionariosEditarView funcionarioEditar = new FuncionariosEditarView(funcionario);

            funcionarioEditar.Show();
            Close();
        }
    }
}
