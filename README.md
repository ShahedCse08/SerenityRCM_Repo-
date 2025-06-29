# ✨ SerenityRCM

**SerenityRCM** is a clean, scalable, and modular web application architecture built with **ASP.NET Core 8**, following the principles of **Clean Architecture**.

It is designed for **enterprise-level development** with a strong focus on:
- ✅ Separation of concerns  
- ✅ Maintainability  
- ✅ Testability  
- ✅ Scalability  

---

## 📦 What’s Inside

| Layer                  | Purpose                                                              |
|------------------------|----------------------------------------------------------------------|
| 🧩 **Domain**           | Core business logic, entities, enums, and value objects             |
| 📜 **Application**      | Use cases, service contracts, interfaces, DTOs                      |
| 💾 **Infrastructure**   | Persistence (EF Core), emailing, reporting, stored procedure execution |
| 🌐 **Web API**          | Controllers, middleware, DI container setup                         |
| 🧪 **Tests**            | Unit and integration tests using xUnit/Moq                         |

---

## 🧱 Project Structure

```plaintext
SerenityRCM.sln
│
├── Core
│   ├── SerenityRCM.Application      # Application logic, use cases, interfaces
│   └── SerenityRCM.Domain           # Domain entities, enums, interfaces
│
├── Infrastructure
│   └── SerenityRCM.Infrastructure   # Persistence, emailing, reporting, stored procedures, etc.
│
├── Presentation
│   └── SerenityRCM.WebApi           # API Controllers, middleware, DI, startup
│
├── Tests
│   └── SerenityRCM.Tests            # Unit and integration tests
│
└── README.md                        # This documentation  

