using System.Data;

namespace WinFormsApp1.Mapeadores
{
    internal class MapeadorDeInsert
    {
        public DataTable InsereDadosDaComanda(string dt_data_atual1, string pesoDigitado, string tb_diversos_descricao1, string convertePonto11, string valor_diario) =>
            Banco.consulta($"INSERT INTO tb_dados(T_DATA, N_PESO, T_OUTROSDIVERSOS, N_OUTROSVALOR, T_TOTAL_DIARIO) VALUES('{dt_data_atual1}',{pesoDigitado},'{tb_diversos_descricao1}','{convertePonto11}','{valor_diario}')");
    }
}
