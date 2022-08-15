using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Medicos
{
    public class MedicoController
    {
        public void Listar()
        {
            MedicoDAO medicosDAO = new MedicoDAO();
            ArrayList lista = medicosDAO.All();
            MedicosView medicos = new MedicosView(lista);
            medicos.Show();
        }

        public void Criar(object objeto)
        {
            Medico medico = (Medico)objeto;
            MedicoDAO medicoDAO = new MedicoDAO();
            medicoDAO.Create(medico);
            Alterar(medico);
        }

        public void Alterar(object objeto)
        {
            Medico medico = (Medico)objeto;
            MedicosEditarView edicao = new MedicosEditarView(medico);
            edicao.Show();
        }

        public void Salvar(object objeto)
        {
            Medico medico = (Medico)objeto;

            MedicoDAO medicoDAO = new MedicoDAO();

            medico = (Medico)medicoDAO.Update(medico);

            ArrayList todos = medicoDAO.All();

            MedicosView listagem = new MedicosView(todos);

            listagem.Show();
        }

        public void Deletar(Object objeto)
        {
            Medico medico = (Medico)objeto;

            MedicoDAO medicoDAO = new MedicoDAO();
            medicoDAO.Delete(medico);

            new MedicosView(medicoDAO.All()).Show();
        }        
    }
}
