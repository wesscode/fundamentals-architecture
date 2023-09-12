namespace SOLID.DIP.Violacao
{
    public class ClienteService //módulo alto nv
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            /*
              Se o clienteRepository mudar o ClienteService muda. Service não deve ser obrigado a saber como criar uma instância de repository.
             */
            var repo = new ClienteRepository(); //módulo baixo nv
            repo.AdicionarCliente(cliente);

            EmailServices.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}