# Projeto FilmScore

FilmScore API é uma aplicação para gerenciamento e consulta de filmes, utilizando Entity Framework Core e banco de dados SQL Server. Este projeto tem como objetivo fornecer uma API robusta e escalável para operações CRUD de filmes.

## Tecnologias Utilizadas

- .NET Core
- Entity Framework Core
- SQL Server
- Azure
- Swagger

### Estrutura do Projeto

- 'FilmScore.API' - Projeto principal da API.
- 'FilmScore.Shared.Data' - Biblioteca de acesso ao banco de dados compartilhados.
- 'FilmScore.Shared.Modelos' - Biblioteca contendo os modelos.
- 'FilmScore.Console' - Projeto de console.

#### Connection Strings

O projeto utiliza duas connection strings diferentes: uma para a nuvem (Azure) e outra para o ambiente local. As connection strings estão definidas nos arquivos `appsettings.json` e `appsettings.Development.json`.

