# Uncommon Animal Shelter
#### A program for an animal shelter (specializing in farm animals; eg. donkeys, cows, sheep).  that implements an API to allow users to search through adoptable animals by query (name, species, gender, age). 

#### By **Sharon Lee**
## 🎉 Contents

- [Description](#-description)
- [Specifications](#-specifications)
- [Instructions](#-instructions)
- [Contact](#-contact)
- [License](#-license)

## Description
This program for this uncommon animal shelter implements an API that has full CRUD functionality (CREATE, READ, UPDATE, DESTROY) and returns responses to API calls. Users are able to search the database by query strings such as name, age, species, and gender. This program includes Swagger for easier documentation. 

### Specifications
| Spec | Input | Output |
| :-------------     | :------------ | :------------- |
| **Postman** | User accesses:http://localhost:5000/api/animals| User view: List of all animals |
| **User gets animal by id| get : http://localhost:5000/api/animals/1 | {"animalId":1,"name":"Molly","species":"Donkey","age":8,"gender":"Female"} |
| **User creates new animal | Post: http://localhost:5000/api/animals {"name":"Molly","species":"Donkey","age":8,"gender":"Female"}  |  Animal is now in database |
| **User deletes animal from database | Delete: http://localhost:5000/api/animals/1 | Animal with animalId 1 is now deleted |

### Instructions

1. Clone this repository: https://github.com/arynsh/UncommonAnimalShelter.Solution
```
$ git clone https://github.com/arynsh/UncommonAnimalShelter.Solution
```
2. Open the command line--and navigate into the repository, then navigate into the UncommonShelter folder.
3. In the command line, type in "dotnet restore" then "dotnet run".
```
$ dotnet restore
```
```
$ dotnet run
```
4. On your browser, open http://localhost:5000/swagger/index.html OR open Postman app and go to localhost:5000/api/animals/ OR go to https://app.swaggerhub.com/apis/arynsh/shelterAPIswagger/v1
5. To access an individual animal, add animal's ID to the end of localhost:5000/api/animals/
(example: localhost:5000/api/animals/1)
6. To search for an animal by query string through Postman, here are the endpoints: name, age, species, gender.
(localhost:5000/api/animals/?age=5)
7. To delete or update an animal through Postman, add their ID to the end of localhost:5000/api/animals/ and choose "Delete" instead of "Get".
(example: localhost:5000/api/animals/5)
8. To get an animal though name, age , or species through Swagger's documentation at http://localhost:5000/swagger/index.html, click the first "Get". Click "Try it out", then enter a query, and hit "execute".
9. To post an animal through Swagger's documentation at http://localhost:5000/swagger/index.html,click "Post" and "Try it out". Enter fields such as name, age, gender, species, and id. Click execute".
10. To edit an animal, click "Put" and "Try it out". Choose the animal by their animalId and change the field you'd like to modify. Click "execute".
11. To get or delete an individual animal, click "Get" (third down) or "Delete". Choose animal that you wish to edit or delete by id.


## Known Bugs
* No known bugs at this time.

## 📋 Technologies Requirements
 You may use Windows, macOS, or Linux as your development operating system, though building and running apps may be limited.
 Tools used:  
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.Net](https://dotnet.microsoft.com/apps/aspnet)
* [MySQLWorkbench](https://www.mysql.com/)
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/#pivot=entityfmwk)
* Microsoft.NET.Sdk.Web
* [Visual Studio](https://www.visualstudiocommunity.com)
* [GitHub](https://www.github.com)
* HTML
*[Postman](https://www.getpostman.com/)
*[Swagger/OpenAPI](https://swagger.io/solutions/api-design/)
 
### Support and Contact details
| Author | GitHub | Email |
|--------|:------:|:-----:|
Sharon Lee| [arynsh](https://github.com/arynsh) |  [sharonlee714@gmail.com](mailto:sharonlee714@gmail.com) 

_Please contact with questions and/or comments._

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **Sharon Lee**