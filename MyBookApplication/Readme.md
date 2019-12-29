Follow the above to migrate multiple db context in the same database.
https://blog.tekspace.io/code-first-multiple-db-context-migration/

 Refer https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-3.1&tabs=visual-studio to add identity tables. Below steps will add tables in the database HangfireApplication
	  a. Install-Package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore -Version 3.0.0 
			Reason - Current dotnetcore version is netcore3.0
	  b. Add-Migration CreateIdentitySchema -Context BookDbContext 
	  c. Update-Database -Context BookDbContext 
	  d. Add-Migration CreateIdentitySchema -Context ApplicationDbContext 
	  e. Update-Database -Context ApplicationDbContext

Google OAuth - https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins?view=aspnetcore-3.1 

Microsoft OAuth - https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/microsoft-logins?view=aspnetcore-3.1