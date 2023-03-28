alter PROCEDURE SP_ALMACENES 
@OP TINYINT = 0,
@AL_ID TINYINT = 0,
@AL_NOMBRE VARCHAR (50) = NULL

AS 
BEGIN
	--GUARDA Y ACTUALIZA
		IF @OP = 1
		BEGIN
			SET @AL_ID=(SELECT ISNULL(MAX(AL_ID),0) + 1 FROM ALMACENES)
			IF NOT EXISTS(SELECT * FROM ALMACENES WHERE AL_ID = @AL_ID)
				BEGIN 
					INSERT INTO ALMACENES(AL_ID,AL_NOMBRE)
					VALUES (@AL_ID, @AL_NOMBRE)
				END
		END 
		--ACTUALIZAR DATOS
		
	--------------------------------------------------------------------------------------------------------------------------------------------------------
		IF @OP = 2
		BEGIN 
			--ELIMINA DATOS EN ESPECIFICO
			DELETE FROM ALMACENES WHERE AL_ID = @AL_ID
		END

		if @OP = 3
			BEGIN 
				UPDATE ALMACENES SET AL_NOMBRE = @AL_NOMBRE
				WHERE AL_ID = @AL_ID
			END
END