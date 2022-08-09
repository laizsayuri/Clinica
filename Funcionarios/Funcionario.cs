namespace Clinica
{
    public class Funcionario
    {
        public int Codf { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Cidade { get; set; }
        public decimal Salario { get; set; }
        public string Cargo { get; set; }

        public override string ToString()
        {
            return Codf + "\n" + Nome + "\n" + Idade + "\n" + Cpf + "\n";
        }
    }
}
