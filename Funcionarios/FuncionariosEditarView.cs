using System;
using System.Collections;
using System.Windows.Forms;

namespace Clinica.Funcionarios
{
    public partial class FuncionariosEditarView : Form
    {
        public FuncionariosEditarView(Funcionario funcionario)
        {
            InitializeComponent();

            codigoValor.Text = funcionario.Codf.ToString();
            nomeValor.Text = funcionario.Nome;
            idadeValor.Text = funcionario.Idade.ToString();
            cpfValor.Text = funcionario.Cpf;
            cidadeValor.Text = funcionario.Cidade;
            salarioValor.Text = funcionario.Salario.ToString();
            cargoValor.Text = funcionario.Cargo;
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

            ArrayList funcionarios = new ArrayList();
            funcionarios.Add(funcionario);

            FuncionariosView listagem = new FuncionariosView(funcionarios);
            listagem.Show();
            Close();
        }
    }
}
