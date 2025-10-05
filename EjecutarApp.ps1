# Script para ejecutar la aplicación Concesionario Web

Write-Host "=== Concesionario Web - Iniciando aplicacion ===" -ForegroundColor Green

# Verificar que estamos en el directorio correcto
if (-not (Test-Path "ConcesionarioWeb.csproj")) {
    Write-Host "Error: No se encontro el archivo ConcesionarioWeb.csproj" -ForegroundColor Red
    Write-Host "Ejecuta este script desde el directorio del proyecto" -ForegroundColor Yellow
    exit 1
}

# Verificar .NET SDK
Write-Host "Verificando .NET SDK..." -ForegroundColor Yellow
$dotnetVersion = dotnet --version
Write-Host "Version de .NET SDK: $dotnetVersion" -ForegroundColor Cyan

# Compilar el proyecto
Write-Host "Compilando el proyecto..." -ForegroundColor Yellow
dotnet build

if ($LASTEXITCODE -ne 0) {
    Write-Host "Error al compilar el proyecto" -ForegroundColor Red
    exit 1
}

Write-Host "Proyecto compilado exitosamente!" -ForegroundColor Green
Write-Host ""
Write-Host "IMPORTANTE: Antes de continuar, asegurate de que:" -ForegroundColor Yellow
Write-Host "1. SQL Server este ejecutandose" -ForegroundColor White
Write-Host "2. La base de datos 'concesionario' exista" -ForegroundColor White
Write-Host "3. La cadena de conexion en appsettings.json sea correcta" -ForegroundColor White
Write-Host ""

# Preguntar si continuar
$continuar = Read-Host "Deseas ejecutar la aplicacion ahora? (S/N)"
if ($continuar -eq "S" -or $continuar -eq "s") {
    Write-Host "Iniciando la aplicacion..." -ForegroundColor Green
    Write-Host "La aplicacion se abrira en: https://localhost:7242" -ForegroundColor Cyan
    Write-Host "Presiona Ctrl+C para detener la aplicacion" -ForegroundColor Yellow
    Write-Host ""
    
    # Ejecutar la aplicación
    dotnet run
} else {
    Write-Host "Para ejecutar la aplicacion manualmente, usa: dotnet run" -ForegroundColor Cyan
}