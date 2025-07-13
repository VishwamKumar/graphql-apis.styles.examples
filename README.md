# 📝 ToDoApp GraphQL API – Layered Architecture

This repository demonstrates a simple **ToDo application** implemented using **GraphQL** with the **HotChocolate** framework in .NET, following a clean **Layered Architecture**.

---

# Author

## Vishwa Kumar
- **Email:** vishwa@vishwa.me
- **GitHub:** [Vishwam](https://github.com/vishwamkumar)
- **LinkedIn:** [Vishwa Kumar](https://www.linkedin.com/in/vishwamohan)

Vishwa is the primary architect of the ToDoApp, responsible for the architecture and implementation of these features.

---


## 📦 Projects

| Project Name                         | Description                                               |
|-------------------------------------|-----------------------------------------------------------|
| `ToDoApp.Data.Sqlite`               | Data access layer using **Entity Framework Core** with **SQLite** database. |
| `ToDoApp.GraphQLApi.HotChocolate`   | GraphQL API built using **HotChocolate**, exposing CRUD operations on ToDo items. |

## 🔧 Tech Stack

- **.NET 9** (or latest)
- **GraphQL** via [HotChocolate](https://chillicream.com/docs/hotchocolate)
- **Entity Framework Core**
- **SQLite**
- **Layered Architecture** (Separation of API, Business Logic, and Data)

## 🚀 Features

- GraphQL endpoints with queries and mutations
- Schema-first approach with clear separation of concerns
- Minimal setup for running and extending
- Easily testable and maintainable code structure

## ▶️ Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/vishwamkumar/todoapp.graphql-api.layered.git   
   ```
   
2. Set the working directory:
   ```bash
        cd ToDoApp.GraphQLApi.HotChocolate
    ```
    ---
3. Run the application:
   ```bash
     dotnet run
   ```
   ---

3. Open Banana Cake Pop (HotChocolate’s GraphQL IDE) in your browser: (use sample from docs)
   ```bash
     http://localhost:5000/graphql
   ```
  ---
  