cd .\SistemaBiblioteca.API\

rmdir ".\Migrations\" /s /q
del .\db_biblioteca.db

dotnet ef migrations add Inicial
dotnet ef database update