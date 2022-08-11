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

            string sql = "SELECT * FROM pacientes order by codp desc";

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
            Paciente paciente  =  (Paciente)  objeto;
            BancoDeDados  bd  =  new  BancoDeDados();
            MySqlConnection  conn  =  bd.conectar();
            MySqlCommand  cmd  =  new  MySqlCommand();

            try 
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO pacientes (nome, idade, cidade, cpf, doenca)" +
                    "VALUES (@nome, @idade, @cidade, @cpf, @doenca)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", paciente.Nome);
                cmd.Parameters.AddWithValue("@idade", paciente.Idade);
                cmd.Parameters.AddWithValue("@cidade", paciente.Cidade);
                cmd.Parameters.AddWithValue("@cpf", paciente.Cpf);
                cmd.Parameters.AddWithValue("@doenca", paciente.Doenca);
                Console.WriteLine(cmd.CommandText.ToString());
                cmd.ExecuteNonQuery();
                int id = int.Parse(cmd.LastInsertedId.ToString());
                paciente.Codp = id;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return paciente;
        }

        public object Delete(object chave)
        {
            Paciente paciente = (Paciente)chave;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from pacientes " + "where codp = @codp";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codp", paciente.Codp);
                
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return paciente;
        }

        public object Read(object chave)
        {
            throw new NotImplementedException();
        }

        public object Update(object objeto)
        {
            Paciente paciente = (Paciente)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "update pacientes set nome=@nome," +
                    "idade = @idade," +
                    "cidade = @cidade, " +
                    "cpf = @cpf, " +
                    "doenca = @doenca " +
                    "where codp = @codp ";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", paciente.Nome);
                cmd.Parameters.AddWithValue("@idade", paciente.Idade);
                cmd.Parameters.AddWithValue("@cidade", paciente.Cidade);
                cmd.Parameters.AddWithValue("@cpf", paciente.Cpf);
                cmd.Parameters.AddWithValue("@doenca", paciente.Doenca);
                cmd.Parameters.AddWithValue("@codp", paciente.Codp);
                
                cmd.ExecuteNonQuery();                
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return paciente;
        }
    }
}
