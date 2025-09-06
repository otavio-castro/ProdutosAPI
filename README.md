# 🛒 Projeto de Produtos

## 📄 Descrição
Este projeto é uma aplicação simples para gerenciamento de produtos. Ele permite cadastrar, visualizar, atualizar e excluir produtos, armazenando todas as informações em **SQL Server**. Desenvolvido com foco em aprendizado de persistência de dados e boas práticas com bancos relacionais.

## 🛠 Tecnologias Utilizadas
- **Backend:** C# com .NET 8 (API Web)
- **ORM:** Entity Framework Core
- **Banco de Dados:** SQL Server
- **Ferramentas:** Visual Studio / VS Code

## ⚙️ Funcionalidades
- Cadastro de novos produtos
- Listagem de produtos
- Atualização de informações de produtos existentes
- Exclusão de produtos
- Persistência de dados no SQL Server

## 🗂 Estrutura do Banco de Dados
A aplicação utiliza **Code First** com Entity Framework Core.

**Entidade Produto:**
- `Id` (int) – chave primária
- `Nome` (string)
- `Descrição` (string)
- `Preço` (decimal)
- `Quantidade` (int)

> As migrações do Entity Framework criam automaticamente as tabelas no SQL Server.

## 🔧 Pré-requisitos
- .NET 8 SDK
- SQL Server (local ou remoto)
- Visual Studio ou VS Code
- Ferramenta para testar a API (Postman ou Insomnia)

## ⚡ Configuração
1. Clone o repositório:
   ```bash
   git clone <URL_DO_REPOSITORIO>
   ```
2. Configure a string de conexão no `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=SEU_SERVIDOR;Database=ProdutosDb;Trusted_Connection=True;"
   }
   ```
3. Aplique as migrações para criar o banco de dados:
   ```bash
   dotnet ef database update
   ```
4. Execute a aplicação:
   ```bash
   dotnet run
   ```

## 📡 Endpoints da API
| Método | Endpoint | Descrição |
|--------|----------|-----------|
| GET    | /api/produtos | Lista todos os produtos |
| GET    | /api/produtos/{id} | Obtém produto por ID |
| POST   | /api/produtos | Cria um novo produto |
| PUT    | /api/produtos/{id} | Atualiza um produto |
| DELETE | /api/produtos/{id} | Remove um produto |

## 🤝 Contribuição
Contribuições são bem-vindas!

- Faça um fork do projeto
- Crie uma branch para sua feature: `git checkout -b feature/nome-da-feature`
- Faça commit das alterações: `git commit -m 'Minha contribuição'`
- Push para a branch: `git push origin feature/nome-da-feature`
- Abra um Pull Request

## 📜 Licença
Este projeto está sob a licença MIT.
