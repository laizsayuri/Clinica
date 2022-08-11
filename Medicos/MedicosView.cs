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
            listagem.DataSource = medicos;

            foreach (Medico m in medicos)
            {
                MessageBox.Show(m.ToString());
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
    }
    
}
