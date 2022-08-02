using System.Data;
using WinFormsApp1.Negocio;

namespace WinFormsApp1.Mapeadores;

public class MapeadorDeComanda
{
    //simplificar passagem de parametros trocar nome para AtualizaComanda - ajustar referencias
    public DataTable ObtemComanda(string pesoDigitado, string tb_diversos_descricao1, string convertePonto11, string valor_diario, string dt_data_atual1) =>
        Banco.consulta($"UPDATE tb_dados SET N_PESO = {pesoDigitado}, T_OUTROSDIVERSOS = '{tb_diversos_descricao1}' , N_OUTROSVALOR = '{convertePonto11}',T_TOTAL_DIARIO = '{valor_diario}' WHERE T_DATA LIKE '{dt_data_atual1}'");

    public List<Comanda> ObtenhaComandas()
    {
        List<Comanda> comandas = new();

        string sql = @"select 
                     T_DATA as 'Data',
                     iif(N_PESO = 0, '', N_PESO || ' Kg') as 'Peso',
                     T_OUTROSDIVERSOS as 'Descricao outros valores',
                     iif(CAST(N_OUTROSVALOR AS NUMERIC (17,8)) <= 0  , '' ,  'R$ '|| REPLACE(N_OUTROSVALOR, '.', ',' ) )as 'Outros VLR',
                     iif (CAST(T_TOTAL_DIARIO AS NUMERIC (17,8)) <= 0 , '' , 'R$ '||  replace(T_TOTAL_DIARIO, '.',',') ) as 'valor total diario'
                     from tb_dados";

        DataTable dt = Banco.consulta(sql);

        foreach(DataRow item in dt.Rows)
        {
            Comanda comanda = new Comanda()
            {
                pesoDigitado = item.Field<string>("Peso"),
                convertePonto11 = item.Field<string>("Outros VLR"),
                dt_data_atual1 = item.Field<string>("Data"),
                tb_diversos_descricao1 = item.Field<string>("Descricao outros valores"),
                valor_diario = item.Field<string>("valor total diario")
            };

            comandas.Add(comanda);
        }

        return comandas;
    }

    public DataTable ObtemComanda(Comanda comanda) =>
        Banco.consulta($"UPDATE tb_dados SET N_PESO = {comanda.pesoDigitado}, T_OUTROSDIVERSOS = '{comanda.tb_diversos_descricao1}' , N_OUTROSVALOR = '{comanda.convertePonto11}',T_TOTAL_DIARIO = '{comanda.valor_diario}' WHERE T_DATA LIKE '{comanda.dt_data_atual1}'");

    //simplificar passagem de parametros - ajustar referências
    public DataTable InsereDadosDaComanda(string dt_data_atual1, string pesoDigitado, string tb_diversos_descricao1, string convertePonto11, string valor_diario) =>
            Banco.consulta($"INSERT INTO tb_dados(T_DATA, N_PESO, T_OUTROSDIVERSOS, N_OUTROSVALOR, T_TOTAL_DIARIO) VALUES('{dt_data_atual1}',{pesoDigitado},'{tb_diversos_descricao1}','{convertePonto11}','{valor_diario}')");

    public void InsereDadosDaComanda(Comanda comanda)
    {
        Banco.consulta($"INSERT INTO tb_dados(T_DATA, N_PESO, T_OUTROSDIVERSOS, N_OUTROSVALOR, T_TOTAL_DIARIO) VALUES('{comanda.dt_data_atual1}',{comanda.pesoDigitado},'{comanda.tb_diversos_descricao1}','{comanda.convertePonto11}','{comanda.valor_diario}')");
    }
}
