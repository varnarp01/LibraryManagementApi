
# Library Management API

This project is a .NET Core Web API designed to manage a library system. It provides a set of RESTful endpoints for managing books and users, including borrowing and returning books. The API uses an in-memory database for simplicity and demonstration purposes.

## Table of Contents

- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Running the API](#running-the-api)
- [API Endpoints](#api-endpoints)
  - [Books Endpoints](#books-endpoints)
  - [Users Endpoints](#users-endpoints)
- [Data Models](#data-models)
- [Error Handling](#error-handling)
- [Swagger Documentation](#swagger-documentation)
- [Contributing](#contributing)
- [License](#license)

## Introduction

The Library Management API is built using ASP.NET Core 7 and provides a set of endpoints for managing a simple library system. The system allows librarians to add, update, and delete books, and customers to borrow and return books. It uses an in-memory database, which means data is not persisted between application restarts.

## Prerequisites

- **.NET 7 SDK**: Make sure to have the .NET 7 SDK installed. You can download it from the [official website](https://dotnet.microsoft.com/download/dotnet/7.0).
- **Visual Studio 2022** or **Visual Studio Code**: Any code editor that supports .NET development.

## Installation

1. **Clone the repository**:

   ```bash
   git clone https://github.com/varnarp01/LibraryManagementApi.git
   cd LibraryManagementApi
   ```

2. **Install dependencies**:

   Navigate to the project directory and run:

   ```bash
   dotnet restore
   ```

   This will restore all the necessary packages required for the project.

## Running the API

To run the API, use the following command:

```bash
dotnet run
```

The API will start and listen on `https://localhost:7257` and `http://localhost:5009`.

## API Endpoints

### Books Endpoints

1. **GET /api/books**
   - **Description**: Retrieves a list of all books.
   - **Response**: Returns a list of books in JSON format.

2. **GET /api/books/{id}**
   - **Description**: Retrieves details of a specific book by its ID.
   - **Parameters**: `id` (Guid): The unique identifier of the book.
   - **Response**: Returns the book details in JSON format.

3. **POST /api/books**
   - **Description**: Adds a new book to the library.
   - **Request Body**: A JSON object representing the book to be added.
   - **Response**: Returns the created book's details.

4. **PUT /api/books/{id}**
   - **Description**: Updates an existing book's information.
   - **Parameters**: `id` (Guid): The unique identifier of the book.
   - **Request Body**: A JSON object representing the updated book details.
   - **Response**: Returns `204 No Content` on successful update.

5. **DELETE /api/books/{id}**
   - **Description**: Removes a book from the library.
   - **Parameters**: `id` (Guid): The unique identifier of the book.
   - **Response**: Returns `204 No Content` on successful deletion.

6. **PATCH /api/books/{id}/borrow**
   - **Description**: Marks a book as borrowed.
   - **Parameters**: `id` (Guid): The unique identifier of the book.
   - **Response**: Returns `204 No Content` on successful operation.

7. **PATCH /api/books/{id}/return**
   - **Description**: Marks a book as returned.
   - **Parameters**: `id` (Guid): The unique identifier of the book.
   - **Response**: Returns `204 No Content` on successful operation.

### Users Endpoints

1. **GET /api/users**
   - **Description**: Retrieves a list of all users.
   - **Response**: Returns a list of users in JSON format.

2. **GET /api/users/{id}**
   - **Description**: Retrieves details of a specific user by their ID.
   - **Parameters**: `id` (Guid): The unique identifier of the user.
   - **Response**: Returns the user details in JSON format.

3. **POST /api/users**
   - **Description**: Adds a new user to the library system.
   - **Request Body**: A JSON object representing the user to be added.
   - **Response**: Returns the created user's details.

## Data Models

### Book Model

```csharp
public class Book
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public bool IsAvailable { get; set; } = true;
}
```

### User Model

```csharp
public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
}
```

## Error Handling

- **404 Not Found**: Returned when a book or user is not found.
- **400 Bad Request**: Returned when the request parameters are invalid.
- **500 Internal Server Error**: Returned when there is an unhandled exception on the server.

## Swagger Documentation

The API is documented using Swagger. To access the Swagger UI:

1. Start the API by running `dotnet run`.
2. Open your browser and navigate to `https://localhost:7257/swagger` or `http://localhost:5009/swagger`.

Swagger provides an interactive UI to test all available endpoints.

## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature-branch`).
5. Create a new Pull Request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
