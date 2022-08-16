using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Funcionarios
{
    public class FuncionarioController
    {
        public void Listar()
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            ArrayList lista = funcionarioDAO.All();
            FuncionariosView funcionarios = new FuncionariosView(lista);
            funcionarios.Show();
        }

        public void Criar(object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            funcionarioDAO.Create(funcionario);
            Alterar(funcionario);
        }

        public void Alterar(object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;
            FuncionariosEditarView edicao = new FuncionariosEditarView(funcionario);
            edicao.Show();
        }

        public void Salvar(object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;

            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            funcionario = (Funcionario)funcionarioDAO.Update(funcionario);

            ArrayList todos = funcionarioDAO.All();

            FuncionariosView listagem = new FuncionariosView(todos);

            listagem.Show();
        }

        public void Deletar(Object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;

            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            funcionarioDAO.Delete(funcionario);

            new FuncionariosView(funcionarioDAO.All()).Show();
        }
    }
}
