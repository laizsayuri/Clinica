using Clinica.Medicos;
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
            AmbulatoriosView tela = new AmbulatoriosView();
            tela.Show();
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
    }
    
}
