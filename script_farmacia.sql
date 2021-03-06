USE [master]
GO
/****** Object:  Database [Sistema de Farmacia]    Script Date: 05/03/2018 14:18:33 ******/
CREATE DATABASE [Sistema de Farmacia] ON  PRIMARY 
( NAME = N'Sistema de Farmacia', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.VALEVALERIA\MSSQL\DATA\Sistema de Farmacia.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Sistema de Farmacia_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.VALEVALERIA\MSSQL\DATA\Sistema de Farmacia_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Sistema de Farmacia] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sistema de Farmacia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sistema de Farmacia] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET ARITHABORT OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Sistema de Farmacia] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Sistema de Farmacia] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Sistema de Farmacia] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET  DISABLE_BROKER
GO
ALTER DATABASE [Sistema de Farmacia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Sistema de Farmacia] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Sistema de Farmacia] SET  READ_WRITE
GO
ALTER DATABASE [Sistema de Farmacia] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Sistema de Farmacia] SET  MULTI_USER
GO
ALTER DATABASE [Sistema de Farmacia] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Sistema de Farmacia] SET DB_CHAINING OFF
GO
USE [Sistema de Farmacia]
GO
/****** Object:  Table [dbo].[Presentacion]    Script Date: 05/03/2018 14:18:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Presentacion](
	[id_presentacion] [int] IDENTITY(1,1) NOT NULL,
	[nombre_presentacion] [varchar](50) NULL,
 CONSTRAINT [PK__Presenta__FD8B465921B6055D] PRIMARY KEY CLUSTERED 
(
	[id_presentacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 05/03/2018 14:18:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[perfil_usuario] [varchar](20) NOT NULL,
	[nombre_usuario] [varchar](30) NOT NULL,
	[contraseña_usuario] [varchar](10) NOT NULL,
 CONSTRAINT [PK__Usuario__F240E5057F60ED59] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 05/03/2018 14:18:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Localidad](
	[id_localidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre_localidad] [varchar](40) NOT NULL,
 CONSTRAINT [PK__Distrito__FE60BAEB0AD2A005] PRIMARY KEY CLUSTERED 
(
	[id_localidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [uni_distrito] UNIQUE NONCLUSTERED 
(
	[nombre_localidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 05/03/2018 14:18:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre_categoria] [varchar](40) NOT NULL,
 CONSTRAINT [PK__Categori__DAFE937C0EA330E9] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 05/03/2018 14:18:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre_cliente] [varchar](40) NOT NULL,
	[direccion_cliente] [varchar](40) NULL,
	[id_localidad] [int] NULL,
	[sexo] [varchar](10) NULL,
	[DNI] [int] NULL,
	[ruc_cliente] [int] NULL,
	[telefono_cliente] [int] NULL,
 CONSTRAINT [PK__Clientes__FEA298EE03317E3D] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [uni_dni] UNIQUE NONCLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 05/03/2018 14:18:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre_empleado] [varchar](40) NOT NULL,
	[direccion_empleado] [varchar](40) NULL,
	[id_localidad] [int] NOT NULL,
	[cargo_empleado] [varchar](40) NOT NULL,
	[edad_empleado] [varchar](2) NULL,
	[telefono_empleado] [int] NOT NULL,
	[ingreso_hora_empleado] [date] NOT NULL,
	[clave_empleado] [varchar](20) NOT NULL,
 CONSTRAINT [PK__Empleado__FE22B4FA164452B1] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 05/03/2018 14:18:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre_proveedor] [varchar](40) NOT NULL,
	[direccion_proveedor] [varchar](50) NULL,
	[telefono_proveedor] [varchar](10) NULL,
	[id_localidad] [int] NULL,
 CONSTRAINT [PK__Proveedo__B776EC0525869641] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 05/03/2018 14:18:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre_producto] [varchar](40) NOT NULL,
	[precio_venta] [decimal](10, 2) NOT NULL,
	[precio_compra] [decimal](10, 2) NOT NULL,
	[fecha_vencimiento] [date] NOT NULL,
	[stock] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
	[id_proveedor] [int] NULL,
	[id_presentacion] [int] NULL,
 CONSTRAINT [PK__Producto__FD8B46431273C1CD] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OrdenPedido]    Script Date: 05/03/2018 14:18:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OrdenPedido](
	[id_orden_pedido] [int] IDENTITY(1,1) NOT NULL,
	[fecha_pedido] [date] NOT NULL,
	[id_cliente] [int] NULL,
	[nombre_cliente] [varchar](40) NULL,
	[id_empleado] [int] NULL,
	[tipo_pago] [varchar](40) NULL,
	[total] [int] NULL,
 CONSTRAINT [PK__OrdenPed__AFA7189207020F21] PRIMARY KEY CLUSTERED 
(
	[id_orden_pedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetalleOrdenPedido]    Script Date: 05/03/2018 14:18:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleOrdenPedido](
	[id_detalle_orden_pedido] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NOT NULL,
	[nombre_producto] [varchar](40) NOT NULL,
	[cantidad] [decimal](10, 2) NULL,
	[precio_venta] [decimal](10, 2) NULL,
	[importe] [decimal](10, 2) NULL,
 CONSTRAINT [PK__DetalleO__64FA54371A14E395] PRIMARY KEY CLUSTERED 
(
	[id_detalle_orden_pedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Boleta]    Script Date: 05/03/2018 14:18:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boleta](
	[id_boleta] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_orden_pedido] [int] NOT NULL,
	[subtotal] [decimal](18, 2) NOT NULL,
	[descuento] [decimal](18, 2) NULL,
	[total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK__Boleta__5F58F55D1DE57479] PRIMARY KEY CLUSTERED 
(
	[id_boleta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Check [CK_DNI]    Script Date: 05/03/2018 14:18:37 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [CK_DNI] CHECK  ((len([dni])=(8)))
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [CK_DNI]
GO
/****** Object:  Check [CK_SEXO]    Script Date: 05/03/2018 14:18:37 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [CK_SEXO] CHECK  (([SEXO]='F' OR [SEXO]='M'))
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [CK_SEXO]
GO
/****** Object:  ForeignKey [FK_Clientes_Localidad]    Script Date: 05/03/2018 14:18:37 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id_localidad])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Localidad]
GO
/****** Object:  ForeignKey [FK_Empleado_Localidad]    Script Date: 05/03/2018 14:18:37 ******/
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id_localidad])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Localidad]
GO
/****** Object:  ForeignKey [FK_Proveedor_Localidad]    Script Date: 05/03/2018 14:18:37 ******/
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id_localidad])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_Proveedor_Localidad]
GO
/****** Object:  ForeignKey [FK_Producto_Categoria]    Script Date: 05/03/2018 14:18:37 ******/
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
/****** Object:  ForeignKey [FK_Producto_Presentacion]    Script Date: 05/03/2018 14:18:37 ******/
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Presentacion] FOREIGN KEY([id_presentacion])
REFERENCES [dbo].[Presentacion] ([id_presentacion])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Presentacion]
GO
/****** Object:  ForeignKey [FK_Producto_Proveedor]    Script Date: 05/03/2018 14:18:37 ******/
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[Proveedor] ([id_proveedor])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Proveedor]
GO
/****** Object:  ForeignKey [FK_OrdenPedido_Clientes]    Script Date: 05/03/2018 14:18:37 ******/
ALTER TABLE [dbo].[OrdenPedido]  WITH CHECK ADD  CONSTRAINT [FK_OrdenPedido_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[OrdenPedido] CHECK CONSTRAINT [FK_OrdenPedido_Clientes]
GO
/****** Object:  ForeignKey [FK_OrdenPedido_Empleado]    Script Date: 05/03/2018 14:18:37 ******/
ALTER TABLE [dbo].[OrdenPedido]  WITH CHECK ADD  CONSTRAINT [FK_OrdenPedido_Empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[OrdenPedido] CHECK CONSTRAINT [FK_OrdenPedido_Empleado]
GO
/****** Object:  ForeignKey [FK_DetalleOrdenPedido_Producto]    Script Date: 05/03/2018 14:18:37 ******/
ALTER TABLE [dbo].[DetalleOrdenPedido]  WITH CHECK ADD  CONSTRAINT [FK_DetalleOrdenPedido_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[DetalleOrdenPedido] CHECK CONSTRAINT [FK_DetalleOrdenPedido_Producto]
GO
/****** Object:  ForeignKey [FK_Boleta_OrdenPedido]    Script Date: 05/03/2018 14:18:37 ******/
ALTER TABLE [dbo].[Boleta]  WITH CHECK ADD  CONSTRAINT [FK_Boleta_OrdenPedido] FOREIGN KEY([id_orden_pedido])
REFERENCES [dbo].[OrdenPedido] ([id_orden_pedido])
GO
ALTER TABLE [dbo].[Boleta] CHECK CONSTRAINT [FK_Boleta_OrdenPedido]
GO
