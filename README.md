# 🏨 Hotel Management System (WinForms + MySQL)

A fully functional **Hotel Management System** built using **C# Windows Forms (.NET)** with a **MySQL database backend**.  
This project manages hotel operations including rooms, bookings, guests, payments, staff, and services with a structured relational database.

---

## 🚀 Project Overview

This system is designed to simulate real-world hotel operations. It provides role-based functionality and ensures smooth management of hotel data through a connected MySQL database.

---

## ✨ Features

### 👤 User & Authentication
- User registration and login system
- Secure user storage in database
- Guest profile management

### 🏨 Hotel & Room Management
- Add / update / delete hotels
- Room types: Single, Double, Suite, Deluxe
- Room availability tracking
- Link rooms with specific hotels

### 🧑‍💼 Staff Management
- Add and manage staff members
- Roles: Receptionist, Manager, Housekeeping, Chef, Waiter
- Salary management system

### 🛎️ Booking System
- Room booking for guests
- Check-in / Check-out dates
- Booking status: Confirmed, Cancelled, Completed
- Automatic total price calculation

### 💳 Payment System
- Payment tracking per booking
- Methods:
  - Credit Card
  - Debit Card
  - Cash
  - Online Transfer
- Payment status: Pending, Completed, Failed

### 🧼 Extra Services
- Food service
- Laundry service
- Spa service
- Transport service
- Service charge management

### Main Tables:
- `register` – user authentication
- `guest_profile` – guest account details
- `Hotels` – hotel information
- `Rooms` – room data & availability
- `Guests` – guest information
- `Bookings` – reservation records
- `Payments` – payment details
- `Services` – additional hotel services
- `Staff` – hotel employees

---

## ⚙️ Tech Stack

- **Frontend:** C# Windows Forms (.NET Framework)
- **Backend:** MySQL
- **Database Access:** ADO.NET / MySQL Connector
- **IDE:** Visual Studio

---

## 🧩 Database Setup

1. Open MySQL Workbench / phpMyAdmin
2. Run the SQL script included in this project:

```sql
CREATE DATABASE HotelManagement;
USE HotelManagement;

string connectionString = "server=localhost;database=HotelManagement;uid=root;password=YOUR_PASSWORD;";
