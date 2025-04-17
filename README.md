
# 🛍️ MerchStore – Clean Architecture Webshop

> A modern merch web app built with ASP.NET Core and Clean Architecture. Designed for cloud deployment, testability, and scalable development.

---

## 📂 Projektstruktur

```bash
src/
├── MerchStore.Domain          # DDD Entities, Value Objects, Interfacesgit a
├── MerchStore.Application     # Business logic, Services, DTOs
├── MerchStore.Infrastructure  # Database, External Services, Repositories
├── MerchStore.WebUI           # ASP.NET Core MVC frontend
```
---

## ✅ Project Progress

### 🧱 Clean Architecture Setup
- [x] Created solution & `src/` folder
- [x] Added Domain, Application, Infrastructure, and WebUI projects
- [x] Connected projects according to Clean Architecture
- [x] Initialized `.gitignore`, `.gitattributes`, and README

### 🧠 Domain Layer (DDD Foundation)
- [x] `Entity<TId>` base class for identity and equality
- [x] `Money` value object with validation and operator overloading
- [x] `Product` entity with encapsulated business logic and validation
- [x] `IRepository<TEntity, TId>` generic interface
- [x] `IProductRepository` domain-specific repository

### 📦 Coming Soon…
- [ ] ProductService in Application Layer
- [ ] Infrastructure implementation of IProductRepository
- [ ] WebUI integration with controller + view
- [ ] Full cart/order flow
- [ ] Cloud deployment to Azure with CI/CD

---

## 🧠 Teknikstack

| Lager         | Teknik                           |
|---------------|----------------------------------|
| Backend       | ASP.NET Core MVC (.NET 9)        |
| Datalagring   | MongoDB (eller SQL, TBD)         |
| Autentisering | JWT (planerat)                   |
| Struktur      | Clean Architecture + DDD         |
| CI/CD         | GitHub Actions                   |
| Hosting       | Azure Container Apps             |

---

## 📦 Version History

### v0.1 – Domain Layer Setup ✅
- Product entity created
- Money value object implemented
- Generic repository interfaces added

---

## 🔧 Kom igång lokalt

```bash
dotnet build
dotnet run --project src/MerchStore.WebUI
```

Open in browser:  
https://localhost:5001 (eller annan port)

---

MIT License – feel free to remix 🚀
```
