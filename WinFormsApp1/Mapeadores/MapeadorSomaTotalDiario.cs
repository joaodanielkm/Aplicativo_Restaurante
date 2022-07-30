using System.Data;

namespace WinFormsApp1.Mapeadores
{
    internal class MapeadorSomaTotalDiario
    {
        public DataTable ObtemSomaTotalDiarioDados() =>
            Banco.consulta("select sum(T_TOTAL_DIARIO) from tb_dados");
    }
}
