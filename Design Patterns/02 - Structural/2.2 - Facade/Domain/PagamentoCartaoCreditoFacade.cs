﻿namespace DesignPatterns
{

    /*
        Classe facade onde isola toda a integração com o meio de pagamento, 
        E se eventualmente mudar a forma de pagamento, todo o código de manutenção está centralizado nessa classe.
     */
    public class PagamentoCartaoCreditoFacade : IPagamentoCartaoCreditoFacade
    {
        private readonly IPayPalGateway _payPalGateway; //metodos de pagamento da integração.0
        private readonly IConfigurationManager _configManager; //arquivo de property

        public PagamentoCartaoCreditoFacade(IPayPalGateway payPalGateway, IConfigurationManager configManager)
        {
            _payPalGateway = payPalGateway;
            _configManager = configManager;
        }

        public bool RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            var apiKey = _configManager.GetValue("apiKey");
            var encriptionKey = _configManager.GetValue("encriptionKey");

            var serviceKey = _payPalGateway.GetPayPalServiceKey(apiKey, encriptionKey);
            var cardHashKey = _payPalGateway.GetCardHashKey(serviceKey, pagamento.CartaoCredito);

            var pagamentoResult = _payPalGateway.CommitTransaction(cardHashKey, pedido.Id.ToString(), pagamento.Valor);

            return pagamentoResult;
        }
    }
}