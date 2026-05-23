# 🎓 Student Registration System (C# WinForms + SQL Server)

A desktop-based Student Registration System developed using **C# Windows Forms** and **Microsoft SQL Server** as part of the ESOFT Metro Campus Final Project.

---

## 📌 Project Overview

This system is designed for managing student registrations in a campus environment. It includes secure login functionality and full CRUD operations for student records.

---

## 🚀 Features

### 🔐 Login System
- Admin authentication (Username & Password)
- Secure access to the system
- Logout and exit functionality

### 🧑‍🎓 Student Registration Module
- Add new student records
- Update existing records
- Delete student records with confirmation
- Auto-fill data using Registration Number (Reg No)
- Search student details by Reg No

### 🗄️ Database Integration
- SQL Server database connectivity
- Persistent data storage
- Registration table with structured schema

---

## 🛠️ Technologies Used

- C# (.NET Framework / Windows Forms)
- Microsoft SQL Server
- ADO.NET (Database Connectivity)
- Visual Studio

---

## 🧾 Database Structure

### Database Name: `Student`

### Table: `Registration`

| Field Name   | Data Type     |
|--------------|--------------|
| regNo        | INT (Primary Key) |
| firstName    | VARCHAR(50)  |
| lastName     | VARCHAR(50)  |
| dateOfBirth  | DATETIME     |
| gender       | VARCHAR(50)  |
| address      | VARCHAR(50)  |
| email        | VARCHAR(50)  |
| mobilePhone  | INT          |
| homePhone    | INT          |
| parentName   | VARCHAR(50)  |
| nic          | VARCHAR(50)  |
| contactNo    | INT          |

---

## 🖥️ System Workflow

1. User logs in using Admin credentials
2. Redirected to Registration Form
3. Student details can be:
   - Added
   - Updated
   - Deleted
   - Searched via Reg No dropdown
4. Logout returns to Login screen

---

## 🔑 Default Login Credentials
- Username: Admin
- Password: Campusone@123


---

## 📸 Screenshots

### Login Page
<img width="897" height="584" alt="image" src="https://github.com/user-attachments/assets/938e58ac-7649-40fe-9386-6540d24e82a3" />


### Registration Page
<img width="1919" height="1020" alt="image" src="https://github.com/user-attachments/assets/322f857a-007c-4f97-befa-d64e31c50e0d" />


---

## 📂 How to Run the Project

1. Clone the repository
```bash
git clone https://github.com/YasinduDulshanPeiris/Student-Registration-System.git
```
2. Open solution in Visual Studio
3. Restore SQL Database
4. Run Database/Student.sql in SQL Server
5. Update connection string in App.config
6. Run the project


---

# 🚀 GitHub Upload Commands

Inside your project folder:

```bash
git init
git add .
git commit -m "Initial commit - Student Registration System"
git branch -M main
git remote add origin https://github.com/YasinduDulshanPeiris/Student-Registration-System.git
git push -u origin main
