# Dr Sneuss's Factory

  ### By [Taylor Somers](https://github.com/taylorsomers/)

## Description

  


## Languages & Technologies Used:

  ### Programming Languages, Libraries, & Frameworks
  * CSHTML
  * CSS
  * C#
  * Entity Framework
  * MVC
  * MySQL
  * .NET Core
  * Razor

  ### Operating Systems & Programs
  * Brave
  * Microsoft PowerShell
  * Microsoft Windows 10
  * Visual Studio Code

## Installation

  1.  Download a web browser, such as Apple Safari, Brave, Google Chrome, Microsoft Edge, Mozilla Firefox, or Yandex.
  2.  Navigate to https://github.com/taylorsomers/DrSneussFactory.Solution.
  3.  Click the green "Clone or download" button at the right of the screen.
  4.  Select "Download ZIP."
  5.  Use a file extractor or unzip program (such as PeaZip, Unzipper, WinZip, Zipware, or 7-ZIP) to extract the ZIP files onto your computer.
  6.  In your browser, navigate to https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer for Mac or https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer for Windows and click the link "click here to download manually" if the download for .NET Core 2.2 SDK does not start automatically.
  7.  Double-click the downloaded .NET Core 2.2 SDK file and run the installer.
  8.  Open your computer's terminal and navigate to the "Factory" subdirectory within the "Factory.Solution" directory.
  9.  Import the file "taylor_somers.sql" using your preferred SQL management tool.
  10. Enter the command "dotnet build" in the terminal.
  11. Enter the command "dotnet run" in the terminal. The program should begin to run in your browser.

  ### Database Setup Instructions

  CREATE DATABASE  IF NOT EXISTS `taylor_somers`;
  
  USE `taylor_somers`;

  DROP TABLE IF EXISTS `__efmigrationshistory`;

  CREATE TABLE `__efmigrationshistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    PRIMARY KEY (`MigrationId`)
  ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  DROP TABLE IF EXISTS `engineermachine`;

  CREATE TABLE `engineermachine` (
    `EngineerMachineId` int NOT NULL AUTO_INCREMENT,
    `EngineerId` int NOT NULL,
    `MachineId` int NOT NULL,
    PRIMARY KEY (`EngineerMachineId`),
    KEY `IX_EngineerMachine_EngineerId` (`EngineerId`),
    KEY `IX_EngineerMachine_MachineId` (`MachineId`),
    CONSTRAINT `FK_EngineerMachine_Engineers_EngineerId` FOREIGN KEY (`EngineerId`) REFERENCES `engineers` (`EngineerId`) ON DELETE CASCADE,
    CONSTRAINT `FK_EngineerMachine_Machines_MachineId` FOREIGN KEY (`MachineId`) REFERENCES `machines` (`MachineId`) ON DELETE CASCADE
  ) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  DROP TABLE IF EXISTS `engineers`;

  CREATE TABLE `engineers` (
    `EngineerId` int NOT NULL AUTO_INCREMENT,
    `EngineerName` longtext,
    PRIMARY KEY (`EngineerId`)
  ) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  DROP TABLE IF EXISTS `machines`;

  CREATE TABLE `machines` (
    `MachineId` int NOT NULL AUTO_INCREMENT,
    `MachineName` longtext,
    `MachineDescription` longtext,
    PRIMARY KEY (`MachineId`)
  ) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


## Specifications

  | Program Behavior | Example Behavior | Example Output | Met? (Y/N) |
  | ----------- | ----------- | ----------- | ----------- |
  | Program will display a splash page allowing the user to navigate to a list of all Engineers employed at the factory as well as all Machines in operation at the factory. | N/A | "View All Engineers; View All Machines" | Y |
  | When the "View All Engineers" link on the splash page is clicked and no Engineers have been created in the database, program will display an Engineers/Index view with a message that no Engineers have been added yet. | "View All Engineers" > *Click* | "All Engineers: No engineers have been entered into the database." | Y |
  | Program will display an "Add a New Engineer" link in the Engineers index view. | N/A | "Add an Engineer" | Y |
  | When the "Add a New Engineer" link on the Engineers index page is clicked, program will display an Engineers/Create view with a form to enter a new Engineer into the database. | "Add a New Engineer" > *Click* | "Enter a New Engineer: Engineer Name:[Input Field]; [Button: 'Enter New Engineer']; 'View All Engineers' | Y |
  | When a new Engineer's name is inputted into the input field and the "Enter New Engineer" button is clicked in the Engineers/Create view, program will add the inputted Engineer to the list of Engineers employed at the factory. | "Engineer Name:[James Bond]; [Button: 'Enter New Engineer']" > *Click* | "All Engineers: James Bond" | Y |
  | When an Engineer's name is clicked in the Engineers index view, and if no machine licenses have been added for that engineer, program will display an Engineers/Details view with a message that no machine licenses have been added yet. | "All Engineers: James Bond" > *Click* | "Engineer Details; Engineer Name: James Bond; This engineer is not licensed to work on any machines yet." | Y |
  | When the "Edit Engineer Info" link in the Engineers/Details view is clicked, program will display an Engineers/Edit view with a field for the user to change Engineer information. | "Edit Engineer Info" > *Click* | "Edit Engineer Info: James Bond; Engineer Name:[James Bond]; [Button: 'Save']" | Y |
  | When the user inputs an edited Engineer Name into the input field and clicks the "Save" button in the Engineers/Edit view, program will display the Engineers/Details view with the edited Engineer Name. | "Edit Engineer Info: James Bond; Engineer Name:[Jimbo]; [Button: 'Save']" > *Click* | "Engineer Details; Engineer Name: Jimbo; This engineer is not licensed to work on any machines yet." | Y |
  | When the "Add Machine License" link in the Engineers/Details view is clicked, program will display an Engineers/AddMachine view with a dropdown list from which a Machine can be selected. | "Engineer Details / Engineer Name: Jimbo / This engineer is not licensed to work on any machines yet. / Add Machine License" > *Click* | "Add a Machine License for this Engineer: / Jimbo / Select Machine:[Dropdown List]; [Button: 'Save']" | Y |
  | When a Machine is selected from the "Select Machine" dropdown list and the "Save" button in the Engineers/AddMachine view is clicked, program will display the Engineers/Details view with the Machine appended to the list of Machines for whiched the Engineer is licensed. | "Add A Machine License for this Engineer: / Jimbo / Select Machine:[Buzz Drill]; [Button: 'Save']" > *Click* | "Engineer Details / Engineer Name: Jimbo / Jimbo's Machine Licenses: / Buzz Drill / [Button: 'Remove Machine License']" | Y |
  | When the "Remove Machine License" button for a Machine in the Engineers/Details view is clicked, program will remove the specific Machine with which it is associated from the list of Machines displayed for the Engineer the details for whom are displayed in the Engineers/Details view. | "Engineer Details / Engineer Name: Jimbo / Jimbo's Machine Licenses: / Buzz Drill / [Button: 'Remove Machine License']" > *Click* | "Engineer Details / Engineer Name: Jimbo / This engineer is not licensed to work on any machines yet." | Y |
  | When the "Delete Engineer" link in the Engineers/Details view is clicked, program will display an Engineers/Delete view with the option to confirm deletion of the selected Engineer or navigate back to the Engineers/Details view. | "Engineer Details / Engineer Name: Jimbo / This engineer is not licensed to work on any machines yet. / Add Machine License / Edit Engineer Info / Delete Engineer" > *Click* | "Are you sure you want to delete this engineer from the database? / Engineer Name: Jimbo / [Button: 'Delete'] / View Engineer Details" | Y |
  | When the "Delete" button in the Engineers/Delete view is clicked, program will display the Engineers/Index view with the selected Engineer removed from the list of Engineers in the database. | "Are you sure you want to delete this engineer from the database? / Engineer Name: Jimbo / [Button: 'Delete']" > *Click* | All Engineers: / No engineers have been entered into the database. / Add a New Engineer" | Y |
  | When the "View All Machines" link on the splash page is clicked and no Machines have been created in the database, program will display a Machines/Index view with a message that no Machines have been added yet. | "View All Machines" > *Click* | "All Machines: No machines have been entered into the database." | Y |
  | Program will display an "Add a New Machine" link in the Machines index view. | N/A | "Add a Machine" | Y |
  | When the "Add a New Machine" link on the Machines index page is clicked, program will display a Machines/Create view with a form to enter a new Machine into the database. | "Add a New Machine" > *Click* | "Enter a New Machine: Machine Name:[Input Field]; Machine Description:[Input Field]; [Button: 'Enter New Machine']; 'View All Machines' | Y |
  | When a new Machine's name and description is inputted into the input field and the "Enter New Machine" button is clicked in the Machines/Create view, program will add the inputted Machine to the list of Machines in operation at the factory. | "Machine Name:[Buzz Drill]; Machine Description:[Drills buzzes]; [Button: 'Enter New Machine']" > *Click* | "All Machines: Buzz Drill" | Y |
  | When a Machine's name is clicked in the Machines index view, and if no engineers have been added for that machine, program will display a Machines/Details view with a message that no engineers have been added yet. | "All Machines: Buzz Drill" > *Click* | "Machine Details / Machine Name: James Bond / Machine Description: Drills Buzzes / This machine has no engineers licensed to work on it yet." | Y |
  | When the "Edit Machine Info" link in the Machine/Details view is clicked, program will display a Machines/Edit view with a field for the user to change Machine information. | "Edit Machine Info" > *Click* | "Edit Machine Info: Buzz Drill / Machine Name:[Buzz Drill]; Machine Description:[Drills buzzes]; [Button: 'Save']" | Y |
  | When the user inputs an edited Machine Name and/or Machine Description into the input fields and clicks the "Save" button in the Machines/Edit view, program will display the Machines/Details view with the edited Machine Name and/or Machine Description. | "Edit Machine Info: Buzz Drill / Machine Name:[Super Buzz Drill]; Machine Description:[Drills buzzes and other stuff]; [Button: 'Save']" > *Click* | "Machine Details / Machine Name: Super Buzz Drill / Machine Description: Drills buzzes and other stuff / This machine has no engineers licensed to work on it yet." | Y |
  | When the "Add Engineer" link in the Machines/Details view is clicked, program will display a Machines/AddMachine view with a dropdown list from which an Engineer can be selected. | "Machine Details / Machine Name: Super Buzz Drill / Drills buzzes and other stuff / This machine has no engineers licensed to work on it yet. / Add Engineer" > *Click* | "Add an Engineer for this Machine: / Buzz Drill / Drills buzzes and stuff / Select Engineer:[Dropdown List]; [Button: 'Save']" | Y |
  | When an Engineer is selected from the "Select Engineer" dropdown list and the "Save" button in the Machines/AddEngineer view is clicked, program will display the Machines/Details view with the Engineer appended to the list of Engineers for that Machine. | "Add an Engineer for this Machine: / Buzz Drill / Select Engineer:[Jimbo]; [Button: 'Save']" > *Click* | "Machine Details / Machine Name: Jimbo / Machine Description: Drills buzzes and other stuff / Engineers: / Buzz Drill / [Button: 'Remove Machine License']" | N |


## Stretch Goals
| Behavior | Input | Output | Met? (Y/N) |
| ----------- | ----------- | ----------- | ----------- |



## Known Bugs

| Location : Message |  Situation  | Resolved (Y/N) |  Bug Resolution Strategy |
| ----------- | ----------- | ----------- | ----------- |
| Controllers\EngineersController.cs : "error CS0103: The name 'join' does not exist in the current context" | Error in terminal while attempting to add HTTPPost action for Details view in Factory/Controllers/EngineersController.cs file. | Y | Delete '.ThenInclude(join => join.Engineer);' from Details HTTPGet action in Factory/Controllers/EngineersController.cs file and then re-add it after building Engineers/Edit view and controller actions. |



## Support & Contact Details

  * You are welcome to contact the (author)[https://github.com/taylorsomers/] via GitHub with any concerns, feedback, possible contributions, questions, or suggestions.


### Contributors

  * [Taylor Somers](https://github.com/taylorsomers/)


### License

  * This program is free to use under the GNU General Public License GPLv3. © 2020 Taylor Somers. All rights reserved.