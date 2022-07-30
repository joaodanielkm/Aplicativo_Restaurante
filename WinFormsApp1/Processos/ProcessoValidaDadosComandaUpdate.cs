using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Processos
{
    internal class ProcessoValidaDadosComandaUpdate
    {
        public bool EhObtidoComanda(string pesoDigitado, string tb_diversos_descricao1, string convertePonto11, string valor_diario, string dt_data_atual1) =>
                    !string.IsNullOrEmpty(pesoDigitado) && !string.IsNullOrWhiteSpace(tb_diversos_descricao1) &&
                    !string.IsNullOrWhiteSpace(convertePonto11) && !string.IsNullOrWhiteSpace(valor_diario) && !string.IsNullOrWhiteSpace(dt_data_atual1) && !(valor_diario == "0");

    }
        
}
