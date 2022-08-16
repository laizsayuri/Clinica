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

namespace Clinica.Consultas
{
    public partial class ConsultasEditarView : Form
    {
        private Consulta consultaBase;

        public ConsultasEditarView(Consulta consulta)
        {
            InitializeComponent();
            consultaBase = consulta;

            codigoMValor.Text = consulta.Codm.ToString();
            codPValor.Text = consulta.Codp.ToString();
            dataValor.Value = consulta.DataHora;                
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
            controller.Salvar(consultaBase, consulta);
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConsultaController consultaController = new ConsultaController();
            consultaController.Listar();
            Close();
        }
    }
}
