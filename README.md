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
  8.  Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.
  9.  Enter the command "dotnet build" in the terminal.
  10. Enter the command "dotnet run" in the terminal. The program should begin to run in the console.

  ### Database Setup Instructions

  


## Specifications

  | Program Behavior | Example Behavior | Example Output | Met? (Y/N) |
  | ----------- | ----------- | ----------- | ----------- |
  | Program will display a splash page allowing the user to navigate to a list of all Engineers employed at the factory as well as all Machines in operation at the factory. | N/A | "View All Engineers; View All Machines" | Y |
  | When the "View All Engineers" link on the splash page is clicked and no Engineers have been created in the database, program will display an Engineers/Index view with a message that no Engineers have been added yet. | "View All Engineers" > *Click* | "All Engineers: No engineers have been entered into the database." | Y |
  | Program will display an "Add an Engineers" link in the Engineers index view. | N/A | "Add an Engineer" | Y |
  | When the "Add an Engineers" link on the Engineers index page is clicked, program will display an Engineers/Create view with a form to enter a new Engineer into the database. | "Add an Engineer" > *Click* | "Enter a New Engineer: Engineer Name:[Input Field]; [Button: 'Enter New Engineer']; 'View All Engineers' | Y |
  | When a new Engineer's name is inputted into the input field and the "Enter New Engineer" button is clicked in the Engineers/Create view, program will add the inputted Engineer to the list of Engineers employed at the factory. | "Engineer Name:[James Bond]; [Button: 'Enter New Engineer']" > *Click* | "All Engineers: James Bond" | Y |
  | When an Engineer's name is clicked in the Engineers index view, program will display an Engineers/Details view for that Engineer, listing any Machines on which that Engineer is licensed to work. | "All Engineers: James Bond" > *Click* |  |  |


## Stretch Goals
| Behavior | Input | Output | Met? (Y/N) |
| ----------- | ----------- | ----------- | ----------- |



## Known Bugs

| Location : Message |  Situation  | Resolved (Y/N) |  Bug Resolution Strategy |
| ----------- | ----------- | ----------- | ----------- |
| Controllers\EngineersController.cs : "error CS0103: The name 'join' does not exist in the current context" | Error in terminal while attempting to add HTTPPost action for Details view in Factory/Controllers/EngineersController.cs file. | Y? | Delete '.ThenInclude(join => join.Engineer);' from Details HTTPGet action in Factory/Controllers/EngineersController.cs file. |



## Support & Contact Details

  * You are welcome to contact the (author)[https://github.com/taylorsomers/] via GitHub with any concerns, feedback, possible contributions, questions, or suggestions.


### Contributors

  * [Taylor Somers](https://github.com/taylorsomers/)


### License

  * This program is free to use under the GNU General Public License GPLv3. © 2020 Taylor Somers. All rights reserved.