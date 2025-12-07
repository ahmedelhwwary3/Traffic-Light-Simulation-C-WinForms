# 🚦 Traffic Light Simulation

A Windows Forms application that simulates traffic light behavior using **reusable UserControls** and **event-driven state management**.

## 🧩 Design Overview
Each traffic light is implemented as a **UserControl**.  
Multiple instances of the control can be created and synchronized through events.

One traffic light controls the timing logic and state transitions, while another traffic light reacts to those changes.

## 🚀 Features
- Traffic lights implemented as reusable UserControls.
- Time-based state transitions (Red, Yellow, Green).
- Event-driven communication between traffic light instances.
- Previous, current, and next light states calculated and exposed.
- Clean separation between timing logic and UI representation.

## 🛠 Technologies Used
- Language: C#
- Framework: .NET WinForms
- Concepts:
  - UserControl-based design
  - Events & Delegates
  - Object-oriented programming
  - Clean architecture principles

## 💡 What This Project Demonstrates
- Strong understanding of event-driven programming.
- Designing reusable and independent UI components.
- Synchronization between multiple UI components via events.
- Clean handling of state transitions and timing logic.

## ▶️ How to Run
1. Open the solution in Visual Studio.
2. Build and run the project.
3. Observe traffic light synchronization and state changes.

## 👨‍💻 Author
Ahmed El-Hwwary
