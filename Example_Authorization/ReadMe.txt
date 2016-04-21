******************************************************************
LLBLGen Pro Authorization example READ-ME FILE
******************************************************************


Example Description
-------------------

- A Windows Application Example which Shows how to implement Authorization with LLBLGenPro Adapter TemplateSet.

- The example is built against the famous Northwind database.
You may download it from Microsoft Download Center, if you don't have it already.



Folders:
--------

1- The LLBLGen Pro project file can be found in the following path: "\LLBLGenPro Project\Authorization.llblgenproj"
2- The LLBLGen Pro generated code can found in the following path: "\Adapter\DAL"
3- The GUI project can be found in the following path: "\Adapter\WinApplication"
4- The Authorizers classes project can be found in the following path: "\Adapter\Authorizers"
5- Another extra project is used as a Login utility which can be found here: "\Adapter\LoginHelper"


How to Install
--------------

1. The authorization examples makes use of 3 extra tables (User, UserGroup & Group) that should be created on the Northwind database.
   To deploy them, please run the following script file: "Database Script\Northwind_authorization_example.sql"

2. Use Visual Studio to open and build the solution found in the following path: "Adapter\SD.LLBLGen.Pro.Examples.Authorization.GUI.sln"

3. If needed, please change the compiled Authorizer.dll path to a valid one in the app.config file in the GUI project for Dependancy Injection to work:

  <dependencyInjectionInformation>
    <additionalAssemblies>
      <assembly filename="..\..\..\Authorizers\bin\debug\Authorizers.dll"/>
    </additionalAssemblies>
  </dependencyInjectionInformation>

   For more information on Dependency Injection options open the app.config file of GUI project. Also read LLBLGenPro documentation.

4. Please adjust the connection string to meet your environment in the app.config file in the GUI project.
  <add key="Main.ConnectionString.SQL Server (SqlClient)" value="data source=.\SQLEXPRESS;initial catalog=Northwind;integrated security=SSPI;persist security info=False;packet size=4096"/>


Help and support
----------------
LLBLGen Pro Help
LLGLGen Pro Reference Manual
http://www.llblgen.com/tinyforum