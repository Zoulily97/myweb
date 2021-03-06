USE [master]
GO
/****** Object:  Database [xiaobaishopping]    Script Date: 01/05/2021 19:49:31 ******/
CREATE DATABASE [xiaobaishopping] ON  PRIMARY 
( NAME = N'xiaobaishopping', FILENAME = N'D:\大四上\xiaobaishopping\db\xiaobaishopping.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'xiaobaishopping_log', FILENAME = N'D:\大四上\xiaobaishopping\db\xiaobaishopping_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [xiaobaishopping] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [xiaobaishopping].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [xiaobaishopping] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [xiaobaishopping] SET ANSI_NULLS OFF
GO
ALTER DATABASE [xiaobaishopping] SET ANSI_PADDING OFF
GO
ALTER DATABASE [xiaobaishopping] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [xiaobaishopping] SET ARITHABORT OFF
GO
ALTER DATABASE [xiaobaishopping] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [xiaobaishopping] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [xiaobaishopping] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [xiaobaishopping] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [xiaobaishopping] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [xiaobaishopping] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [xiaobaishopping] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [xiaobaishopping] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [xiaobaishopping] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [xiaobaishopping] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [xiaobaishopping] SET  DISABLE_BROKER
GO
ALTER DATABASE [xiaobaishopping] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [xiaobaishopping] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [xiaobaishopping] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [xiaobaishopping] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [xiaobaishopping] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [xiaobaishopping] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [xiaobaishopping] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [xiaobaishopping] SET  READ_WRITE
GO
ALTER DATABASE [xiaobaishopping] SET RECOVERY FULL
GO
ALTER DATABASE [xiaobaishopping] SET  MULTI_USER
GO
ALTER DATABASE [xiaobaishopping] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [xiaobaishopping] SET DB_CHAINING OFF
GO
USE [xiaobaishopping]
GO
/****** Object:  Table [dbo].[t_user]    Script Date: 01/05/2021 19:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[adress] [varchar](200) NULL,
	[sex] [int] NULL,
	[mobile] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[qq] [varchar](50) NULL,
	[state] [int] NULL,
	[addate] [datetime] NULL,
 CONSTRAINT [PK_t_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_shopping]    Script Date: 01/05/2021 19:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_shopping](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[goodsid] [int] NULL,
	[userid] [int] NULL,
	[num] [int] NULL,
	[state] [int] NULL,
	[addate] [datetime] NULL,
	[orderid] [varchar](200) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_order]    Script Date: 01/05/2021 19:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_order](
	[id] [varchar](200) NOT NULL,
	[userid] [int] NULL,
	[amount] [int] NULL,
	[state] [int] NULL,
	[addate] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_goods]    Script Date: 01/05/2021 19:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_goods](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[price] [int] NULL,
	[num] [int] NULL,
	[img] [varchar](50) NULL,
	[detail] [text] NULL,
	[state] [int] NULL,
	[addate] [datetime] NULL,
 CONSTRAINT [PK_t_goods] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
