-- Script para configurar la base de datos del concesionario
-- Ejecutar en SQL Server Management Studio (SSMS)
-- Conectarse a: LAPTOP-P510448J\SQLEXPRESS

-- 1. Crear la base de datos si no existe
IF DB_ID('concesionario') IS NULL
    CREATE DATABASE concesionario;
GO

-- 2. Usar la base de datos
USE concesionario;
GO

-- 3. Crear la tabla tipo_vehiculo si no existe
IF OBJECT_ID('dbo.tipo_vehiculo','U') IS NULL
BEGIN
    CREATE TABLE dbo.tipo_vehiculo(
        id INT IDENTITY(1,1) PRIMARY KEY,
        nombre VARCHAR(255) NOT NULL
    );
    
    -- Insertar datos iniciales
    INSERT INTO dbo.tipo_vehiculo(nombre)
    VALUES ('Automóvil'),('Camioneta'),('Motocicleta');
    
    PRINT 'Tabla tipo_vehiculo creada e inicializada con datos de prueba.';
END
ELSE
BEGIN
    PRINT 'La tabla tipo_vehiculo ya existe.';
END
GO

-- 4. Verificar que los datos estén insertados
SELECT * FROM dbo.tipo_vehiculo;
GO