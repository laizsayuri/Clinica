using Clinica.Medicos;
using Clinica.Medicos.Ambulatorios;
using System.Collections;
using System.Windows.Forms;

namespace Clinica
{
    public partial class MedicosView : Form
    {
        public MedicosView()
        {
            InitializeComponent();
        }

        public MedicosView(ArrayList medicos)
        {
            InitializeComponent();
            int x = 0;

            foreach (Medico m in medicos)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = m.Codm;
                this.listagem.Rows[x].Cells[1].Value = m.Nome;
                this.listagem.Rows[x].Cells[2].Value = m.Idade;
                this.listagem.Rows[x].Cells[3].Value = m.Especialidade;
                this.listagem.Rows[x].Cells[4].Value = m.Cpf;
                this.listagem.Rows[x].Cells[5].Value = m.Cidade;
                this.listagem.Rows[x].Cells[6].Value = m.Nroa;
                x++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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


        private void button5_Click(object sender, System.EventArgs e)
        {
            InicioView inicio = new InicioView();
            inicio.Show();
            Close();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            MedicosCriarView medicoCriar = new MedicosCriarView();
            medicoCriar.Show();
            Close();
        }

        private void ambulatoriosBtn_Click(object sender, System.EventArgs e)
        {
            AmbulatorioController ambulatorioController = new AmbulatorioController();
            ambulatorioController.Listar();
            Hide();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            int rowindex = listagem.CurrentCell.RowIndex;

            string codm = listagem.Rows[rowindex].Cells[0].Value.ToString();
            string nome = listagem.Rows[rowindex].Cells[1].Value.ToString();
            string idade = listagem.Rows[rowindex].Cells[2].Value.ToString();
            string especialidade = listagem.Rows[rowindex].Cells[3].Value.ToString();
            string cpf = listagem.Rows[rowindex].Cells[4].Value.ToString();
            string cidade = listagem.Rows[rowindex].Cells[5].Value.ToString();
            string nroa = listagem.Rows[rowindex].Cells[6].Value.ToString();

            Medico medico = new Medico();

            medico.Codm = int.Parse(codm);
            medico.Nome = nome;
            medico.Idade = int.Parse(idade);
            medico.Especialidade = especialidade;
            medico.Cpf = cpf;
            medico.Cidade = cidade;
            medico.Nroa = int.Parse(nroa);

            MedicoController controller = new MedicoController();
            controller.Alterar(medico);
            Close();
        }

       
        private void button3_Click_1(object sender, System.EventArgs e)
        {
            int rowindex = listagem.CurrentCell.RowIndex;

            string codm = listagem.Rows[rowindex].Cells[0].Value.ToString();
            string nome = listagem.Rows[rowindex].Cells[1].Value.ToString();
            string idade = listagem.Rows[rowindex].Cells[2].Value.ToString();
            string especialidade = listagem.Rows[rowindex].Cells[3].Value.ToString();
            string cpf = listagem.Rows[rowindex].Cells[4].Value.ToString();
            string cidade = listagem.Rows[rowindex].Cells[5].Value.ToString();
            string nroa = listagem.Rows[rowindex].Cells[6].Value.ToString();

            Medico medico = new Medico();

            medico.Codm = int.Parse(codm);
            medico.Nome = nome;
            medico.Idade = int.Parse(idade);
            medico.Especialidade = especialidade;
            medico.Cpf = cpf;
            medico.Cidade = cidade;
            medico.Nroa = int.Parse(nroa);

            MedicoController controller = new MedicoController();
            controller.Deletar(medico);

            Close();
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            Close();
            MedicoController controller = new MedicoController();
            controller.Listar();
        }

        private void filtrarBtn_Click(object sender, System.EventArgs e)
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
    }
    
}
