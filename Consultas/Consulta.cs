using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Consultas
{
    public class Consulta
    {
        public int Codm { get; set; }
        public string Codp{ get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        

        public override string ToString()
        {
            return Codm + "\n" + Codp + "\n" + Data + "\n" + Hora + "\n";
        }
    }
}
