## 📋 Contact Management System

A Windows Forms application for managing contacts and countries, 
built using C# and SQL Server with a clean 3-layer architecture.

## 🏗️ Architecture
- **Data Access Layer** — Raw SQL queries with parameterized commands
- **Business Logic Layer** — Handles modes (Add/Update), validation, and save logic
- **Presentation Layer** — WinForms UI with Tab Controls for clean navigation

## ✨ Features
- Full CRUD operations for Contacts and Countries
- Input validation (email, phone, date of birth, country code)
- Confirmation dialogs before Add/Delete operations
- Auto-refresh ListView after every operation
- Smart button enabling/disabling based on application state
- Tab-based navigation between List, Add, and Update views

## 🛠️ Technologies
- C# .NET WinForms
- SQL Server
- ADO.NET (SqlConnection, SqlCommand, SqlDataReader)
