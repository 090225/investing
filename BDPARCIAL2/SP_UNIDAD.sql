alter PROCEDURE SP_UNIDAD
@OP TINYINT = 0,
@UN_ID TINYINT = 0,
@UN_DESCRIPCION VARCHAR (100) = NULL


AS 
BEGIN
	--GUARDA Y ACTUALIZA
		IF @OP = 1
		BEGIN
			SET @UN_ID=(SELECT ISNULL(MAX(UN_ID),0) + 1 FROM UNIDAD)
			IF NOT EXISTS(SELECT * FROM UNIDAD WHERE UN_ID = @UN_ID)
				BEGIN 
					INSERT INTO UNIDAD(UN_ID, UN_DESCRIPCION)
					VALUES (@UN_ID, @UN_DESCRIPCION)
				END
		END 
		--ACTUALIZAR DATOS
		
	--------------------------------------------------------------------------------------------------------------------------------------------------------
		IF @OP = 2
		 
			BEGIN 
				UPDATE UNIDAD SET UN_DESCRIPCION = @UN_DESCRIPCION
				WHERE UN_ID = @UN_ID
			END
		
END