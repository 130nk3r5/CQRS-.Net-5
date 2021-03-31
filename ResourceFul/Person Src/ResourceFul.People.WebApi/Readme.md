
# Migrations #

Ensure that you are on the ./ResourceFul folder  

dotnet ef --startup-project "./Person Src/ResourceFul.People.WebApi/ResourceFul.People.WebApi.csproj" migrations add InitialMigration --output-dir Migrations --project "./Person Src/ResourceFul.People.Infrastructure/ResourceFul.People.Infrastructure.csproj"