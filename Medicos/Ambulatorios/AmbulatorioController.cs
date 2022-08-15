using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Medicos.Ambulatorios
{
    public class AmbulatorioController
    {
        public void Listar()
        {
            AmbulatorioDAO ambulatoriosDAO = new AmbulatorioDAO();
            ArrayList lista = ambulatoriosDAO.All();
            AmbulatoriosView ambulatorios = new AmbulatoriosView(lista);
            ambulatorios.Show();
        }

        public void Criar(object objeto)
        {
            Ambulatorio ambulatorio = (Ambulatorio)objeto;
            AmbulatorioDAO ambulatorioDAO = new AmbulatorioDAO();
            ambulatorioDAO.Create(ambulatorio);
            Alterar(ambulatorio);
        }

        public void Alterar(object objeto)
        {
            Ambulatorio ambulatorio = (Ambulatorio)objeto;
            AmbulatoriosEditarView edicao = new AmbulatoriosEditarView(ambulatorio);
            edicao.Show();
        }

        public void Salvar(object objeto)
        {
            Ambulatorio ambulatorio = (Ambulatorio)objeto;

            AmbulatorioDAO ambulatorioDAO = new AmbulatorioDAO();

            ambulatorio = (Ambulatorio)ambulatorioDAO.Update(ambulatorio);

            ArrayList todos = ambulatorioDAO.All();

            AmbulatoriosView listagem = new AmbulatoriosView(todos);

            listagem.Show();
        }

        public void Deletar(Object objeto)
        {
            Ambulatorio ambulatorio = (Ambulatorio)objeto;

            AmbulatorioDAO ambulatorioDAO = new AmbulatorioDAO();
            ambulatorioDAO.Delete(ambulatorio);

            new MedicosView(ambulatorioDAO.All()).Show();
        }
    }
}
