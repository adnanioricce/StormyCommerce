# WithoffStore
Essa página que vocês estão vendo aqui agora, é uma coleção de código, que usa um sistema de versionamento chamada *git*, esse código versionado é chamada de *repositório*, e será nesse repositório que todas as funcionalidades, bem como tarefas a se realizar,e progresso do projeto estarão presentes. 

O Código-fonte foi separado em 3 partes, essa separação é pra seguir um certo padrão de uma arquitetura chamada "Layered Architecture" ou Architectura em Camadas, explicações do porque disso mais abaixo. 
Sobre as camadas...
## UI/Presentation 
Se Refere a camada de apresentação do projeto, nosso front-end. Aqui vai estar toda parte da aplicação que precisa ficar com o usuario. 
## Core
Essa é a parte onde vai realmente acontecer a lógica da aplicação, a parte chata, como o do sistema de pagamento,Controle de estoque,Cadastro e afins. 
Vou dar mais detalhes sobre essa camada em outra parte 
## Data Access Layer 
O Nome diz tudo, essa é a camada que vai ter lógica responsavel relacionada a operações de banco de dados, sendo utilizada no restante da aplicação para mandar e retornar dados para a camada lógica da aplicação(Essa camada não pode ser contato com a Camada de Apresentação).

# Guidelines
Na Raiz do Repositório vocês podem encontrar um arquivo de nome *guidelines.md*, por favor leiam esse arquivo antes de começarem a adicionar alguma coisa ou mudar alguma coisa. 
#Docs
Há uma Pasta Docs, mas ela no momento não contem nada. nessa parte em especifico planejava colocar a documentação do Código fonte, a parte da documentação que o TCC requisita.
