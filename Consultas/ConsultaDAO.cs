using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Consultas
{
    internal class ConsultaDAO : IDAO
    {
        public ArrayList All()
        {
            ArrayList lista = new ArrayList();

            Consulta consulta;

            BancoDeDados bd = new BancoDeDados();

            string sql = "SELECT * FROM consultas order by data, hora desc";

            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    consulta = new Consulta();
                    consulta.Codm = rdr[0] == DBNull.Value ? 0 : int.Parse(rdr[0].ToString());
                    consulta.Codp = rdr[1] == DBNull.Value ? 0 : int.Parse(rdr[1].ToString());
                    consulta.DataHora = DateTime.Parse(rdr[2].ToString().Split(' ')[0] + " " + rdr[3].ToString());                   
                    lista.Add(consulta);
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
            Consulta consulta = (Consulta)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO consultas (codm, codp, data, hora )" +
                    "VALUES (@codm, @codp, @data, @hora )";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codm", consulta.Codm);
                cmd.Parameters.AddWithValue("@codp", consulta.Codp);
                cmd.Parameters.AddWithValue("@data", consulta.DataBanco);
                cmd.Parameters.AddWithValue("@hora", consulta.Hora); 
                cmd.ExecuteNonQuery();
                
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return consulta;
        }

        public object Delete(object chave)
        {
            Consulta consulta = (Consulta)chave;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from consultas where codm = @codm and codp = @codp and data = @data and hora = @hora ";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codm", consulta.Codm);
                cmd.Parameters.AddWithValue("@codp", consulta.Codp);
                cmd.Parameters.AddWithValue("@data", consulta.DataBanco);
                cmd.Parameters.AddWithValue("@hora", consulta.Hora);

                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return consulta;
        }

        public object Read(object chave)
        {
            throw new NotImplementedException();
        }

        public object Update(object objeto)
        {
            throw new NotImplementedException();
        }

        public Consulta Update(Consulta consultaAntiga, Consulta consultaNova)
        {
            Delete(consultaAntiga);
            Create(consultaNova);

            return consultaNova;
        }
    }
}
