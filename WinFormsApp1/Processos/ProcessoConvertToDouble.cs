using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Processos
{
    internal class ProcessoConvertToDouble
    {
        public double[] ConvertToDouble(string l_vlr_peso_atual1, string pesoDigitado, string pagoEmpresa)
        {
            double[] valorDouble = new[] { Convert.ToDouble(l_vlr_peso_atual1), Convert.ToDouble(pesoDigitado), Convert.ToDouble(pagoEmpresa) };
            return valorDouble;
        }
    }
}