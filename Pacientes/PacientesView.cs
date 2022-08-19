using Clinica.Pacientes;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Clinica
{
    public partial class PacientesView : Form
    {
        public PacientesView()
        {
            InitializeComponent();
            
        }

        public PacientesView(ArrayList pacientes)
        {
            InitializeComponent();

            
            int x = 0;

            foreach (Paciente p in pacientes)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = p.Codp;
                this.listagem.Rows[x].Cells[1].Value = p.Nome;
                this.listagem.Rows[x].Cells[2].Value = p.Idade;
                this.listagem.Rows[x].Cells[3].Value = p.Cpf;
                this.listagem.Rows[x].Cells[4].Value = p.Cidade;
                this.listagem.Rows[x].Cells[5].Value = p.Doenca;
                x++;
            }
        }

        // filtrar
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            string nomeLista;
            string valorFiltro = filtroValor.Text;
            string nomeFiltro = campoFiltro.Text;

            if (nomeFiltro.Equals(""))
            {
                MessageBox.Show("Selecione um campo para filtrar");
                return;
            }
            else if (valorFiltro.Equals(""))
            {
                MessageBox.Show("Digite um valor para filtrar");
                return;
            }

            switch (nomeFiltro)
            {
                case "Nome":
                    do
                    {
                        nomeLista = this.listagem.Rows[x].Cells[1].Value.ToString();
                        if (!nomeLista.ToUpper().Contains(valorFiltro.ToUpper()))
                        {
                            this.listagem.Rows.RemoveAt(x);
                            x = x - 1;
                        }

                        x++;

                    } while (x < this.listagem.Rows.Count - 1);

                    break;
                case "CPF":
                    do
                    {
                        nomeLista = this.listagem.Rows[x].Cells[4].Value.ToString();
                        if (!nomeLista.ToUpper().Contains(valorFiltro.ToUpper()))
                        {
                            this.listagem.Rows.RemoveAt(x);
                            x--;
                        }
                        x++;
                    } while (x < this.listagem.Rows.Count - 1);
                    break;
            }
            this.listagem.Update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InicioView inicio = new InicioView();
            inicio.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PacientesCriarView pacienteCriar = new PacientesCriarView();
            pacienteCriar.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = listagem.CurrentCell.RowIndex;

            string codp = listagem.Rows[rowindex].Cells[0].Value.ToString();
            string nome = listagem.Rows[rowindex].Cells[1].Value.ToString();
            string idade = listagem.Rows[rowindex].Cells[2].Value.ToString();
            string cpf = listagem.Rows[rowindex].Cells[3].Value.ToString();
            string cidade = listagem.Rows[rowindex].Cells[4].Value.ToString();
            string doenca = listagem.Rows[rowindex].Cells[5].Value.ToString();

            Paciente paciente = new Paciente();

            paciente.Codp = int.Parse(codp);
            paciente.Nome = nome;
            paciente.Idade = int.Parse(idade);
            paciente.Cpf = cpf;
            paciente.Cidade = cidade;
            paciente.Doenca = doenca;

            PacienteController controller = new PacienteController();
            controller.Alterar(paciente);
            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = listagem.CurrentCell.RowIndex;

            string codp = listagem.Rows[rowindex].Cells[0].Value.ToString();
            string nome = listagem.Rows[rowindex].Cells[1].Value.ToString();
            string idade = listagem.Rows[rowindex].Cells[2].Value.ToString();
            string cpf = listagem.Rows[rowindex].Cells[3].Value.ToString();
            string cidade = listagem.Rows[rowindex].Cells[4].Value.ToString();
            string doenca = listagem.Rows[rowindex].Cells[5].Value.ToString();

            Paciente paciente = new Paciente();

            paciente.Codp = int.Parse(codp);
            paciente.Nome = nome;
            paciente.Idade = int.Parse(idade);
            paciente.Cpf = cpf;
            paciente.Cidade = cidade;
            paciente.Doenca = doenca;

            PacienteController controller = new PacienteController();
            controller.Deletar(paciente);
            
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
            PacienteController controller = new PacienteController();
            controller.Listar();
        }
    }
}
