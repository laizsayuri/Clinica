using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Medicos.Ambulatorios
{
    internal class AmbulatorioDAO : IDAO
    {
        public ArrayList All()
        {
            ArrayList lista = new ArrayList();

            Ambulatorio ambulatorio;

            BancoDeDados bd = new BancoDeDados();

            string sql = "SELECT * FROM ambulatorios order by nroa desc ";

            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ambulatorio = new Ambulatorio();
                    ambulatorio.Nroa = int.Parse(rdr[0].ToString());
                    ambulatorio.Andar = rdr[1].ToString();
                    ambulatorio.Capacidade = int.Parse(rdr[2].ToString());
                    lista.Add(ambulatorio);
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
            Ambulatorio ambulatorio = (Ambulatorio)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO ambulatorios (andar, capacidade)" +
                    "VALUES (@andar, @capacidade )";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@andar", ambulatorio.Andar);
                cmd.Parameters.AddWithValue("@capacidade", ambulatorio.Capacidade);
                
                Console.WriteLine(cmd.CommandText.ToString());
                cmd.ExecuteNonQuery();
                int id = int.Parse(cmd.LastInsertedId.ToString());
                ambulatorio.Nroa = id;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return ambulatorio;
        }

        public object Read(object chave)
        {
            throw new NotImplementedException();
        }

        public object Update(object objeto)
        {
            Ambulatorio ambulatorio = (Ambulatorio)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "update ambulatorios set andar = @andar, capacidade = @capacidade where nroa = @nroa ";

                cmd.Prepare();
                cmd.Parameters.AddWithValue("@andar", ambulatorio.Andar);
                cmd.Parameters.AddWithValue("@capacidade", ambulatorio.Capacidade);
                cmd.Parameters.AddWithValue("@nroa", ambulatorio.Nroa);

                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return ambulatorio;
        }

        public object Delete(object chave)
        {
            Ambulatorio ambulatorio = (Ambulatorio)chave;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from ambulatorios where nroa = @nroa ";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nroa", ambulatorio.Nroa);

                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return ambulatorio;
        }
    }
}
