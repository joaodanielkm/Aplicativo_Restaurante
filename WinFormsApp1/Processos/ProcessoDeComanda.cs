using WinFormsApp1.Mapeadores;
using WinFormsApp1.Negocio;

namespace WinFormsApp1.Processos;

public class ProcessoDeComanda
{
    private MapeadorDeComanda mapeador = new();

    public void InsiraComanda(Comanda comanda)
    {
        if (comanda.pesoDigitado == null)
        {
            throw new Exception("Peso invalido");
        }

        try
        {
            mapeador.InsereDadosDaComanda(comanda);
        }
        catch (Exception ex)
        {
            //Exibir mensagem de falha na tela para o usuário tentar novamente
        }
        
    }

    public List<Comanda> ObtenhaComandas() => mapeador.ObtenhaComandas();
}
