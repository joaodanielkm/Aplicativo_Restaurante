using System.Data;

namespace WinFormsApp1.Mapeadores;

public class MapeadorDeLogin
{
    public string ObtenhaLogins(string username, string senha)
    {
        var dt = Banco.consulta($"SELECT * FROM tb_usuario WHERE T_USERNAME = '{username}' AND T_SENHA = '{senha}'");

            
        return dt.Rows[0].Field<string>("T_NOMEUSUARIO");
    }
}
