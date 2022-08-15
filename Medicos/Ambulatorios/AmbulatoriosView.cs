using Clinica.Medicos.Ambulatorios;
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

namespace Clinica.Medicos
{
    public partial class AmbulatoriosView : Form
    {
        public AmbulatoriosView()
        {
            InitializeComponent();
        }
        public AmbulatoriosView(ArrayList ambulatorios)
        {
            InitializeComponent();
            int x = 0;

            foreach (Ambulatorio a in ambulatorios)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = a.Nroa;
                this.listagem.Rows[x].Cells[1].Value = a.Andar;
                this.listagem.Rows[x].Cells[2].Value = a.Capacidade;                
                x++;
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
            AmbulatoriosCriarView ambulatorioCriar = new AmbulatoriosCriarView();
            ambulatorioCriar.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = listagem.CurrentCell.RowIndex;

            string nroa = listagem.Rows[rowindex].Cells[0].Value.ToString();
            string andar = listagem.Rows[rowindex].Cells[1].Value.ToString();
            string capacidade = listagem.Rows[rowindex].Cells[2].Value.ToString();
            
            Ambulatorio ambulatorio = new Ambulatorio();

            ambulatorio.Nroa = int.Parse(nroa);
            ambulatorio.Andar = andar;
            ambulatorio.Capacidade = int.Parse(capacidade);
            
            AmbulatorioController controller = new AmbulatorioController();
            controller.Alterar(ambulatorio);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = listagem.CurrentCell.RowIndex;

            string nroa = listagem.Rows[rowindex].Cells[0].Value.ToString();
            string andar = listagem.Rows[rowindex].Cells[1].Value.ToString();
            string capacidade = listagem.Rows[rowindex].Cells[2].Value.ToString();

            Ambulatorio ambulatorio = new Ambulatorio();

            ambulatorio.Nroa = int.Parse(nroa);
            ambulatorio.Andar = andar;
            ambulatorio.Capacidade = int.Parse(capacidade);

            AmbulatorioController controller = new AmbulatorioController();
            controller.Deletar(ambulatorio);

            Close();
        }
    }
}
