# LanComWebApiFinalVersion

How to run this aplication:

This project is configured to work on local database with server name: `.` and database named `WEB`.
In order to have working project you must configure your database like it is mentioned above or change database setting in `appsetting.json`.

In order to create you tables you need to execute next commands in Visual Studio Package Manager Console
- add-migration `NameOfMigration`
- Update-Database

Then run aplication and go to: `https://localhost:44387/` where is Swagger.
In order for everything to work make sure that you have data base configured!

