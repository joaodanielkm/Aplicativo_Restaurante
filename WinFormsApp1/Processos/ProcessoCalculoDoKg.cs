
namespace WinFormsApp1.Processos
{
    internal class ProcessoCalculoDoKg
    {
        public double SomaDoKg(double pesoDigitado, double pesoAtual, double pagoEmpresa) {
            
            double resultadoDaSoma = (pesoDigitado * pesoAtual) / 1000;
            resultadoDaSoma = (resultadoDaSoma - pagoEmpresa);
            return resultadoDaSoma;

        }
    }
}
