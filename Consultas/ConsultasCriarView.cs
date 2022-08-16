using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.Consultas
{
    public partial class ConsultasCriarView : Form
    {
        public ConsultasCriarView()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConsultaController consultaController = new ConsultaController();
            consultaController.Listar();
            Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta
            {
                Codm = int.Parse(codigoMValor.Text),
                Codp = int.Parse(codPValor.Text),
                DataHora = dataValor.Value,                
            };

            ConsultaController controller = new ConsultaController();

            controller.Criar(consulta);
            Hide();            
        }
    }
}
