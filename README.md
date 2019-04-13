# CSDLDPT_SQL
Lưu trữ ảnh SQL_SEVER

//sql_sever

USE [master]
GO
/****** Object:  Database [CSDLDPT]    Script Date: 10-Apr-2019 10:39:32 PM ******/
CREATE DATABASE [CSDLDPT]
USE [CSDLDPT]
GO
/****** Object:  Table [dbo].[IMG]    Script Date: 10-Apr-2019 10:39:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IMG](
	[title] [nchar](10) NOT NULL,
	[Byte] [ntext] NULL,
 CONSTRAINT [PK_IMG] PRIMARY KEY CLUSTERED 
(
	[title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [CSDLDPT] SET  READ_WRITE 
GO
