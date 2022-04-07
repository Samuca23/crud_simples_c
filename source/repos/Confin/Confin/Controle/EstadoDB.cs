using Confin.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confin.Controle
{
    class EstadoDB
    {
        public static List<Estado> GetEstados(NpgsqlConnection conexao)
        {
            List<Estado> lista = new List<Estado>();
            try
            {
                string sql = "SELECT * " +
                               "FROM estado";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string sigla = (string) dr["est_sigla"];
                    string nome = dr.GetString(1);
                    Estado estado = new Estado(sigla, nome);
                    lista.Add(estado);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de SQL " + e.Message);
            }
            return lista;
        }

        public static bool SetInsereEstado(Estado estado, NpgsqlConnection conexao)
        {
            bool retorno = false;

            try
            {
                string sql = "INSERT INTO estado (est_sigla, nome) VALUES (@sigla, @nome)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@sigla", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.est_sigla;
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.nome;
                int valor = cmd.ExecuteNonQuery();
                if(valor == 1)
                {
                    retorno = true;
                }
            }catch(Exception e)
            {
                Console.WriteLine("Erro de SQL " + e.Message);
            }

            return retorno;
        }

        public static bool SetAlteraEstado(Estado estado, NpgsqlConnection conexao)
        {
            bool retorno = false;

            try
            {
                string sql = "UPDATE estado SET nome = @nome WHERE est_sigla = @sigla " ;
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@sigla", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.est_sigla;
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.nome;
                int valor = cmd.ExecuteNonQuery();
                if (valor == 1)
                {
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de SQL " + e.Message);
            }

            return retorno;
        }

        public static bool SetExcluirEstado(string sigla, NpgsqlConnection conexao)
        {
            bool retorno = false;

            try
            {
                string sql = "DELETE FROM estado WHERE est_sigla = @sigla ";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@sigla", NpgsqlTypes.NpgsqlDbType.Varchar).Value = sigla;
                int valor = cmd.ExecuteNonQuery();
                if (valor == 1)
                {
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de SQL " + e.Message);
            }

            return retorno;
        }
    }
}
