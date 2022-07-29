using System.Data;
using WinFormsApp1.Mapeadores;

namespace WinFormsApp1.Processos;

public class ProcessoLogin
{
    
    public DataTable ObtenhaLogins(string username, string senha) =>
        new MapeadorDeLogin().ObtenhaLogins(username, senha);

    //public PDF ImprimaLoguins
    //     => var logins = Mapeador.ObtenhaLogins(usr,pass)
    //          Montador.EmitaLogints(logins)

    //public void CadastreLogin()
}
