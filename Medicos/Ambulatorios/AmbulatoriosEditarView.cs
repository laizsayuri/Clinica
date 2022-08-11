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
    public partial class AmbulatoriosEditarView : Form
    {
        public AmbulatoriosEditarView(Ambulatorio ambulatorio)
        {
            InitializeComponent();

            nroaValor.Text = ambulatorio.Nroa.ToString();
            andarValor.Text = ambulatorio.Andar;
            capacidadeValor.Text = ambulatorio.Capacidade.ToString();                       

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Ambulatorio ambulatorio = new Ambulatorio
            {
                Nroa = int.Parse(nroaValor.Text),
                Andar = andarValor.Text,
                Capacidade = int.Parse(capacidadeValor.Text),                
            };

            ArrayList ambulatorios = new ArrayList();
            ambulatorios.Add(ambulatorio);

            AmbulatoriosView listagem = new AmbulatoriosView(ambulatorios);
            listagem.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AmbulatoriosView ambulatorio = new AmbulatoriosView();
            ambulatorio.Show();
            Close();
        }
    }
}
