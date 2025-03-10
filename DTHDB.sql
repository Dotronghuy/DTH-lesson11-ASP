USE [DTH_K22CNT1Lesson11]
GO
/****** Object:  Table [dbo].[DthUsers]    Script Date: 7/1/2024 8:39:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DthUsers](
	[DthID] [int] NOT NULL,
	[DthUsersName] [nvarchar](50) NULL,
	[DthPassword] [nvarchar](50) NULL,
	[DthFullName] [nvarchar](50) NULL,
	[DthAge] [int] NULL,
	[DthEmail] [nvarchar](50) NULL,
	[DthPhone] [nvarchar](50) NULL,
	[DthStatus] [bit] NULL,
 CONSTRAINT [PK_DthUsers] PRIMARY KEY CLUSTERED 
(
	[DthID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[DthUsers] ([DthID], [DthUsersName], [DthPassword], [DthFullName], [DthAge], [DthEmail], [DthPhone], [DthStatus]) VALUES (1, N'DOTRONGHUY', N'12345678a2', N'Đỗ Trọng Huy', 20, N'hel0babyno1234@gmail.com', N'0123465789', 1)
