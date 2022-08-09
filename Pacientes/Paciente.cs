namespace Clinica
{
    public class Paciente
    {
        public int Codp { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Cidade { get; set; }
        public string Doenca { get; set; }

        public override string ToString()
        {
            return Codp + "\n" + Nome + "\n" + Idade + "\n" + Cpf + "\n";
        }
    }
}
