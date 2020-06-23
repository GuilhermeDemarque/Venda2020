USE [master]
GO
/****** Object:  Database [VENDAS2020]    Script Date: 22/06/2020 20:26:28 ******/
CREATE DATABASE [VENDAS2020]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VENDAS2020', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\VENDAS2020.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VENDAS2020_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\VENDAS2020_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [VENDAS2020] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VENDAS2020].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VENDAS2020] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VENDAS2020] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VENDAS2020] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VENDAS2020] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VENDAS2020] SET ARITHABORT OFF 
GO
ALTER DATABASE [VENDAS2020] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VENDAS2020] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VENDAS2020] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VENDAS2020] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VENDAS2020] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VENDAS2020] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VENDAS2020] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VENDAS2020] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VENDAS2020] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VENDAS2020] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VENDAS2020] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VENDAS2020] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VENDAS2020] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VENDAS2020] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VENDAS2020] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VENDAS2020] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VENDAS2020] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VENDAS2020] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VENDAS2020] SET  MULTI_USER 
GO
ALTER DATABASE [VENDAS2020] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VENDAS2020] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VENDAS2020] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VENDAS2020] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VENDAS2020] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VENDAS2020] SET QUERY_STORE = OFF
GO
USE [VENDAS2020]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 22/06/2020 20:26:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cpf] [varchar](14) NULL,
	[celular] [varchar](50) NULL,
	[municipio] [varchar](40) NULL,
	[endereco] [varchar](30) NULL,
	[cep] [varchar](8) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 22/06/2020 20:26:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[codcompra] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [int] NULL,
	[fornecedor] [varchar](50) NULL,
 CONSTRAINT [PK_Venda] PRIMARY KEY CLUSTERED 
(
	[codcompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedores]    Script Date: 22/06/2020 20:26:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedores](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NULL,
	[cnpj] [varchar](50) NULL,
	[telefone] [varchar](50) NULL,
 CONSTRAINT [PK_Fornecedores] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Itens]    Script Date: 22/06/2020 20:26:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Itens](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[produtoid] [int] NULL,
	[produto] [varchar](50) NULL,
 CONSTRAINT [PK_Itens] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produtos]    Script Date: 22/06/2020 20:26:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos](
	[codproduto] [int] IDENTITY(1,1) NOT NULL,
	[nomeproduto] [varchar](50) NOT NULL,
	[quantidade] [int] NULL,
	[precocusto] [float] NULL,
	[precovenda] [float] NULL,
 CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED 
(
	[codproduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([codigo], [nome], [cpf], [celular], [municipio], [endereco], [cep]) VALUES (1, N'Joao', N'1458          ', N'99721555    ', N'Assis', N'diones', N'1987520')
INSERT [dbo].[Clientes] ([codigo], [nome], [cpf], [celular], [municipio], [endereco], [cep]) VALUES (2, N'Alex', N'5789965', N'9975588', N'Sao Paulo ', N'Av Paulista', N'1515')
INSERT [dbo].[Clientes] ([codigo], [nome], [cpf], [celular], [municipio], [endereco], [cep]) VALUES (3, N'toni', N'15488         ', N'852445      ', N'palmital', N'sdfsdf', N'145987')
INSERT [dbo].[Clientes] ([codigo], [nome], [cpf], [celular], [municipio], [endereco], [cep]) VALUES (6, N'sergio', N'1414', N'1414', N'barcelona', N'camp nou', N'8989')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Compra] ON 

INSERT [dbo].[Compra] ([codcompra], [codigo], [fornecedor]) VALUES (2, 2, N'joaozin')
INSERT [dbo].[Compra] ([codcompra], [codigo], [fornecedor]) VALUES (3, 2, N'apple')
INSERT [dbo].[Compra] ([codcompra], [codigo], [fornecedor]) VALUES (4, 1, N'baseus')
INSERT [dbo].[Compra] ([codcompra], [codigo], [fornecedor]) VALUES (5, 2, N'apple')
INSERT [dbo].[Compra] ([codcompra], [codigo], [fornecedor]) VALUES (6, 2, N'apple')
SET IDENTITY_INSERT [dbo].[Compra] OFF
GO
SET IDENTITY_INSERT [dbo].[Fornecedores] ON 

INSERT [dbo].[Fornecedores] ([codigo], [nome], [cnpj], [telefone]) VALUES (1, N'baseus', N'1111', N'2222')
INSERT [dbo].[Fornecedores] ([codigo], [nome], [cnpj], [telefone]) VALUES (2, N'apple', N'89752941      ', N'57289       ')
INSERT [dbo].[Fornecedores] ([codigo], [nome], [cnpj], [telefone]) VALUES (4, N'elma chips', N'89885455', N'12424')
INSERT [dbo].[Fornecedores] ([codigo], [nome], [cnpj], [telefone]) VALUES (5, N'Samsung', N'987456', N'997895454')
SET IDENTITY_INSERT [dbo].[Fornecedores] OFF
GO
SET IDENTITY_INSERT [dbo].[Produtos] ON 

INSERT [dbo].[Produtos] ([codproduto], [nomeproduto], [quantidade], [precocusto], [precovenda]) VALUES (1, N'coca', 3, 5, 10)
INSERT [dbo].[Produtos] ([codproduto], [nomeproduto], [quantidade], [precocusto], [precovenda]) VALUES (3, N'spri', 5, 5, 5)
INSERT [dbo].[Produtos] ([codproduto], [nomeproduto], [quantidade], [precocusto], [precovenda]) VALUES (4, N'fanta', 10, 20, 20)
INSERT [dbo].[Produtos] ([codproduto], [nomeproduto], [quantidade], [precocusto], [precovenda]) VALUES (5, N'tota', 1, 1, 1)
INSERT [dbo].[Produtos] ([codproduto], [nomeproduto], [quantidade], [precocusto], [precovenda]) VALUES (6, N'w', 1, 1, 1)
INSERT [dbo].[Produtos] ([codproduto], [nomeproduto], [quantidade], [precocusto], [precovenda]) VALUES (7, N'g', 2, 2, 2)
INSERT [dbo].[Produtos] ([codproduto], [nomeproduto], [quantidade], [precocusto], [precovenda]) VALUES (8, N'S10', 5, 1000, 2500)
SET IDENTITY_INSERT [dbo].[Produtos] OFF
GO
USE [master]
GO
ALTER DATABASE [VENDAS2020] SET  READ_WRITE 
GO
