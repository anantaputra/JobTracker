# Job Tracker API

A backend API for tracking job applications, built with **.NET 8** and **Clean Architecture** principles.
This project is designed as a **portfolio-grade backend system**, demonstrating real-world backend patterns such as separation of concerns, database migrations, and containerized deployment.

---

## 🚀 Tech Stack

* **.NET 8 (ASP.NET Core Web API)**
* **Entity Framework Core**
* **SQL Server**
* **Docker**
* **Swagger / OpenAPI**

---

## 🏗 Architecture

This project follows **Clean Architecture**, ensuring clear separation of responsibilities between layers.

```
src/
├── JobTracker.API            → Presentation layer (Controllers, Swagger)
├── JobTracker.Application    → Use cases, commands, handlers
├── JobTracker.Domain         → Entities & business rules
└── JobTracker.Infrastructure → EF Core, repositories, persistence, migrations
```

### Why Clean Architecture?

* Framework-independent business logic
* Easier testing and maintenance
* Scalable and extensible design

---

## 🗄 Database Design

* **SQL Server** runs on the Windows host machine
* **API runs inside Docker**
* Connection is handled using `host.docker.internal`
* Database schema is managed via **EF Core Migrations**
* Tables are organized under a dedicated schema: `app`

Example table:

* `app.JobApplications`

---

## 🐳 Docker Setup

The API is containerized using Docker to simulate a real-world development environment.

* API runs inside a Docker container
* SQL Server runs on the host machine
* Allows easy transition to CI/CD or cloud deployment

---

## 🔧 Features

* Create job applications
* Retrieve job applications
* Clean separation between domain and infrastructure
* Strongly typed domain entities
* EF Core migrations for schema versioning
* Swagger UI for API exploration

---

## 📌 Sample Endpoint

```http
GET /api/job-applications
```

Sample response:

```json
[
  {
    "id": "guid",
    "companyName": "Tokopedia",
    "position": "Backend Developer",
    "appliedAt": "2025-01-19T00:00:00"
  }
]
```

---

## 🧪 Local Development

### Prerequisites

* .NET 8 SDK
* Docker
* SQL Server (Windows)

### Steps

1. Run SQL Server on your local machine
2. Start the API container
3. Apply database migrations:

```bash
dotnet ef database update \
  --project JobTracker.Infrastructure \
  --startup-project JobTracker.API
```

4. Open Swagger UI:

```
https://localhost:{port}/swagger
```

---

## 🎯 Project Purpose

This project was built to:

* Improve backend engineering skills in .NET
* Demonstrate Clean Architecture in a real-world scenario
* Showcase Dockerized backend development
* Serve as a portfolio project for backend or fullstack roles

---

## 🔮 Future Improvements

* Authentication & Authorization
* Pagination & filtering
* Job application status workflow
* CI/CD pipeline integration
* Cloud deployment (AWS / Azure)

---

## 📄 License

MIT License
