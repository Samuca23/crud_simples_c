using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confin.Controle
{
    public class Conexao
    {
        public static NpgsqlConnection getConexao()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = new NpgsqlConnection("server=localhost; port=5432;user id=postgres; password=postgres;database=financeiro");
                conexao.Open();
                Console.WriteLine("Conexao OK");
            }catch(Exception e)
            {
                Console.WriteLine("Erro ao conectar ao banco: " + e.Message);
            }

            return conexao;
        }

        public static void setFechaConexao(NpgsqlConnection conexao)
        {
            if(conexao != null)
            {
                try
                {
                    conexao.Close();
                    Console.WriteLine("Fechou");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao fechar conexão do banco: " + e.Message);
                }
            }
        }
    }
}
