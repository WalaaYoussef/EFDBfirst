# 🎓 University Management System

A **University Management System** built with **C# and .NET Framework**, using **Entity Framework 6 (Database First)** and **SQL Server**.

The project provides a simple way to manage university data and demonstrates **CRUD operations and database relationships**.

## 🚀 Features

* 👨‍🎓 Student Management
* 👨‍🏫 Teacher Management
* 🏢 Department Management
* 📚 Course Management
* 📝 Student Enrollment
* 🔄 CRUD Operations
* 🔗 Entity Relationships
* 🔍 LINQ Queries
* 📊 Retrieve related data from multiple entities

## 🛠️ Technologies

* **C#**
* **.NET Framework 4.7.2**
* **Entity Framework 6**
* **Database First**
* **SQL Server**
* **LINQ**
* **Visual Studio**

## 🗄️ Database Structure

The system contains the following main entities:

```text
Department
├── Teachers
└── Courses

Student
└── Enrollments
      └── Course

Teacher
└── TeacherCourse
      └── Course
```

## 💡 What I Practiced

This project helped me practice:

* Working with SQL Server databases
* Entity Framework Database First
* CRUD operations
* Primary and foreign keys
* One-to-many relationships
* Many-to-many relationships
* LINQ queries
* Updating and deleting related records
* Using `Include()` to retrieve related data

## ▶️ Getting Started

1. Clone the repository.
2. Open the solution in **Visual Studio**.
3. Make sure SQL Server is installed.
4. Create/configure the `UniversityDB` database.
5. Update the connection string in `App.config` for your local SQL Server.
6. Build and run the project.

## 📌 Project Purpose

This project is a **backend/database practice project** created to demonstrate my understanding of **C#, Entity Framework, SQL Server, CRUD operations, and relational databases**.

