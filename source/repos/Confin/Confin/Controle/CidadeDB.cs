using Confin.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confin.Controle
{
    class CidadeDB
    {
        public static List<Cidade> GetCidade(NpgsqlConnection conexao)
        {
            List<Cidade> lista = new List<Cidade>();

            try
            {
                string sSql = "SELECT * FROM cidade";
                NpgsqlCommand cmd = new NpgsqlCommand(sSql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    int cid_codigo = dr.GetInt32(0);
                    string nome = dr.GetString(1);
                    string sigla = dr.GetString(2);
                    Cidade cidade = new Cidade(cid_codigo, nome, sigla);
                    lista.Add(cidade);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de SQL " + e.Message);
            }

            return lista;
        }

        public static bool SetInsereCidade(Cidade cidade, NpgsqlConnection conexao)
        {
            bool retorno = false;

            try
            {
                string sSql = "INSERT INTO cidade (cid_codigo, nome, est_sigla) VALUES (@codigo, @nome, @sigla)";
                NpgsqlCommand cmd = new NpgsqlCommand(sSql, conexao);
                cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = cidade.cid_codigo;
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = cidade.nome;
                cmd.Parameters.Add("@sigla", NpgsqlTypes.NpgsqlDbType.Varchar).Value = cidade.est_sigla;
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

        public static bool SetAlteraCidade(Cidade cidade, NpgsqlConnection conexao)
        {
            bool retorno = false;

            try
            {
                string sSql = "UPDATE cidade SET nome = @nome, est_sigla = @sigla where cid_codigo = @codigo";
                NpgsqlCommand cmd = new NpgsqlCommand(sSql, conexao);
                cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = cidade.cid_codigo;
                cmd.Parameters.Add("@nome",   NpgsqlTypes.NpgsqlDbType.Varchar).Value = cidade.nome;
                cmd.Parameters.Add("@sigla",  NpgsqlTypes.NpgsqlDbType.Varchar).Value = cidade.est_sigla;
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

        public static bool SetExcluiCidade(int codigo, NpgsqlConnection conexao)
        {
            bool retorno = false;

            try
            {
                string sSql = "DELETE FROM cidade WHERE cid_codigo = @codigo";
                NpgsqlCommand cmd = new NpgsqlCommand(sSql, conexao);
                cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = codigo;
                int valor = cmd.ExecuteNonQuery();
                if (valor == 1)
                {
                    retorno = true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro ao excluir Cidade! " + e);
            }

            return retorno;
        }
    }
}
