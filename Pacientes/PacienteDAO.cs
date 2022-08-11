using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Pacientes
{
    internal class PacienteDAO : IDAO
    {
        public ArrayList All()
        {
            ArrayList lista = new ArrayList();
            Paciente paciente;
            BancoDeDados bd = new BancoDeDados();
            string sql = "SELECT * FROM pacientes";
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    paciente = new Paciente();
                    paciente.Codp = int.Parse(rdr[0].ToString());
                    paciente.Nome = rdr[1].ToString();
                    paciente.Idade = int.Parse(rdr[2].ToString());
                    paciente.Cpf = rdr[3].ToString();
                    paciente.Cidade = rdr[4].ToString();
                    paciente.Doenca = rdr[5].ToString();
                    lista.Add(paciente);

                }
                rdr.Close();
            }
            catch
            {
                throw;
            }
            return lista;
        }

        public object Create(object objeto)
        {
            throw new NotImplementedException();
        }

        public object Delete(object objeto)
        {
            throw new NotImplementedException();
        }

        public object Read(object chave)
        {
            throw new NotImplementedException();
        }

        public object Update(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
