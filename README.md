# EnergyMonitoringAPI

## Descrição
`EnergyMonitoringAPI` é uma API desenvolvida em .NET Core para monitoramento e gerenciamento da produção de energia a partir de fontes renováveis, como energia solar e eólica. A API oferece operações CRUD (Create, Read, Update, Delete) para registros de produção de energia e utiliza o MongoDB como banco de dados para armazenamento.

## Funcionalidades
- Monitoramento em tempo real da produção de energia.
- Suporte a múltiplas fontes de energia (Solar e Eólica).
- Operações CRUD para registros de produção de energia.
- Documentação da API usando Swagger para fácil interação e teste.

## Tecnologias Utilizadas
- .NET Core
- MongoDB
- Swagger para documentação da API

## Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) (versão 6.0 ou superior)
- [MongoDB](https://www.mongodb.com/try/download/community) (versão mais recente)
- Editor de código, como [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)

## Configuração do Projeto

### 1. Clonar o Repositório
```bash
git clone https://github.com/lucasrabd/EnergyMonitoringAPI.git
cd EnergyMonitoringAPI
```

### 2. Configurar o `appsettings.json`
Certifique-se de que a string de conexão com o MongoDB está correta no arquivo `appsettings.json`:
```json
"ConnectionStrings": {
  "MongoDb": "mongodb://localhost:27017"
}
```
Altere conforme necessário para seu ambiente.

### 3. Restaurar Pacotes e Executar o Projeto
```bash
dotnet restore
dotnet run
```
A API estará disponível em `http://localhost:5000`.

## Documentação da API com Swagger
A documentação interativa da API está disponível em `http://localhost:5000/swagger`. Você pode usá-la para explorar e testar os endpoints.

## Endpoints da API

### `GET /api/energy`
Retorna todos os registros de produção de energia.

### `GET /api/energy/{id}`
Retorna um registro de produção de energia específico pelo `id`.

### `POST /api/energy`
Cria um novo registro de produção de energia.

**Exemplo de Corpo de Requisição:**
```json
{
  "source": "Solar",
  "timestamp": "2024-11-07T12:00:00Z",
  "production": 20.5,
  "temperature": 25.0,
  "windSpeed": 0.0,
  "solarRadiation": 700.0
}
```

### `PUT /api/energy/{id}`
Atualiza um registro de produção de energia existente.

**Exemplo de Corpo de Requisição:**
```json
{
  "id": "1",
  "source": "Wind",
  "timestamp": "2024-11-07T13:00:00Z",
  "production": 30.0,
  "temperature": 20.5,
  "windSpeed": 12.0,
  "solarRadiation": 0.0
}
```

### `DELETE /api/energy/{id}`
Remove um registro de produção de energia.

## Estrutura do Projeto
```
EnergyMonitoringAPI/
│
├── Controllers/
│   └── EnergyController.cs
│
├── Models/
│   ├── EnergyProduction.cs
│   └── User.cs
│
├── Repositories/
│   ├── EnergyRepository.cs
│   └── IEnergyRepository.cs
│
├── Services/
│   └── EnergyService.cs
│
├── Data/
│   └── MongoDbContext.cs
│
├── appsettings.json
└── Program.cs
```
