-- PROCEDIMIENTOS ALMACENADOS --
--•Procedure para listar los registros de Carreras.

USE BDESTUDIOS2023
GO

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'ListarCarreras')
BEGIN
    DROP PROCEDURE ListarCarreras
END
GO

CREATE PROCEDURE ListarCarreras
AS
BEGIN
    SELECT *
    FROM Carreras
END
GO


--Procedure para listar los registros de Alumnos:

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'ListarAlumnos')
BEGIN
    DROP PROCEDURE ListarAlumnos
END
GO

CREATE PROCEDURE ListarAlumnos
AS
BEGIN
    SELECT *
    FROM Alumnos
END
GO

-- Procedure para agregar un registro a la tabla Alumnos:

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'AgregarAlumno')
BEGIN
    DROP PROCEDURE AgregarAlumno
END
GO

CREATE PROCEDURE AgregarAlumno
(
    @codalu char(7),
    @nomalu varchar(50),
    @telefono varchar(10),
    @codcar int
)
AS
BEGIN
    INSERT INTO Alumnos (codalu, nomalu, telefono, codcar)
    VALUES (@codalu, @nomalu, @telefono, @codcar)
END
GO

-- Procedure para actualizar un registro en la tabla Alumnos:

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'ActualizarAlumno')
BEGIN
    DROP PROCEDURE ActualizarAlumno
END
GO

CREATE PROCEDURE ActualizarAlumno
(
    @codalu char(7),
    @nomalu varchar(50),
    @telefono varchar(10),
    @codcar int
)
AS
BEGIN
    UPDATE Alumnos
    SET nomalu = @nomalu,
        telefono = @telefono,
        codcar = @codcar
    WHERE codalu = @codalu
END
GO


---PROCEDIMIENTO PARA BUSCAR POR ID

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'BuscarAlumnoPorId')
BEGIN
    DROP PROCEDURE BuscarAlumnoPorId
END
GO

CREATE PROCEDURE BuscarAlumnoPorId
(
    @codalu char(7)
)
AS
BEGIN
    SELECT *
    FROM Alumnos
    WHERE codalu = @codalu
END
GO

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'ActualizarCarrera')
BEGIN
    DROP PROCEDURE ActualizarCarrera
END
GO

CREATE PROCEDURE ActualizarCarrera
(
    @codcar int,
    @nuevoNombre varchar(40)
)
AS
BEGIN
    UPDATE Carreras
    SET nomcar = @nuevoNombre
    WHERE codcar = @codcar
END
GO


IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'AgregarCarrera')
BEGIN
    DROP PROCEDURE AgregarCarrera
END
GO

CREATE PROCEDURE AgregarCarrera
(
    @codcar int,
    @nomcar varchar(40)
)
AS
BEGIN
    INSERT INTO Carreras (codcar, nomcar)
    VALUES (@codcar, @nomcar)
END
GO

