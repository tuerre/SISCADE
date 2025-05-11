-- CREATE DATABASE SISCADE;
-- GO
-- USE SISCADE;

CREATE TABLE Cliente (
    IdCliente INT PRIMARY KEY IDENTITY,
    NombreCompleto NVARCHAR(100) NOT NULL,
    DocumentoTipo NVARCHAR(20) NOT NULL,
    DocumentoNumero NVARCHAR(50) UNIQUE NOT NULL,
    Nacionalidad NVARCHAR(50),
    Direccion NVARCHAR(150),
    Telefono NVARCHAR(20),
    Correo NVARCHAR(100),
    Ocupacion NVARCHAR(100),
    FuenteFondos NVARCHAR(100)
);

CREATE TABLE Empleado (
    IdEmpleado INT PRIMARY KEY IDENTITY,
    NombreCompleto NVARCHAR(100) NOT NULL,
    Usuario NVARCHAR(50) UNIQUE NOT NULL,
    Contrasena NVARCHAR(255) NOT NULL,
    Rol NVARCHAR(20) NOT NULL,
    Estado BIT DEFA		ULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    UltimoInicioSesion DATETIME
);

CREATE TABLE Moneda (
    IdMoneda INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(50) NOT NULL,
    Codigo NVARCHAR(10) UNIQUE NOT NULL
);

CREATE TABLE TasaCambio (
    IdTasa INT PRIMARY KEY IDENTITY,
    IdMoneda INT FOREIGN KEY REFERENCES Moneda(IdMoneda),
    TasaCompra DECIMAL(18, 4) NOT NULL,
    TasaVenta DECIMAL(18, 4) NOT NULL,
    FechaVigencia DATE NOT NULL,
    UsuarioRegistro NVARCHAR(50) NOT NULL
);

CREATE TABLE Transaccion (
    IdTransaccion INT PRIMARY KEY IDENTITY,
    IdCliente INT FOREIGN KEY REFERENCES Cliente(IdCliente),
    IdEmpleado INT FOREIGN KEY REFERENCES Empleado(IdEmpleado),
    IdMoneda INT FOREIGN KEY REFERENCES Moneda(IdMoneda),
    TipoTransaccion NVARCHAR(10) CHECK (TipoTransaccion IN ('Compra', 'Venta')) NOT NULL,
    Monto DECIMAL(18, 2) NOT NULL,
    TasaCambioAplicada DECIMAL(18, 4) NOT NULL,
    TotalLocal DECIMAL(18, 2) NOT NULL,
    FechaHora DATETIME DEFAULT GETDATE(),
    FormaPago NVARCHAR(50) NOT NULL,
    Observaciones NVARCHAR(255)
);

