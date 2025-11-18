# EFCore-Configuration-Patterns-Demo

This repository contains a simple and clear demonstration of different ways to configure entity models in **Entity Framework Core**.  
The goal is to show how EF Core reads configuration from conventions, Data Annotations, Fluent API, and external configuration classes — including applying them automatically using **assembly scanning**.

---

## 🎯 Purpose

This repo helps you understand:

- How EF Core decides table/column names using **conventions**.
- When and why to use **Data Annotations**.
- Full control using **Fluent API** in `OnModelCreating`.
- How to organize your code using **IEntityTypeConfiguration<T>** classes.
- How to automatically register all configuration classes using **ApplyConfigurationsFromAssembly**.

---

## 🚀 Running the Projects

Each project is independent. Just:

1. Open the solution in Visual Studio or Rider.
2. Set a project as **Startup Project**.
3. Run it.

---

## 📘 EF Core Features Covered

✔ Conventions  
✔ Data Annotations  
✔ Fluent API  
✔ IEntityTypeConfiguration  
✔ ApplyConfigurationsFromAssembly  





