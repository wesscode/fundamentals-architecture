using System;
using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI.Controllers
{
    public class ServiceLocator2Controller : Controller
    {

        /*
         * Service locator injetado na propriedade.
         * Service Locator: Serviço do container de DI do dotnet onde lá está a instância de todos objetos registrados.
         Esse padrão deve ser evitado pois é conhecido como uma má pratica por influenciar em uma mal testabilidade etc*/
        public void Index([FromServices] IServiceProvider serviceProvider)
        {
            // Retorna null se não estiver registrado
            serviceProvider.GetRequiredService<IClienteServices>().AdicionarCliente(new Cliente());
        }
    }
}