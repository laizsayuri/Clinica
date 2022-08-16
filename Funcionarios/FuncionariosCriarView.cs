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
            FuncionarioController funcionarioController = new FuncionarioController();
            funcionarioController.Listar();
            Close();            
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario
            {                
                Nome = nomeValor.Text,
                Idade = int.Parse(idadeValor.Text),
                Cpf = cpfValor.Text,
                Cidade = cidadeValor.Text,                
                Salario = decimal.Parse(salarioValor.Text),
                Cargo = cargoValor.Text
            };

            FuncionarioController controller = new FuncionarioController();

            controller.Criar(funcionario);
            Hide();            
        }
    }
}
