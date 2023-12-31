USE [TN]
GO
/****** Object:  Table [dbo].[CAUHOIS]    Script Date: 22/11/2023 15:51:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAUHOIS](
	[STT] [int] NOT NULL,
	[CauHoi] [nvarchar](max) NOT NULL,
	[DapAnA] [nvarchar](max) NULL,
	[DapAnB] [nvarchar](max) NULL,
	[DapAnC] [nvarchar](max) NULL,
	[DapAnD] [nvarchar](max) NULL,
	[DapAnDung] [nvarchar](10) NULL,
	[DapAnChon] [nvarchar](10) NULL,
 CONSTRAINT [PK_CAUHOIS] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[CAUHOIS] ([STT], [CauHoi], [DapAnA], [DapAnB], [DapAnC], [DapAnD], [DapAnDung], [DapAnChon]) VALUES (1, N'1 + 1 = ?', N'2', N'3', N'4', N'5', N'A', NULL)
INSERT [dbo].[CAUHOIS] ([STT], [CauHoi], [DapAnA], [DapAnB], [DapAnC], [DapAnD], [DapAnDung], [DapAnChon]) VALUES (2, N'2 + 2 = ?', N'2', N'3', N'4', N'5', N'C', NULL)
INSERT [dbo].[CAUHOIS] ([STT], [CauHoi], [DapAnA], [DapAnB], [DapAnC], [DapAnD], [DapAnDung], [DapAnChon]) VALUES (3, N'3 + 3 = ?', N'3', N'4', N'5', N'6', N'D', NULL)
