Examples included
-----------------

- Adapter Example: Shows how to implement Validation in LLBLGenPro Adapter Template group.
  For GUI utilizes: ASP.NET webforms

- SelfServicing Example: Shows how to implement Validation in LLBLGenPro SelfServicing Template group.
  For GUI utilizes: WinForms


How to Install
--------------

1. Install Northwind DB
Run script "SQLScrips\instwnd.sql" in your local SQLServer (If you haven't already installed). 

2. Open, compile and run solutions
    - "Code\Adapter\LLBLGenPro - Validation Example - Adapter.sln"
    - "Code\SelfServicing\LLBLGenPro - Validation Example - SelfServicing.sln"

3. For information on Dependency Injection options open config files of GUI projects. Also read LLBLGenPro 
   documentation.

4. For the Adapter example, please adjust the connection string to meet your environment in the web.config 
   file in the GUI project.
   for the SelfServicing example, please adjust the connection string to meet your environment in the 
   app.config file in the GUI project.


Pitfalls and Limitations
--------------------------
At SelfServicing example at CustomerForm and OrderForm, if you set an invalid value to a control 
(say control A), an error icon is shown and the control value keeps
the invalid one. Then you go to another field control (say B) and set some value, when you do that, 
the value of A is reset to the original value and the error icon is still there (valid value and error 
icon). This is a flaw of the IDataErrorInfo + ErrorProviders. The example expects that the user (as 
users used to) see an error icon and fixed it, then go to another field control. If that flow is used, 
everything will work, if not, you should add especial code at your GUI to call some routine that reset 
IDataErrorInfo of the "valid fields". You can read more about this discussion here: 
http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=12151


Help and support
------------------
LLBLGen Pro Help
LLGLGen Pro Reference Manual
http://www.llblgen.com/tinyforum
