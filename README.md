# 🏠 RoomRental API

[![.NET](https://github.com/thami-coding/RoomRental.Server/actions/workflows/dotnet.yml/badge.svg)](https://github.com/thami-coding/RoomRental.Server/actions/workflows/dotnet.yml)

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-the-badge&logo=dotnet&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-4169E1?style=flat-the-badge&logo=postgresql&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-2496ED?style=flat-the-badge&logo=docker&logoColor=white)
![xUnit](https://img.shields.io/badge/test-xUnit-blue?style=flat-square&logo=dotnet)
![Swagger](https://img.shields.io/badge/-Swagger-%2385EA2D?style=flat-square&logo=swagger&logoColor=black)
![GitHub Actions](https://img.shields.io/badge/CI%2FCD-GitHub%20Actions-blue?style=flat-square&logo=github-actions&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green?style=flat-the-badge)

> A RESTful API for managing apartment rental listings built with **.NET 10**, **Onion Architecture**, and **PostgreSQL**.
> This project is still in development so not all features are working.

---

## 📋 Table of Contents

- [About](#about)
- [Architecture](#architecture)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Run with Docker](#run-with-docker)
  - [Run Locally](#run-locally)
- [API Endpoints](#api-endpoints)
- [Project Structure](#project-structure)

---

## About

RoomRental is a backend REST API that allows property managers to list apartments and renters to discover and request rooms. Built as a portfolio project demonstrating Onion Architecture, professional Git workflows, and modern .NET development practices.

---

## Architecture

The solution follows **Onion Architecture** with a strict dependency rule — outer layers depend on inner layers, never the reverse.

<img width="646" height="499" alt="image" src="https://github.com/user-attachments/assets/508b42f2-8b05-4320-8c8f-2bfccb1db048" />

## Features

- ✅ **CRUD** operations for apartment listings
- ✅ **Onion Architecture** with strict layer separation
- ✅ **Global error handling** with custom exceptions
- ✅ **AutoMapper** for DTO mapping
- ✅ **EF Core** with code-first migrations
- ✅ **PostgreSQL** database
- 🔜 JWT Authentication & Authorization
- 🔜 Pagination, Filtering & Sorting
- 🔜 Image uploads with cloud storage
- 🔜 Rate limiting
- 🔜 Unit tests
- 🔜 Integration tests

---

## Tech Stack

| Layer | Technology |
|---|---|
| Framework | .NET 10 / ASP.NET Core |
| Language | C# |
| Database | PostgreSQL |
| ORM | Entity Framework Core |
| Mapping | AutoMapper 16 |
| Containerization | Docker & Docker Compose |

---

## Getting Started

### Prerequisites

To run with Docker you only need:

- [Docker Desktop](https://www.docker.com/products/docker-desktop/)

That's it. No need to install .NET or PostgreSQL locally.

---

### Run with Docker

**1. Clone the repository**

```bash
git clone https://github.com/thami-coding/RoomRental.Server.git
cd RoomRental.Server
```

**2. Create a `.env` file in the root directory**

```bash
cp .env.example .env
```

Or create it manually with the following content:

```env
POSTGRES_DB=roomrental
POSTGRES_USER=postgres
POSTGRES_PASSWORD=yourpassword
CONNECTION_STRING=Host=db;Port=5432;Database=roomrental;Username=postgres;Password=yourpassword
```

**3. Start the containers**

```bash
docker compose up --build
```

**4. The API is now running at:**

```
http://localhost:5000
```

**5. Explore the API via Swagger:**

```
http://localhost:5000/swagger
```

> 💡 Migrations run automatically on startup — no manual setup required.

---

### Run Locally

If you prefer to run without Docker, you will need:

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/)

**1. Clone the repository**

```bash
git clone https://github.com/thami-coding/RoomRental.Server.git
cd RoomRental.Server
```

**2. Set up User Secrets**

```bash
cd src/RoomRental.Server
dotnet user-secrets set "ConnectionStrings:postgresConnection" "Host=localhost;Port=5432;Database=roomrental;Username=postgres;Password=yourpassword"
```

**3. Apply migrations**

```bash
dotnet ef database update --project src/Infrastructure/Persistence --startup-project src/RoomRental.Server
```

**4. Run the API**

```bash
dotnet run --project src/RoomRental.Server
```

---

## API Endpoints

### Apartments

| Method | Endpoint | Description |
|---|---|---|
| `GET` | `/api/apartments` | Get all apartments |
| `GET` | `/api/apartments/{id}` | Get apartment by ID |
| `POST` | `/api/apartments` | Create a new apartment |
| `PUT` | `/api/apartments/{id}` | Update an apartment |
| `PATCH` | `/api/apartments/{id}` | Partially update an apartment |
| `DELETE` | `/api/apartments/{id}` | Delete an apartment |

### Example Request Body — Create Apartment

```json
{
  "title": "Modern Studio in Berea",
  "availableRooms": 1,
  "description": "A compact modern studio perfect for a single professional.",
  "address": {
    "street": "14 Berea Road",
    "province": "KwaZulu-Natal",
    "city": "Durban",
    "suburb": "Berea"
  }
}
```

---

## Project Structure

<img width="294" height="285" alt="image" src="https://github.com/user-attachments/assets/f298e5b5-277a-4fc6-82ed-e0d3906a120a" />


---

<p align="center">Built with ❤️ by yours truly</p>
