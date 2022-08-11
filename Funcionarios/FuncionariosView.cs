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
            listagem.DataSource = funcionarios;

            foreach (Funcionario p in funcionarios)
            {
                MessageBox.Show(p.ToString());
            }
        }

        // filtrar
        private void button1_Click(object sender, EventArgs e)
        {

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
           
        }

        private void dependentesBtn_Click(object sender, EventArgs e)
        {
            DependentesView tela = new DependentesView();
            tela.Show();
            Hide();
        }
    }
}
