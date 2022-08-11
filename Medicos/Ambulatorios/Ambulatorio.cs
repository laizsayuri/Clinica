using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Medicos
{
    public class Ambulatorio
    {
        public int Nroa { get; set; }
        public string Andar { get; set; }
        public int Capacidade { get; set; }      

        public override string ToString()
        {
            return Nroa + "\n" + Andar + "\n" + Capacidade + "\n";
        }
    }
}
