namespace DemoDI.Cases
{
    /*
     * Violação do Princípio ISP(Interface segregation principle): cada classe devia ter sua interface especializada.
     * Violação do Princípio LSP(Liskov Substitution Principle): Possui ambiguidade no código tendo em vista Herança que não deveria existir.
     * E isso é sinal que seu Design não foi bem definido.
     */

    //Buscando um serviço baseado em chave.

    public interface IService
    {
        string Retorno();
    }
    public class ServiceA : IService { 
        public string Retorno()
        {
            return "A";
        }
    }
    public class ServiceB : IService {
        public string Retorno()
        {
            return "B";
        }
    }
    public class ServiceC : IService {
        public string Retorno()
        {
            return "C";
        }
    }
}