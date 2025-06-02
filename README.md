# winforms-blood-sugar-diary
A WindowsForms application for tracking blood sugar measurements, using Entity Framework Code First approach.

## Features

- **User Authentication**: Secure login and registration system with error handling
- **Measurement Tracking**: 
  - Add, edit, delete blood sugar measurements
  - Visual indicators for high/low values
- **Data Export**: Export measurements to XML format
- **Patient Management**: Edit patient profile information
- **Responsive UI**: Color-coded data grid view with intuitive controls

## Technologies Used

- **.NET Framework**: Windows Forms application
- **Entity Framework**: Code First approach for database management
- **SQL Server**: LocalDB for data storage
- **LINQ**: For data queries and manipulation
- **XML Serialization**: For data export functionality
- **Dependency Separation**: Business logic separated into class library

## Setup Instructions

### Prerequisites

- Visual Studio 2019 vagy újabb (ajánlott: 2022)
- .NET Framework 4.7.2 vagy újabb
- SQL Server Express LocalDB (usually automatically installed with Visual Studio)

### Installation Steps

1. Clone the repository
2. Open the solution in Visual Studio
3. Build the solution to restore NuGet packages
4. Run database migrations:
   - Open Package Manager Console
   - Run `Update-Database` command
5. Run the application

### Common Setup Issues

1. **Database Connection Errors**:
   - Ensure LocalDB is installed
   - Check connection string in App.config

2. **Migration Problems**:
   - Try running `Add-Migration InitialCreate -Force` if initial migration fails
   - Delete Migrations folder and recreate if needed

3. **Missing NuGet Packages**:
   - Right-click solution → "Restore NuGet Packages"

## Usage

1. Register a new account
2. Add blood sugar measurements
3. View color-coded history of your measurements
4. Export data or edit your profile as needed

