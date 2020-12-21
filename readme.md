# Like-Button 
An Implementation of like-button feature which consists of a web API built with C# on .net framework and MySQL for its database. A page that features a button was built to communicate with this API using JavaScript.

## Getting Started
Start by cloning the project from the git repository into your local machine and import the sql script file to auto generate the database.

### Prerequisites
- .NET Framework 4.7 or above 
- Visual studio 2019
- local server like xampp for mysql databases

### Installing

After cloning the project to your local machine, some settings has to be changed to run the API locally on your machine as these said settings are working locally on my machine hence the changes.
- `ConnectionString` in `appSettings.json` should be changed to carry your database credentials.
- launch URL on `launchSettings.json` should be changed according to the default url the API is running on your local machine.
- Change the `baseURL` variable found in `likeButton.js` to the URL of your local server.

## Run Test
- You can use the run button on Visual studio to start up the web API or navigate to the project folder from your CLI and run by typing 'dotnet run'
- From your CLI navigate to the project directory serve the project folders using the php code 'serve .' then load up the html page.

