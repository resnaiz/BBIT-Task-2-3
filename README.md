# House Management 
This project is a REST API developed using ASP.NET Core that manages information about houses, apartments, and residents. It supports various operations such as retrieving, creating, updating, and deleting objects.

# Setup Instructions
Follow these steps to set up and run the project:

1. Clone the repository: git clone <repository-url>
2. Navigate to the project directory: cd <project-directory>
3. Install the required dependencies: dotnet restore
4. Configure the database connection in the appsettings.json file.
5. Apply the database migrations: dotnet ef database update
6. Run the project: dotnet run
7. Access the API endpoints using a tool like Postman or any web browser.
### Feel free to contact me if you have any questions or need further assistance.
  
## Task 2: REST API Development
- Developed a RESTful API using ASP.NET Core.
- Implemented three data types: House, Apartment, and Resident.
- Defined the properties for each data type as follows:
### House:
1. Number
2. Street
3. City
4. State
5. Postal Code
### Apartment:
1. Number
2. Floor
3. Number of Rooms
4. Number of Residents
5. Total Area
6. Livable Area
7. Reference to the House where the apartment is located
### Citizen:
1. First Name
2. Last Name
3. Personal Identity Code
4. Date of Birth
5. Phone Number
6. Email
7. Reference to the Apartment where the resident lives
- Implemented the following API operations:
1. Retrieving objects
2. Creating objects
3. Updating objects
4. Deleting objects
## Task 3: Real-Life Scenario Adaptation
- Refactored the data processing logic from the controllers to services.
- Connected the API to a SQL database.
- Created default database objects using database seed:
- Created two houses.
- Created five apartments in total.
- Created four residents in total.
- Configured the database for each model.
- Expanded the relationships between the models:
- Each resident can have multiple apartments.
- Each apartment can have multiple residents.
- Each house can have multiple apartments, but each apartment belongs to only one house.
- Added a new boolean field, "IsOwner," to the Resident model.
- Migrated the database to apply the changes.
- Created DTO (Data Transfer Object) models.
- Integrated AutoMapper for mapping between models and DTOs.
