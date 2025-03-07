USE [master]
GO

/****** Object:  Database [WheaterDb]    Script Date: 5/15/2022 10:40:43 PM ******/
CREATE DATABASE [WheaterDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WheterDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\WheterDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WheterDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\WheterDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WheaterDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [WheaterDb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [WheaterDb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [WheaterDb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [WheaterDb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [WheaterDb] SET ARITHABORT OFF 
GO

ALTER DATABASE [WheaterDb] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [WheaterDb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [WheaterDb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [WheaterDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [WheaterDb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [WheaterDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [WheaterDb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [WheaterDb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [WheaterDb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [WheaterDb] SET  DISABLE_BROKER 
GO

ALTER DATABASE [WheaterDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [WheaterDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [WheaterDb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [WheaterDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [WheaterDb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [WheaterDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [WheaterDb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [WheaterDb] SET RECOVERY FULL 
GO

ALTER DATABASE [WheaterDb] SET  MULTI_USER 
GO

ALTER DATABASE [WheaterDb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [WheaterDb] SET DB_CHAINING OFF 
GO

ALTER DATABASE [WheaterDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [WheaterDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [WheaterDb] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [WheaterDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [WheaterDb] SET QUERY_STORE = OFF
GO

ALTER DATABASE [WheaterDb] SET  READ_WRITE 
GO


