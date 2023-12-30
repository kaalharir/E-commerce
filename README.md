# E-commerce
How to Run:
Follow these steps to run the E-commerce CRUD Operations project locally:

Prerequisites:
.NET SDK installed
Visual Studio or any preferred code editor
Clone the Repository:
bash
Copy code
git clone https://github.com/kaalharir/E-commerce.git
cd E-commerce
Database Setup:
Open the project in Visual Studio or your preferred code editor.

Open the appsettings.json file in the project root.

Update the connection string to point to your SQL Server instance:

json
Copy code
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=ECommerceDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
Modify the Server, Database, and authentication settings accordingly.

Open the Package Manager Console (PMC) and run the following commands to apply migrations:

bash
Copy code
Update-Database
Run the Application:
Build and run the project from Visual Studio or use the following commands:

bash
Copy code
dotnet build
dotnet run
Open your web browser and navigate to http://localhost:5000.

You should see the E-commerce application running.

Access the Application:
Explore the various pages to perform CRUD operations on products.
Create, read, update, and delete products as needed.
