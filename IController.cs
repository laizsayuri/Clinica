using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal interface IController
    {
        void Listar();
        void Criar(object objeto);
        void Alterar(object objeto);
        void Salvar(object objeto);
        void Deletar(object objeto);
    }
}
