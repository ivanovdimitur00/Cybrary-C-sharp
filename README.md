# Cybrary (C#)
Simple web app for posting and searching e-books using C#, .NET framework and the MVC architecture.
<br/>
<br/>

## Table of contents
0. [Project status](#Project-status)
1. [Description](#Description)
3. [Key features and functionalities](#Key-features-and-functionalities)
4. [Structure](#Structure)
5. [Installation instructions](#Installation-instructions)
6. [Dependencies](#Dependencies)
7. [System requirements](#System-requirements)
8. [Usage examples](#Usage-examples)
9. [API references](#API-references)
10. [Bugs](#Bugs)
11. [Future improvements](#Futute-improvements)
<br/>

## Project status
Completed and working. Not expecting changes.
<br/>
<br/>

## Description
The purpose and goal of the project is to create an MVC project using C# and .NET .

The intended audiences for the project are the teacher in my .NET programming class and myself.
<br/>
<br/>

## Key features and functionalities
* ### KEY FEATURES
  * Users can browse books without an account but can't post books;
  * Users can register an account;
  * Users can login with a registered account;
  * Logged users can upload books;
  * Users can search books using the search bar and also apply filters.
 
* ### FUNCTIONALITIES
  * Login and register system, provided by microsoft;
  * SQL Database model;
  * Search and Filtering.
<br/>

## Structutre
Here are some of the important directories and files you need to know about this project:
* `Program.cs` and `Startup.cs` - program files for configuring the project upon startup;
* `wwwroot` - contains some files for the frontend;
* `Properties/launchSettings.json` - network config file;
* `Pages` - folder, containing the frontend web page files;
* `Models` - folder, containing the book entity file;
* `Data` - folder, containing the database migrations and `ApplicationDBContext.cs` file.
<br/>

## Installation instructions
Usually, the project is supposed to be hosted on a server and given a domain. However, I don't have a HomeLab or am I able to rent a server or a domain. Instead:
1. Download this project;
2. Open the Project in Visual Studio 2022;
3. Open Miscrosoft SQL Server 2022;
4. Ensure you have all the needed dependencies;
5. Ensure you are connecting to your local database;
6. Build the project. You should have access now.
<br/>

## Dependencies
This is a list of dependencies that you need if you want to run the project locally. Aside from **an internet connection**, you will need:
* Visual Studio 2022;
* Microsoft SQL Server 2022;
* Microsoft .NET framework 6.X;
* NuGet packages:
  * "Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore" Version="6.0.13";
  * "Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="6.0.13";
  * "Microsoft.AspNetCore.Identity.UI" Version="6.0.13";
  * "Microsoft.EntityFrameworkCore" Version="7.0.5";
  * "Microsoft.EntityFrameworkCore.Design" Version="7.0.5";
  * "Microsoft.EntityFrameworkCore.SqlServer" Version="7.0.5";
  * "Microsoft.EntityFrameworkCore.Tools" Version="6.0.16";
  * "Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="6.0.13".
<br/>

## System requirements
The project has been developed for the Miscrosoft Windows operating system.
| System requirements  |
| -------------------- | 
| Microsoft Windows 10 | 
<br/>

## Usage examples
We assume that the project has been accessed on the internet or has been run on a local instance. 
<br/>

1. For unregistered users:
  * They can look at books and search for them, but not edit;
  * They can register and/or login.
2. For logged-in users:
  * They can create their own books;
  * They can search for books.
3. For Administrators:
<br/>

## API references
Nothing to mention here.
<br/>
<br/>

## Bugs
- [x] No bugs have been caught.
<br/>

## Future improvements
- [ ] Pick a domain for the website and a hosting solution;
- [ ] Implement a simple frontend.
