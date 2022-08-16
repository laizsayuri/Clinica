using Clinica.Medicos;
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

            string sql = "select m.*, p.*, c.data, c.hora from consultas c " +
                "join pacientes p on p.codp = c.codp " +
                "join medicos m on c.codm = m.codm; ";

            BancoDeDados bd = new BancoDeDados();

            Consulta consulta;            

            Paciente paciente = new Paciente();
            Medico medico = new Medico();
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            //string data, hora;
            int nroa = 0;
            

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    consulta = new Consulta();
                    medico = new Medico();
                    paciente = new Paciente();

                    medico.Codm = int.Parse(rdr[0].ToString());
                    medico.Nome = rdr[1].ToString();
                    medico.Idade = int.Parse(rdr[2].ToString());
                    medico.Especialidade = rdr[3].ToString();
                    medico.Cpf = rdr[4].ToString();
                    medico.Cidade = rdr[5].ToString();
                    int.TryParse(rdr[6].ToString(), out nroa);
                    medico.Nroa = nroa;
                    paciente.Codp = int.Parse(rdr[7].ToString());
                    paciente.Nome = rdr[8].ToString();
                    paciente.Idade = int.Parse(rdr[9].ToString());
                    paciente.Cpf = rdr[10].ToString();
                    paciente.Cidade = rdr[11].ToString();
                    paciente.Doenca = rdr[12].ToString();
                    consulta.DataHora = DateTime.Parse(rdr[13].ToString().Split(' ')[0] + " " + rdr[14].ToString());
                    consulta.Medico = medico;
                    consulta.Paciente = paciente;
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
                cmd.Parameters.AddWithValue("@codm", consulta.Medico.Codm);
                cmd.Parameters.AddWithValue("@codp", consulta.Paciente.Codp);
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
                cmd.Parameters.AddWithValue("@codm", consulta.Medico.Codm);
                cmd.Parameters.AddWithValue("@codp", consulta.Paciente.Codp);
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
