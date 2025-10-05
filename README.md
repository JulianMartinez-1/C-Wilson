# 🎯 C# Wilson - Repositorio de Proyectos# Concesionario Web - Aplicación ASP.NET Core MVC



Este repositorio contiene todos mis proyectos desarrollados en C# durante el aprendizaje de programación orientada a objetos y desarrollo web.## Requisitos del Sistema

- Windows 10/11

## 📁 Estructura del Repositorio- Visual Studio 2022 con workload "ASP.NET and web development"

- .NET SDK 8

### 🖥️ [`01-Proyectos-Consola/`](./01-Proyectos-Consola/)- SQL Server (SQLEXPRESS o LocalDB)

Proyectos de aplicaciones de consola que demuestran conceptos fundamentales de C#:- SQL Server Management Studio (SSMS)



- **`CLASE 1/`** - Primeros ejercicios en C### Configuración de la Base de Datos

- **`EjerciciosHerencia/`** - Implementación de herencia

  - Conversión de dinero### 1. Abrir SSMS y conectarse al servidor

  - Cálculo de IMC- Conectarse a: `DESKTOP-QPGCC0J\SQLEXPRESS` (o tu instancia de SQL Server)

  - Operaciones matemáticas

  - Diagnóstico de valgo de rodilla### 2. Ejecutar el script de configuración

- **`HerenciaVehiculo/`** - Sistema de herencia con vehículos- Abrir el archivo `Scripts/ConfigurarBaseDatos.sql` en SSMS

  - Clase base Vehiculo- Ejecutar el script completo (F5)

  - Clases derivadas: Taxi, Motocicleta- Verificar que se creen la base de datos y tabla con datos de prueba

- **`Polimorfismo/`** - Demostración de polimorfismo

  - Animales domésticos (Perro, Gato)### 3. Verificar la cadena de conexión

- **`Trabajos/`** - Ejercicios avanzados- Revisar `appsettings.json` y asegurarse de que el servidor coincida con tu instancia

  - Workshop de POO- Formato: `Server=TU-SERVIDOR\SQLEXPRESS;Database=concesionario;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=true`

  - Manejo de arrays

  - Sistemas de empleados y nómina## Ejecutar la Aplicación

- **`TRABAJOS_CLASE/`** - Ejercicios realizados en clase

### En Desarrollo

### 🌐 [`02-ConcesionarioWeb/`](./02-ConcesionarioWeb/)1. Abrir el proyecto en Visual Studio 2022

**Aplicación Web ASP.NET Core MVC** - Sistema de gestión para concesionario de vehículos2. Presionar F5 o usar "Debug > Start Debugging"

3. La aplicación se abrirá en: `https://localhost:7242`

#### 🚀 Características principales:

- ✅ **Arquitectura MVC** (Model-View-Controller)### Desde línea de comandos

- ✅ **Entity Framework Core** para acceso a datos```powershell

- ✅ **SQL Server** como base de datoscd "ruta-del-proyecto"

- ✅ **CRUD completo** para tipos de vehículosdotnet run

- ✅ **Scaffolding automático** de vistas```

- ✅ **Validaciones de datos**

- ✅ **Responsive design**## Rutas Disponibles

- `/` o `/Home/Index` - Página de inicio

#### 🛠️ Tecnologías utilizadas:- `/TipoVehiculos` - Lista de tipos de vehículos

- **Framework**: ASP.NET Core 8.0- `/TipoVehiculos/Create` - Crear nuevo tipo de vehículo

- **Base de datos**: SQL Server (SQLEXPRESS)- `/TipoVehiculos/Edit/{id}` - Editar tipo de vehículo

- **ORM**: Entity Framework Core- `/TipoVehiculos/Details/{id}` - Detalles del tipo de vehículo

- **Frontend**: Razor Pages, HTML5, CSS3- `/TipoVehiculos/Delete/{id}` - Eliminar tipo de vehículo

- **Herramientas**: Visual Studio 2022, SSMS

## Arquitectura del Proyecto

#### 📋 Funcionalidades:

- 🏠 **Página de inicio** con navegación### Modelos

- 📝 **Gestión de tipos de vehículos**:- `Models/TipoVehiculo.cs` - Entidad principal con validaciones

  - Crear nuevos tipos

  - Listar todos los tipos### Contexto de Datos

  - Editar tipos existentes- `Data/ConcesionarioContext.cs` - DbContext de Entity Framework

  - Ver detalles

  - Eliminar tipos### Controladores

- 🔧 **Scripts de automatización**:- `Controllers/HomeController.cs` - Controlador de la página de inicio

  - Configuración de base de datos- `Controllers/TipoVehiculosController.cs` - CRUD para tipos de vehículos

  - Verificación del entorno

  - Ejecución simplificada### Vistas

- `Views/Home/Index.cshtml` - Página de inicio

#### 🚀 Cómo ejecutar:- `Views/TipoVehiculos/` - Vistas CRUD generadas por scaffolding

```bash- `Views/Shared/_Layout.cshtml` - Layout principal

cd 02-ConcesionarioWeb

dotnet run## Configuración para Producción

```

**URL**: `https://localhost:7242` o `http://localhost:5242`### Archivo appsettings.Production.json

Ya está configurado para usar la misma cadena de conexión. Para un entorno de producción real, actualizar con los datos del servidor de producción.

#### 📚 Documentación:

Ver [`02-ConcesionarioWeb/README.md`](./02-ConcesionarioWeb/README.md) para instrucciones detalladas.### Variable de entorno

```powershell

---$env:ASPNETCORE_ENVIRONMENT="Production"

```

## 🎓 Objetivos de Aprendizaje

## Publicación

Este repositorio demuestra el progreso en:

### Para carpeta local

### 📚 Conceptos de POO:```powershell

- ✅ **Encapsulación** - Ocultación de datos y métodosdotnet publish -c Release -o ./publish

- ✅ **Herencia** - Reutilización de código entre clases```

- ✅ **Polimorfismo** - Comportamiento dinámico de objetos

- ✅ **Abstracción** - Simplificación de sistemas complejos### Para IIS

1. Instalar .NET 8 Hosting Bundle

### 🏗️ Arquitectura de Software:2. Crear Application Pool (No Managed Code)

- ✅ **Patrón MVC** - Separación de responsabilidades3. Crear sitio web apuntando a la carpeta publicada

- ✅ **Inyección de dependencias** - Desacoplamiento4. Configurar permisos apropiados

- ✅ **Entity Framework** - ORM y mapeo objeto-relacional

- ✅ **Scaffolding** - Generación automática de código## Solución de Problemas



### 🌐 Desarrollo Web:### Error 404 en ruta raíz

- ✅ **ASP.NET Core** - Framework web moderno- Verificar que el `HomeController` existe

- ✅ **Razor Pages** - Generación dinámica de HTML- Revisar la configuración de rutas en `Program.cs`

- ✅ **Routing** - Navegación y URLs amigables

- ✅ **Validaciones** - Integridad de datos### Errores de conexión a base de datos

- Verificar que SQL Server esté ejecutándose

---- Comprobar la cadena de conexión en `appsettings.json`

- Asegurarse de que la base de datos existe

## 🛠️ Requisitos del Sistema

### Certificado HTTPS local

### Para proyectos de consola:```powershell

- .NET 9.0 SDKdotnet dev-certs https --trust

- Visual Studio 2022 o VS Code```



### Para el proyecto web:### Verificar puertos disponibles

- Windows 10/11- HTTPS: 7242

- .NET 8.0 SDK- HTTP: 5242

- SQL Server (SQLEXPRESS o LocalDB)- Si están ocupados, cambiar en `launchSettings.json`

- Visual Studio 2022 con workload "ASP.NET and web development"

- SQL Server Management Studio (SSMS)## Paquetes NuGet Incluidos

- Microsoft.EntityFrameworkCore.SqlServer (8.0.7)

---- Microsoft.EntityFrameworkCore.Tools (8.0.7)



## 📞 Contacto## Estructura de la Base de Datos

```sql

**Desarrollador**: Julian Martinez  -- Tabla: dbo.tipo_vehiculo

**Repositorio**: [C-Wilson](https://github.com/JulianMartinez-1/C-Wilson)CREATE TABLE dbo.tipo_vehiculo(

    id INT IDENTITY(1,1) PRIMARY KEY,

---    nombre VARCHAR(255) NOT NULL

);

*Este repositorio forma parte del aprendizaje de desarrollo de software con C# y .NET*```