CREATE DATABASE BDFarmacia;

use BDFarmacia;

-- Tabla tipoUsuarios
INSERT INTO tipoUsuarios (tipoUsuario) VALUES 
('Administrador'),
('Vendedor'),
('Cliente'),
('Proveedor'),
('Gerente'),
('Farmacéutico'),
('Técnico de Laboratorio'),
('Reponedor'),
('Cajero'),
('Auxiliar');

-- Tabla Usuarios
INSERT INTO Usuarios (id_tipoUsuario, nombreUsuario, Contraseña) VALUES 
(1, 'admin', 'admin123'),
(2, 'vendedor1', 'vend123'),
(2, 'vendedor2', 'vend456'),
(3, 'cliente1', 'cli123'),
(3, 'cliente2', 'cli456'),
(4, 'proveedor1', 'prov123'),
(4, 'proveedor2', 'prov456'),
(5, 'gerente1', 'ger123'),
(5, 'gerente2', 'ger456'),
(6, 'farmaceutico1', 'farm123');

-- Tabla Cargo
INSERT INTO Cargo (nombreCargo, pagoXHora) VALUES 
('Farmacéutico', 15.00),
('Vendedor', 10.00),
('Administrativo', 9.50),
('Reponedor', 9.00),
('Cajero', 9.00),
('Gerente', 20.00),
('Auxiliar', 8.50),
('Técnico de Laboratorio', 12.50);

-- Tabla Departamentos
INSERT INTO Departamentos (NombreDepartamento) VALUES 
('San Salvador'),
('Santa Ana'),
('San Miguel'),
('La Libertad'),
('Usulután');

-- Tabla Sucursales
INSERT INTO Sucursales (NombreSucursal, Id_Departamento) VALUES 
('Sucursal A', 1),
('Sucursal B', 2),
('Sucursal C', 3),
('Sucursal D', 4),
('Sucursal E', 5);

-- Tabla Proveedores
INSERT INTO Proveedores (NombreProveedor, Dirección, Email, Telefono) VALUES 
('Distribuidora A', 'Calle Principal 123', 'info@proveedora.com', '1111-2222'),
('Farmacia B', 'Av. Central 456', 'contacto@farmacia.com', '3333-4444'),
('Productos C', 'Calle Secundaria 789', 'ventas@productos.com', '5555-6666'),
('Distribuidora D', 'Av. Norte 123', 'info@distribuidora.com', '7777-8888'),
('Farmacia E', 'Calle Sur 456', 'contacto@farmaciae.com', '9999-0000');

INSERT INTO Marcas (NombreMarca) VALUES 
('Genérico'),
('Pfizer'),
('Bayer'),
('Novartis'),
('GlaxoSmithKline'),
('Roche'),
('Merck'),
('Johnson & Johnson'),
('Sanofi'),
('AbbVie');

INSERT INTO Presentaciones (TipoDePre) VALUES 
('Tabletas'),
('Cápsulas'),
('Jarabe'),
('Gotas'),
('Crema'),
('Inyección'),
('Suspensión oral'),
('Spray nasal'),
('Supositorios'),
('Gel tópico');

INSERT INTO Categorias (NombreCategoria) VALUES 
('Analgésicos'),
('Antibióticos'),
('Antiácidos'),
('Antihistamínicos'),
('Antiinflamatorios'),
('Broncodilatadores'),
('Hipolipemiantes'),
('Ansiolíticos'),
('Antiulcerosos'),
('Relajantes musculares');

INSERT INTO Productos (NombreProducto, PrecioV, Stock, Descripcion, Receta, id_Categoria, id_Presentacion, id_Marca) VALUES 
('Paracetamol', 5.99, 200, 'Analgesico y antipirético', 0, 1, 1, 1),
('Amoxicilina', 7.50, 150, 'Antibiótico', 1, 2, 2, 2),
('Omeprazol', 8.25, 180, 'Antiácido', 0, 3, 3, 3),
('Loratadina', 6.80, 220, 'Antihistamínico', 0, 4, 4, 4),
('Ibuprofeno', 6.50, 250, 'Antiinflamatorio y analgésico', 0, 1, 5, 1),
('Cetirizina', 9.00, 180, 'Antihistamínico', 0, 4, 6, 4),
('Salbutamol', 10.20, 200, 'Broncodilatador', 1, 5, 7, 5),
('Diazepam', 12.75, 170, 'Ansiolítico y relajante muscular', 1, 6, 8, 6),
('Lansoprazol', 8.90, 190, 'Antiulceroso', 0, 3, 9, 3),
('Simvastatina', 15.40, 210, 'Hipolipemiante', 1, 7, 10, 7);

-- Tabla Lotes
INSERT INTO Lotes (id_Producto, id_Proveedor, id_Sucursal, FechaCompra, FechaVencimiento, PrecioCompra, PDescuento, Cantidad) VALUES 
(1, 1, 1, '2024-03-01', '2025-03-01', 100.00, 0.50, 100),
(2, 2, 2, '2024-03-02', '2025-03-02', 120.00, 0.20, 120),
(3, 3, 3, '2024-03-03', '2025-03-03', 90.00, 0.90, 90),
(4, 4, 4, '2024-03-04', '2025-03-04', 80.00, 0.40, 80),
(5, 5, 5, '2024-03-05', '2025-03-05', 110.00, 0.10, 110);

INSERT INTO InventarioSucursales (id_Producto, id_Sucursal, Cantidad) VALUES 
(1, 1, 100),
(2, 2, 120),
(3, 3, 90),
(4, 4, 80),
(5, 5, 110);


INSERT INTO Empleados (id_Usuario, Nombre, Direccion, Id_Cargo, Edad, Telefono, FechaIngreso) VALUES 
(1, 'Juan Pérez', 'Av. Central 123', 1, 35, '7777-8888', '2018-01-10'),
(2, 'María López', 'Calle Norte 456', 2, 28, '8888-9999', '2019-02-15'),
(3, 'Carlos García', 'Av. Sur 789', 3, 40, '9999-0000', '2017-03-20'),
(4, 'Ana Martínez', 'Calle Este 123', 4, 32, '1111-2222', '2020-04-25'),
(5, 'Laura Rodríguez', 'Av. Oeste 456', 5, 25, '2222-3333', '2016-05-30');

INSERT INTO Membresias (TipoMembresia, Costo, Beneficios) VALUES 
('Básica', 50.00, 'Descuento del 10% en medicamentos'),
('Bronce', 70.00, 'Descuento del 15% en medicamentos, consulta gratuita'),
('Plata', 60.00, 'Descuento del 20% en medicamentos, consulta gratuita, 2 exámenes de laboratorio gratuitos'),
('Oro', 80.00, 'Descuento del 25% en medicamentos, consulta gratuita, 4 exámenes de laboratorio gratuitos, descuento en servicios adicionales'),
('Premium', 90.00, 'Descuento del 30% en medicamentos, consulta gratuita, 6 exámenes de laboratorio gratuitos, descuento en servicios adicionales y hospitalización'),
('Ninguna', 0.00, 'No tiene');

INSERT INTO PeriodoMembresias (periodoMembresia) VALUES 
(30),
(60),
(90),
(120),
(180);


INSERT INTO Clientes (id_Usuario, NombreCliente, Dui, Dirección, Email, Telefono, FechaConMem, FechaVenMem, id_Membresia, NumCitasAsis) VALUES 
(4, 'Roberto García', '001234567', 'Colonia 1, San Salvador', 'roberto@example.com', '7777-8888', '2023-01-01', '2024-01-01', 1, 3),
(5, 'María Rodríguez', '001234568', 'Colonia 2, San Salvador', 'maria@example.com', '9999-0000', '2023-02-01', '2024-02-01', 2, 5),
(6, 'José Martínez', '001234569', 'Colonia 3, San Salvador', 'jose@example.com', '1111-2222', '2023-03-01', '2024-03-01', 3, 2),
(7, 'Sofía López', '001234570', 'Colonia 4, San Salvador', 'sofia@example.com', '3333-4444', '2023-04-01', '2024-04-01', 4, 4),
(8, 'Daniel Hernández', '001234571', 'Colonia 5, San Salvador', 'daniel@example.com', '5555-6666', '2023-05-01', '2024-05-01', 5, 1);


INSERT INTO PagoMembresias (Id_Cliente, FechaPago, MontoPagado, id_PeriodoMembresias, id_Membresias) VALUES 
(1, '2024-03-01', 50.00, 1, 1),
(2, '2024-03-02', 70.00, 2, 2),
(3, '2024-03-03', 60.00, 3, 3),
(4, '2024-03-04', 80.00, 4, 4),
(5, '2024-03-05', 90.00, 5, 5);

INSERT INTO DescuentosMembresia (Id_Membresia, id_Categoria, PorcentajeDesct) VALUES 
(1, 1, 0.10),
(2, 2, 0.15),
(3, 3, 0.20),
(4, 4, 0.25),
(5, 5, 0.30);

INSERT INTO ConveniosHC (NombreHC, Direccion, Telefono, Correo) VALUES 
('Hospital A', 'Av. Principal 123', '2222-3333', 'info@hospitala.com'),
('Hospital B', 'Calle Central 456', '4444-5555', 'info@hospitalb.com'),
('Hospital C', 'Av. Norte 789', '6666-7777', 'info@hospitalc.com'),
('Hospital D', 'Calle Sur 123', '8888-9999', 'info@hospitald.com'),
('Hospital E', 'Av. Oeste 456', '0000-1111', 'info@hospitale.com');

INSERT INTO DatosConvenios (Id_ConveniosHC, Id_Membresia, FechaInicio, FechaVencimiento) VALUES 
(1, 1, '2024-03-01', '2024-06-01'),
(2, 2, '2024-03-02', '2024-06-02'),
(3, 3, '2024-03-03', '2024-06-03'),
(4, 4, '2024-03-04', '2024-06-04'),
(5, 5, '2024-03-05', '2024-06-05');

INSERT INTO DrEspecialidades (Id_ConveniosHC, NombreDr, Especialidad, Tel) VALUES 
(1, 'Dr. Pérez', 'Medicina General', '7777-8888'),
(2, 'Dr. López', 'Pediatría', '9999-0000'),
(3, 'Dr. García', 'Ginecología', '1111-2222'),
(4, 'Dr. Martínez', 'Oftalmología', '3333-4444'),
(5, 'Dr. Rodríguez', 'Odontología', '5555-6666');

INSERT INTO ConsultasME (Id_DatConvenios, Id_Cliente, Id_DrEspecialidades, Fecha, DetallesAdicionales) VALUES 
(1, 1, 1, '2024-03-01', 'Consulta general'),
(2, 2, 2, '2024-03-02', 'Consulta pediátrica'),
(3, 3, 3, '2024-03-03', 'Consulta ginecológica'),
(4, 4, 4, '2024-03-04', 'Consulta oftalmológica'),
(5, 5, 5, '2024-03-05', 'Consulta odontológica');

INSERT INTO estadoDevolucion (estadoDevolucion) VALUES 
('Pendiente'),
('Aceptada'),
('Rechazada'),
('En proceso'),
('Completada');

INSERT INTO MotivoDevolucion (Motivo) VALUES 
('Producto defectuoso'),
('Producto incorrecto'),
('Cambio de producto'),
('Cancelación de pedido'),
('Otro motivo');



INSERT INTO estadoPedido (estadoPedido) VALUES 
('Pendiente'),
('En proceso'),
('En tránsito'),
('Entregado'),
('Cancelado');

INSERT INTO TipoDePagos(Pago) VALUES 
('Efectivo'),
('Tarjeta de crédito'),
('Tarjeta de débito'),
('Transferencia bancaria'),
('Cheque');


INSERT INTO Facturas (Fecha, id_Empleado, id_Cliente, Subtotal, Descuento, Total, id_TipoPago, id_Sucursal) VALUES 
('2024-03-01', 1, 1, 100.00, 10.00, 90.00, 1, 1),
('2024-03-02', 2, 2, 150.00, 15.00, 135.00, 2, 2),
('2024-03-03', 3, 3, 120.00, 5.00, 115.00, 3, 3),
('2024-03-04', 4, 4, 80.00, 8.00, 72.00, 1, 4),
('2024-03-05', 5, 5, 200.00, 20.00, 180.00, 2, 5);

INSERT INTO DetalleCompras (id_Producto, id_Lote, id_Factura, Total, Descuento, Cantidad) VALUES 
(1, 1, 1, 25.00, 0.00, 5),
(2, 2, 2, 60.00, 5.00, 8),
(3, 3, 3, 50.00, 0.00, 6),
(4, 4, 4, 40.00, 2.00, 7),
(5, 5, 5, 30.00, 0.50, 4);

INSERT INTO Pedidos (id_facturas, id_estado_pedido, id_Empleado, Fecha_pedidos, direccion) VALUES 
(1, 1, 1, '2024-03-01', 'Colonia Escalón, San Salvador'),
(2, 2, 2, '2024-03-02', 'Colonia San Benito, San Salvador'),
(3, 3, 3, '2024-03-03', 'Colonia Flor Blanca, San Salvador'),
(4, 4, 4, '2024-03-04', 'Colonia San Francisco, San Salvador'),
(5, 5, 5, '2024-03-05', 'Colonia Maquilishuat, San Salvador');

INSERT INTO Devoluciones (id_estadoDevolucion, id_Producto, id_Factura, id_Empleado, FechaDevolucion, Id_MotivoDevolucion, Cantidad, MontoReembolsado) VALUES 
(1, 1, 1, 1, '2024-03-15', 1, 2, 10.00),
(2, 2, 2, 2, '2024-03-20', 2, 3, 15.00),
(3, 3, 3, 3, '2024-03-25', 3, 4, 20.00),
(4, 4, 4, 4, '2024-03-30', 4, 5, 25.00),
(5, 5, 5, 5, '2024-04-01', 5, 6, 30.00);

INSERT INTO TipoHoras (DescripHoras) VALUES 
('Ordinarias'),
('Extraordinarias'),
('Nocturnas'),
('Festivas'),
('Suplementarias');

INSERT INTO HorasTrabajadas (id_Empleado, Fecha, HorasTrabajadas, TipoHora) VALUES 
(1, '2024-03-01', 8, 1),
(2, '2024-03-01', 7, 2),
(3, '2024-03-01', 8, 3),
(4, '2024-03-01', 9, 4),
(5, '2024-03-01', 8, 5);

INSERT INTO TipoDeduccion (DescripDeduc) VALUES 
('Seguro Médico'),
('Pensión'),
('Impuesto sobre la Renta'),
('Préstamo'),
('Otros Descuentos');

INSERT INTO Deducciones (id_Empleado, TipoDeduccion, MontoDeduccion, FechaDeduccion) VALUES 
(1, 1, 50.00, '2024-03-15'),
(2, 2, 75.00, '2024-03-20'),
(3, 3, 100.00, '2024-03-25'),
(4, 4, 30.00, '2024-03-30'),
(5, 5, 40.00, '2024-04-01');

INSERT INTO DetallePago (TotXHoras, TotDescuentos, Aguinaldo) VALUES 
(300.00, 125.00, 50.00),
(320.00, 150.00, 60.00),
(280.00, 110.00, 45.00),
(350.00, 140.00, 55.00),
(310.00, 130.00, 52.00);

INSERT INTO PagosRealizados (id_Empleado, FechaDePago, MontoTotal, id_DetallePago) VALUES 
(1, '2024-03-15', 400.00, 1),
(2, '2024-03-20', 430.00, 2),
(3, '2024-03-25', 390.00, 3),
(4, '2024-03-30', 420.00, 4),
(5, '2024-04-01', 380.00, 5);



-- Procedimiento 

CREATE PROCEDURE InsertarDetalleCompra
    @IdFactura INT,
    @IdProducto INT,
    @Cantidad INT,
    @ErrorTexto NVARCHAR(255) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @FechaActual DATETIME;
    DECLARE @PrecioUnitario DECIMAL(18,2);
    DECLARE @IdSucursal INT;
    DECLARE @IdCliente INT;
    DECLARE @IdLote INT;
    DECLARE @IdMembresia INT;
    DECLARE @DescuentoPorVencimiento DECIMAL(18,2);
    DECLARE @DescuentoPorMembresia DECIMAL(18,2);
    DECLARE @TotalDescuento DECIMAL(12,2);
    DECLARE @VerificarMembresia BIT;
    DECLARE @FechaVencimiento DATETIME;
    DECLARE @FechaLimite DATETIME;
	DECLARE @Total DECIMAL(18,2);

    -- Inicializar el texto de error
    SET @ErrorTexto = '';

	SET @TotalDescuento = 0;

    -- Obtener la sucursal y cliente
    SELECT @IdSucursal = id_Sucursal, @IdCliente = id_Cliente
    FROM Facturas
    WHERE id_Factura = @IdFactura;

    -- Obtener la fecha actual
    SET @FechaActual = GETDATE();

    -- Obtener el precio unitario del artículo
    SELECT @PrecioUnitario = PrecioV
    FROM Productos
    WHERE id_Producto = @IdProducto;

    -- Obtener el lote más próximo a vencer para la sucursal dada y su descuento por vencimiento
    SELECT TOP 1 @IdLote = id_Lotes, @DescuentoPorVencimiento = PDescuento, @FechaVencimiento = FechaVencimiento
    FROM Lotes 
    WHERE id_Producto = @IdProducto 
    AND id_Sucursal = @IdSucursal
    AND FechaVencimiento > @FechaActual
    AND Cantidad >= @Cantidad
    ORDER BY FechaVencimiento ASC;

    -- Verificar si se encontró un lote válido
    IF @IdLote IS NULL
    BEGIN
        SET @ErrorTexto = 'No hay stock de ese producto.';
        RETURN;
    END;

    -- Calcular el descuento por membresía del cliente
    SELECT @IdMembresia = id_Membresia 
    FROM Clientes
	WHERE id_Cliente = @IdCliente;

    EXEC VerificarProductoMembresia @idMembresia, @IdProducto, @Respuesta = @VerificarMembresia OUTPUT;

	SET @Total = @Cantidad * @PrecioUnitario;
	SET @FechaLimite = DATEADD(MONTH, -1, @FechaVencimiento);

  IF (@IdMembresia != 6 AND @VerificarMembresia = 1) OR @FechaVencimiento >= @FechaLimite 
		BEGIN
			IF @FechaVencimiento < @FechaLimite
				BEGIN
					SET @DescuentoPorVencimiento = 0;
				END;

			IF @IdMembresia = 6 OR @VerificarMembresia = 0
				BEGIN
					SET @DescuentoPorMembresia = 0;
				END;

			SELECT @DescuentoPorMembresia = PorcentajeDesct 
			FROM DescuentosMembresia
			WHERE Id_Membresia =  @IdMembresia;

			IF @DescuentoPorVencimiento > @DescuentoPorMembresia
				BEGIN
					SET @TotalDescuento = @Total * @DescuentoPorVencimiento;
				END
			ELSE
				BEGIN
					SET @TotalDescuento = @Total * @DescuentoPorMembresia;
				END;
	  END;

	INSERT INTO DetalleCompras (id_Producto, id_Lote, id_Factura, Total, Descuento, Cantidad)
	VALUES (@IdProducto, @IdLote, @IdFactura, @Total, @TotalDescuento, @Cantidad);

END;



--DECLARE @ErrorText NVARCHAR(255);
--EXEC InsertarDetalleCompra 3,3,2, @ErrorText OUTPUT;
--print @ErrorText;


CREATE PROCEDURE VerificarProductoMembresia
	@idMembresia INT,
	@idProducto INT,
	@Respuesta BIT OUTPUT
AS
BEGIN

	DECLARE @IdCategoria INT;
	DECLARE @Existe INT;

	SELECT @IdCategoria = id_Categoria
	FROM Productos
	WHERE id_Producto = @idProducto;

	SELECT @Existe = COUNT(*)
	FROM DescuentosMembresia
	WHERE id_Categoria = @IdCategoria AND Id_Membresia = @idMembresia;

	IF @Existe != 0
		SET @Respuesta = 1;
	ELSE
		SET @Respuesta = 0;

END;


--DECLARE @Resultado BIT;
--EXEC VerificarProductoMembresia  2,2, @Respuesta = @Resultado OUTPUT;
--SELECT @Resultado AS Respuesta;

CREATE PROCEDURE CalcularTotalesDeDetalle
	@idFactura INT
AS
BEGIN
	DECLARE @Subtotal DECIMAL(12,2);
	DECLARE @TotalDescuento DECIMAL(12,2);
	DECLARE @TotalFinal DECIMAL(12,2);

	SELECT @Subtotal = SUM(Total), @TotalDescuento = SUM(Descuento)
	FROM DetalleCompras
	WHERE id_Factura = @idFactura;

	SET @TotalFinal = @Subtotal - @TotalDescuento;

	UPDATE Facturas 
	SET Subtotal = @Subtotal, Descuento = @TotalDescuento, Total = @TotalFinal
	WHERE id_Factura = @idFactura;

END;


--EXEC CalcularTotalesDeDetalle 3;

--TRIGGERS

CREATE TRIGGER RestarStockPorCompra
ON DetalleCompras
AFTER INSERT
AS
BEGIN
  DECLARE @IdLote INT;
	DECLARE @IdProducto INT;
	DECLARE @IdSucursal INT;
  DECLARE @CantidadComprada INT;

  -- Obtener el Id del lote y la cantidad comprada de la fila insertada
  SELECT @IdLote = i.id_Lote, @CantidadComprada = i.Cantidad
  FROM inserted i;

	SELECT @IdProducto = id_Producto, @IdSucursal = id_Sucursal
	FROM Lotes
  WHERE id_Lotes = @IdLote;

  -- Restar la cantidad comprada de la cantidad disponible en el lote
  UPDATE Lotes
  SET Cantidad = Cantidad - @CantidadComprada
  WHERE id_Lotes = @IdLote;

  UPDATE Productos
	SET Stock = Stock - @CantidadComprada
	WHERE id_Producto = @IdProducto;

	UPDATE InventarioSucursales
	SET Cantidad = Cantidad - @CantidadComprada
	WHERE id_Sucursal = @IdSucursal
	AND id_Producto = @IdProducto;

END;
