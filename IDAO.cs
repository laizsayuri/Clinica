using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal interface IDAO
    {
        ArrayList All();
        Object Create(object objeto);
        Object Read (object chave);
        Object Update(object objeto);
        Object Delete (object chave);      
    }
}
