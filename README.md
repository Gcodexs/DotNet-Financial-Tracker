## What Did I Build?
A **Full Stack web application** that connects three components: a user interface, a backend server, and a database.

The goal is to understand how these components communicate with each other and what role each one plays within the application.

### 🎨 Frontend — React
The frontend is the visual part of the application. It is what users see and interact with through their web browser.
### ⚙️ Backend — C# and .NET 10
The backend is the server responsible for processing requests from the frontend.
I used SQLite as the database, which can store information in a local file named `financial.db`.

<p align="center">
<img width="65%" alt="01" src="https://github.com/user-attachments/assets/2b56a6f1-2458-468a-b4e6-48aaeaaf8fde" />
</p>

## Creating the Main Project Folder
Before building the application, we need to organize the files inside a main project directory.
**Command used in the terminal:**

```bash
mkdir -p Documents/DotNet-Financial-Tracker
```
- `mkdir`: creates a directory.
- `-p`: creates any necessary parent directories and avoids errors if they already exist.
- `Documents/DotNet-Financial-Tracker`: specifies the path and name of the directory.

## Creating the Backend with .NET 10

Once we are inside the main project directory, we create the backend.

**Command used in the terminal:**

```bash
dotnet new webapi -o Backend
```
This command generates the initial server structure, including configuration files and C# source code.

- `dotnet`: runs the .NET command-line tool.
- `new`: creates a new project from a template.
- `webapi`: selects the template for building a web API.
- `-o Backend`: creates the project files inside a directory named `Backend`.
