# Sapphire
ERP System Based on SAP B1.

## API

API REST to integrate different platforms

### Build

Build in [ASP CORE 5.0](https://dotnet.microsoft.com/download/dotnet/5.0).

```zsh
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.1
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.2
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 5.0.2
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 5.0.2
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.2
dotnet add package Microsoft.IdentityModel.Tokens --version 6.8.0
dotnet add package Microsoft.AspNetCore.Cors --version 2.2.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.2
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 5.0.2
```

### Migrations

#### Add Migration 
dotnet ef migrations add MIGRATION_NAME

#### Apply Migration on DB
dotnet ef database update

#### To unapply a specific migration(s):
dotnet ef database update MIGRATION_NAME

#### To unapply all migrations:
dotnet ef database update 0

#### To remove last migration:
dotnet ef migrations remove

### Generate an Controller with CLI
```zsh
dotnet-aspnet-codegenerator controller -name [CONTROLLER_NAME] -api -m [namespace].[classname] -dc Sapphire_Context -outDir [FILE_OUTPUT_PATH] -namespace [namespace]
```

Example:

```zsh
dotnet-aspnet-codegenerator controller -name CountryController -api -m SapphireApi.Data.Adminsitration.Country.CountryModel -dc Sapphire_Context -outDir Data\\Administration\\SystemInitialization\\Country -namespace SapphireApi.Data.Adminsitration.Country
```

## Web Front-End - Angular

## Mobile - Android


## License
[MIT](https://choosealicense.com/licenses/mit/)