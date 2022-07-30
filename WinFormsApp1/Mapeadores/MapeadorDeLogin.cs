using System.Data;

namespace WinFormsApp1.Mapeadores;

public class MapeadorDeLogin
{
    public DataTable ObtenhaLogins(string username, string senha) =>
        Banco.consulta($"SELECT * FROM tb_usuario WHERE T_USERNAME = '{username}' AND T_SENHA = '{senha}'");
}
