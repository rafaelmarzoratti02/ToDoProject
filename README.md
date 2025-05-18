ToDoProject é uma aplicação ASP.NET Core para gerenciamento de tarefas, estruturada em múltiplas camadas para facilitar a organização, manutenção e escalabilidade do código.

Estrutura do Projeto
Todo.API: Projeto principal da API, responsável por expor endpoints REST para manipulação de tarefas. Utiliza ASP.NET Core e Swagger para documentação automática.
ToDo.Application: Camada de aplicação, destinada a conter regras de negócio e orquestração entre as entidades e a API.
ToDo.Core: Camada de domínio, responsável por definir as entidades e regras de negócio fundamentais do sistema.
Funcionalidades
CRUD de tarefas (em desenvolvimento)
Documentação automática com Swagger (Swashbuckle)
Estrutura modular para facilitar testes e manutenção
