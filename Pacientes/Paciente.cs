namespace Clinica
{
    internal class Paciente : object
    {
        public int Codp { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Cidade { get; set; }
        public string Doenca { get; set; }

        public override string ToString()
        {
            return this.Codp + "\n" + this.Nome + "\n" + this.Idade + "\n" + this.Cpf + "\n";
        }
    }
}
