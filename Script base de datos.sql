USE [master]
GO
/****** Object:  Database [Agencia]    Script Date: 13/02/2024 02:17:14 p. m. ******/
CREATE DATABASE [Agencia]

GO
USE [Agencia]
CREATE TABLE [dbo].[Vehiculos](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[NumPlaca] [varchar](7) NOT NULL,
	[VIN] [varchar](17) NULL,
	[Marca] [varchar](20) NULL,
	[Serie] [varchar](17) NULL,
	[Ano] [int] NULL,
	[Color] [varchar](20) NULL,
	[CantPuertas] [int] NULL,
 CONSTRAINT [PK_Vehiculos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Agencia] SET  READ_WRITE 
GO
