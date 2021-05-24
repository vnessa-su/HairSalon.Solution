# Eau Claire's Salon

#### Eau Claire's Salon web app for adding, editing, and displaying information on their stylists and clients.

#### By Vanessa Su

## Description

MVC pattern web app that displays information on the stylists and clients of Eau Claire's Salon from a database. That database includes a Stylists table and a Clients table with rows associated to a Stylist. The web app also allows the user to add new entries for either table and edit/delete entries already in the database.

## User Story

* See a splash page with links to the stylist list, client list, and their respective pages to add new entries
* See the list of all stylists
* Select a stylist to see their details and a list of their clients
* Add a new stylist
* Edit a stylist's entry
* Delete a stylist from the database
* See the list of all clients
* Select a client to see their details and their associated stylist
* Add a new client with an associated stylist
* Edit a client's entry
* Delete a client from the database

## Technologies Used

* C#
* ASP.NET&#8203; Core
* Razor
* Entity Framework Core
* MySQL
* VS Code

## Setup/Installation Requirements

### Prerequisites
* [MySQL](https://www.mysql.com/)
* [.NET](https://dotnet.microsoft.com/)
* A text editor like [VS Code](https://code.visualstudio.com/)

### Installation
1. Clone the repository: `git clone https://github.com/vnessa-su/HairSalon.Solution.git`
2. Navigate to the `/HairSalon.Solution` directory
3. Open with your preferred text editor to view the code base
* #### Database Setup
1. Log into your MySQL server using `mysql -u root -p`
2. Enter in password when prompted
3. Create database: `mysql> CREATE vanessa_su;`
4. Select database: `mysql> USE vanessa_su;`
5. Check that `vanessa_su` is selected: `mysql> SELECT DATABASE();`
6. Load tables from provided file: `mysql> source vanessa_su.sql;`
7. Check that the `Stylists` and `Clients` tables were loaded: `mysql> SHOW TABLES;`
8. Exit MySQL: `mysql> exit`
* #### Run the Program
1. Navigate to the `/HairSalon` directory
2. Create appsettings.json file: `touch appsettings.json`
3. Open appsettings.json in a text editor and add in:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=<port number>;Database={PROJECT_DATABASE};Uid=root;Pwd=<password>;"
  }
}
```
  * Replace `<port number>` with the port number the server is running on, default is usually 3306
  * Replace `<password>` with your MySQL password
4. Save the file and go back to the terminal
5. Run `dotnet restore`
6. Run `dotnet build`
7. Start the program with `dotnet run`
8. Open http://localhost:5001/ in your preferred browser

## Known Bugs

_No known bugs_

## Contact Information

For any questions or comments, please reach out through GitHub.

## License

[MIT License](license)

Copyright (c) 2021 Vanessa Su