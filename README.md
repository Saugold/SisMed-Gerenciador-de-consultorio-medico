# 🏥 Gerenciador Web de Consultório Médico

Sistema web desenvolvido em ASP.NET MVC com Razor Pages para gerenciar pacientes, médicos, consultas e o monitoramento de sinais vitais em um consultório médico.

---

## 📌 Descrição

Este sistema permite que clínicas e consultórios realizem o controle completo de pacientes, médicos, agendamentos e sinais vitais, oferecendo uma plataforma prática e eficiente para gerenciamento do dia a dia.

---

## 🚧 Status do Projeto

✅ Projeto finalizado (em fase de testes e melhorias).

---

## ✨ Funcionalidades

### 👤 Pacientes
- [x] Cadastro de pacientes
- [x] Edição de informações
- [x] Exclusão
- [x] Listagem completa

### 🩺 Médicos
- [x] Cadastro de médicos
- [x] Edição de informações
- [x] Exclusão
- [x] Listagem completa

### 📅 Consultas
- [x] Cadastrar novas consultas
- [x] Editar informações da consulta
- [x] Excluir consultas

### 📊 Sinais Vitais
- [x] Adicionar sinais vitais ao paciente (pressão, batimentos etc.)
- [x] Editar registros de sinais vitais
- [x] Excluir registros

---

## 🛠️ Tecnologias Utilizadas

- ASP.NET Core MVC
- Razor Pages
- Entity Framework Core 9
- SQL Server
- FluentValidation

---
## 💻 Como executar o projeto

### ✅ Pré-requisitos

- .NET 8 ou superior
- SQL Server
- Visual Studio 2022 ou VS Code

### ⚙️ Instruções

```bash
# Clone o repositório
git clone https://github.com/Saugold/SisMed-Gerenciador-de-consultorio-medico.git

# Acesse a pasta
cd SisMed

# Restaure os pacotes
dotnet restore

# Crie o banco de dados (migrations já estão configuradas)
dotnet ef database update

# Rode o projeto
dotnet run
```
## 📦 Pacotes NuGet Utilizados

```xml
<ItemGroup>
  <PackageReference Include="FluentValidation" Version="11.11.0" />
  <PackageReference Include="FluentValidation.AspNetCore" Version="11.3.0" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="9.0.1">
    <PrivateAssets>all</PrivateAssets>
    <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
  </PackageReference>
  <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="9.0.1" />
</ItemGroup>
