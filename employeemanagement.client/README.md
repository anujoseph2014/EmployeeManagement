# EmployeemanagementClient

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 14.1.3.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via a platform of your choice. To use this command, you need to first add a package that implements end-to-end testing capabilities.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.


PROJECT STRUCTURE

.
├── angular       # Angular application frontend
│   ├── src        # Source code for Angular components, services, etc.
│   │   └── app    # Main Angular application module
│   ├── package.json  # Dependencies and scripts for the Angular application
│   └── ...          # Other Angular-related files
├── backend       # .NET Core backend project
│   ├── Controllers # API controllers for CRUD operations
│   ├── DataAccess  # Data access layer for interacting with SQLite3
│   ├── Models       # Data models representing employee data
│   ├── Services     # Services for business logic
│   ├── Program.cs    # Application startup configuration (including CORS)
│   └── ...          # Other .NET Core-related files
├── launchSettings.json  # Configuration for launching the backend in different environments
└── README.md         # This file (project documentation)



USING THE APPLICATION

1.Start the backend using dotnet run in the backend directory (optional for local testing).
2.Run ng serve in the angular directory to start the Angular frontend.
3.Access the application in your browser at http://localhost:4200.

Additional Notes

CORS: The .NET Core backend's Program.cs file should be configured to allow CORS requests from the Angular frontend's origin (http://localhost:4200).
Swagger: When running the .NET Core backend, you might be able to access Swagger documentation to inspect the available API endpoints at https://localhost:44313/swagger/index.html (adjust the port if necessary).
SQLite3: SQLite3 is a lightweight, embedded database that is included with the .NET Core project automatically.
