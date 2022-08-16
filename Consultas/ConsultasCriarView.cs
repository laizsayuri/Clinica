using Clinica.Medicos;
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
    public partial class ConsultasCriarView : Form
    {
        public ConsultasCriarView()
        {
            InitializeComponent();
        }

        public ConsultasCriarView(ArrayList medicos, ArrayList pacientes)
        {
            InitializeComponent();
            foreach (Medico m in medicos)
                this.medicos_combo.Items.Add(m.Codm + " - " + m.Nome);
            foreach (Paciente p in pacientes)
                this.pacientes_combo.Items.Add(p.Codp + " - " + p.Nome);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConsultaController consultaController = new ConsultaController();
            consultaController.Listar();
            Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            ConsultaController controller = new ConsultaController();
            string medico = this.medicos_combo.SelectedItem.ToString();
            string paciente = this.pacientes_combo.SelectedItem.ToString();
            DateTime dataHora = this.dataHoraConsulta.Value;

            Medico m = new Medico();
            Paciente p = new Paciente();

            m.Codm = int.Parse(medico.Split(' ')[0]);
            p.Codp = int.Parse(paciente.Split(' ')[0]);

            Consulta consulta = new Consulta();
            consulta.Medico = m;
            consulta.Paciente = p;
            consulta.DataHora = dataHora;
            controller.Criar(consulta);
            Close();
        }
    }
}
