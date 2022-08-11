namespace Clinica.Medicos
{
    public class Medico
    {
        public int Codm { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Especialidade { get; set; }
        public string Cpf { get; set; }
        public string Cidade { get; set; }
        public string Nroa { get; set; }

        public override string ToString()
        {
            return Codm + "\n" + Nome + "\n" + Idade + "\n" + Cpf + "\n" + Especialidade + "\n";
        }
    }
}
