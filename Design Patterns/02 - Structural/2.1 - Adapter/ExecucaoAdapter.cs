namespace DesignPatterns
{
    public class ExecucaoAdapter
    {
        public static void Executar()
        {
            var pagamentoLogPadrao = new TransacaoService(new Logger());
            pagamentoLogPadrao.RealizarTransacao();

            //Adaptador(LogAdapter), recebe uma injeção de dependência da adaptação(LogNetMasterService).
            var pagamentoLogCustom = new TransacaoService(new LogAdapter(new LogNetMasterService()));
            pagamentoLogCustom.RealizarTransacao();
        }
    }
}