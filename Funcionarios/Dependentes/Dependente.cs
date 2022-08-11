using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Funcionarios
{
    public  class Dependente
    {
        public int Codd { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Codf { get; set; }
        
        public override string ToString()
        {
            return Codd + "\n" + Nome + "\n" + DataNascimento + "\n" + Codf + "\n";
        }
    }
}

