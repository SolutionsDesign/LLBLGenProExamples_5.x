LLBLGen Pro Data Scope example Adapter/Selfservicing.
=========================================================

This example shows the usage of the Data Scope feature, which was first introduced in LLBLGen Pro v4. The example combines adapter and selfservicing code in one application, to illustrate the differences between the two with respect to Data Scopes. It requires the SqlServer Northwind database to run. To make it run on your system, change the connection string in the App.config file to make the code be able to access your SqlServer instance with the Northwind database.

The Data Scopes are defined in the Northwind.BO project. The example also illustrates 're-parenting' with a specific scope. Be aware that the application will save changes to your database. If you want to keep your northwind database in-tact, first make a copy.
The CustomerManagerUsingBO forms illustrate the actual power of the scope: there's almost no code, yet the forms are feature rich: they manage data for customer, its orders and the order lines, you can edit the data, add new data and persist the changes, including deletes. It also illustates how to enable a save button based on changes detected by the scope.

You can see which queries LLBLGen Pro produces and which calls are made by switching on tracing: open App.Config in the GUI project and switch on one or more of the trace switches in the file (enable the DQE tracing switch to view queries). Recompile and run the application in debug mode, you'll see the queries and other tracing output in the Output window of Visual Studio.NET. 

Two UIs
---------
There are two UIs implemented: one in Winforms and one in WPF. The Winforms one also supports SelfServicing and has a bit more sophisticated customer editor (with more controls) than the WPF one. The WPF one offers the same features with respect to the data scopes so you can see how to use them in a WPF scenario as well. The code used in both UIs is more or less the same. 