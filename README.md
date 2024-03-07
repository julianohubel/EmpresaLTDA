# EmpresaLTDA

Essa é uma API voltada para o gerenciamento de funcionários de uma empresa;
<br>Foi desenvolvida seguindo normas de **DDD** e **TDD** e padrões de **CQRS**.

# Tecnologias

Essa API foi desnvolvida usado framewor **.NET 8** com a liguagem **C#**;
<br>O sitema genrenciador de banco de dados (ORM) utilizado foi o **EntitiyFreworkCore**
<br>Para a base de dados foi utilizado o **MYSQL**;

# Execução Local

Para executar o projeto de forma local, é necessário que tenha uma instancia do ***MYSQL** e que a connection string esteja configurada em `appSetting.Development.json` em `ConnectionStrings:MySQL`
<br><br>Antes da execução é impontate executar o comando de migração na raiz (EmpresaLTDA) para criar e popular a base de dados com arquivo iníciais:
```code
dotnet ef database update --project Empregados.Domain.Infra   --startup-project Empregados.API
```
<br>Agora, execute  a API localmente, para o efeito, execute o comando na raiz da API (EmpresaLTDA/Empregados.API)
```code
dotnet run
```
Após isso poderá acessar no endereço https://localhost:7250/swagger  ou http://localhost:5295/swagger  e verá todos os endpoints diponíveis na API<br>
![image](https://github.com/julianohubel/EmpresaLTDA/assets/22960308/fd5c9d85-888a-454c-a7b2-e0c1bbb3c8b5)

# Execução Local com Docker

A API já está devidamente configurada para criar a imagem de todos os projetos e subir o container MySQL necessário para a execução do aplicativo.
<br>Aqui não se faz necessária a execução inicial da para criar a base de dados, o `docker-compose` já se encarrega disso, executando o script que está dentro de `database-scripts`
<br>Para o efeito, execute a linha do comnado na raiz (EmpresaLTDA)
```code
docker compose up
```
<br>Depois dos conteiners serem montados, o aplicativo já deve estar acessível através do endereço http://localhost:5000/swagger

# Testes
**Testes Unitários** form criados pra garantir o funcionamento dos comandos executados pelos cotrollers da API
<br>Para o efeito de execução dos testes, basta executar o comando na raiz do projeto de testes (EmpresaLTDA/Empregados.Domain.Tests)
```code
dotnet test
```
