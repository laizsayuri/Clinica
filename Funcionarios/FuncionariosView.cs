using Clinica.Funcionarios.Dependentes;
using Clinica.Funcionarios;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Clinica.Funcionarios
{
    public partial class FuncionariosView : Form
    {
        public FuncionariosView()
        {
            InitializeComponent();
        }

        public FuncionariosView(ArrayList funcionarios)
        {
            InitializeComponent();
            int x = 0;

            foreach (Funcionario f in funcionarios)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = f.Codf;
                this.listagem.Rows[x].Cells[1].Value = f.Nome;
                this.listagem.Rows[x].Cells[2].Value = f.Idade;
                this.listagem.Rows[x].Cells[3].Value = f.Cpf;
                this.listagem.Rows[x].Cells[4].Value = f.Cidade;
                this.listagem.Rows[x].Cells[5].Value = f.Salario;
                this.listagem.Rows[x].Cells[6].Value = f.Cargo;
                x++;
            }            
        }

        private void filtro(int index, string valor)
        {
            string nomeLista;
            int x = 0;
            do
            {
                nomeLista = this.listagem.Rows[x].Cells[index].Value.ToString();
                if (!nomeLista.ToUpper().Contains(valor.ToUpper()))
                {
                    this.listagem.Rows.RemoveAt(x);
                    x--;
                }
                x++;
            } while (x < this.listagem.Rows.Count - 1);
        }

        // filtrar
        private void button1_Click(object sender, EventArgs e)
        {
            string campoFiltro = this.campoFiltro.Text;
            string valorFiltro = this.valorFiltro.Text;

            int x = 0;

            if (campoFiltro.Equals(""))
            {
                MessageBox.Show("Escolha um campo para o filtro");
                return;
            }
            if (valorFiltro.Equals(""))
            {
                MessageBox.Show("Digite um valor para o filtro");
                return;
            }
            switch (campoFiltro)
            {
                case "Nome":
                    this.filtro(1, valorFiltro);
                    break;
                case "CPF":
                    this.filtro(4, valorFiltro);
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InicioView inicio = new InicioView();
            inicio.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FuncionariosCriarView funcionarioCriar = new FuncionariosCriarView();
            funcionarioCriar.Show();
            Close();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            int rowindex = listagem.CurrentCell.RowIndex;

            string codf = listagem.Rows[rowindex].Cells[0].Value.ToString();
            string nome = listagem.Rows[rowindex].Cells[1].Value.ToString();
            string idade = listagem.Rows[rowindex].Cells[2].Value.ToString();           
            string cpf = listagem.Rows[rowindex].Cells[3].Value.ToString();
            string cidade = listagem.Rows[rowindex].Cells[4].Value.ToString();
            string salario = listagem.Rows[rowindex].Cells[5].Value.ToString();
            string cargo = listagem.Rows[rowindex].Cells[6].Value.ToString();

            Funcionario funcionario = new Funcionario();

            funcionario.Codf = int.Parse(codf);
            funcionario.Nome = nome;
            funcionario.Idade = int.Parse(idade);
            funcionario.Cpf = cpf;
            funcionario.Cidade = cidade;
            funcionario.Salario = int.Parse(salario); 
            funcionario.Cargo = cargo;

            FuncionarioController controller = new FuncionarioController();
            controller.Alterar(funcionario);
            Close();
        }

        private void dependentesBtn_Click(object sender, EventArgs e)
        {
            DependenteController dependenteController = new DependenteController();
            dependenteController.Listar();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = listagem.CurrentCell.RowIndex;

            string codf = listagem.Rows[rowindex].Cells[0].Value.ToString();
            string nome = listagem.Rows[rowindex].Cells[1].Value.ToString();
            string idade = listagem.Rows[rowindex].Cells[2].Value.ToString();
            string cpf = listagem.Rows[rowindex].Cells[3].Value.ToString();
            string cidade = listagem.Rows[rowindex].Cells[4].Value.ToString();
            string salario = listagem.Rows[rowindex].Cells[5].Value.ToString();
            string cargo = listagem.Rows[rowindex].Cells[6].Value.ToString();

            Funcionario funcionario = new Funcionario();

            funcionario.Codf = int.Parse(codf);
            funcionario.Nome = nome;
            funcionario.Idade = int.Parse(idade);
            funcionario.Cpf = cpf;
            funcionario.Cidade = cidade;
            funcionario.Salario = int.Parse(salario);
            funcionario.Cargo = cargo;

            FuncionarioController controller = new FuncionarioController();
            controller.Deletar(funcionario);

            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
            FuncionarioController controller = new FuncionarioController();
            controller.Listar();
        }
    }
}
