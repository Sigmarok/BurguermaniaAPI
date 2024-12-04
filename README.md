
```markdown
# Burguermania API

Esta é a API do Burguermania, um serviço para gerenciar produtos, categorias, pedidos e usuários de um restaurante de hambúrgueres.

## Tecnologias Utilizadas

- .NET 6
- Entity Framework Core
- PostgreSQL
- ASP.NET Core
- Swagger

## Configuração do Projeto

### Pré-requisitos

- .NET 6 SDK
- PostgreSQL

### Configuração do Banco de Dados

1. Configure a string de conexão no arquivo `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=burguermania;Username=seu_usuario;Password=sua_senha"
  }
}
```

2. Execute as migrações para criar o banco de dados:

```sh
dotnet ef database update
```

### Executando a Aplicação

1. Clone o repositório:

```sh
git clone https://github.com/seu_usuario/burguermania-api.git
```

2. Navegue até o diretório do projeto:

```sh
cd burguermania-api
```

3. Restaure as dependências e compile o projeto:

```sh
dotnet restore
dotnet build
```

4. Execute a aplicação:

```sh
dotnet run
```

A API estará disponível em `https://localhost:5001` ou `http://localhost:5000`.

## Endpoints

### Produtos

- `GET /api/Products`: Retorna todos os produtos.
- `GET /api/Products/{id}`: Retorna um produto específico pelo ID.
- `POST /api/Products`: Cria um novo produto.
- `PUT /api/Products/{id}`: Atualiza um produto existente pelo ID.
- `DELETE /api/Products/{id}`: Exclui um produto pelo ID.

### Categorias

- `GET /api/Categories`: Retorna todas as categorias.
- `GET /api/Categories/{name?}`: Retorna categorias pelo nome. Se o nome não for fornecido, retorna todas as categorias.
- `POST /api/Categories`: Cria uma nova categoria.
- `PUT /api/Categories/{id}`: Atualiza uma categoria existente pelo ID.
- `DELETE /api/Categories/{id}`: Exclui uma categoria pelo ID.

### Pedidos

- `GET /api/Orders`: Retorna todos os pedidos.
- `GET /api/Orders/{id}`: Retorna um pedido específico pelo ID.
- `POST /api/Orders`: Cria um novo pedido.
- `PUT /api/Orders/{id}`: Atualiza um pedido existente pelo ID.
- `DELETE /api/Orders/{id}`: Exclui um pedido pelo ID.

### Usuários

- `GET /api/Users`: Retorna todos os usuários.
- `GET /api/Users/{id}`: Retorna um usuário específico pelo ID.
- `POST /api/Users`: Cria um novo usuário.
- `PUT /api/Users/{id}`: Atualiza um usuário existente pelo ID.
- `DELETE /api/Users/{id}`: Exclui um usuário pelo ID.

## Configuração do CORS

A aplicação está configurada para permitir solicitações CORS do domínio `http://localhost:4200`. Você pode modificar essa configuração no arquivo `Program.cs`:

```csharp
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:4200")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});
```

## Documentação da API

A documentação da API está disponível via Swagger. Após iniciar a aplicação, acesse `https://localhost:5001/swagger` ou `http://localhost:5000/swagger` para visualizar a documentação interativa.

## Contribuição

Sinta-se à vontade para contribuir com este projeto. Para isso, siga os passos abaixo:

1. Faça um fork do projeto.
2. Crie uma nova branch (`git checkout -b feature/nova-feature`).
3. Faça as alterações necessárias e commit (`git commit -am 'Adiciona nova feature'`).
4. Envie para o repositório remoto (`git push origin feature/nova-feature`).
5. Abra um Pull Request.

## Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
```

Você pode copiar o conteúdo acima e colá-lo diretamente no seu arquivo 

README.md

.
