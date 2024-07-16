## Bookstore CRUD App - .NET Core MVC

### Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
  - [Book Management](#book-management)
  - [Validations](#validations)
  - [Edit and Details](#edit-and-details)
  - [Fuzzy Search](#fuzzy-search)
- [Contributing](#contributing)
- [License](#license)

### Introduction

The Bookstore CRUD App is a web application built using .NET Core MVC & EF Core. It provides a simple and intuitive interface for managing a bookstore's inventory, allowing users to perform Create, Read, Update, and Delete (CRUD) operations on book records.

### Features

- **Book Management**: Users can create, view, update, and delete book records, including details such as title, author, description, price, and publication date.
- **Data Seeding**: The application uses EF Core to seed the database with initial book records for demonstration purposes.
- **Object Models**: EF Core is used to define the object models for books, including validation rules and relationships.
- **Validations**: The application implements validations to ensure that book records are created and updated with valid data.
- **Search and Filtering**: Users can search for books by title or author, and filter the book list based on various criteria.
- **User Authentication**: The application supports user authentication, allowing users to access and manage their own book records.
- **Responsive Design**: The application is designed to be mobile-friendly and responsive, ensuring a seamless user experience across different devices.

### Technologies Used

- **ASP.NET Core MVC**: The application is built using the .NET Core MVC framework, providing a robust and scalable web development platform.
- **Entity Framework Core**: The application uses Entity Framework Core for data access, database management, and data seeding.
- **SQL Server**: The application uses SQL Server as the underlying database for storing book records.
- **Bootstrap**: The application's user interface is styled using the Bootstrap CSS framework, ensuring a modern and responsive design.
- **jQuery**: The application utilizes jQuery for client-side scripting and enhancing the user experience.

### Getting Started

#### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or any other compatible database management system)

#### Installation

1. Clone the repository:

   ```
   git clone https://github.com/your-username/bookstore-crud-app.git
   ```

2. Navigate to the project directory:

   ```
   cd bookstore-crud-app
   ```

3. Restore the project dependencies:

   ```
   dotnet restore
   ```

4. Update the database connection string in the `appsettings.json` file to match your SQL Server configuration.

5. Apply the database migrations:

   ```
   dotnet ef database update
   ```

6. Build and run the application:

   ```
   dotnet run
   ```

7. Open your web browser and navigate to `https://localhost:5001` to access the Bookstore CRUD App.

### Usage

#### Book Management

1. Register or log in to the application.
2. Manage book records by creating, reading, updating, and deleting them.
3. Use the search and filtering features to find specific books.
4. Explore the responsive design and navigate the application on different devices.

#### Validations

The application implements validations to ensure that book records are created and updated with valid data. These validations include:

- **Required fields**: Title, author, description, price, and publication date are required.
- **Price validation**: The price must be a positive number.
- **Publication date validation**: The publication date must be in the past.

#### Edit and Details

The application provides pages for editing and viewing the details of a book record. The edit page allows users to modify the book's details, while the details page displays all the information about a specific book.

#### Fuzzy Search

The application supports fuzzy search, which allows users to search for books by title or author even if they don't know the exact spelling. The search results will include books that closely match the search query.

### Contributing

Contributions to the Bookstore CRUD App are welcome! If you find any issues or have suggestions for improvements, please feel free to submit a pull request or open an issue on the [GitHub repository](https://github.com/your-username/bookstore-crud-app).

### License

This project is licensed under the [MIT License](LICENSE).
