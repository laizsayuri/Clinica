using Clinica.Medicos;
using Clinica.Pacientes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Consultas
{
    public class ConsultaController : IController
    {
        public void Listar()
        {
            ConsultaDAO consultaDAO = new ConsultaDAO();
            ArrayList lista = consultaDAO.All();
            ConsultasView consultas = new ConsultasView(lista);
            consultas.Show();
        }

        public void Criar(object objeto)
        {
            Consulta consulta = (Consulta)objeto;
            ConsultaDAO consultaDAO = new ConsultaDAO();
            consultaDAO.Create(consulta);

            ArrayList lista = consultaDAO.All();

            ConsultasView tela = new ConsultasView(lista);
            tela.Show();
        }

        public void Alterar(object objeto)
        {
            Consulta consulta = (Consulta)objeto;
            PacienteDAO pacienteDAO = new PacienteDAO();
            MedicoDAO medicoDAO = new MedicoDAO();
            ArrayList pacientes, medicos;
            medicos = medicoDAO.All();
            pacientes = pacienteDAO.All();
            ConsultasEditarView edicao = new ConsultasEditarView(consulta, medicos, pacientes);
            edicao.Show();
        }

        public void preparaCriacao()
        {
            PacienteDAO pacienteDAO = new PacienteDAO();
            MedicoDAO medicoDAO = new MedicoDAO();
            ArrayList pacientes, medicos;
            medicos = medicoDAO.All();
            pacientes = pacienteDAO.All();
            ConsultasCriarView tela = new ConsultasCriarView(medicos, pacientes);
            tela.Show();
        }


        public void Deletar(Object objeto)
        {
            Consulta consulta = (Consulta)objeto;

            ConsultaDAO consultaDAO = new ConsultaDAO();
            consultaDAO.Delete(consulta);

            new ConsultasView(consultaDAO.All()).Show();
        }

        public void Salvar(Consulta objetoAntigo, Consulta objetoNovo)
        {
            ConsultaDAO consultaDAO = new ConsultaDAO();

            Consulta consulta = (Consulta)consultaDAO.Update(objetoAntigo, objetoNovo);

            ArrayList todos = consultaDAO.All();

            ConsultasView listagem = new ConsultasView(todos);

            listagem.Show();
        }

        public void Salvar(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
