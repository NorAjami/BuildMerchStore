# 🛍️ MerchStore

A modern, clean architecture-based merchandise web application built with ASP.NET Core (.NET 9) and designed for cloud deployment.

## 🚀 Tech Stack

- ASP.NET Core MVC (.NET 9)
- Clean Architecture: Domain, Application, Infrastructure, WebUI
- MongoDB or SQL (choice pending)
- Azure Container Apps (for cloud hosting)
- GitHub Actions (CI/CD pipeline)

## 💡 Features

- Layered project structure
- JWT-based authentication (planned)
- Cart, Products, Orders (in progress)
- Admin panel for product management

## 🧪 How to Run

```bash
dotnet clean
dotnet build
dotnet run --project src/MerchStore.WebUI
