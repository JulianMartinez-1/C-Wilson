# Concesionario Web - Aplicación ASP.NET Core MVC

## Requisitos del Sistema
- Windows 10/11
- Visual Studio 2022 con workload "ASP.NET and web development"
- .NET SDK 8
- SQL Server (SQLEXPRESS o LocalDB)
- SQL Server Management Studio (SSMS)

## Configuración de la Base de Datos

### 1. Abrir SSMS y conectarse al servidor
- Conectarse a: `DESKTOP-QPGCC0J\SQLEXPRESS` (o tu instancia de SQL Server)

### 2. Ejecutar el script de configuración
- Abrir el archivo `Scripts/ConfigurarBaseDatos.sql` en SSMS
- Ejecutar el script completo (F5)
- Verificar que se creen la base de datos y tabla con datos de prueba

### 3. Verificar la cadena de conexión
- Revisar `appsettings.json` y asegurarse de que el servidor coincida con tu instancia
- Formato: `Server=TU-SERVIDOR\SQLEXPRESS;Database=concesionario;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=true`

## Ejecutar la Aplicación

### En Desarrollo
1. Abrir el proyecto en Visual Studio 2022
2. Presionar F5 o usar "Debug > Start Debugging"
3. La aplicación se abrirá en: `https://localhost:7242`

### Desde línea de comandos
```powershell
cd "ruta-del-proyecto"
dotnet run
```

## Rutas Disponibles
- `/` o `/Home/Index` - Página de inicio
- `/TipoVehiculos` - Lista de tipos de vehículos
- `/TipoVehiculos/Create` - Crear nuevo tipo de vehículo
- `/TipoVehiculos/Edit/{id}` - Editar tipo de vehículo
- `/TipoVehiculos/Details/{id}` - Detalles del tipo de vehículo
- `/TipoVehiculos/Delete/{id}` - Eliminar tipo de vehículo

## Arquitectura del Proyecto

### Modelos
- `Models/TipoVehiculo.cs` - Entidad principal con validaciones

### Contexto de Datos
- `Data/ConcesionarioContext.cs` - DbContext de Entity Framework

### Controladores
- `Controllers/HomeController.cs` - Controlador de la página de inicio
- `Controllers/TipoVehiculosController.cs` - CRUD para tipos de vehículos

### Vistas
- `Views/Home/Index.cshtml` - Página de inicio
- `Views/TipoVehiculos/` - Vistas CRUD generadas por scaffolding
- `Views/Shared/_Layout.cshtml` - Layout principal

## Configuración para Producción

### Archivo appsettings.Production.json
Ya está configurado para usar la misma cadena de conexión. Para un entorno de producción real, actualizar con los datos del servidor de producción.

### Variable de entorno
```powershell
$env:ASPNETCORE_ENVIRONMENT="Production"
```

## Publicación

### Para carpeta local
```powershell
dotnet publish -c Release -o ./publish
```

### Para IIS
1. Instalar .NET 8 Hosting Bundle
2. Crear Application Pool (No Managed Code)
3. Crear sitio web apuntando a la carpeta publicada
4. Configurar permisos apropiados

## Solución de Problemas

### Error 404 en ruta raíz
- Verificar que el `HomeController` existe
- Revisar la configuración de rutas en `Program.cs`

### Errores de conexión a base de datos
- Verificar que SQL Server esté ejecutándose
- Comprobar la cadena de conexión en `appsettings.json`
- Asegurarse de que la base de datos existe

### Certificado HTTPS local
```powershell
dotnet dev-certs https --trust
```

### Verificar puertos disponibles
- HTTPS: 7242
- HTTP: 5242
- Si están ocupados, cambiar en `launchSettings.json`

## Paquetes NuGet Incluidos
- Microsoft.EntityFrameworkCore.SqlServer (8.0.7)
- Microsoft.EntityFrameworkCore.Tools (8.0.7)

## Estructura de la Base de Datos
```sql
-- Tabla: dbo.tipo_vehiculo
CREATE TABLE dbo.tipo_vehiculo(
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL
);
```