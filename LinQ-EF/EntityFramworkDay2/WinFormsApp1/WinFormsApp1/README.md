# 📚 Library Management System (WinForms)

A modern, professional Windows Forms application for managing library books, authors, and categories. Built with .NET, Entity Framework Core, and a custom UI framework.

## ✨ Features

- **Modern UI/UX**:
  - Custom "Royal Blue & Slate" professional theme.
  - Responsive Dashboard with Sidebar navigation.
  - Interactive Card-based book browser.
  - Custom controls (`ModernTextBox`, `RoundedButton`) for a polished look.

- **User Management**:
  - Secure Login & Registration.
  - User Profiles.

- **Book Management**:
  - **Browse**: View books in a grid layout with cover images and details.
  - **Search**: Real-time filtering (UI header prepared).
  - **Add Books**: comprehensive form with image upload support.
  - **Details View**: Read-only view of book metadata (Price, Quantity, Author, etc.).

## 🛠️ Technology Stack

- **Frontend**: Windows Forms (.NET)
- **Database**: SQL Server (LocalDB/Express) via Entity Framework Core
- **ORM**: Entity Framework Core (Database-First / Code-First hybrid approach)
- **Language**: C#

## 🚀 Getting Started

### Prerequisites
- .NET SDK (6.0 or later)
- SQL Server or LocalDB
- Visual Studio 2022 (recommended)

### Installation

1.  **Clone the repository**:
    ```bash
    git clone https://github.com/yourusername/library-app-winforms.git
    ```
2.  **Database Setup**:
    - Update the connection string in `App.config` or `LibraryContext.cs` to point to your SQL Server instance.
    - Run migrations (if applicable) or ensure the database schema exists.
3.  **Build & Run**:
    ```bash
    cd WinFormsApp1
    dotnet run
    ```

## 🎨 Design System

The application uses a centralized `UIHelper` class to enforce consistency:

- **Primary Color**: Royal Blue (`#2563EB`)
- **Secondary Color**: Slate 600 (`#475569`)
- **Background**: Slate 100 (`#F1F5F9`)

## 📂 Project Structure

- `Forms/`: Contains all application screens (`Home`, `Login`, `BookDetails`, etc.).
- `Controls/`: Custom UI components (`RoundedButton.cs`, `ModernTextBox.cs`, `Card.cs`).
- `Helpers/`: Static utilities (`UIHelper.cs`).
- `Models/`: EF Core entity classes (`Book`, `Author`, `Category`).
- `Data/`: Database context (`LibraryContext.cs`).

---

*Built with ❤️ using .NET WinForms*
