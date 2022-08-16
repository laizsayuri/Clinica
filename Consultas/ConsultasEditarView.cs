using Clinica.Medicos;
using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Clinica.Consultas
{
    public partial class ConsultasEditarView : Form
    {
        private Consulta consultaBase;

        public ConsultasEditarView(Consulta consulta, ArrayList medicos, ArrayList pacientes)
        {
            InitializeComponent();
            consultaBase = consulta;

            foreach (Medico m in medicos)
                codigoMValor.Items.Add(m.Codm + " - " + m.Nome);

            foreach (Paciente p in pacientes)
                codPValor.Items.Add(p.Codp + " - " + p.Nome);

            var medicoIndex = medicos.IndexOf(medicos.Cast<Medico>().ToList().First(x => x.Codm == consulta.Medico.Codm));
            var pacienteIndex = pacientes.IndexOf(pacientes.Cast<Paciente>().ToList().First(x => x.Codp == consulta.Paciente.Codp));

            codigoMValor.SelectedIndex = medicoIndex;
            codPValor.SelectedIndex = pacienteIndex;

            dataHoraConsulta.Value = consulta.DataHora; 
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            ConsultaController controller = new ConsultaController();

            string medico = codigoMValor.Text;
            string paciente = codPValor.Text;
            DateTime dataHora = dataHoraConsulta.Value;        
            

            Medico m = new Medico();
            Paciente p = new Paciente();

            m.Codm = int.Parse(medico.Split(' ')[0]);
            p.Codp = int.Parse(paciente.Split(' ')[0]);

            Consulta consulta = new Consulta();
            consulta.Medico = m;
            consulta.Paciente = p;
            consulta.DataHora = dataHora;
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
