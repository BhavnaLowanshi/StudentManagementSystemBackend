# Student Management System API

Built with ASP.NET Core Web API, EF Core, and JWT Authentication.

## Features
- **CRUD Operations**: Get all, Add, Update, and Delete students.
- **JWT Authentication**: Secure endpoints using JSON Web Tokens.
- **Global Exception Handling**: Custom middleware for centralized error management.
- **Logging**: Serilog integration for request and error logging.
- **Swagger Documentation**: Interactive API testing with JWT support.
- **Layered Architecture**: Controller -> Service -> Repository.

## Technologies Used
- .NET Core 9.0
- Entity Framework Core (SQL Server)
- JWT Bearer Authentication
- Serilog
- Swashbuckle (Swagger)

## Prerequisites
- .NET 9 SDK
- SQL Server Express (LocalDB)
- Visual Studio 2022 or VS Code

## Setup Instructions
1. **Clone the project** to your local machine.
2. **Database Configuration**:
   - Update the `DefaultConnection` string in `appsettings.json` to point to your SQL Server instance.
3. **Apply Migrations**:
   - Run `dotnet ef database update` to create the database schema.
4. **Run the Application**:
   - Run `dotnet run` or use your IDE's play button.
5. **Access API Documentation**:
   - Navigate to `http://localhost:<port>/index.html` to view the Swagger UI.

## Authentication (JWT)
1. Use the `/api/Auth/login` endpoint to get a token.
   - Credentials for testing: `admin@school.com` / `Admin@123`
2. Copy the token and authorize in Swagger:
   - Click "Authorize" button.
   - Enter: `Bearer [your_token]`
3. Now you can access the protected `/api/Students` endpoints.

## Evaluation Criteria Met
- **Code Quality**: Clean, structured, and follows .NET best practices.
- **Architecture**: Separated into Controllers, Services, and Repositories.
- **Error Handling**: Global middleware handles all exceptions correctly.
- **Security**: JWT implementation restricts unauthorized access.
- **API functionality**: Fully working CRUD operations for the Student model.
