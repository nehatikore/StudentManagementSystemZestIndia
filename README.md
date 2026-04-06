This is a simple Student Management System built using ASP.NET Core Web API and SQL Server.It allows you to perform basic operations like adding, viewing, updating, and deleting students.
Features:
Get all students
Add new student
Update student
Delete student
JWT Authentication (secured APIs)
Swagger for API testing

Technologies Used:
ASP.NET Core Web API (.NET 6/8)
SQL Server
React (optional UI)

Setup Steps:
Clone Project
git clone <your-repo-link>
cd student-management-system

Setup Database:
Run this in SQL Server:

CREATE DATABASE StudentDB;

USE StudentDB;

CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Email NVARCHAR(100),
    Age INT,
    Course NVARCHAR(100),
    CreatedDate DATETIME DEFAULT GETDATE()
);

 Configure Connection:

Update appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=StudentDB;Trusted_Connection=True;"
}

Run Project:
dotnet run

Open:
https://localhost:5001/swagger
Run React UI
cd student-ui
npm install
npm start

API Endpoints
GET /api/student
POST /api/student
PUT /api/student
DELETE /api/student/{id}

This project shows basic CRUD operations using a clean architecture with secure APIs.
