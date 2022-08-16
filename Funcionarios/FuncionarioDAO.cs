using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Funcionarios
{
    internal class FuncionarioDAO : IDAO
    {
        public ArrayList All()
        {
            ArrayList lista = new ArrayList();

            Funcionario funcionario;

            BancoDeDados bd = new BancoDeDados();

            string sql = "SELECT * FROM funcionarios order by codf desc";

            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    funcionario = new Funcionario();
                    funcionario.Codf = int.Parse(rdr[0].ToString());
                    funcionario.Nome = rdr[1].ToString();
                    funcionario.Idade = int.Parse(rdr[2].ToString());
                    funcionario.Cpf = rdr[3].ToString();
                    funcionario.Cidade = rdr[4].ToString();
                    funcionario.Salario = decimal.Parse(rdr[5].ToString());
                    funcionario.Cargo = rdr[6].ToString();
                    
                    lista.Add(funcionario);
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
            Funcionario funcionario = (Funcionario)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO funcionarios (nome, idade, cpf, cidade, salario, cargo )" +
                    "VALUES (@nome, @idade, @cpf, @cidade, @salario, @cargo )";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@idade", funcionario.Idade);
                cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);                
                cmd.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                cmd.Parameters.AddWithValue("@salario", funcionario.Salario);
                cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);

                Console.WriteLine(cmd.CommandText.ToString());
                cmd.ExecuteNonQuery();
                int id = int.Parse(cmd.LastInsertedId.ToString());
                funcionario.Codf = id;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return funcionario;
        }

        public object Delete(object chave)
        {
            Funcionario funcionario = (Funcionario)chave;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from funcionarios where codf = @codf ";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codf", funcionario.Codf);

                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return funcionario;
        }

        public object Read(object chave)
        {
            throw new NotImplementedException();
        }

        public object Update(object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "update funcionarios set nome = @nome, " +
                    "idade = @idade," +
                    "cpf = @cpf, " +
                    "cidade = @cidade, " +
                    "salario = @salario, " + 
                    "cargo = @cargo " +
                    "where codf = @codf ";

                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@idade", funcionario.Idade);
                cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                cmd.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                cmd.Parameters.AddWithValue("@salario", funcionario.Salario);
                cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                cmd.Parameters.AddWithValue("@codf", funcionario.Codf);

                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return funcionario;
        }
    }
}
