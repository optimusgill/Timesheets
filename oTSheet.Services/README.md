# oTSheet.Services

All Timesheet-related services will be loaded in this folder

Configuration VisualCode.
download And install VisualStudio Code from https://code.visualstudio.com/download

Download and install Postman 

Once you start visual studio code install the following extensions:
-C#.
-C# Extensions.
-C# XML Documentation Comments.
-Visual Studio IntelliCode.
-REST Client

from the terminal menu, select New Terminal 
type : dotnet new webapi -n "projectname"
Created the project,type in the terminal: code -r projectname
Visual Code will open the project folder 

Connect to the site and search for the following libraries: 
-Microsoft.EntityFramework copy and past inside the terminal this command :"dotnet add package Microsoft.EntityFrameworkCore"
-Microsoft.EntityFrameworkCore.Design : "dotnet add package Microsoft.EntityFrameworkCore.Design"
-Microsoft.EntityFrameworkCore.SqlServer: "dotnet add package Microsoft.EntityFrameworkCore.SqlServer"

if the installation was successful by typing in the terminal :"dotnet ef" or "dotnet -ef" (depends on the version you want to use)
you should see the list of EntityFramework commands.


dotnet tool install --global dotnet-ef

By "dotnet ef migrations  add InitialMigration" you generate the classes that they will create the table inside the dabase specify inside the connection string

Inside a first Migration File you will find 2 Methods UP to creation a table and DOWN to drop a table

To delete a migration use this command:"dotnet ef migrations remove".

To Create the tables and database use this command :"dotnet ef database update".
The command will also create a History table of migration(duo. _EFMigrationsHistory).



