# Fundamentos arquitetura de software
projeto para fins de estudo sobre o ecossitema de arquitetura de software.


## Pilares fundamentais da OOP
- Estado
- Comportamento
- Abstração
- Herança
- Polimorfismo
- Encapsulamento

*"Na orientação a objetos devemos sempre buscar o baixo acoplamento e a alta coesão entre os objetos."* <br>
**Acoplamento:** Uma dependência direta entre um objeto e outro. Quando um objeto muda o outro muda por consequência.<br>
**Coesão:** Objetos executando uma única responsabilidade livre de uma dependência direta com um outro objeto.

## Princípios S.O.L.I.D
- **SRP:** Single responsability principle.
    * Uma classe deve ter apenas um/e um motivo para ser modificada.
- **OCP:** Open/Closed principle
    * Entidades de software (classe, módulos, funções, etc) devem estar abertas para *extensão* mas fechadas para *modificações*.
- **LSP:** Liskov substitution principle
    * Se q(x) é uma propriedade demonstrável dos objetos X de tipo T. Então q(x) deve ser verdadeiro para objetos Y de tipo S onde S é um subtipo de T. *subclasses devem ser substituidas por suas superClasses*
- **ISP:** Interface segregation principle
    * Clientes não devem ser forçados a depender de métodos que não usam. *muitas interfaces específicas são melhores que uma interface única*
- **DIP:** Dependency inversion principle
    * Módulos de alto nível, não devem depender de módulos de baixo nível. Ambos devem depender de abstração. Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações. *dependa de uma abstração e não de uma implementação*

*Os princípios SOLID devem ser aplicados para se obter os benefícios da orientação a objeto.*

## Injeção de dependência (DI)

- Entendendo container DI
    * ioc benchmack: <a href="https://www.palmmedia.de/blog/2011/8/30/ioc-container-benchmark-performance-comparison" targer="_blank">👀benchmarks-ioc-dotnet</a>
- Ciclo de vida:
    * Scoped: Criado apenas uma vez por cliente-request.
    * Transiente: A instância  da classe será criada toda vez que for injetada em alguma classe.
    * Singleton: A instância  do objeto é criada e permanece durante todo tempo de execução da aplicação.
- Generics
- Service Locator
- Multiplas implementações

## Clean code

- Simples
- Direto
- Eficiente
- Sem duplicidade
- Elegante
- Feito com cuidado
- Fácil de ler

## Design Patterns
*São padrões de código para soluções de problemas conhecidos. O objetivo não é reinventar a roda e sim aplicar uma solução com um  bom design de código.*

### O padrões estão separados por 3 familias são elas:
- **Criacional:** 
    * Abstract Factory
    * Factory Method
    * Singleton
- **Estrutural:** 
    * Adapter
    * Facade
    * Composite
- **Comportamental:** 
    * Command
    * Strategy
    * Observer
- **Consultar padrões dotnet:**
    * <a href="www.dofactory.com/net/design-patterns" target="_blank">👀click-me</a>

## Estilos arquiteturais
*"Um estilo arquitetural é uma abordagem de como projetar e entregar uma aplicação. Trata-se de cini irganizar os componentes responsáveis de uma arquitetura, como eles irão interagir entre sí e quais aspectos tecnológicos irão atender. Os estilos podem coexistir, onde o mesmo projeto pode possuir mais de um estilo."*

- **Arquitetura monolítica**
    * Onde todo o sistema está acoplado a um só projeto, desde o cliente ao servidor.
- **Arquitetura em camadas**
    * Separação de camadas com suas respectivas responsabilidades
- **Arquitetura rest**
    * estilo cliente, servidor realizando requests.
- **Arquitetura microservices**
    * Granularização dos serviços em várias partes idependentes.
- **Arquitetura SOA**
    * SOA vs Microservices: O estilo é o mesmo porém o micro é quebrado em serviços menores.
- **Arquitetura de plugins(wordpress)**
- **Arquitetura de Client-Servidor**
- **Arquitetura pipe e filters**

## Padrões arquiteturais
*Os padrões arquiteturais são semelhantes aos "Design Patterns", mas possuem um escopo diferente. São estratégias de alto nível que diz respeito a componentes de grande escala as propriedades globais de um sistema. Um projeto de arquitetura pode conter diversos estilos e cada estilo pode utilizar diversos padrões. Um ádrão pode ser um subconjunto de um estilo arquitetural visando um escopo especifico.*

- **Padrão MVC**
- **padrão CQRS**
- **Arquiteura 3 camadas**
    * Onde a mesma é um estilo e um padrão
    * **Estilo: Ao dividir as camadas.**
    * **Padrão: Porque cada camada possuí uma responsabilidade específica.**
- **Arquitetura cebola**
    * Onde a mesma é um estilo e um padrão
    * **Estilo: Separação em camadas.**
    * **Padrão: Forma que ela se comporta e a forma que resolve o problema.** 
- **Arquitetura Port&Adapters(Hexagonal)**
    * Onde a mesma é um estilo e um padrão
    * **Estilo: A forma que é prosposta de como a arquitetura vai trabalhar.**
    * **Padrão: É o catalogo de estilos que ela irá acumular para que essa implementção seja possível.**

## CQRS - Command Query Responsability Segregation