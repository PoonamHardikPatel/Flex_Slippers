2022-10-10 10:45pm  

Created by : Poonam Hardik Patel
Purpose : Create a ASP.NET Core Web App - named : Flex_Slippers

- Using .NET Core 3.1
- Individual user account authentication
- HTTPS selected
- Create README.txt file

- Logged into my GitHub Account
- Create Repositories

- Changed "index.cshtml" page

- Build the Application... Sucessfully done...
- Test the application - Test Done... All Good!!!
- Commit all changes to GitHub!!!


//-------------------------------------------------------------------


2022-10-13 12:37am  

/** Step - 2 - Add a data model class **/

- Find & Write all properties regarding my product.
- Create a data model class - named : "Slipper.cs" in "Models" folder.


2022-10-13 01:08am

- Check all packages in - "Dependencies > Packages"
- Change the all versions from - "Tools > NuGet Package Manager > Manage NuGet Packages for Solution"

- Rebuild the Application... Sucessfully done...
- Test the application - Test Done... All Good!!!
- Commit all changes to GitHub!!!


2022-10-13 01:20am

- Create context file - named : "Flex_SlippersContext.cs" file in "Data" folder.
- Update "Flex_SlippersContext.cs" file and add necessary code for Application.

- Now, open the file - named : "Startup.cs"
- Update "Startup.cs" file
- Open and Update "appsettings.json" file

- Rebuild the Application... Sucessfully done...
- Test the application - Test Done... All Good!!!
- Commit all changes to GitHub!!!


2022-10-13 08:27pm

- Rebuild the Application... Sucessfully done...
- Test the application - Test Done... All Good!!!

- Open and Update "appsettings.json" file

- Now it's time to - Scaffold Slipper pages
- Getting Error "No Parameter"
- Open and Update "Startup.cs" file
- Solve the error..

- Scaffolding Done ...
- One new controller file added in the list 
	- named : "SlippersController.cs" file
- One new folder added in "Views" folder 
	- named : "Sleppers" folder
- Created new files in "Slippers" folder 
	- named : "Create.cshtml", "Delete.cshtml", "Details.cshtml", "Edit.cshtml", "Index.cshtml"

- Rebuild the Application... Sucessfully done...
- Test the application - Test Done... All Good!!!
- Commit all changes to GitHub!!!


2022-10-13 09:40pm

- Next step is - Migration 
- Open "NuGet Package Manager Console"
- Run command - "Add-Migration InitialCreate -Context Flex_SlippersContext"
- Command successfully executed...
- Now Run Command - "Update-Database -Context Flex_SlippersContext"
- Command successfully executed...

- Rebuild the Application... Sucessfully done...
- Test the application - Test Done... All Good!!!
- Commit all changes to GitHub!!!


2022-10-13 09:53pm

- Open and Update "Views/Shared/_Layout.cshtml" file...
	- Added link on Application title in header...


2022-10-13 10:02pm

- Next step to Checked the database server with the SQL Server 
- Open "View" menu :
	- Open "SQL Server Object Explorer"
	- Find your database and Check the options that - "View Designer" and "View Data"

- Rebuild the Application... Sucessfully done...
- Test the application - Test Done... All Good!!!
- Commit all changes to GitHub!!!


2022-10-13 10:10pm

- Create "SeedData.cs" file in "Models" folder
- Enter Data as per your product in "SeedData.cs" file
- Completed "SeedData.cs" file and add 12 rows of data.

- Now Run Command - "Update-Database -Context Flex_SlippersContext"
- Command successfully executed...

- Rebuild the Application... Sucessfully done...
- Test the application - Test Done... All Good!!!
- Commit all changes to GitHub!!!


- Open and Update "Slipper.cs" file
- Give "Display" properti in the fields
- Run and Show the results...


2022-10-13 11:20pm

- Started with Searching options : 
- Give a searching on "Department" field.
- For taht, first open "SlippersController.cs" file.
- Update the async "Index" method with one parameters for search option on "Department" feild.
- Update the "Index.cshtml" file of "Slippers" folder
- Add form for "Department" seraching option and submiting data 

- Create one more class file - named : "SlipperMaterialViewModel.cs"
- Then, again Update the async "Index" method with two parameters 
	- for search option on "Department" feild and dropdown option on "Material" field.
- Update the "Index.cshtml" file of "Slippers" folder
- Add form for "Department" seraching and "Material" dropdown option and submiting data 

- Rebuild the Application... Sucessfully done...
- Test the application - Test Done... All Good!!!
- Commit all changes to GitHub!!!


2022-10-14 01:23am

- Adding "Rating" property in "Slipper.cs" file
- Applied "Range" validation 1-5 on this feild
- Edit the /Views/Movies/Index.cshtml file and add a Rating field.
- Update the /Views/Movies/Create.cshtml with a Rating field.
- Update the /Views/Movies/Delete.cshtml with a Rating field.
- Update the /Views/Movies/Details.cshtml with a Rating field.
- Update the /Views/Movies/Edit.cshtml with a Rating field.
- Update the "SeedData.cs" file and add Rating feild data in it.


//-------------------------------------------------------------------


2022-10-14 12:02pm

- Create "AboutUs.cshtml" file in "Views/Home" folder
- Open and Update "HomeController.cshtml" file 
- Add Acion for "AboutUs" in controller
- Add a link in the header of the "Views/Shared/_Layout.cshtml" file

- Rebuild the Application... Sucessfully done...
- Test the application - Test Done... All Good!!!

- Create folder in "wwwroot/images" 
- Add images in this created folder 

- Open this file and write about our fictional company.
