using Clinica.Medicos.Ambulatorios;
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
            AmbulatorioController ambulatorioController = new AmbulatorioController();
            ambulatorioController.Listar();
            Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Ambulatorio ambulatorio = new Ambulatorio
            {
                Andar = andarValor.Text,
                Capacidade = int.Parse(capacidadeValor.Text)
            };

            AmbulatorioController controller = new AmbulatorioController();

            controller.Criar(ambulatorio);
            Hide();
        }
    }
}
