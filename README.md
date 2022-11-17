# Who wants to be a Millionaire

Simple implementation of popular TV show


## Configuration

#### 1. Change your database connection string in [appsettings.json](https://github.com/dtamon/Task2_MillionaireGame/blob/master/Task2_MillionaireGame/appsettings.json)
````json
"ConnectionStrings": {
    "connection": "Server=localhost\\SQLEXPRESS;Database=millionaire_game;Trusted_Connection=True;TrustServerCertificate=True;"
  },
  ````
#### 2. Initiate database
Run `update-database` command in Package Manager Console
#### 2. Fill database with sample data using script [InsertSampleData.sql](https://github.com/dtamon/Task2_MillionaireGame/blob/master/InsertSampleData.sql)


## Architecture

- I used Entity Framework Core for easy communication with database
- [HomeController](https://github.com/dtamon/Task2_MillionaireGame/blob/master/Task2_MillionaireGame/Controllers/HomeController.cs)'s job is to communicate between View and [HomeService](https://github.com/dtamon/Task2_MillionaireGame/blob/master/Task2_MillionaireGame/Services/HomeService.cs) and to decide which View should be displayed depending on the correctness of the answer and the level the player is at 
- [HomeService](https://github.com/dtamon/Task2_MillionaireGame/blob/master/Task2_MillionaireGame/Services/HomeService.cs)'s job is to call [Repositories](https://github.com/dtamon/Task2_MillionaireGame/tree/master/Task2_MillionaireGame/Repositories) to access data from database, cast received data to [GameViewModel](https://github.com/dtamon/Task2_MillionaireGame/tree/master/Task2_MillionaireGame/Models) that will be displayed in View, check correctness of chosen answers and randomize the choice of questions and order of answers 
- [Repositories](https://github.com/dtamon/Task2_MillionaireGame/tree/master/Task2_MillionaireGame/Repositories) job is to get needed data from database using LINQ, each repository corresponds to a table from the database
- [GameViewModel](https://github.com/dtamon/Task2_MillionaireGame/blob/master/Task2_MillionaireGame/Models/GameViewModel.cs) is a complex model composed of data from all tables from the database. It contains an information about [Level](https://github.com/dtamon/Task2_MillionaireGame/blob/master/Task2_MillionaireGame/Context/Level.cs) that the player is currently on, randomly selected [Question](https://github.com/dtamon/Task2_MillionaireGame/blob/master/Task2_MillionaireGame/Context/Question.cs) from a level and randomly assigned [Answers](https://github.com/dtamon/Task2_MillionaireGame/blob/master/Task2_MillionaireGame/Context/Question.cs) to the question

## Database (Microsoft SQL Server)
#### Database consist of three tables:
- [Levels](https://github.com/dtamon/Task2_MillionaireGame/blob/master/Task2_MillionaireGame/Context/Level.cs) (containing Id and the Prize for completion of a level)
- [Questions](https://github.com/dtamon/Task2_MillionaireGame/blob/master/Task2_MillionaireGame/Context/Question.cs) (containing Id, Content of the question and the Id of the level to which it is assigned)
- [Answers](https://github.com/dtamon/Task2_MillionaireGame/blob/master/Task2_MillionaireGame/Context/Question.cs) (containing Id, Content of the answer, information whether answer is true or false and If of the question to which it relates)
