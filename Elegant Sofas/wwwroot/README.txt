
					    [ CYB206: WEB APPLICATION SECURITY ]
						  Group Project Prototype - SOFAS WEB APP
Beta Group
----------->					
Hemn Hamad Ameen
Amanjit Kaur
Sandeep Singh
		 		>=====================> ASP.NET Core MVC <=======================< 

						     

====> PART 1: Get started with ASP.NET Core MVC <====
 
2024-02-17 1433

- Created new project named "Elegant Sofas", having three folders: Controllers, Models and Views
- changed the Home page, adding a Sofa image with some format creativity.

 
====> PART 2: Add a controller <====

2024-02-17 1442

- Added a controller under Controller folder named "HelloWorldController" and updated with a some code.
- Now the page URL is like this: https://localhost:7078/helloworld --> showing this message "This is my default action..."


====> PART 3: Add a View <====

2024-02-17 1448

- Created a new forlder named "HelloWorld", adding a Razor "Index.cshtml" to the folder and replacing the code with some new code. 
- Updating the content of the Views/Shared/_Layout.cshtml file with the given code. Adding App name "SOFAS"
- Running the app and making sure the page loads with no errors. 


====> PART 4: Add a Model <====

2024-02-17 1503

- Added a class under Model forlder and named "SOFAS.cs"
- Added New Scaffolded Item under Controller forlder name "SOFASController", adding SQL Server as database provider.
- Now, coming to an important stage ----> "Migration", here is how it's done:
From the Tools menu, select NuGet Package Manager > Package Manager Console, then running these commands in the powershell: Add-Migration InitialCreate & Update-Databas
- Testing the App: it's running without errors.


====> PART 5: Work with a database in an ASP.NET Core MVC app <====

2024-02-17 1510

- Examining the database: View Designer & View Data >> brwosing SOFAS.cs content in the database
- Seed the database by creating "SeedData" under Models folder and updating the code. 
- Add the seed initializer: Replacing the contents of Program.cs with new generated code.
- Running the App, it shows a table of all the SOFAS stored in the database with their details.


====> PART 6: Controller Methods and Views in ASP.NET Core <====

2024-02-17 1520

- Tested the app by editing the SOFAS records (edit, create and delete) Sofas.
- Reviewed the code as per the tutorial, updating the Models/SOFAS.cs file and add the highlighted lines
- Running the App, it works properly..

====> PART 7: add search to an ASP.NET Core MVC app <====

2024-02-17 1530

- Update the Index method found inside Controllers/SOFASController.cs with the some code
- Update the Views/SOFASs/Index.cshtml file, and add the <form> Filter text box to the page


====> PART 8: Add a New Field to an ASP.NET Core MVC app <====

2024-02-17 1542

- Adding a "Rating" property to Models/SOFAS.cs module
- Edit the /Views/SOFASs/Index.cshtml file and add a Rating field
- Update the /Views/SOFASs/Create.cshtml with a Rating field
- Update the SeedData, adding "Rating" to each record
- Running Migration, build done
- Database has been updated..


====> PART 9: Add a Validation an ASP.NET Core MVC app <====

2024-02-17 1550

- Update the SOFAS class to take advantage of the built-in validation attributes Required, StringLength, RegularExpression, Range and the DataType
- Field Validation: validating the data input in the fields. (e.g. String for Product, Decimals for Price..etc)


====> PART 9: 10, Examine the Details and Delete Methods of an ASP.NET Core App <====
				
2024-02-17 1600

- Examined the Details method.
- Examine the Delete and DeleteConfirmed methods

====> PART 10: Deployment and publishing the App to MS Azure Cloud <====

2024-03-07 1200

- Rebuilding the app and publishing it to MS Azure
- Create App Service on Azure cloud
- Create SQL database on Azure cloud
- Create an instance on the App and start publishing to Azure
- Publishing has been done successfully
- Now the App can be accessed via this URL: https://coolsofa.azurewebsites.net/


							============> END OF THE APP NOTES <============ 


&&&&&&& Finally saving the updates to GitHub repository &&&&&&&
Here is repo URL: 


Source of Data: The data has been collected from teppermans:
https://www.teppermans.com/furniture/living-room/sofas-sectionals/sofas


======================================
Shared workload: Group Work Perfomance
======================================
Hemn: Initiated the App from step 1-5 including updating the README file in parallel.
Sandeep: Moved on with step 5-7 updating the README file accordingly.
Amanjit: Finished the steps 7-9 also putting all notes in the README file.

Other observations:
- We togther created the app, ran and tested, every step of the way.
- Added the README file, putting our inputs and observations.
- Created a gitHub repo for the App. 
- Updated the databse and added new features with the Sofa products.
- It was a good experience as a team on such a project.
=======
					    [ CYB206: WEB APPLICATION SECURITY ]
						  Group Project Prototype
Beta Group
----------->
Hemn Hamad Ameen
Amanjit Kaur
Sandeep Singh
		 		>=====================> ASP.NET Core MVC <=======================< 

						     

====> PART 1: Get started with ASP.NET Core MVC <====
 
2024-02-17 1433

- Created new project named "Elegant Sofas", having three folders: Controllers, Models and Views
- changed the Home page, adding a Sofa image with some format creativity.

 
====> PART 2: Add a controller <====

2024-02-17 1442

- Added a controller under Controller folder named "HelloWorldController" and updated with a some code.
- Now the page URL is like this: https://localhost:7078/helloworld --> showing this message "This is my default action..."


====> PART 3: Add a View <====

2024-02-17 1448

- Created a new forlder named "HelloWorld", adding a Razor "Index.cshtml" to the folder and replacing the code with some new code. 
- Updating the content of the Views/Shared/_Layout.cshtml file with the given code. Adding App name "SOFAS"
- Running the app and making sure the page loads with no errors. 


====> PART 4: Add a Model <====

2024-02-17 1503

- Added a class under Model forlder and named "SOFAS.cs"
- Added New Scaffolded Item under Controller forlder name "SOFASController", adding SQL Server as database provider.
- Now, coming to an important stage ----> "Migration", here is how it's done:
From the Tools menu, select NuGet Package Manager > Package Manager Console, then running these commands in the powershell: Add-Migration InitialCreate & Update-Databas
- Testing the App: it's running without errors.


====> PART 5: Work with a database in an ASP.NET Core MVC app <====

2024-02-17 1510

- Examining the database: View Designer & View Data >> brwosing SOFAS.cs content in the database
- Seed the database by creating "SeedData" under Models folder and updating the code. 
- Add the seed initializer: Replacing the contents of Program.cs with new generated code.
- Running the App, it shows a table of all the SOFAS stored in the database with their details.


====> PART 6: Controller Methods and Views in ASP.NET Core <====

2024-02-17 1520

- Tested the app by editing the SOFAS records (edit, create and delete) Sofas.
- Reviewed the code as per the tutorial, updating the Models/SOFAS.cs file and add the highlighted lines
- Running the App, it works properly..

====> PART 7: add search to an ASP.NET Core MVC app <====

2024-02-17 1530

- Update the Index method found inside Controllers/SOFASController.cs with the some code
- Update the Views/SOFASs/Index.cshtml file, and add the <form> Filter text box to the page


====> PART 8: Add a New Field to an ASP.NET Core MVC app <====

2024-02-17 1542

- Adding a "Rating" property to Models/SOFAS.cs module
- Edit the /Views/SOFASs/Index.cshtml file and add a Rating field
- Update the /Views/SOFASs/Create.cshtml with a Rating field
- Update the SeedData, adding "Rating" to each record
- Running Migration, build done
- Database has been updated..


====> PART 9: Add a Validation an ASP.NET Core MVC app <====

2024-02-17 1550

- Update the SOFAS class to take advantage of the built-in validation attributes Required, StringLength, RegularExpression, Range and the DataType
- Field Validation: validating the data input in the fields. (e.g. String for Product, Decimals for Price..etc)


====> PART 9: 10, Examine the Details and Delete Methods of an ASP.NET Core App <====
				
2024-02-17 1600

- Examined the Details method.
- Examine the Delete and DeleteConfirmed methods

====> PART 10: Deployment and publishing the App to MS Azure Cloud <====

2024-03-07 1200

- Rebuilding the app and publishing it to MS Azure
- Create App Service on Azure cloud
- Create SQL database on Azure cloud
- Create an instance on the App and start publishing to Azure
- Publishing has been done successfully
- Now the App can be accessed via this URL: https://coolsofa.azurewebsites.net/


							============> END OF THE APP NOTES <============ 


&&&&&&& Finally saving the updates to GitHub repository &&&&&&&
Here is repo URL: 


Source of Data: The data has been collected from teppermans:
https://www.teppermans.com/furniture/living-room/sofas-sectionals/sofas


======================================
Shared workload: Group Work Perfomance
======================================
Hemn: Initiated the App from step 1-5 including updating the README file in parallel.
Sandeep: Moved on with step 5-7 updating the README file accordingly.
Amanjit: Finished the steps 7-9 also putting all notes in the README file.

Other observations:
- We togther created the app, ran and tested, every step of the way.
- Added the README file, putting our inputs and observations.
- Created a gitHub repo for the App. 
- Updated the databse and added new features with the Sofa products.
- It was a good experience as a team on such a project.
>>>>>>> vavbar updated
