using Clinica.Medicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Consultas
{
    public class Consulta
    {
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public DateTime DataHora { get; set; }
        public string Data { get
            {
                return DataHora.ToString("dd/MM/yyyy");
            } }

        public string Hora { get
            {
                return DataHora.ToString("HH:mm:ss");
            } }


        public string DataBanco
        {
            get
            {
                return DataHora.ToString("yyyy-MM-dd");
            }
        }

        public Consulta()
        {
            Paciente = new Paciente();
            Medico = new Medico();
        }
        
    }
}
