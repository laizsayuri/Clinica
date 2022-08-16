using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Funcionarios.Dependentes
{
    internal class DependenteDAO : IDAO
    {
        public ArrayList All()
        {
            ArrayList lista = new ArrayList();

            Dependente dependente;

            BancoDeDados bd = new BancoDeDados();

            string sql = "SELECT * FROM dependetes order by codd desc ";

            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dependente = new Dependente();
                    dependente.Codd = int.Parse(rdr[0].ToString());
                    dependente.Nome = rdr[1].ToString();
                    dependente.DataNascimento = DateTime.Parse(rdr[2].ToString());
                    dependente.Codf = int.Parse((rdr[3].ToString()).ToString());
                    lista.Add(dependente);
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
            Dependente dependente = (Dependente)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO dependetes (nome, nascimento, codf)" +
                    "VALUES (@nome, @nascimento, @codf )";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", dependente.Nome);
                cmd.Parameters.AddWithValue("@nascimento", dependente.DataNascimento);
                cmd.Parameters.AddWithValue("@codf", dependente.Codf);

                Console.WriteLine(cmd.CommandText.ToString());
                cmd.ExecuteNonQuery();
                int id = int.Parse(cmd.LastInsertedId.ToString());
                dependente.Codd = id;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return dependente;
        }

        public object Delete(object chave)
        {
            Dependente dependente = (Dependente)chave;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from dependetes where codd = @codd ";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codd", dependente.Codd);

                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return dependente;
        }

        public object Read(object chave)
        {
            throw new NotImplementedException();
        }

        public object Update(object objeto)
        {
            Dependente dependente = (Dependente)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "update dependetes set nome = @nome, nascimento = @nascimento, codf = @codf where codd = @codd ";

                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", dependente.Nome);
                cmd.Parameters.AddWithValue("@nascimento", dependente.DataNascimento);
                cmd.Parameters.AddWithValue("@codf", dependente.Codf);
                cmd.Parameters.AddWithValue("@codd", dependente.Codd);

                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return dependente;
        }
    }
}
