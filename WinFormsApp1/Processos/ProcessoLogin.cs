using System.Data;
using WinFormsApp1.Mapeadores;

namespace WinFormsApp1.Processos;

public class ProcessoLogin
{
    
    public DataTable ObtenhaLogins(string username, string senha) =>
        new MapeadorDeLogin().ObtenhaLogins(username, senha);

}
