USE [Forum]
GO

/****** Object:  Table [dbo].[Question]    Script Date: 14/01/2019 20:59:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Question](
	[QuestionId] [int] IDENTITY(1,1) NOT NULL,
	[QuestionTitle] [nvarchar](max) NOT NULL,
	[QuestionDetails] [nvarchar](max) NOT NULL,
	[DatePosted] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


