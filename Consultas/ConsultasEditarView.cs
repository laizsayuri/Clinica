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
        public ConsultasEditarView(Consulta consulta)
        {
            InitializeComponent();

            codigoMValor.Text = consulta.Codm.ToString();
            codPValor.Text = consulta.Codp.ToString();
            dataValor.Text = consulta.Data.ToString();
            horaValor.Text = consulta.Hora;            
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

            ArrayList consultas = new ArrayList();
            consultas.Add(consulta);

            ConsultasView listagem = new ConsultasView(consultas);
            listagem.Show();
            Close();
        }
    }
}
