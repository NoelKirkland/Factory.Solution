# Dr. Sneuss' Factory

### By Noel Kirkland, 8/7/2020

•[Stories](#1)<br>
•[Setup](#2)<br>
•[Bugs](#3)<br>
•[Contact](#4)<br>
•[Tech](#5)<br>
•[License](#6)

## Description

This project will help the famous Dr. Sneuss keep track of their engineers, as well as their machines, in an easy to use web application. Once set up properly, Dr. Sneuss will be able store data on their engineers, and on their machines, in a local database and will be able to pull up the information they need at any time.

## User Stories <a name="1"></a>

* As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.

* As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it.

* As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.

* As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed

* As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.

* As the factory manager, I need to be able to specify if a machine is operational, malfunctioning, or in the process of being repaired.

* As the factory manager, I need to be able to specify if an engineer is idle, or actively working on repairs.

* As the factory manager, I need to be able to add inspection dates to the machines, or dates of license renewal to the engineers.

* I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it.

## Setup/Installation Requirements <a name="2"></a>

* _Install the .NET framework_
  1. _This program utilizes .NET version 3.1, and requires [this framework to be pre-installed](https://dotnet.microsoft.com/download/dotnet-core/3.1)_

* _Install and configure MySQL_
  1. _This program utilizes MySQL Community Server version 8.0.15 and requires [this to be pre-installed](https://dev.mysql.com/downloads/file/?id=484914). Click the link at the bottom that reads "No thanks, just start my download"_
  2. _Use Legacy Password Encryption and set password to "epicodus"_
  3. _Click "Finish_

* _Download this application from HitHub_
  1. _Open the following web address in your browser: **`https://github.com/NoelKirkland`**_
  2. _Click on the button labeled_ Repositories
  3. _Navigate into the **`Factory.Solution`** repository and click the green button labeled "Clone or download" and download the zip to your computer_

* _Install the MySQL database_
  1. _Open the downloaded application in a text editor ([V.S. Code preferred](https://code.visualstudio.com/))_
  2. _Open a new terminal in your text editor (Ctrl+\` in V.S. Code) and run command `> echo 'export PATH="$PATH:/usr/local/mysql/bin"' >> ~/.zprofile`_
  3. _Enter the command `> source ~/.zprofile` to confirm MsSQL has been installed_
  4. _Connect to MySQL by running the command `> mysql -uroot -pepicodus`_
  5. _Install the necessary MySQL database by copying the code block below and entering it into your terminal_
  6. _Once the following code block has been entered you will close MySQL by running the command `> exit`_

```
      DROP DATABASE IF EXISTS `noel_kirkland`;
      CREATE DATABASE `noel_kirkland` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
      USE `noel_kirkland`;
      CREATE TABLE `Engineers` (
      `EngineerId` int(11) NOT NULL AUTO_INCREMENT,
      `EngineerName` longtext,
      `ActiveIdle` bit(1) NOT NULL,
      `LastLicensed` datetime(6) NOT NULL,
      PRIMARY KEY (`EngineerId`)
      ) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
      CREATE TABLE `Machines` (
      `MachineId` int(11) NOT NULL AUTO_INCREMENT,
      `MachineName` longtext,
      `Status` longtext,
      `LastInspection` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000',
      PRIMARY KEY (`MachineId`)
      ) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
      CREATE TABLE `EngineerMachine` (
      `EngineerMachineId` int(11) NOT NULL AUTO_INCREMENT,
      `EngineerId` int(11) NOT NULL,
      `MachineId` int(11) NOT NULL,
      PRIMARY KEY (`EngineerMachineId`),
      KEY `IX_EngineerMachine_EngineerId` (`EngineerId`),
      KEY `IX_EngineerMachine_MachineId` (`MachineId`),
      CONSTRAINT `FK_EngineerMachine_Engineers_EngineerId` FOREIGN KEY (`EngineerId`) REFERENCES `engineers` (`EngineerId`) ON DELETE CASCADE,
      CONSTRAINT `FK_EngineerMachine_Machines_MachineId` FOREIGN KEY (`MachineId`) REFERENCES `machines` (`MachineId`) ON DELETE CASCADE
      ) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```

* _Run the application_
  1. _In the terminal, navigate to the project directory by running the command `> cd Factory`_
  2. _Now that we are in the Factory directory you will run the command `> dotnet restore`_
  3. _Once the "obj" folder has initialized you will run the command `> dotnet run`_
  4. _Go to http://localhost:5000/ in your preferred browser to use the application_


## Known Bugs <a name="2"></a>

There are no known bugs at this time

## Support and Contact Details <a name="3"></a>

If there are any issues or questions contact me at noelkirkland@gmail.com

## Technologies Used <a name="4"></a>

*  C#/.NET
*  MySQL
*  HTML
*  CSS
*  Markdown


### License <a name="5"></a>

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*