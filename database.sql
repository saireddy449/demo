USE [MvcDemo]
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 12/18/2017 21:15:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Priority] [int] NULL,
	[RemainderDate] [date] NULL,
	[EstimatedCost] [int] NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_tblEmployee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
