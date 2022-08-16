using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Consultas
{
    public class ConsultaController
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
            Alterar(consulta);
        }

        public void Alterar(object objeto)
        {
            Consulta consulta = (Consulta)objeto;
            ConsultasEditarView edicao = new ConsultasEditarView(consulta);
            edicao.Show();
        }

        public void Salvar(Consulta objetoAntigo, Consulta objetoNovo)
        {           

            ConsultaDAO consultaDAO = new ConsultaDAO();

            Consulta consulta = (Consulta)consultaDAO.Update(objetoAntigo, objetoNovo);

            ArrayList todos = consultaDAO.All();

            ConsultasView listagem = new ConsultasView(todos);

            listagem.Show();
        }

        public void Deletar(Object objeto)
        {
            Consulta consulta = (Consulta)objeto;

            ConsultaDAO consultaDAO = new ConsultaDAO();
            consultaDAO.Delete(consulta);

            new ConsultasView(consultaDAO.All()).Show();
        }
    }
}
