# Ex04 - Hierarchical Menu System

## 📌 Overview
This project implements a **hierarchical menu system** for console applications, demonstrating **object-oriented programming principles**, **interfaces**, **delegates**, and **event-driven programming**.

The system allows users to navigate menus, execute actions, and manage menu structures dynamically.

## 🎯 Objectives
- Implement object-oriented concepts such as **polymorphism**.
- Utilize **interfaces** to define menu behaviors.
- Implement **delegates (Action<T>)** for handling menu actions.
- Work with **collections** to manage menu items dynamically.
- Create a modular, reusable menu system for console applications.

## 🛠️ Project Structure
The solution consists of **three separate projects**:

1. **`Ex04.Menus.Interfaces`** (Class Library)
   - Implements the menu system using **interfaces**.
   - Provides an abstract and extensible approach to defining menu behavior.

2. **`Ex04.Menus.Events`** (Class Library)
   - Implements the menu system using **delegates and events**.
   - Demonstrates event-driven programming for dynamic menu interactions.

3. **`Ex04.Menus.Test`** (Console Application)
   - Demonstrates both implementations in action.
   - Allows users to interact with menus built using both **interfaces** and **delegates**.

## 📌 Features
✔️ Hierarchical menu system.  
✔️ Supports nested submenus and action-based menu items.  
✔️ Navigation between menus with **Back/Exit** options.  
✔️ **Two separate implementations** (Interfaces & Delegates).  
✔️ Executes predefined actions dynamically.

## 📂 Example Menu Structure
** Main Menu **
Letters and Version

Show Current Date/Time

Exit
Please enter your choice (1-2 or 0 to exit):


** Letters and Version **
Show Version

Count Lowercase Letters
Back

