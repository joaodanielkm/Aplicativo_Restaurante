using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace WinFormsApp1
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=C:\\Banco\\bd_restaurante.db");
            //C:\\eRepositorios-\\dbeys\\Banco_restaurante\\C:\\Program Files (x86)\\Aplicativo Restaurante\\Restaurante App\\Banco\\
            conexao.Open();
            return conexao;
        }

        public static DataTable VerificaUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_usuario";
                    da = new SQLiteDataAdapter(cmd.CommandText, conexao);
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                throw new ("Não foi possivel verificar os usuarios no banco de dados",ex);
                

            }
     

        }
        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, conexao);
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                throw new ("Falha na conexão com o banco",ex);
                
            }

        }
    }
}
