using System.Data;

namespace WinFormsApp1.Mapeadores
{
    internal class MapeadorConsultaTodaTabela
    {
        public DataTable ObtemTodaTabelaConfiguracoes() =>
            Banco.consulta("select * from tb_configuracoes");

        public DataTable ObtemTodaTabelaUsuarios() =>
            Banco.consulta("Select * from tb_usuario");

        public DataTable ObtemTodaTabelaDados() =>
            Banco.consulta("Select * from tb_dados");
    }

}
