alTER procedure SP_COMPRAS
@OP TINYINT= 0,
@CO_FOLIO TINYINT = 0,
@CO_SERIE VARCHAR(3)= NULL,
@CO_ID_TIPODOCTO TINYINT= 0,
@CO_ID_PROVEEDOR TINYINT=0,
@CO_ID_ALMACEN TINYINT = 0,
@CO_FACTURA VARCHAR(20) = NULL,
@CO_FECHA VARCHAR = NULL
AS

	BEGIN
	--GUARDA Y ACTUALIZA
		IF @OP = 1
		BEGIN
			SET @CO_FOLIO=(SELECT ISNULL(MAX(CO_FOLIO),0) + 1 FROM COMPRAS)
			IF NOT EXISTS(SELECT * FROM COMPRAS WHERE CO_FOLIO = @CO_FOLIO)
				BEGIN 
					INSERT INTO COMPRAS(CO_FOLIO,CO_SERIE,CO_ID_TIPODOCTO,CO_ID_PROVEEDOR,CO_ID_ALMACEN,CO_FACTURA,CO_FECHA)
					VALUES (@CO_FOLIO,@CO_SERIE,@CO_ID_TIPODOCTO,@CO_ID_PROVEEDOR,@CO_ID_ALMACEN,@CO_FACTURA,@CO_FECHA)
				END
		END 
		--ACTUALIZAR DATOS
		
	--------------------------------------------------------------------------------------------------------------------------------------------------------
		IF @OP = 2
		 
			BEGIN 
				UPDATE COMPRAS SET CO_FOLIO = @CO_FOLIO
				WHERE CO_FOLIO = @CO_FOLIO
			END
END
