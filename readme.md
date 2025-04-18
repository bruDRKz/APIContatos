
# API de Contatos 📱

Esta é uma API RESTful simples para gerenciar contatos. Ela permite que você crie, leia, atualize e exclua informações de contatos. A API é construída com ASP.NET Core e utiliza um banco de dados SQL Server para armazenar os dados.

## Tecnologias 🛠️

- ASP.NET Core
- SQL Server
- Entity Framework Core

## Funcionalidades 🚀

A API oferece as seguintes funcionalidades:

- **GET /api/contatos**: Retorna a lista de todos os contatos.
- **GET /api/contatos/{id}**: Retorna os detalhes de um contato específico.
- **POST /api/contatos**: Cria um novo contato.
- **PUT /api/contatos/{id}**: Atualiza os dados de um contato existente.
- **DELETE /api/contatos/{id}**: Deleta um contato.

## Instalação ⚙️

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/nome-do-repositorio.git
   ```

2. Navegue até o diretório do projeto:
   ```bash
   cd nome-do-repositorio
   ```

3. Restaure as dependências do projeto:
   ```bash
   dotnet restore
   ```

4. Configure a conexão com o banco de dados no arquivo `appsettings.json`:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=contatos_db;User Id=sa;Password=senha;"
   }
   ```

5. Crie o banco de dados:
   ```bash
   dotnet ef database update
   ```

6. Execute o projeto:
   ```bash
   dotnet run
   ```

A API estará disponível em `http://localhost:5000` ou `https://localhost:5001`.

## Endpoints 📍

### 1. GET /api/contatos
Retorna todos os contatos.

**Resposta**:
```json
[
  {
    "id": 1,
    "nome": "João Silva",
    "email": "joao@exemplo.com",
    "telefone": "1234-5678"
  },
  ...
]
```

### 2. GET /api/contatos/{id}
Retorna o contato especificado pelo ID.

**Resposta**:
```json
{
  "id": 1,
  "nome": "João Silva",
  "email": "joao@exemplo.com",
  "telefone": "1234-5678"
}
```

### 3. POST /api/contatos
Cria um novo contato.

**Exemplo de body**:
```json
{
  "nome": "Maria Oliveira",
  "email": "maria@exemplo.com",
  "telefone": "9876-5432"
}
```

**Resposta**:
```json
{
  "id": 2,
  "nome": "Maria Oliveira",
  "email": "maria@exemplo.com",
  "telefone": "9876-5432"
}
```

### 4. PUT /api/contatos/{id}
Atualiza os dados de um contato existente.

**Exemplo de body**:
```json
{
  "nome": "Maria Oliveira",
  "email": "maria.novo@exemplo.com",
  "telefone": "9876-1111"
}
```

**Resposta**:
```json
{
  "id": 2,
  "nome": "Maria Oliveira",
  "email": "maria.novo@exemplo.com",
  "telefone": "9876-1111"
}
```

### 5. DELETE /api/contatos/{id}
Deleta um contato.

**Resposta**:
```json
{
  "message": "Contato deletado com sucesso"
}
```

## Testes 🧪

Para testar a API, você pode usar o **Postman** ou outra ferramenta de API. Basta enviar as requisições para os endpoints definidos acima.

## Contribuição 🤝

Se você deseja contribuir para o projeto, siga as etapas abaixo:

1. Fork este repositório.
2. Crie uma nova branch para suas mudanças.
3. Realize as alterações desejadas.
4. Envie um pull request explicando suas mudanças.
