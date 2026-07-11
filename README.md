# CatApiA_02

Descripción
-----------
CatApiA_02 es una API REST en ASP.NET Core (proyecto Web) para gestionar recursos "Cat". El proyecto apunta a .NET 10 (net10.0) y usa Entity Framework Core y Npgsql para acceso a datos, además de Swashbuckle/Swagger para documentación interactiva.

Estado actual
------------
- Proyecto: CatApiA_02 (solución: CatApiA_02.slnx)
- Target framework: .NET 10 (net10.0)
- Endpoints CRUD implementados en Controllers/CatController.cs
- Lógica de negocio localizada en Application (CatUseCase)
- Paquetes principales: Microsoft.EntityFrameworkCore, Npgsql.EntityFrameworkCore.PostgreSQL, Swashbuckle.AspNetCore

Endpoints principales
--------------------
- GET  /api/cats           -> Obtener todos los gatos
- GET  /api/cats/{id}      -> Obtener un gato por id (GUID)
- POST /api/cats           -> Crear un nuevo gato
- PUT  /api/cats/{id}      -> Actualizar un gato existente
- DELETE /api/cats/{id}    -> Eliminar un gato

Ejecución
---------
1. Abrir la solución CatApiA_02.slnx en Visual Studio o usar la CLI de .NET.
2. Configurar la cadena de conexión en appsettings.json (si usa base de datos PostgreSQL).
3. Desde la carpeta raíz del repositorio ejecutar:

   dotnet run --project CatApiA_02/CatApiA_02.csproj

4. Al ejecutar, la UI de Swagger estará disponible en /swagger para probar los endpoints.

Notas
-----
- Compruebe appsettings.json para configuración de la base de datos y otros ajustes.
- Para cambios en el modelo de datos, aplicar migraciones de EF Core según corresponda.

