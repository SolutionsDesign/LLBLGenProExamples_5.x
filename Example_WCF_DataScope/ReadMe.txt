******************************************************************
LLBLGen Pro WCF & Data Scopes example READ-ME FILE
******************************************************************

Example Description
-------------------
- A VS.NET Solution that shows how to implement a WCF solution using a desktop app client with LLBLGenPro Adapter TemplateSet.
- The example uses the v4 DataScope feature to perform much of the entity management on the client, while
  outsourcing the data-access to the service. 
- The example shows how a Unit Of Work can be send back to the service to be committed, after it's been
  created by the DataScope.
- The example is built against the famous Northwind database. You may download it from Microsoft Download Center, 
  if you don't have it already.

This example is both usable as standalone service + client and as an IIS hosted service + client. This readme contains 
information to setup both.

Folders:
--------
1. Client: A Windows application acting as the client of the WCF Service.
2. DAL: Contains the LLBLGen Pro generated code.
3. Host: A windows application acting as the host for the WCF service.
4. LLBLGenPro Project: Contains the LLBLGen Pro project file, for generating the code against Northwind.
5. Service: The WCF Service library.
6. ServiceInterface: A library which defines the Service Interface which acts as the service contract and is referenced at the Service and the client.
7. IIS wsHTTPBindings: A folder with additional files to host this WCF project in IIS using wsHTTPbindings.
8. BinaryEncoding: A folder with two config files which illustrate how to use binary encoded data for optimal performance over HTTP ( so in 
   combination of wsHTTPbindings) 


How to Install, no IIS hosting
-----------------------------------
1. Use Visual Studio (solution file is in format vs.net 2010) to open and build the solution found in the root folder: "\SD.LLBLGen.Pro.Examples.WCF.sln"
2. Please adjust the connection string to meet your environment in the app.config file of the Service Host.
  <add key="Main.ConnectionString.SQL Server (SqlClient)" value="data source=.;initial catalog=Northwind;integrated security=SSPI;persist security info=False;packet size=4096"/>

How to Install, IIS hosting
-----------------------------------
1. Use Visual Studio to open and build the solution found in the root folder: "\SD.LLBLGen.Pro.Examples.WCF.sln"
2. Create an Application in IIS targeting a folder into which you copy the dll found in Service\Bin\Debug or Service\bin\release folder and specify "WCFService" as the alias of the application, otherwise modify the endpoint address in the Client config file)
3. Copy the App.config file contents found in IIS wsHTTPBindings to the Client's App.config file. Copy the web.config file
and the CustomerService.svc file found in IIS wsHTTPBindings to the folder used as the IIS application's root folder. 
4. Please adjust the connection string to meet your environment in the web.config file copied to the service's bin folder.
  <add key="Main.ConnectionString.SQL Server (SqlClient)" value="data source=.\SQLEXPRESS;initial catalog=Northwind;integrated security=SSPI;persist security info=False;packet size=4096"/>
5. If you want to use binary encoding for optimal performance, please check the config files in the BinaryEncoding folder for details how to
   configure the client and service to use binary encoding over HTTP.

   
How To Run, no IIS hosting
----------------------------------
After building the solution, you should run the Host, and click on the "Start the Service" button.
Then you should run the client to access the service hosted.

How to run, IIS hosting
----------------------------------
Make sure IIS is running and the application you created is active and then start the client to connect to the service.
NOTE: The maxReceivedMessageSize="65536000" was specified in binding configuration's service behaviour, to prevent issues when the returned message size exceeds the default size.


More about LLBLGen Pro & WCF
----------------------------
Please check "Windows Communication Foundation (WCF) support"
In the LLBLGen Pro Runtime Framework manual, in the following path:
"Using the generated code -> Adapter -> Distributed Systems -> XML Webservices / WCF support"

Help and support
----------------
LLBLGen Pro Help
LLGLGen Pro Reference Manual
http://www.llblgen.com/tinyforum