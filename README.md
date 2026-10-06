# .NET Framework Learning

> A structured learning journey to master .NET and ASP.NET Core through daily practice, exercises, notes, and hands-on projects.

---

## 📚 About This Repository

This repository documents my learning journey in the .NET ecosystem, with a primary focus on:

- .NET
- ASP.NET Core
- C#
- Dependency Injection
- Entity Framework Core
- SQL Server
- Web API
- Authentication & Authorization
- Software Architecture
- Testing
- Application Development

The purpose of this repository is not only to store source code, but also to document my understanding, experiments, exercises, and progress throughout the learning process.

---

## 🎯 Learning Goals

The main goals of this learning journey are to:

- Understand the fundamentals of the .NET ecosystem.
- Understand how ASP.NET Core applications are structured.
- Build applications using clean and maintainable code.
- Understand Dependency Injection and Service Lifetimes.
- Connect ASP.NET Core applications with SQL Server.
- Work with Entity Framework Core.
- Build RESTful Web APIs.
- Implement authentication and authorization.
- Understand common application architecture and design patterns.
- Build real-world applications using .NET.

---

## 🗺️ Learning Roadmap

### 1. .NET & ASP.NET Core Fundamentals

- [x] .NET SDK
- [x] .NET CLI
- [x] Creating a .NET project
- [x] Running a .NET application
- [x] Project structure
- [x] Understanding `Program.cs`

### 2. ASP.NET Core

- [x] `WebApplication.CreateBuilder()`
- [x] `builder`
- [x] `builder.Build()`
- [x] `app`
- [x] `app.Run()`
- [x] Razor Pages
- [ ] HTTP Request & Response
- [ ] Middleware
- [ ] Routing

### 3. Services

- [x] Understanding Services
- [x] Creating a Service
- [x] Using a Service
- [x] Separating application logic
- [ ] Service design principles

### 4. Dependency Injection

- [x] Dependency
- [x] Dependency Injection concept
- [x] Manual Dependency Injection
- [x] DI Container
- [x] Service Registration
- [x] Constructor Injection
- [ ] Scoped
- [ ] Transient
- [ ] Singleton
- [ ] Service Lifetime comparison

### 5. Interfaces & Abstraction

- [ ] Interface
- [ ] Abstraction
- [ ] Interface-based Dependency Injection
- [ ] Service contracts
- [ ] Loose coupling

### 6. Entity Framework Core

- [ ] EF Core
- [ ] DbContext
- [ ] DbSet
- [ ] Entity
- [ ] Connection String
- [ ] Migration
- [ ] CRUD
- [ ] Relationships
- [ ] LINQ

### 7. Repository & Application Architecture

- [ ] Repository Pattern
- [ ] Service Layer
- [ ] Separation of Concerns
- [ ] Application flow
- [ ] Project structure
- [ ] Layered Architecture

### 8. ASP.NET Core Web API

- [ ] Controllers
- [ ] Routing
- [ ] GET
- [ ] POST
- [ ] PUT
- [ ] DELETE
- [ ] JSON
- [ ] HTTP Status Codes
- [ ] REST API

### 9. Model, DTO & Validation

- [ ] Models
- [ ] DTO
- [ ] Model Binding
- [ ] Validation
- [ ] Data Annotations

### 10. Authentication & Authorization

- [ ] Authentication
- [ ] Authorization
- [ ] Login
- [ ] Identity
- [ ] Roles
- [ ] Claims

### 11. Error Handling & Logging

- [ ] Exception Handling
- [ ] `ILogger`
- [ ] Logging
- [ ] Global Error Handling
- [ ] Custom Error Responses

### 12. Configuration

- [ ] `appsettings.json`
- [ ] Environment Configuration
- [ ] `IConfiguration`
- [ ] Options Pattern
- [ ] Environment Variables

### 13. Testing

- [ ] Unit Testing
- [ ] Integration Testing
- [ ] Service Testing
- [ ] Mocking

### 14. Real-World Project

- [ ] Database Design
- [ ] Entity
- [ ] Repository
- [ ] Service
- [ ] Dependency Injection
- [ ] Web API
- [ ] Authentication
- [ ] Authorization
- [ ] Validation
- [ ] Testing
- [ ] Deployment

---

## 📂 Current Project Structure

```text
dotNet-Framework-Learning/
│
├── README.md
├── .gitignore
│
├── BelajarService/
│   ├── Services/
│   │   ├── DiscountService.cs
│   │   ├── TaxService.cs
│   │   └── OrderService.cs
│   │
│   ├── Program.cs
│   └── BelajarService.csproj
│
└── TokoSaya/
    ├── Pages/
    │   ├── Index.cshtml
    │   └── Index.cshtml.cs
    │
    ├── Services/
    │   └── ProductService.cs
    │
    ├── Program.cs
    └── TokoSaya.csproj