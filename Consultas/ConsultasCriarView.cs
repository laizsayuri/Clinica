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
            ConsultasView consulta = new ConsultasView();
            consulta.Show();
            Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta
            {
                Codm = int.Parse(codigoMValor.Text),
                Codp = codPValor.Text,
                Data = dataValor.Text,
                Hora = horaValor.Text,
            };

            ConsultasEditarView consultaEditar = new ConsultasEditarView(consulta);

            consultaEditar.Show();
            Close();
        }
    }
}
