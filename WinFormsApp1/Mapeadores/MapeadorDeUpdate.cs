using System.Data;


namespace WinFormsApp1.Mapeadores
{
    internal class MapeadorDeUpdate
    {
        public DataTable ObtemComanda(string pesoDigitado, string tb_diversos_descricao1, string convertePonto11, string valor_diario, string dt_data_atual1) =>
            Banco.consulta($"UPDATE tb_dados SET N_PESO = {pesoDigitado}, T_OUTROSDIVERSOS = '{tb_diversos_descricao1}' , N_OUTROSVALOR = '{convertePonto11}',T_TOTAL_DIARIO = '{valor_diario}' WHERE T_DATA LIKE '{dt_data_atual1}'");
            
    }
}
