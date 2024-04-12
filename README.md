Search Application
This project is a search application built using .NET Core 8 for the backend API, Angular for the frontend user interface, and EntityFramework Core for database management.

Getting Started
To run this project locally, follow these steps:

Prerequisites
.NET Core 8
Node.js and npm
Angular CLI
Installation
Clone the repository:

bash
Copy code
git clone <repository-url>
cd <project-folder>
Backend Setup:

Navigate to the backend directory.

Run the following command to install dependencies and start the backend server:

bash
Copy code
dotnet run
Frontend Setup:

Navigate to the frontend directory.

Run the following command to install dependencies:

bash
Copy code
npm install
After installing dependencies, start the frontend server:

bash
Copy code
ng serve
Open your web browser and navigate to http://localhost:4200 to access the application.

Database Backup
A database backup file (SearchServiceDB.bak) is provided in the DB folder of this repository. You can use this backup to restore the database used by the application.

To restore the database:

Use a database management tool to restore the database backup from the SearchServiceDB.bak file.
Usage
Enter a search term in the input field and click the 'Search' button to search for people.
The application will display search results based on the entered search term.
Technologies Used
 -.NET Core 8
 - Angular
 - EntityFramework Core
