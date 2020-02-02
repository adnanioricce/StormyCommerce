# Rodando o Servidor 
## Pré requisitos 
- .net core sdk 2.2.401 ou superior 
- postgresql 

## passos para rodar 
-> inicie o postgresql 
-> atualize a ConnectionString em src/SimplCommerce.WebHost/appsettings.json
-> vá até a pasta src/SimplCommerce.WebHost/
-> construa o esquema do Banco de dados
  -> Na linha de comando, digite ```dotnet ef database update``` e confirme
  -> No visual Studio,em Tools>Gerenciador De Pacotes>Console Do Gerenciador de pacotes, digite Update-Database e confirme
-> na linha de comando, digite dotnet run
-> siga os links mostrados na linha de comando para acessar a documentação da API


# Sobre o projeto 
o projeto é na verdade um fork do [SimplCommerce](http://github.com/simplCommerce/SimplCommerce), em vista de realizar um trabalho de conclusão de curso.
