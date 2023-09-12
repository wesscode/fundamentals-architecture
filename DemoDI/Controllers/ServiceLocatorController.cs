using System;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI.Controllers
{
    public class ServiceLocatorController : Controller
    {
        private readonly IServiceProvider _serviceProvider;

        /*
         * Service locator injetado no construtor.
         Esse padrão deve ser evitado pois é conhecido como uma má pratica por influenciar em uma mal testabilidade etc
        */
        public ServiceLocatorController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Index()
        {
            // Retorna null se não estiver registrado
            _serviceProvider.GetRequiredService<IClienteServices>().AdicionarCliente(new Cliente());
        }
    }
}
