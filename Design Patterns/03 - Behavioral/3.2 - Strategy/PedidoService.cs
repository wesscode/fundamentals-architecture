namespace DesignPatterns
{
    /*
     * Pattern Strategy centralização de código, definido por uma classe genérica que atende as especializações que deriva da mesma interface.
        Objeto especializado definido no momento da instância dessa classe.
     */
    public class PedidoService
    {
        private readonly IPagamento _pagamento;
        
        public PedidoService(IPagamento pagamento)
        {
            _pagamento = pagamento;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            return _pagamento.RealizarPagamento(pedido, pagamento);
        }
    }
}