# FinalAssignment_CSharp_Tic

A comprehensive C# WinForms application for managing users, courses, marks, and timetable scheduling — designed as a Final Year Assignment project.

---

## Table of Contents

1. [Introduction](#introduction)  
2. [Project Overview](#project-overview)  
3. [Main Functions](#main-functions)  
4. [Key Features](#key-features)  
5. [Technologies Used](#technologies-used)  
6. [Challenges Faced](#challenges-faced)  
7. [Solutions Implemented](#solutions-implemented)  
8. [Future Updates](#future-updates)  
9. [How to Run](#how-to-run)  
10. [Conclusion](#conclusion)  

---

## Introduction

This project is developed as part of a Final Year assignment to demonstrate skills in C#, SQLite, and Windows Forms. It covers key academic management functionalities including user registration, role-based access, marks management, course handling, and timetable creation.

---

## Project Overview

The application supports multiple user roles (Admin, Student, Lecturer, Staff) with role-specific access. Admins can manage users, courses, marks, and timetables efficiently through a user-friendly interface.

---

## Main Functions

- **User Management**: Add, update, and delete users with roles and credentials.  
- **Course Management**: Manage course details and assign students.  
- **Marks Management**: Input and modify student marks by course and subject.  
- **Timetable Module**: Create and manage class schedules by courses and lecturers.

---

## Key Features

- Role-based login and dashboard views  
- SQLite database integration for persistent data storage  
- Data validation and error handling in forms  
- Dynamic DataGridViews for real-time data display  
- Modular UserControls for better UI separation and maintenance

---

## Technologies Used

- **Language:** C#  
- **Framework:** .NET Windows Forms  
- **Database:** SQLite  
- **Development Environment:** Visual Studio  
- **Version Control:** Git & GitHub  

---

## Challenges Faced

- Synchronizing multiple user roles with specific UI access.  
- Ensuring data integrity across related tables (users, students, lecturers).  
- Implementing CRUD operations with SQLite in a WinForms environment.  
- Designing intuitive UI with limited time constraints.

---

## Solutions Implemented

- Modular UserControls for each functional area to isolate code and UI.  
- Parameterized SQL queries to prevent SQL injection.  
- Added default records for new students in related tables (marks).  
- Used event-driven programming for responsive UI interactions.

---

## Future Updates

- Implement full login for all user roles (Student, Lecturer, Staff).  
- Enhance timetable with drag-and-drop scheduling.  
- Add reporting and export features (PDF, Excel).  
- Integrate notifications and reminders for schedules and marks.  
- Improve UI with modern themes and responsive design.

---

## How to Run

1. Clone the repository:  
   ```bash
   git clone https://github.com/Ajay-Ram07/FinalAssignment_C_Sharp_Tic.git
2. Open the solution in Visual Studio.

3. Build the solution to restore NuGet packages and compile.

4. Run the project; the SQLite database initializes automatically on first run.

5. Use the Admin login to access the dashboard and test functionalities.

Conclusion
This project demonstrates foundational skills in C# Windows Forms development, database handling with SQLite, and software design principles necessary for academic and practical software projects. It’s a solid base for future enhancements and real-world applications.

Developed by Ajay Ram
Final Year Project - C# Windows Forms Application
GitHub Repository

