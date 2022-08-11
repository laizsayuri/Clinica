using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Pacientes
{
    public class PacienteController
    {
        public void Listar()
        {
            PacienteDAO pacientesDAO = new PacienteDAO();
            ArrayList lista = pacientesDAO.All();
            PacientesView pacientes = new PacientesView(lista);
            pacientes.Show();
        }
    }
}
