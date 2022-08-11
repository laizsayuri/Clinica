using System;
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
    public partial class AmbulatoriosCriarView : Form
    {
        public AmbulatoriosCriarView()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AmbulatoriosView ambulatorio = new AmbulatoriosView();
            ambulatorio.Show();
            Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Ambulatorio ambulatorio = new Ambulatorio
            {
                Nroa = int.Parse(nroaValor.Text),
                Andar = andarValor.Text,
                Capacidade = int.Parse(capacidadeValor.Text),
            };

            AmbulatoriosEditarView ambulatorioEditar = new AmbulatoriosEditarView(ambulatorio);

            ambulatorioEditar.Show();
            Close();
        }
    }
}
