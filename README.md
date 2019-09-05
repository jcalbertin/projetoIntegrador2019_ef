# projetoIntegrador2019_ef
Projeto Hands-on de auxilio para elaboração do projeto integrador baseado em EF e .NET Core 2

Irá ser criado um projeto console, que usará a técnica de Code First para mapear as classes criadas gerando tabelas e colunas no banco de dados. Dessa forma, permitindo a manipulaçao das informaç±oes por meio de orientacao a objetos, com geraç±ao automática de comandos SQL.
Posteriormente, será utilizado de dentro de uma Web API.

### Softwares necessários:
- .Net Core 2.2
- Visual Studio Code
- Plugins:
    - C# for Visuaal Sudio Code (powered by OminSharp)
    - C# IDE Extensions (jchannon)
- MS SQL Server ou MySQL
- Cliente de acesso ao BD de sua escolha

### Etapas para rodar o projeto a partir desse repositorio:

Na pasta do projeto, digite:
>  -  dotnet restore
>  -  dotnet build
>  -  dotnet run


### Etapas de criaçao do projeto do ZERO:

#### (Aula 1 - EAD) Seguir a sequência de passos: 

1. Criar um novo projeto console:
Na pasta do projeto, digite:
-    dotnet new console

Digite:
-    code .           (Para abrir o projeto no Visual Studio Code)

2. No terminal, digitar:
-    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
-    dotnet add package Microsoft.EntityFrameworkCore.Tools 

    Será adicionado o driver do banco MSSQL Server e a lib de geraçao de entidades do .net core, respectivamente.

3. No terminal, digitar:
-    dotnet restore    - (opcional) util para baixar dependencias (libs)
-    dotnet build      - (opcional) Verifica se há um erro de código
e
-    dotnet run        - para rodar o projeto


#### (Aula 2 - EAD) Geraçao de tabelas a partir de implementaçao das classes

Nesse etapa, utilizando Code First fazemos a geraçao das tabelas e colunas por meio do ORM.
Será indroduzido o conceito do ORM, Migrations utilizando o framework EF Core.
Seguir a sequência de passos:

1. Abra o arquivo projetoIntegrador2019_ef.csproj

2. Adicione o seguinte trecho XML antes do fechamento da TAG </Project>:

<ItemGroup>
    <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.1" />
</ItemGroup>

3. Digite:
-    dotnet restore

4. Para as demais etapas, considere o código contido nesse repositório:
    4.1. Crie uma pasta Modelos e implemente as classes Turma.cs e Aluno.cs, conforme consta na especificaçao
    4.2. Nessa mesma pasta, crie uma classe TurmaContext.cs e implemente seu código

5. Execute pelo terminal:
