USE [RDP]
GO
/****** Object:  StoredProcedure [dbo].[lntsp_insert_Prob_sol_details]    Script Date: 12/27/2020 01:15:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- insert_student @NAME='Sona',@Gender='M',@Age=34


create PROCEDURE [dbo].[insert_student]

(
		
		
		@NAME nvarchar(50) = NULL,
		@Gender nvarchar(50) = NULL,
		@Age int = NULL
		
		

)

AS

	DECLARE @usr_name nvarchar(50) = NULL


BEGIN

					
					INSERT INTO PERSON
					(NAME,Gender,Age)
					values (@NAME,@Gender,@Age)
					
											
					
				
	
END


