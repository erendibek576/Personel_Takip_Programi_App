USE [master]
GO
/****** Object:  Database [personel_takip_programı]    Script Date: 27.06.2022 17:09:00 ******/
CREATE DATABASE [personel_takip_programı]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'personel_takip_programı', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\personel_takip_programı.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'personel_takip_programı_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\personel_takip_programı_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [personel_takip_programı] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [personel_takip_programı].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [personel_takip_programı] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [personel_takip_programı] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [personel_takip_programı] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [personel_takip_programı] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [personel_takip_programı] SET ARITHABORT OFF 
GO
ALTER DATABASE [personel_takip_programı] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [personel_takip_programı] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [personel_takip_programı] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [personel_takip_programı] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [personel_takip_programı] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [personel_takip_programı] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [personel_takip_programı] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [personel_takip_programı] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [personel_takip_programı] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [personel_takip_programı] SET  DISABLE_BROKER 
GO
ALTER DATABASE [personel_takip_programı] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [personel_takip_programı] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [personel_takip_programı] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [personel_takip_programı] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [personel_takip_programı] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [personel_takip_programı] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [personel_takip_programı] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [personel_takip_programı] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [personel_takip_programı] SET  MULTI_USER 
GO
ALTER DATABASE [personel_takip_programı] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [personel_takip_programı] SET DB_CHAINING OFF 
GO
ALTER DATABASE [personel_takip_programı] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [personel_takip_programı] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [personel_takip_programı] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [personel_takip_programı] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [personel_takip_programı] SET QUERY_STORE = OFF
GO
USE [personel_takip_programı]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 27.06.2022 17:09:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[admin_id] [int] IDENTITY(1,1) NOT NULL,
	[k_adi] [nvarchar](50) NOT NULL,
	[sifre] [nvarchar](50) NOT NULL,
	[sifre_tekrar] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[admin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[k_adi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[departman]    Script Date: 27.06.2022 17:09:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[departman](
	[departman_id] [int] IDENTITY(1,1) NOT NULL,
	[departman_adi] [nvarchar](100) NOT NULL,
	[aciklama] [nchar](255) NULL,
 CONSTRAINT [PK_departman] PRIMARY KEY CLUSTERED 
(
	[departman_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__departma__DE50E69BD8743130] UNIQUE NONCLUSTERED 
(
	[departman_adi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[izin]    Script Date: 27.06.2022 17:09:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[izin](
	[izin_id] [int] IDENTITY(1,1) NOT NULL,
	[personel_id] [int] NOT NULL,
	[izin_tur] [nvarchar](50) NOT NULL,
	[izin_baslangic] [date] NOT NULL,
	[izin_bitis] [date] NOT NULL,
	[tarih] [date] NOT NULL,
	[saat] [datetime] NOT NULL,
 CONSTRAINT [PK_izin] PRIMARY KEY CLUSTERED 
(
	[izin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kidem_tazminat]    Script Date: 27.06.2022 17:09:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kidem_tazminat](
	[kidem_tazminat_id] [int] IDENTITY(1,1) NOT NULL,
	[personel_id] [int] NOT NULL,
	[is_ayrilis_tarih] [date] NOT NULL,
	[esas_gun] [nvarchar](50) NOT NULL,
	[esas_ucret] [decimal](18, 2) NOT NULL,
	[brut_tutar] [decimal](18, 2) NOT NULL,
	[damga_vergi_tutar] [decimal](18, 2) NOT NULL,
	[net_tutar] [decimal](18, 2) NOT NULL,
	[tazminat_odeme] [nvarchar](50) NULL,
	[tarih] [date] NOT NULL,
 CONSTRAINT [PK_kidem_tazminat] PRIMARY KEY CLUSTERED 
(
	[kidem_tazminat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[maas]    Script Date: 27.06.2022 17:09:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[maas](
	[maas_id] [int] IDENTITY(1,1) NOT NULL,
	[personel_id] [int] NOT NULL,
	[donem] [nvarchar](100) NOT NULL,
	[toplam_maas] [decimal](18, 2) NOT NULL,
	[tarih] [date] NOT NULL,
	[maas_odeme] [nvarchar](50) NULL,
 CONSTRAINT [PK__maas__82E06B918305B822] PRIMARY KEY CLUSTERED 
(
	[maas_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mesai]    Script Date: 27.06.2022 17:09:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mesai](
	[mesai_id] [int] IDENTITY(1,1) NOT NULL,
	[personel_id] [int] NOT NULL,
	[baslangic_saat] [nvarchar](50) NOT NULL,
	[bitis_saat] [nvarchar](50) NOT NULL,
	[mesai_saat_ucret] [decimal](18, 2) NOT NULL,
	[tutar] [decimal](18, 2) NOT NULL,
	[donem] [nvarchar](50) NULL,
	[mesai_odeme] [nvarchar](50) NULL,
	[tarih] [date] NOT NULL,
 CONSTRAINT [PK_mesai] PRIMARY KEY CLUSTERED 
(
	[mesai_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personel]    Script Date: 27.06.2022 17:09:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personel](
	[personel_id] [int] IDENTITY(1,1) NOT NULL,
	[tc_kimlik] [nvarchar](11) NOT NULL,
	[sicil_no] [nvarchar](12) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[dogum_yer] [nvarchar](50) NOT NULL,
	[dogum_tarih] [date] NOT NULL,
	[cinsiyet] [nvarchar](10) NOT NULL,
	[adres] [nvarchar](255) NOT NULL,
	[cep_telefon] [nvarchar](15) NOT NULL,
	[ev_telefon] [nvarchar](15) NULL,
	[askerlik_durum] [nvarchar](50) NOT NULL,
	[departman_id] [int] NOT NULL,
	[durum] [nvarchar](50) NOT NULL,
	[is_baslangic_tarih] [date] NOT NULL,
	[iban_no] [nvarchar](32) NOT NULL,
	[maas] [decimal](18, 2) NOT NULL,
	[yol_yardim] [decimal](18, 2) NULL,
	[yemek_yardim] [decimal](18, 2) NULL,
	[sgk_prim] [decimal](18, 2) NULL,
	[personel_resim] [nvarchar](255) NULL,
 CONSTRAINT [PK_personel] PRIMARY KEY CLUSTERED 
(
	[personel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__personel__640D426A69602D79] UNIQUE NONCLUSTERED 
(
	[cep_telefon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__personel__6EE157062B5C6577] UNIQUE NONCLUSTERED 
(
	[sicil_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__personel__73E4718F2693C65F] UNIQUE NONCLUSTERED 
(
	[tc_kimlik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__personel__A623598F6C6BBDAF] UNIQUE NONCLUSTERED 
(
	[personel_resim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__personel__AB6E6164528CC6CA] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__personel__BB5F2CA73C1304E9] UNIQUE NONCLUSTERED 
(
	[ev_telefon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__personel__D08F5C1392E9F0E9] UNIQUE NONCLUSTERED 
(
	[iban_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[kidem_tazminat] ADD  DEFAULT ('ödemesi yapılmadı') FOR [tazminat_odeme]
GO
ALTER TABLE [dbo].[maas] ADD  CONSTRAINT [DF_maas_maas_odeme]  DEFAULT (N'ödeme yapılmadı') FOR [maas_odeme]
GO
ALTER TABLE [dbo].[mesai] ADD  DEFAULT ('ödemesi yapılmadı') FOR [mesai_odeme]
GO
ALTER TABLE [dbo].[izin]  WITH CHECK ADD  CONSTRAINT [FK_izin_personel] FOREIGN KEY([personel_id])
REFERENCES [dbo].[personel] ([personel_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[izin] CHECK CONSTRAINT [FK_izin_personel]
GO
ALTER TABLE [dbo].[kidem_tazminat]  WITH CHECK ADD  CONSTRAINT [FK_kidem_tazminat_personel] FOREIGN KEY([personel_id])
REFERENCES [dbo].[personel] ([personel_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[kidem_tazminat] CHECK CONSTRAINT [FK_kidem_tazminat_personel]
GO
ALTER TABLE [dbo].[maas]  WITH CHECK ADD  CONSTRAINT [FK_maas_personel] FOREIGN KEY([personel_id])
REFERENCES [dbo].[personel] ([personel_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[maas] CHECK CONSTRAINT [FK_maas_personel]
GO
ALTER TABLE [dbo].[mesai]  WITH CHECK ADD  CONSTRAINT [FK_mesai_personel] FOREIGN KEY([personel_id])
REFERENCES [dbo].[personel] ([personel_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[mesai] CHECK CONSTRAINT [FK_mesai_personel]
GO
ALTER TABLE [dbo].[personel]  WITH CHECK ADD  CONSTRAINT [FK_personel_departman1] FOREIGN KEY([departman_id])
REFERENCES [dbo].[departman] ([departman_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[personel] CHECK CONSTRAINT [FK_personel_departman1]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'maas'
GO
USE [master]
GO
ALTER DATABASE [personel_takip_programı] SET  READ_WRITE 
GO
