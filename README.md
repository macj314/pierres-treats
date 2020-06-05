# _Pierre's Treats_

#### _Epicodus Project Jun 5, 2020_

#### By _**Jason Macie**_

## Description

_This is a project that allows users to add and track flavors and treats in a database. The user should be able to register and login to the site. They can then add, view, edit, and delete all of their flavors and treats._

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. Create an appsettings.json folder in the root directory. Set the 'server', 'port', 'uid', and 'pwd' to your own personal setting for your SQL service. But set the 'database' setting to jason_macie<br>
Example: 
``` 
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=server;Port=port;database=jason_macie;uid=userid;pwd=password;"
  }
}
```
4. Run the program with the commands dotnet restore, dotnet build, and dotnet run inside of the PierresTreats directory.

### Create Database 
#### SQL Queries:
```
CREATE SCHEMA `jason_macie` ;
USE `jason_macie`;
CREATE TABLE `flavors` (
  `FlavorId` int NOT NULL AUTO_INCREMENT,
  `Name` longtext,
  `UserId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`FlavorId`),
  KEY `IX_Flavors_UserId` (`UserId`),
  CONSTRAINT `FK_Flavors_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `flavortreat` (
  `FlavorTreatId` int NOT NULL AUTO_INCREMENT,
  `TreatId` int NOT NULL,
  `FlavorId` int NOT NULL,
  PRIMARY KEY (`FlavorTreatId`),
  KEY `IX_FlavorTreat_FlavorId` (`FlavorId`),
  KEY `IX_FlavorTreat_TreatId` (`TreatId`),
  CONSTRAINT `FK_FlavorTreat_Flavors_FlavorId` FOREIGN KEY (`FlavorId`) REFERENCES `flavors` (`FlavorId`) ON DELETE CASCADE,
  CONSTRAINT `FK_FlavorTreat_Treats_TreatId` FOREIGN KEY (`TreatId`) REFERENCES `treats` (`TreatId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `treats` (
  `TreatId` int NOT NULL AUTO_INCREMENT,
  `Name` longtext,
  `Ingredients` longtext,
  `Description` longtext,
  `UserId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`TreatId`),
  KEY `IX_Treats_UserId` (`UserId`),
  CONSTRAINT `FK_Treats_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```

#### Use SQL File
Or import jason_macie.sql in the root directory of this program.

## Known Bugs

There are no known bugs at the time of this update.

## Technologies Used

* C#
* .NET Core
* MSBuild
* ASP.Net Core
* MVC
* Razor
* HtmlHelper
* Entity Framework Core
* Git and GitHub

## Specs

| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **Users are presented with a homepage to navigate to a login page as well as a page that displays a list of treats, and flavors.** | User Input:"Enter site" | Output: "Pierre's Sweet and Savory Treats!" |
| **Users can register an account and login.** | User Input: Name:"Jeremy" Email: test@testmail.com Password: **** | Output: "Logged in as Jeremy" |
| **Users can create flavors/treats and view their details. They can also edit/delete any flavors they've created while logged in.** | User Input: Create flavor Sweet | Output: Flavor Name: Sweet Edit? Delete? Details

### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Jason Macie_**