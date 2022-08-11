using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Medicos
{
    internal class MedicoDAO : IDAO
    {
        public ArrayList All()
        {
            ArrayList lista = new ArrayList();

            Medico medico;

            BancoDeDados bd = new BancoDeDados();

            string sql = "SELECT * FROM medicos order by codm desc";

            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    medico = new Medico();
                    medico.Codm = int.Parse(rdr[0].ToString());
                    medico.Nome = rdr[1].ToString();
                    medico.Idade = int.Parse(rdr[2].ToString());
                    medico.Especialidade = rdr[3].ToString();
                    medico.Cpf = rdr[4].ToString();
                    medico.Cidade = rdr[5].ToString();
                    medico.Nroa = rdr[6] == DBNull.Value ? 0 : int.Parse(rdr[6].ToString());
                    lista.Add(medico);
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
            Medico medico = (Medico)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO medicos (nome, idade, especialidade, cidade, cpf, nroa)" +
                    "VALUES (@nome, @idade, @especialidade, @cidade, @cpf, @nroa )";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", medico.Nome);
                cmd.Parameters.AddWithValue("@idade", medico.Idade);
                cmd.Parameters.AddWithValue("@especialidade", medico.Especialidade);
                cmd.Parameters.AddWithValue("@cidade", medico.Cidade);
                cmd.Parameters.AddWithValue("@cpf", medico.Cpf);
                cmd.Parameters.AddWithValue("@nroa", (medico.Nroa == 0 ? (object)DBNull.Value : medico.Nroa));
                
                Console.WriteLine(cmd.CommandText.ToString());
                cmd.ExecuteNonQuery();
                int id = int.Parse(cmd.LastInsertedId.ToString());
                medico.Codm = id;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return medico;
        }

        public object Read(object chave)
        {
            throw new NotImplementedException();
        }

        public object Update(object objeto)
        {
            Medico medico = (Medico)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "update medicos set nome = @nome, " +
                    "idade = @idade," +
                    "especialidade = @especialidade, " +
                    "cidade = @cidade, " +
                    "cpf = @cpf, " +
                    "nroa = @nroa " +
                    "where codm = @codm ";

                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", medico.Nome);
                cmd.Parameters.AddWithValue("@idade", medico.Idade);
                cmd.Parameters.AddWithValue("@especialidade", medico.Especialidade);
                cmd.Parameters.AddWithValue("@cidade", medico.Cidade);
                cmd.Parameters.AddWithValue("@cpf", medico.Cpf);
                cmd.Parameters.AddWithValue("@nroa", (medico.Nroa == 0 ? (object)DBNull.Value : medico.Nroa));
                cmd.Parameters.AddWithValue("@codm", medico.Codm);

                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return medico;
        }

        public object Delete(object chave)
        {
            Medico medico = (Medico)chave;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from medicos where codm = @codm ";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codm", medico.Codm);

                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return medico;
        }
    }
}
