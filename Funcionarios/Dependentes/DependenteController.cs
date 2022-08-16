using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Funcionarios.Dependentes
{
    public class DependenteController
    {
        public void Listar()
        {
            DependenteDAO dependenteDAO = new DependenteDAO();
            ArrayList lista = dependenteDAO.All();
            DependentesView dependentes = new DependentesView(lista);
            dependentes.Show();
        }

        public void Criar(object objeto)
        {
            Dependente dependente = (Dependente)objeto;
            DependenteDAO dependenteDAO = new DependenteDAO();
            dependenteDAO.Create(dependente);
            Alterar(dependente);
        }

        public void Alterar(object objeto)
        {
            Dependente dependente = (Dependente)objeto;
            DependentesEditarView edicao = new DependentesEditarView(dependente);
            edicao.Show();
        }

        public void Salvar(object objeto)
        {
            Dependente dependente = (Dependente)objeto;

            DependenteDAO dependenteDAO = new DependenteDAO();

            dependente = (Dependente)dependenteDAO.Update(dependente);

            ArrayList todos = dependenteDAO.All();

            DependentesView listagem = new DependentesView(todos);

            listagem.Show();
        }

        public void Deletar(Object objeto)
        {
            Dependente dependente = (Dependente)objeto;

            DependenteDAO dependenteDAO = new DependenteDAO();
            dependenteDAO.Delete(dependente);

            new DependentesView(dependenteDAO.All()).Show();
        }
    }
}
