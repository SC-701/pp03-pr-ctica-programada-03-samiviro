CREATE PROCEDURE ObtenerVehiculos 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT         Vehiculo.Id, Vehiculo.Placa, Vehiculo.Color, Vehiculo.Anio, Vehiculo.Precio, Vehiculo.CorreoPropietario, Vehiculo.TelefonoPropietario, Marcas.Nombre, Modelos.Nombre AS Expr1
FROM            Marcas INNER JOIN
                         Modelos ON Marcas.Id = Modelos.IdMarca INNER JOIN
                         Vehiculo ON Modelos.Id = Vehiculo.IdModelo
END