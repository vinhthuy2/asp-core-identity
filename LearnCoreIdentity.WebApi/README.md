1. Add Microsoft.AspNetCore.Identity.EntityFrameworkCore
2. Create `ApplicationDbContext.cs`. Configure build options to use Sqlite...
3. ```
   builder.Services
    .AddIdentityApiEndpoints<IdentityUser>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
   
4. ```
   app.MapIdentityApi<IdentityUser>();


## Entity framework
1. `dotnet migration add initial-migration`
2. `dotnet ef database update`