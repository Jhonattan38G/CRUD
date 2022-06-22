--- Script SQL para PRUEBA TÉCNICA

--- Crear tabla
use dbML

create table prueba(
	id int not null primary key identity,
	nombre varchar(50) not null,
	doc_type varchar(20) not null,
	num_type int not null,
	direccion varchar(30),
	telefono int not null,
	correo varchar(50),
	fecha dateTime,
)



-- PRIMER PROCESO ALMACENADO DE PRUEBA
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JhonattanGonzalez
-- Create date: 18/06/2022
-- Description: insertar registros de usuarios con procedimientos almacenados
-- =============================================
CREATE PROCEDURE spInsertar
	-- Add the parameters for the stored procedure here

    @nombre varchar (50),
	@doc_type varchar (20),
    @num_type  int,
    @direccion varchar (30),
    @telefono int,
    @correo varchar (50),
    @fecha dateTime

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	insert into prueba (
		nombre,
		doc_type,
		num_type,
		direccion,
		telefono,
		correo,
		fecha
	)
	values(
		@nombre,
		@doc_type,
		@num_type,
		@direccion,
		@telefono,
		@correo,
		@fecha
	)

END
GO


-- prueba Procedimiento spInsertar
declare @FECHA_ACTUAL datetime
Set @FECHA_ACTUAL=GETDATE()
Print @FECHA_ACTUAL

exec spInsertar 'Jhonattan','cedula',1231231,'calle 24 No 13',21321321,'correo@mail.com', @FECHA_ACTUAL

SELECT *
FROM PRUEBA




-- SEGUNDO PROCESO ALMACENADO DE PRUEBA
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JhonattanGonzalez
-- Create date: 18/06/2022
-- Description: insertar registros de usuarios con procedimientos almacenados
-- =============================================
CREATE PROCEDURE spInsertar2
	-- Add the parameters for the stored procedure here

    @nombre varchar (50),
	@doc_type varchar (20),
    @num_type  int,
    @direccion varchar (30),
    @telefono int,
    @correo varchar (50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @FECHA_ACTUAL datetime
	Set @FECHA_ACTUAL=GETDATE()
	insert into prueba (
		nombre,
		doc_type,
		num_type,
		direccion,
		telefono,
		correo,
		fecha
	)
	values(
		@nombre,
		@doc_type,
		@num_type,
		@direccion,
		@telefono,
		@correo,
		@FECHA_ACTUAL
	)

END
GO



-- prueba Procedimiento spInsertar2
exec spInsertar2 'Jhonattan','cedula',1231231,'calle 24 No 13',21321321,'correo@mail.com'

SELECT *
FROM PRUEBA


-- TERCER PROCESO ALMACENADO DE PRUEBA
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JhonattanGonzalez
-- Create date: 18/06/2022
-- Description: consultar registros de usuarios con procedimientos almacenados
-- =============================================
CREATE PROCEDURE spConsulta
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM PRUEBA

END
GO



-- prueba Procedimiento spInsertar2 y Consulta
exec spInsertar2 'Alexander','NIP',11001103,'carrera 2 No 1',79532,'correo@gmail.com'
exec spConsulta






-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JhonattanGonzalez
-- Create date: 18/06/2022
-- Description: Eliminar registros de usuarios con procedimientos almacenados
-- =============================================
CREATE PROCEDURE spEliminar
	-- Add the parameters for the stored procedure here

    @id int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM prueba
	WHERE id = @id;
	

END
GO



-- prueba Procedimiento spInsertar2 y Consulta
exec spInsertar2 'Mir R','Tarjeta',11001103,'carrera 2 No 1',79532,'correo123@gmail.com'
exec spConsulta
exec spEliminar 2

exec spConsulta





-- QUINTO PROCESO ALMACENADO DE PRUEBA
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JhonattanGonzalez
-- Create date: 18/06/2022
-- Description: Editar registros de usuarios con procedimientos almacenados
-- =============================================
CREATE PROCEDURE spEditar
	-- Add the parameters for the stored procedure here

	@id int,
    @nombre varchar (50),
	@doc_type varchar (20),
    @num_type  int,
    @direccion varchar (30),
    @telefono int,
    @correo varchar (50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	declare @FECHA_ACTUAL datetime
	Set @FECHA_ACTUAL=GETDATE()


	UPDATE prueba
	set nombre = @nombre, 
	doc_type=@doc_type,
	num_type=@num_type,
	direccion=@direccion,
	telefono=@telefono,
	correo=@correo,
	fecha=@FECHA_ACTUAL
	where id =@id;


END
GO


-- prueba Procedimiento spEditar y Consulta
exec spEditar 1,'Jhon','cedula',11001103,'carrera 2 No 3',79532,'correo123@gmail.com'
exec spConsulta





-- SEXTO PROCESO ALMACENADO DE PRUEBA
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JhonattanGonzalez
-- Create date: 18/06/2022
-- Description: consulta de registros de usuarios con procedimientos almacenados para edicion
-- =============================================
CREATE PROCEDURE spEditarConsulta
	-- Add the parameters for the stored procedure here

	@id int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select *
	from prueba
	where id = @id


END
GO

exec spEditarConsulta 10
