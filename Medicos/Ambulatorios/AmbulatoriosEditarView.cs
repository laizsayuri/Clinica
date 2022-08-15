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

            AmbulatorioController controller = new AmbulatorioController();
            controller.Salvar(ambulatorio);
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AmbulatorioController ambulatorioController = new AmbulatorioController();
            ambulatorioController.Listar();
            Close();
        }
    }
}
