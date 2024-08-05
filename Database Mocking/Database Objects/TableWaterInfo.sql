USE [WheaterDb]
GO

/****** Object:  Table [dbo].[WeatherInfo]    Script Date: 5/15/2022 10:39:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WeatherInfo](
	[Date] [datetime] NOT NULL,
	[Temperature] [int] NOT NULL,
	[Summary] [varchar](50) NOT NULL
) ON [PRIMARY]
GO


