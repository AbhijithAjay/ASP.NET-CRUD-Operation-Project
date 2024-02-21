## Employee management 

This project is an Employee Management System built using ASP.NET. It allows users to manage employee records, including adding new employees, updating details, and deleting employees from the system.

## Features

- **Add Employee:** Add new employees to the system by providing their details such as name, department, salary, etc.
- **Update Details:** Update existing employee details, such as their department, or salary information.
- **Delete Employee:** Remove employees from the system when they are no longer part of the organization.

## Technologies Used

- ASP.NET
- Entity Framework (for data access)
- HTML/CSS (for front-end)
- C# (for back-end logic)
- SQL Server (for database)

## Setup Instructions

1. **Clone the Repository:**
https://github.com/AbhijithAjay/ASP.NET-CRUD-Operation-Project.git

2. **Navigate to the Project Directory:**

cd ASP.NET-CRUD-Operation-Project

`One more time because the project file is stored in ASP.NET-CRUD-Operation-Project folder`
**cd ASP.NET-CRUD-Operation-Project**

3. **Restore Dependencies:**
dotnet restore

4. **Update Connection String:**
- Open `appsettings.json` file and update the connection string with your SQL Server details.

5. **Run Migrations:**
dotnet ef database update

6. **Run the Application:**
dotnet run

7. **Access the Application:**
- Open your web browser and go to `http://localhost:5066` to access the Employee Management System.