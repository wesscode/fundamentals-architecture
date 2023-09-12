using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class FromServicesController : Controller
    {
        /*
            Em caso de uma necessidade de não poder mexer no construtor,
            realizamos a injeção pro propriedade. Porém a melhor forma e indicada é pelo o construtor.
         */
        public void Index([FromServices] IClienteServices clienteServices) //Injeção de dependência por parâmetro.
        {
            clienteServices.AdicionarCliente(new Cliente());
        }
    }
}