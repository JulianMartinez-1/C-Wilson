# Script de verificación para el proyecto Concesionario Web

Write-Host "=== Verificacion de Configuracion - Concesionario Web ===" -ForegroundColor Green
Write-Host ""

$errores = 0

# 1. Verificar .NET SDK
Write-Host "1. Verificando .NET SDK..." -ForegroundColor Yellow
$dotnetVersion = dotnet --version 2>$null
if ($dotnetVersion) {
    Write-Host "   OK - .NET SDK instalado: $dotnetVersion" -ForegroundColor Green
} else {
    Write-Host "   ERROR - .NET SDK no encontrado" -ForegroundColor Red
    $errores++
}

# 2. Verificar archivo del proyecto
Write-Host "2. Verificando archivo del proyecto..." -ForegroundColor Yellow
if (Test-Path "ConcesionarioWeb.csproj") {
    Write-Host "   OK - ConcesionarioWeb.csproj encontrado" -ForegroundColor Green
} else {
    Write-Host "   ERROR - ConcesionarioWeb.csproj no encontrado" -ForegroundColor Red
    $errores++
}

# 3. Verificar archivos importantes
Write-Host "3. Verificando archivos del proyecto..." -ForegroundColor Yellow
$archivos = @("Program.cs", "appsettings.json", "Models/TipoVehiculo.cs", "Data/ConcesionarioContext.cs")

foreach ($archivo in $archivos) {
    if (Test-Path $archivo) {
        Write-Host "   OK - $archivo" -ForegroundColor Green
    } else {
        Write-Host "   ERROR - $archivo no encontrado" -ForegroundColor Red
        $errores++
    }
}

# 4. Verificar compilación
Write-Host "4. Verificando compilacion..." -ForegroundColor Yellow
$resultado = dotnet build --verbosity quiet 2>$null
if ($LASTEXITCODE -eq 0) {
    Write-Host "   OK - El proyecto compila correctamente" -ForegroundColor Green
} else {
    Write-Host "   ERROR - Error en la compilacion" -ForegroundColor Red
    $errores++
}

# Resumen
Write-Host ""
Write-Host "=== RESUMEN ===" -ForegroundColor Cyan
if ($errores -eq 0) {
    Write-Host "EXITO - Configuracion completa! El proyecto esta listo." -ForegroundColor Green
    Write-Host ""
    Write-Host "Proximos pasos:" -ForegroundColor Yellow
    Write-Host "1. Ejecutar Scripts/ConfigurarBaseDatos.sql en SSMS" -ForegroundColor White
    Write-Host "2. Verificar cadena de conexion en appsettings.json" -ForegroundColor White
    Write-Host "3. Ejecutar: dotnet run" -ForegroundColor White
} else {
    Write-Host "ERROR - Se encontraron $errores errores" -ForegroundColor Red
}

Write-Host ""