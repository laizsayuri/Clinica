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

        public void Criar(object objeto)
        {
            Paciente paciente = (Paciente)objeto;
            PacienteDAO pacienteDAO = new PacienteDAO();
            pacienteDAO.Create(paciente);
            Alterar(paciente);                      
        }

        public void Alterar(object objeto)
        {
            Paciente paciente = (Paciente)objeto;
            PacientesEditarView edicao = new PacientesEditarView(paciente);
            edicao.Show();
        }

        public void Salvar(object objeto)
        {
            Paciente paciente = (Paciente)objeto;

            PacienteDAO pacienteDAO = new PacienteDAO();

            paciente = (Paciente)pacienteDAO.Update(paciente);

            ArrayList todos = pacienteDAO.All();

            PacientesView listagem = new PacientesView(todos);

            listagem.Show();
        }

        public void Deletar(Object objeto)
        {
            Paciente paciente = (Paciente)objeto;

            PacienteDAO pacienteDAO = new PacienteDAO();
            pacienteDAO.Delete(paciente);

            new PacientesView(pacienteDAO.All()).Show();
        }
    }
}
