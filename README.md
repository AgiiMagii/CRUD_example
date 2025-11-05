# University Management System (.NET Framework + Entity Framework 6)

This project is a learning exercise designed to practice CRUD (Create, Read, Update, Delete) operations using the .NET Framework and Entity Framework 6. Its main goal is to gain practical experience in data handling, data presentation, and working with Windows Forms, using a pre-existing relation database “UniversityExample” that contains dummy data of students, professors, courses, and faculties.
It also serves as a personal reference for the future, where I can revisit and remind myself how to perform various operations with databases and data, or return later to compare and see the progress I’ve made. It helps me keep track of techniques, best practices, and solutions I’ve learned while working with CRUD operations, Entity Framework, and Windows Forms.

---

## Table of Contents
1. [Overview](#overview)
2. [Features](#features)
3. [Technologies Used](#technologies-used)
4. [Getting Started](#getting-started)
   - [Prerequisites](#prerequisites)
   - [Installation](#installation)
   - [Database Setup](#database-setup)
5. [Usage](#usage)
6. [Project Structure](#project-structure)
7. [Future Improvements](#future-improvements)
8. [License](#license)

---

## Overview
Since the database already exists in SQL Server, this project uses a Database First / Existing Database approach, connecting C# classes to the pre-defined tables. CRUD operations are implemented in the C# application, while Entity Framework translates these operations into SQL commands executed on the database.

The user interface (UI) is built with Windows Forms, focusing on clear data management logic and practical usability. During development, the project demonstrates:

- How to bind data to controls such as DataGridView and ComboBox;

- How to implement filtering and search functionality;

- How to organize code into logical layers (data layer, business logic, UI layer);

- How to handle errors and ensure stable application performance.

In addition to the main desktop project, a separate web version [UniversityExampleWEB](https://github.com/AgiiMagii/UniversityExampleWEB.git) is under early development, using the same database structure. This allows for a comparison of desktop vs. web data handling and expands the project’s capabilities to web environments.

Overall, this project serves as a solid foundation for learning data management in the .NET ecosystem, providing practical experience for building more advanced CRUD applications and full-featured web solutions in the future.

---

## Features
- Create, read, update, delete records
- Display data using DataGridView and other WinForms controls
- Search and filter data
- Simple validation for user input

---

## Technologies Used
- .NET Framework 4.x
- C#
- Entity Framework 6
- SQL Server (SSMS)
- Windows Forms
- Visual Studio

---

## Future Improvements and goals
- Future extensions planned for schedules, classrooms, and grading.
- Add error handler
- Implement advanced filtering and reporting
- Add authentication and authorization
- Enhance UI with modern design

---

## Getting Started
<-- Update coming soon -->

### Prerequisites
- Visual Studio 2022
- SQL Server Express or full edition
- .NET Framework installed

### Installation
<-- Update coming soon -->
