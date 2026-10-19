# Livro Caixa Web

Sistema de controle financeiro pessoal com Blazor + SQLite.

## Funcionalidades

- Dashboard com resumo de entradas, saídas e saldo
- Cadastro de lançamentos financeiros
- Página de entidade/organização
- Relatório por mês
- Persistência em SQLite
- Interface em Blazor Server

## Requisitos

- .NET SDK 8.0+

## Como executar

```bash
cd src/ControleFinanceiroWeb
dotnet restore
dotnet run
```

A aplicação será iniciada em:

- https://localhost:5001
- http://localhost:5000

## Estrutura principal

- `Components/Pages` — páginas do sistema
- `Components/Layout` — layout e menu lateral
- `Data` — conexão e inicialização do SQLite
- `Models` — entidades do sistema
- `wwwroot/app.css` — estilos da aplicação
