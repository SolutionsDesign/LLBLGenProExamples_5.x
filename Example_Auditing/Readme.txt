Examples included
-----------------

- Adapter Example: Shows how to implement Auditing in LLBLGenPro Adapter TemplateSet.
  For GUI utilizes ASP.NET webforms

- SelfServicing Example: Shows how to implement Auditing in LLBLGenPro SelfServicing TemplateSet.
  For GUI utilizes WinForms


How to Install
--------------

1. Install Northwind DB and Auditor tables
Run script "SQLScrips\instwnd_auditor_sample.sql" in your local SQLServer
If you already have a Northwind DB installed, only run the last section of the script named 
"START LLBLGENPRO AUDITOR EXAMPLE TABLE STRUCTURE AND DATA".
That section create AuditInfo and User tables and fill some useful information for audit. Also fill a couple of test users.

2. Open, compile and run solutions
    - "Code\Adapter\LLBLGenPro - Auditing Example - Adapter.sln"
    - "Code\SelfServicing\LLBLGenPro - Auditing Example - SelfServicing.sln"

3. For information on Dependency Injection options open config files of GUI projects. Also read LLBLGenPro Runtime library documentation.

4. For the Adapter example, please adjust the connection string to meet your environment in the web.config file in the
   GUI project.
   for the SelfServicing example, please adjust the connection string to meet your environment in the app.config file in the
   GUI project.

Help and support
------------------
LLBLGen Pro Help
LLGLGen Pro Reference Manual
http://www.llblgen.com/tinyforum
