# Fundamentos arquitetura de software
projeto para fins de estudo sobre o ecossitema de arquitetura de software.


## Pilares fundamentais da OOP
- Estado
- Comportamento
- Abstração
- Herança
- Polimorfismo
- Encapsulamento: Esconder métodos privados da classe para expor outro que faça uso dele. Chamar métodos sem saber como ele funciona internamente.

*"Na orientação a objetos devemos sempre buscar o baixo acoplamento e a alta coesão entre os objetos."* <br>
**Acoplamento:** Uma dependência direta entre um objeto e outro. Quando um objeto muda o outro muda por consequência.<br>
**Coesão:** Objetos executando uma única responsabilidade livre de uma dependência direta com um outro objeto.

## Modificadores de acesso 
 - Public: Não possui acesso restrito.
 - Protected: Apenas a classe que está herdando aquela classe pode acessar aquele método.
 - Internal: Acesso limitado ao assemblie para classes e métodos.
 - Private: Acesso limitado ao assemblie em caso de CLASSE. Limitado a classe em caso de MÉTODO.
 - Private protected: Acesso limitados ao mesmo assemblie E Acesso limitado a classes que estão derivando dela *somente para métodos*
 - Protected internal: Acesso limitado a classes que estão derivando dela OU Acesso limitados ao mesmo assemblie. *somente para métodos*

 - Sealed: Classe selada nunca pode ser herdada. Somente instânciada.

## Classe Abstrata Vs Interface
- Interface:
    - Contrato simples, onde se você está querendo usar essa interface você precisa implementar todos os métodos dela.
    - Obriga a quem herdar realizar a implementação dos seus métodos expostos.

- Classe abstrata:
    - Além de obrigar a implementar os métodos abstratos a classe abstrata também possui comportamentos que podem ser derivados.

## Interface Vs Implementação
- **Interface:** Diminui o acoplamento devida a baixa dependência e aumenta a coesão. Onde a classe passa a depender da abstração e não mais da implementação.

- **Implementação:** Utilizar classes concretas no meio de um código que faz outras coisas. Onde gera um relacionalmento direto da classe que está implementando para a classe que está sendo implementa, esse é um caso de alto acoplamento.

*"Sempre prefira depender de abstrações(interface) invés de implementações. A classe que precisa instanciar suas dependências, ela mesmo se resolver, não passar a responsabilidade para quem ta querendo usa-la."* 

## Herança Vs Composição
*É interessante realizar uma avaliação se a classe abtraída É A classe especializada ou seja, se a classe especializada utiliza todos os comportamentos da sua abstração, somente ai deve ser feito uma Herança no mais opte por uma composição.*

- **Herança:** Alto acoplamento e herda expõe todos os comportamentos da classe abstraída.
- **Composição:** Só utiliza o necessário na classe que está sendo composta, baixo acoplamento.

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
    * ioc benchmack: <a href="https://www.palmmedia.de/blog/2011/8/30/ioc-container-benchmark-performance-comparison" target="_blank">👀benchmarks-ioc-dotnet</a>
- Ciclo de vida:
    * Scoped: Criado apenas uma vez por cliente-request.
    * Transiente: A instância  da classe será criada toda vez que for injetada em alguma classe.
    * Singleton: A instância  do objeto é criada e permanece durante todo tempo de execução da aplicação.
- Generics
- Service Locator
- Multiplas implementações

## Clean code
- Linhas de código
- Números de métodos
- Número de classes
- Linha de código por método
- Complexidade ciclomática: ifs aninhado
- Número de estruturas de decisão
- Escolha os nomes que revelem intenção
- Por que existe
- O que faz
- Como é usado
- Use nomes fáceis de se encontrar
- Use nomes pronunciáveis
- Evite siglas ou acrônimos
- Não economize palavras
- Revele a intenção do código
- Evite palavras que podem ser variáveis ou palavras reservadas em outras plataformas
- O tipo não precisa estar no nome
- Evite trocadilhos, não misture idioma, não mescle nomes.


## Boas práticas
- Nome de classe devem ser SUBSTANTIVOS
- Nome de métodos devem conter VERBOS de
preferência no infinitivo.
- Não seja genérico
- Métodos <= 20 linhas
- Linha <= 100 caracteres
- Classe <= 500 linhas
- Extraia trechos em métodos privados
- Métodos devem fazer apenas uma coisa, fazê-la certa e somente fazê-la.
- Evite muitos parâmetros
- Não deixe o método mentir dizendo que faz uma coisa e faz outras "escondidas"
- Se o método tiver mais de uma responsabilidade extraia em dois ou mais.
- Leia seu método de cima para baixo como uma narrativa, ele deve fazer sentido.
- Aplique uma boa indentação.

## Comentários
- Comentários não vão ajudar um código ruim ser melhor interpretado.
- Um código que requer comentário, precisa ser reescrito.
- Não deixe trechos de código comentado

* Quando comentar ?
- Alertar consequências que pode vir a causar
- Licença, direitos autorais, etc.
- Necessidade de explicar uma regra de negócio interna.
- Decisões de design de código
- Gerar documentação do código

## Tratamento de erros
- Tratar e prever possíveis exceções é de responsabilidade do desenvolvedor.
- Retorne exceptions e não código de erro.
- Informe o máximo que puder em sua exception.(não para o cliente)
- Se necessário crie exceptions personalizadas para um problema específico.
- Não retorne NULL

* Regra dos escoteiros:
"Deixe a área de acampamento mais limpa de como você a encontrou".

## Design Patterns
*São padrões de código para soluções de problemas conhecidos. O objetivo não é reinventar a roda e sim aplicar uma solução com um  bom design de código.*

### O padrões estão separados por 3 familias, são elas:
- **Criacional:** _Fornecem meios de criação de obj e de como será instanciado._
    * Abstract Factory: Fábrica de fábrica que delega a criação do produto a uma fabrica concreta.
    * Factory Method
    * Singleton
- **Estrutural:** _Tratam da composição de obj por herança e interfaces para diferentes funcionalidades._
    * Adapter
    * Facade
    * Composite
- **Comportamental:** _Tratam das interações e comunicação entre os objetos além da divisão de responsabilidade._
    * Command
    * Strategy
    * Observer
- **Consultar padrões dotnet:**
    * <a href="www.dofactory.com/net/design-patterns" target="_blank">👀click-me</a>

## Estilos arquiteturais
*"Um estilo arquitetural é uma abordagem de como projetar e entregar uma aplicação. Trata-se de como organizar os componentes responsáveis de uma arquitetura, como eles irão interagir entre sí e quais aspectos tecnológicos irão atender. Os estilos podem coexistir, onde o mesmo projeto pode possuir mais de um estilo."*

- **Arquitetura monolítica**
    * Onde todo o sistema está acoplado a um só projeto, desde o cliente ao servidor.
- **Arquitetura em camadas**
    * Separação de camadas com suas respectivas responsabilidades
- **Arquitetura rest**
    * Estilo cliente, servidor realizando requests.
- **Arquitetura microservices**
    * Granularização dos serviços em várias partes independentes.
- **Arquitetura SOA**
    * SOA vs Microservices: O estilo é o mesmo porém o micro é quebrado em serviços menores.
- **Arquitetura de plugins(wordpress)**
- **Arquitetura de Client-Servidor**
- **Arquitetura pipe e filters**

## Padrões arquiteturais
*Os padrões arquiteturais são semelhantes aos "Design Patterns", mas possuem um escopo diferente. São estratégias de alto nível que diz respeito a componentes de grande escala as propriedades globais de um sistema. Um projeto de arquitetura pode conter diversos estilos e cada estilo pode utilizar diversos padrões. Um padrão pode ser um subconjunto de um estilo arquitetural visando um escopo específico.*

- **Padrão MVC**
     * **Padrão: Define uma formação de responsabilidades e como elas conversam entre sí** 
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
*Um padrão arquitetural onde o foco principal é separar os meios de leitura e escrita de dados. Alterações de dados são realizados via **Commands** e leituras de dados que são realizados via **Queries***

- **Commands**
    * Representa uma intenção de mudança no estado de uma entidade. São expressivos e representam uma única intenção de negócio(Insert, update, delete).
- **Queries**
    * É a forma de obter dados de um banco ou origem de dados para atender as necessidades da aplicação.

*"Podemos considerar que toda aplicação que salva em uma base de dados e busque em outra é um padrão CQRS."*
* <a href="https://www.eduardopires.net.br/category/cqrs/" target="_blank">👀click-me</a>

## Event Sourcing
*Uma forma de salvar todos os estados anteriores de uma entidade. Podendo assim colhendo comportamentos dos usuários, até mesmo dar replay e retornar a entidade ao seu estado inicial.*

## Domain-Driven Design(DDD)
*É um guia de como entender um negócio, organiza-lo em um conjunto de princípios, criar uma modelagem com base no negócio e implementar utilizando diversas boas práticas. Razoavelmente fácil de entender, porém difícil de aplicar.*

- **Processo de "implementação" do DDD:**
    * Entender o negócio
    * Extrair a linguagem ubíqua
    * Modelagem estrátegica
    * Definir a arquitetura
    * Modelagem tática

## Arquitetura Evolutivas
*Ser cuidadoso, evitar implementações desnecessárias, se possível adie.*
*"Um bom arquiteto permite que decisões importantes sejam adiadas e um bom arquiteto maximiza o número de decisões tomadas."*
*"Uma arquitetura evolutiva suporta mudanças contínuas e incrementais como um primeiro princípio por meio de vários aspectos."*

- Sempre considere a complexidade
    * **Acidental:** A complexidade acidental é aquela que surge durante o processo de desenvolvimento, ou seja, ela é **causada** pela abordagem escolhida para resolver o problema.
    * **Essencial:** Já a essencial é basicamente a complexidade que nosso "software" se propõe resolver. Sim! Infelizmente existem problemas complexos, e é neles que temos que focar.

## Lei de conway's Law
*"Qualquer empresa que projeta um sistema, inevitavelmente produz um projeto cuja estrutura é uma cópia da estrutura de comunicação da organização."* **Melvin Conway**

## Agilidade e o manifesto ágil
<a href="https://agilemanifesto.org" target="_blank">manifesto</a>

## DevOps
*O termo DevOps deriva da junção das palavras **"desenvolvimento"** e **"operação"**, sendo uma prática de engenharia de software que possui o intuito de unificar o desenvolvimento de software(Dev) e a operação de software(Ops). O mesmo pretende fornecer em ciclos de desenvolvimento menores, frequência de implatação aumentada, liberação mais seguras, em alinhamento próximo com os objetivos de negócio.*

**Planejamento ➡️ build ➡️ CI/CD ➡️ Deploy ➡️ Operate ➡️ Continuous feedbacks ♾️**

## Princípio DRY(Dont Repeat Yourself)
*Cada parte do conhecimento deve ter uma representação única, não ambígua e e definitiva dentro da aplicação.*

## Princípio KISS (Keep It Simple, Stupid)
*O kiss valorizaa simplicidade do projeto e defende que toda a complexidade desnecessária seja descartada.*

## Princípio YAGNI (You Ain't Gonna Need It)
*Uma orientação que sugere não adicionar funcionalidades ao código fonte de uma aplicação até que estas sejam realmente necessárias.*
