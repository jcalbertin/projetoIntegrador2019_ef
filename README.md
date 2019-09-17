# projetoIntegrador2019_ef
Projeto Hands-on de auxílio para elaboração do projeto integrador baseado em EF e .NET Core 2

Irá ser criado um projeto console, que usará a técnica de Code First para mapear as classes criadas gerando tabelas e colunas no banco de dados. Dessa forma, permitindo a manipulaçao das informações por meio de orientacao a objetos, com geração automática de comandos SQL.
Posteriormente, será utilizado de dentro de uma Web API.

## Para Saber mais

Pesquise sobre os conceitos envolvidos neste hands-on.

- O que é Mapeamento objeto-relacional (ORM)
- O que sao Migrations (Migrações)
- Diferencie Code-First vs DB-First. Vantangens e desvantagens. Quando usar cada um deles.


### Softwares necessários:
- .Net Core 2.2
- Visual Studio Code
- Plugins:
    - C# for Visuaal Sudio Code (powered by OminSharp)
    - C# IDE Extensions (jchannon)
- MS SQL Server ou MySQL 
- Cliente de acesso ao BD de sua escolha

### Etapas para rodar o projeto a partir desse repositório:

Na pasta do projeto, digite:
>  -  dotnet restore
>  -  dotnet build
>  -  dotnet run


### Etapas de criaçao do projeto do ZERO:

#### (Aula 1 - EAD) Seguir a sequência de passos: 

1. Criar um novo projeto console:
Na pasta do projeto, digite:
> -    dotnet new console

Digite:
> -    code .           (Para abrir o projeto no Visual Studio Code)

2. No terminal, digitar:
> -    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
> -    dotnet add package Microsoft.EntityFrameworkCore.Tools 

    Será adicionado o driver do banco MSSQL Server e a lib de geração de entidades do .net core, respectivamente.

3. No terminal, digitar:
> -    dotnet restore    - (opcional) util para baixar dependências (libs)
> -    dotnet build      - (opcional) Verifica se há um erro de código
e
> -    dotnet run        - para rodar o projeto


#### (Aula 2 - EAD) Geração de tabelas a partir de implementaçao das classes

Nesse etapa, utilizando Code First fazemos a geração das tabelas e colunas por meio do ORM.
Será indroduzido o conceito do ORM, Migrations utilizando o framework EF Core.
Seguir a sequência de passos:

1. Abra o arquivo projetoIntegrador2019_ef.csproj

2. Adicione o seguinte trecho XML antes do fechamento da TAG < /Project >:

> <ItemGroup>
>    <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.1" />
> </ItemGroup>

3. Digite:
> -    dotnet restore

4. Para as demais etapas, considere o código contido nesse repositório:
    - 4.1. Crie uma pasta Modelos e implemente as classes Turma.cs e Aluno.cs, conforme consta na especificação
    - 4.2. Nessa mesma pasta, crie uma classe TurmaContext.cs e implemente seu código

5. Execute pelo terminal:
> - dotnet ef migrations add TabelasIniciais    (Gera o versionamento das tabelas)
> - dotnet ef database update                   (Efetua o versionamento no banco, gerando/alterando as tabelas)

6. Modifique o arquivo Program.cs, criando objetos e interagindo com eles. Observe o que acontece no banco de dados.
- Para executar:
>    - dotnet restore
>    - dotnet build
>    - dotnet run

#### (Aula 3 - EAD) - Modificando e interagindo com objetos

7. Experimente fazer modificações nas classes, e efetue os comandos para persistir as alterações:
> - dotnet ef migrations add < Nome da Migracao >
> - dotnet ef database update 

### Conclusao:

Veja que o .Net Core versiona suas alterações no banco, permite realizar operações usando OO e evoluir o sistema, apenas modificando classes e objetos.
