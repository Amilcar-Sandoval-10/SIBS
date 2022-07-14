Create Database Gonper
USE [Gonper]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 07/09/2019 19:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Codigo]  AS ('E'+right('000'+CONVERT([varchar],[ID]),(3))),
	[Nombrecat] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 07/09/2019 19:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Codigo]  AS ('A'+right('0000'+CONVERT([varchar],[Id_Cliente]),(4))),
	[Nombre] [nvarchar](30) NOT NULL,
	[Apellidos] [nvarchar](30) NOT NULL,
	[Cedula] [nchar](16) NULL,
	[FechaNac] [nvarchar](15) NOT NULL,
	[Genero] [char](1) NULL,
	[Direccion] [nvarchar](max) NULL,
	[Telefono] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 07/09/2019 19:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[CodEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Codigo]  AS ('B'+right('0000'+CONVERT([varchar],[CodEmpleado]),(4))),
	[Nombre] [nvarchar](30) NOT NULL,
	[Apellidos] [nvarchar](30) NOT NULL,
	[INSS] [nvarchar](12) NULL,
	[FechaNac] [nvarchar](15) NOT NULL,
	[Genero] [char](1) NULL,
	[Direccion] [nvarchar](max) NULL,
	[Telefono] [nvarchar](15) NULL,
	[EstadoCivil] [nvarchar](12) NOT NULL,
	[Email] [nvarchar](80) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURA]    Script Date: 07/09/2019 19:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA](
	[Id_Factura] [int] IDENTITY(1,1) NOT NULL,
	[Codigo]  AS ('J'+right('0000'+CONVERT([varchar],[Id_Factura]),(4))),
	[Id_Cliente] [int] NULL,
	[Cod_Productos] [int] NULL,
	[CodEmpleado] [int] NULL,
	[ID] [int] NULL,
	[Cod_Inventario] [int] NULL,
	[Fecha] [nvarchar](15) NOT NULL,
	[FormaPago] [nvarchar](10) NULL,
	[Cantidad] [int] NOT NULL,
	[Subtotal] [float] NOT NULL,
	[IVA] [float] NOT NULL,
	[Descuento] [float] NULL,
	[Total] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura_Compras]    Script Date: 07/09/2019 19:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura_Compras](
	[ID_Compras] [int] IDENTITY(1,1) NOT NULL,
	[Codigo]  AS ('H'+right('0000'+CONVERT([varchar],[ID_Compras]),(4))),
	[Cod_Proveedor] [int] NOT NULL,
	[Cod_Productos] [int] NOT NULL,
	[Cod_Inventario] [int] NOT NULL,
	[ID] [int] NOT NULL,
	[FechaCompra] [nvarchar](15) NULL,
	[Telefono] [int] NULL,
	[FormaPago] [nvarchar](20) NULL,
	[Cantidad] [int] NOT NULL,
	[Subtotal] [float] NOT NULL,
	[IVA] [float] NOT NULL,
	[Descuento] [float] NULL,
	[Total] [float] NOT NULL,
 CONSTRAINT [PK__Factura___B82691E8D142AE57] PRIMARY KEY CLUSTERED 
(
	[ID_Compras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historial_de_Empleados]    Script Date: 07/09/2019 19:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial_de_Empleados](
	[CodHistorial] [int] IDENTITY(1,1) NOT NULL,
	[Codigo]  AS ('C'+right('0000'+CONVERT([varchar],[CodEmpleado]),(4))),
	[CodEmpleado] [int] NULL,
	[Cargo] [nvarchar](20) NOT NULL,
	[Antiguedad] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodHistorial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 07/09/2019 19:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventario](
	[Cod_Inventario] [int] IDENTITY(1,1) NOT NULL,
	[Codigo]  AS ('G'+right('0000'+CONVERT([varchar],[Cod_Inventario]),(4))),
	[ID] [int] NOT NULL,
	[Fecha_Entrada] [nvarchar](15) NULL,
	[StockMaximo] [int] NULL,
	[StockMinimo] [int] NULL,
	[StockActual] [int] NULL,
	[Garantia] [nvarchar](20) NULL,
	[Cod_Productos] [int] NULL,
 CONSTRAINT [PK__Inventar__97B2D7CD55E7A288] PRIMARY KEY CLUSTERED 
(
	[Cod_Inventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 07/09/2019 19:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Cod_Productos] [int] IDENTITY(1,1) NOT NULL,
	[Codigo]  AS ('F'+right('0000'+CONVERT([varchar],[Cod_Productos]),(4))),
	[NombreProducto] [nvarchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
	[Fecha_Expiracion] [nvarchar](15) NOT NULL,
	[ID] [int] NOT NULL,
	[Descuento] [float] NULL,
 CONSTRAINT [PK__Producto__3BFF3DCBF87DA1B9] PRIMARY KEY CLUSTERED 
(
	[Cod_Productos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 07/09/2019 19:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[Cod_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Codigo]  AS ('D'+right('0000'+CONVERT([varchar],[Cod_Proveedor]),(4))),
	[Nombre] [nvarchar](30) NULL,
	[ID] [int] NOT NULL,
	[Telefono] [nvarchar](15) NULL,
	[Direccion] [nvarchar](max) NULL,
	[Email] [nvarchar](80) NULL,
 CONSTRAINT [PK__Proveedo__F7D7424E875FFDAC] PRIMARY KEY CLUSTERED 
(
	[Cod_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 07/09/2019 19:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](20) NOT NULL,
	[Contraseña] [nvarchar](20) NOT NULL,
	[Tipo_Usuario] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 
GO
INSERT [dbo].[Categoria] ([ID], [Nombrecat]) VALUES (12, N'Escolar y Oficina')
GO
INSERT [dbo].[Categoria] ([ID], [Nombrecat]) VALUES (13, N'Manualidades')
GO
INSERT [dbo].[Categoria] ([ID], [Nombrecat]) VALUES (14, N'Papeleria')
GO
INSERT [dbo].[Categoria] ([ID], [Nombrecat]) VALUES (15, N'Tecnologia')
GO
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (1, N'Mario Esteban', N'Herrera Solis', N'001-060589-0003A', N'1989-05-07', N'M', N'Del hospital salud integral, dos cuadras arriba', N'89675420')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (2, N'Elizabeth Fernanda', N'Estrada Campos', N'004-071189-1017U', N'1989-11-07', N'F', N'Carretera a Montelimar, km 35', N'78654369')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (3, N'Adrian Ernesto', N'Lira', N'006-300193-0000K', N'1993-01-30', N'M', N'Parque las madres, 3 metros al norte', N'54678933')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (4, N'Mauicio de Jesus', N'Calderon Gonzalez', N'005-030398-1000P', N'1998-03-03', N'M', N'Catedral de Managua, 150 varas arriba', N'77652036')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (5, N'Martin', N'Cuadra', N'001-060684-1010L', N'1984-06-06', N'M', N'Metrocentro, 3 metros al norte', N'89674411')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (6, N'Karla Isabel', N'Hernadez Perez', N'002-110998-0000M', N'1998-09-11', N'F', N'Dos cuadras de Empresa SuKarne', N'76789033')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (7, N'Rosa Fernanda', N'Castro', N'007-100893-1014L', N'1993-08-10', N'F', N'Masaya', N'77651098')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (8, N'Miriam del Socorro', N'Pineda Hernandez', N'001-090987-0013Y', N'1987-09-09', N'F', N'Del Zumen, dos cuadras abajo', N'54328766')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (9, N'Daniel', N'Jimenez Rocha', N'004-130299-0100L', N'1999-02-13', N'M', N'Km 17 carretera vieja a Leon', N'86437740')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (10, N'Cristhiam Gabriel', N'Miranda Ruiz', N'002-161296-1012H', N'1996-12-16', N'M', N'Colegio Calazan, 30 metros al norte', N'22786532')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (11, N'Erika Gimena', N'Blandon Vega', N'005-290491-0034D', N'1991-04-29', N'F', N'Centro Cristhiano Los Andes, 150 varas al norte', N'76558710')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (12, N'Marcos Joel', N'Perez Gomez', N'004-090385-0000M', N'1985-03-09', N'M', N'Iglesia del Carmen, 30 metros al este', N'88832967')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (13, N'Ana Maria', N'Fernandez', N'003-141091-0210L', N'1991-10-14', N'F', N'Masaya', N'76431905')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (14, N'Juan Gabriel', N'Lara Tellez', N'005-301087-1012T', N'1987-10-30', N'M', N'Del ministerio cuadra y media al lago', N'54320987')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (15, N'Adrian', N'Lopez', N'001-220995-1010L', N'1995-09-22', N'M', N'Clinica el Samaritano, 30 cuadras al este', N'85217798')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (16, N'Brenda', N'Vanegas', N'007-210999-1010L', N'1999-09-21', N'F', N'Carretera sur km 8 1/2, frente a los Tanques de Enacal', N'84785622')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (17, N'Eliecer', N'Trillos', N'004-020297-1010L', N'1997-02-02', N'M', N'Centro Periférico, Gasolinera Puma Salvadorita ½ c abajo, Módulo ', N'82547862')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (18, N'Martha', N'Ramirez', N'006-080695-1010L', N'1995-06-08', N'F', N'Mercado Mayoreo Bodega # 7, Módulo # 6 ', N'78456522')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (19, N'Ivette', N'Medina', N'006-050298-1010L', N'1998-02-05', N'F', N'Barrio Monseñor Lezcano, antiguo Banco Popular 20vrs.abajo', N'22557575')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (20, N'Yadira', N'Vasquez', N'006-120499-1010L', N'1999-04-12', N'F', N'Rotonda Periodista 300 mtrs al norte, Edificio Centro, Torre 2, Oficina ', N'22703271')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellidos], [Cedula], [FechaNac], [Genero], [Direccion], [Telefono]) VALUES (22, N'Kenneth', N'López', N'001-160100-1021T', N'2000-01-16', N'M', N'Managua', N'85785687')
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 
GO
INSERT [dbo].[Empleados] ([CodEmpleado], [Nombre], [Apellidos], [INSS], [FechaNac], [Genero], [Direccion], [Telefono], [EstadoCivil], [Email]) VALUES (1, N'Ramiro Daniel', N'Lopez Perez', N'401215-3', N'1985-05-03', N'M', N'Ciudad Sandino Frente al Mercadito', N'87761267', N'Soltero', N'lperezdaniel@gmail.com')
GO
INSERT [dbo].[Empleados] ([CodEmpleado], [Nombre], [Apellidos], [INSS], [FechaNac], [Genero], [Direccion], [Telefono], [EstadoCivil], [Email]) VALUES (2, N'Ramiro Daniel', N'Lopez Perez', N'401215-3', N'1985-05-03', N'M', N'Ciudad Sandino, Frente al Mercadito', N'87761267', N'Soltero', N'lperezdaniel@gmail.com')
GO
INSERT [dbo].[Empleados] ([CodEmpleado], [Nombre], [Apellidos], [INSS], [FechaNac], [Genero], [Direccion], [Telefono], [EstadoCivil], [Email]) VALUES (3, N'Cecilia Isabel', N'Herrera Sanchez', N'981230-7', N'1983-11-07', N'F', N'Dos cuadras de Hospital Militar', N'75342290', N'Casado', N'ceciliaherrera@gmail.com')
GO
INSERT [dbo].[Empleados] ([CodEmpleado], [Nombre], [Apellidos], [INSS], [FechaNac], [Genero], [Direccion], [Telefono], [EstadoCivil], [Email]) VALUES (4, N'Osvaldo', N'Duarte Castro', N'871310-12', N'1990-08-12', N'M', N'MERCONICA, dos cuadras al este, media cuadra al lago', N'76451198', N'Casado', N'dcastrosvaldo@hotmail.com')
GO
INSERT [dbo].[Empleados] ([CodEmpleado], [Nombre], [Apellidos], [INSS], [FechaNac], [Genero], [Direccion], [Telefono], [EstadoCivil], [Email]) VALUES (5, N'William Damian', N'Cuadra Vega', N'801230-9', N'1983-11-09', N'M', N'Masaya', N'88235631', N'Soltero', N'wdamianvega@gmail.com')
GO
INSERT [dbo].[Empleados] ([CodEmpleado], [Nombre], [Apellidos], [INSS], [FechaNac], [Genero], [Direccion], [Telefono], [EstadoCivil], [Email]) VALUES (6, N'Sandra Victoria', N'Fonseca', N'934510-2', N'1991-02-02', N'F', N'Carrera Montelimar, frente a escuela San Jeronimo', N'76239910', N'Soltera', N'sandravictoria@gmail.com')
GO
INSERT [dbo].[Empleados] ([CodEmpleado], [Nombre], [Apellidos], [INSS], [FechaNac], [Genero], [Direccion], [Telefono], [EstadoCivil], [Email]) VALUES (7, N'Lucia Yamileth', N'Rosales', N'400319-4', N'1987-10-04', N'F', N'Frente a Iglesia Bautista Nadayosis', N'22349708', N'Casada', N'yamirosales@hotmail.com')
GO
INSERT [dbo].[Empleados] ([CodEmpleado], [Nombre], [Apellidos], [INSS], [FechaNac], [Genero], [Direccion], [Telefono], [EstadoCivil], [Email]) VALUES (8, N'Fernando', N'Duartes', N'301043-1', N'1979-09-09', N'M', N'Plaza España dos cuadras al lago', N'55349876', N'Casado', N'fernandoduartes@gmail.com')
GO
INSERT [dbo].[Empleados] ([CodEmpleado], [Nombre], [Apellidos], [INSS], [FechaNac], [Genero], [Direccion], [Telefono], [EstadoCivil], [Email]) VALUES (9, N'Sadia Jahoska', N'Vega Mendoza', N'501321-6', N'1982-04-06', N'F', N'Catedral de Leon,150 varas al norte', N'88713487', N'Soltera', N'jahoskavegamendoza@gmail.com')
GO
INSERT [dbo].[Empleados] ([CodEmpleado], [Nombre], [Apellidos], [INSS], [FechaNac], [Genero], [Direccion], [Telefono], [EstadoCivil], [Email]) VALUES (10, N'Ervin Jose', N'Calero Gomez', N'40047-2', N'1989-11-24', N'M', N'Nagarote', N'59872345', N'Soltero', N'caleroervinjose@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[FACTURA] ON 
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (1, 1, 4, 1, 14, NULL, N'2019/04/05', N'Efectivo', 2, 166, 24.9, 10, 180.9)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (4, 3, 1, 4, 12, NULL, N'2019/02/05', N'Credito', 5, 90, 13.5, 0, 103.5)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (5, 2, 3, 6, 13, NULL, N'2019/03/05', N'Efectivo', 10, 310, 46.5, 6, 350.5)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (6, 9, 1, 3, 12, NULL, N'2019/03/09', N'Efectivo', 6, 498, 74.7, 0, 562.7)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (7, 1, 1, 5, 12, NULL, N'2019/03/09', N'Efectivo', 1, 18, 2.7, 0, 20.7)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (8, 9, 6, 4, 12, NULL, N'    /  /', N'Efectivo', 2, 56, 8.4, 5, 59.4)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (9, 1, 2, 1, 12, NULL, N'    /  /', N'Efectivo', 1, 144, 21.6, 10, 155.6)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (10, 1, 4, 1, 14, NULL, N'    /  /', N'Efectivo', 2, 166, 24.9, 10, 180.9)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (11, 1, 4, 1, 14, NULL, N'    /  /', N'Efectivo', 2, 166, 24.9, 10, 180.9)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (12, 3, 4, 1, 14, NULL, N'2019/05/06', N'Efectivo', 2, 166, 24.9, 10, 180.9)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (13, 1, 4, 1, 14, NULL, N'2019/05/06', N'Efectivo', 2, 166, 24.9, 10, 180.9)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (14, 1, 4, 1, 14, NULL, N'2019/06/03', N'Efectivo', 2, 166, 24.9, 10, 180.9)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (15, 1, 5, 7, 15, NULL, N'    /  /', N'Efectivo', 2, 126, 18.9, 5, 139.9)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (16, 1, 2, 1, 12, NULL, N'    /  /', N'Efectivo', 2, 288, 43.2, 10, 321.2)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (17, 2, 4, 1, 14, NULL, N'    /  /', N'Efectivo', 2, 166, 24.9, 10, 180.9)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (18, 1, 4, 10, 14, 1, N'2019/02/08', N'Efectivo', 3, 249, 37.35, 10, 276.35)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (19, 2, 4, 3, 14, 1, N'2019/08/09', N'Efectivo', 5, 415, 62.25, 10, 467.25)
GO
INSERT [dbo].[FACTURA] ([Id_Factura], [Id_Cliente], [Cod_Productos], [CodEmpleado], [ID], [Cod_Inventario], [Fecha], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (20, 1, 4, 1, 14, 1, N'    /  /', N'Efectivo', 2, 166, 24.9, 10, 180.9)
GO
SET IDENTITY_INSERT [dbo].[FACTURA] OFF
GO
SET IDENTITY_INSERT [dbo].[Factura_Compras] ON 
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (3, 1, 4, 1, 14, N'2019/04/05', 0, N'Efectivo', 2, 166, 24.9, 10, 180.9)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (4, 4, 5, 6, 15, N'2019/04/05', 0, N'Efectivo', 10, 630, 94.5, 5, 719.5)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (5, 3, 1, 2, 12, N'2019/02/05', 0, N'Credito', 2, 36, 5.4, 0, 41.4)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (6, 5, 4, 5, 14, N'2019/04/02', 0, N'Efectivo', 2, 166, 24.9, 10, 180.9)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (7, 3, 4, 5, 14, N'2019/02/06', 0, N'Efectivo', 2, 166, 24.9, 10, 180.9)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (8, 4, 3, 4, 13, N'2019/03/09', 0, N'Efectivo', 3, 93, 13.95, 6, 100.95)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (9, 1, 4, 1, 14, N'2019/03/09', 0, N'Efectivo', 2, 166, 24.9, 10, 180.9)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (10, 5, 1, 2, 12, N'    /  /', 0, N'Efectivo', 2, 36, 5.4, 0, 41.4)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (11, 1, 4, 1, 14, N'2019/05/06', 0, N'Efectivo', 2, 166, 24.9, 10, 180.9)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (22, 1, 2, 2, 12, N'', 0, N'Efectivo', 2, 36, 5, 0, 41)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (23, 1, 4, 1, 14, N'2019/06/09', 0, N'Efectivo', 10, 830, 124.5, 10, 944.5)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (24, 6, 5, 6, 15, N'2019/05/20', 0, N'Efectivo', 10, 630, 94.5, 5, 719.5)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (25, 6, 5, 6, 15, N'2019/04/09', 0, N'Efectivo', 10, 630, 94.5, 5, 719.5)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (26, 1, 2, 2, 12, N'', 0, N'Efectivo', 2, 36, 5, 0, 41)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (27, 3, 2, 2, 12, N'', 0, N'Efectivo', 2, 36, 5, 0, 41)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (28, 20, 6, 7, 12, N'2019/03/25', 0, N'Efectivo', 2, 56, 8.4, 5, 59.4)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (29, 3, 1, 2, 12, N'2019/05/09', 0, N'Efectivo', 3, 54, 8.1, 0, 62.1)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (30, 3, 1, 2, 12, N'2019/09/08', 0, N'Efectivo', 5, 90, 13.5, 0, 103.5)
GO
INSERT [dbo].[Factura_Compras] ([ID_Compras], [Cod_Proveedor], [Cod_Productos], [Cod_Inventario], [ID], [FechaCompra], [Telefono], [FormaPago], [Cantidad], [Subtotal], [IVA], [Descuento], [Total]) VALUES (31, 1, 1, 2, 12, N'    /  /', 0, N'Efectivo', 5, 90, 13.5, 0, 103.5)
GO
SET IDENTITY_INSERT [dbo].[Factura_Compras] OFF
GO
SET IDENTITY_INSERT [dbo].[Historial_de_Empleados] ON 
GO
INSERT [dbo].[Historial_de_Empleados] ([CodHistorial], [CodEmpleado], [Cargo], [Antiguedad]) VALUES (1, NULL, N'Administrador', N'5 años')
GO
INSERT [dbo].[Historial_de_Empleados] ([CodHistorial], [CodEmpleado], [Cargo], [Antiguedad]) VALUES (2, NULL, N'Gerente', N'4 años')
GO
INSERT [dbo].[Historial_de_Empleados] ([CodHistorial], [CodEmpleado], [Cargo], [Antiguedad]) VALUES (3, NULL, N'Ventas', N'3 años')
GO
INSERT [dbo].[Historial_de_Empleados] ([CodHistorial], [CodEmpleado], [Cargo], [Antiguedad]) VALUES (4, NULL, N'Ventas', N'3 años')
GO
INSERT [dbo].[Historial_de_Empleados] ([CodHistorial], [CodEmpleado], [Cargo], [Antiguedad]) VALUES (5, NULL, N'Ventas', N'3 años')
GO
INSERT [dbo].[Historial_de_Empleados] ([CodHistorial], [CodEmpleado], [Cargo], [Antiguedad]) VALUES (6, NULL, N'Ventas', N'3 años')
GO
INSERT [dbo].[Historial_de_Empleados] ([CodHistorial], [CodEmpleado], [Cargo], [Antiguedad]) VALUES (7, NULL, N'Bodega', N'3 años')
GO
INSERT [dbo].[Historial_de_Empleados] ([CodHistorial], [CodEmpleado], [Cargo], [Antiguedad]) VALUES (8, NULL, N'Bodega', N'3 años')
GO
INSERT [dbo].[Historial_de_Empleados] ([CodHistorial], [CodEmpleado], [Cargo], [Antiguedad]) VALUES (9, NULL, N'Compras', N'3 años')
GO
INSERT [dbo].[Historial_de_Empleados] ([CodHistorial], [CodEmpleado], [Cargo], [Antiguedad]) VALUES (10, NULL, N'Compras', N'3 años')
GO
SET IDENTITY_INSERT [dbo].[Historial_de_Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Inventario] ON 
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (1, 14, N'2019/02/05', 100, 10, 20, N'Si', 4)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (2, 12, N'2019/02/05', 80, 10, 40, N'No', 1)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (3, 12, N'2019/02/05', 90, 15, 27, N'Si', 2)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (4, 13, N'2019/02/05', 100, 60, 27, N'Si', 3)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (5, 14, N'2019/02/05', 120, 10, 27, N'No', 4)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (6, 15, N'2019/02/05', 50, 5, 27, N'Si', 5)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (7, 12, N'2019/02/05', 100, 20, 27, N'No', 6)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (8, 15, N'2019/02/05', 50, 5, 27, N'Si', 7)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (9, 12, N'2019/02/05', 50, 10, 27, N'No', 8)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (10, 15, N'2019/02/05', 100, 10, 27, N'Si', 9)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (11, 13, N'2019/02/05', 50, 5, 27, N'No', 10)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (12, 13, N'2019/02/05', 50, 10, 33, N'No', 12)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (13, 14, N'2019/02/05', 100, 10, 27, N'No', 13)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (14, 15, N'2019/05/06', 100, 10, 34, N'Si', 7)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (17, 12, N'2019/03/04', 100, 5, 27, N'No', 8)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (18, 14, N'2019/04/09', 200, 50, 27, N'No', 4)
GO
INSERT [dbo].[Inventario] ([Cod_Inventario], [ID], [Fecha_Entrada], [StockMaximo], [StockMinimo], [StockActual], [Garantia], [Cod_Productos]) VALUES (19, 15, N'2019/03/09', 100, 30, 27, N'Si', 9)
GO
SET IDENTITY_INSERT [dbo].[Inventario] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 
GO
INSERT [dbo].[Productos] ([Cod_Productos], [NombreProducto], [Precio], [Fecha_Expiracion], [ID], [Descuento]) VALUES (1, N'Lapiceros', 18, N'2019-03-28', 12, 0)
GO
INSERT [dbo].[Productos] ([Cod_Productos], [NombreProducto], [Precio], [Fecha_Expiracion], [ID], [Descuento]) VALUES (2, N'Marcadores', 144, N'2019-04-01', 12, 10)
GO
INSERT [dbo].[Productos] ([Cod_Productos], [NombreProducto], [Precio], [Fecha_Expiracion], [ID], [Descuento]) VALUES (3, N'Foamy', 31, N'2019-05-02', 13, 6)
GO
INSERT [dbo].[Productos] ([Cod_Productos], [NombreProducto], [Precio], [Fecha_Expiracion], [ID], [Descuento]) VALUES (4, N'Papel Bond', 83, N'2019-05-10', 14, 10)
GO
INSERT [dbo].[Productos] ([Cod_Productos], [NombreProducto], [Precio], [Fecha_Expiracion], [ID], [Descuento]) VALUES (5, N'Audifonos', 63, N'2019-06-09', 15, 5)
GO
INSERT [dbo].[Productos] ([Cod_Productos], [NombreProducto], [Precio], [Fecha_Expiracion], [ID], [Descuento]) VALUES (6, N'Pintura Barrilito Acrilico', 28, N'2021-05-01', 12, 5)
GO
INSERT [dbo].[Productos] ([Cod_Productos], [NombreProducto], [Precio], [Fecha_Expiracion], [ID], [Descuento]) VALUES (7, N'Bolso Maxxel PLAPTOP', 756.62, N'2021-05-01', 15, 20)
GO
INSERT [dbo].[Productos] ([Cod_Productos], [NombreProducto], [Precio], [Fecha_Expiracion], [ID], [Descuento]) VALUES (8, N'Adhesivo doble cara', 115.86, N'2021-05-01', 12, 9)
GO
INSERT [dbo].[Productos] ([Cod_Productos], [NombreProducto], [Precio], [Fecha_Expiracion], [ID], [Descuento]) VALUES (9, N'Teclado Maxell USB', 422.76, N'2021-05-01', 15, 30)
GO
INSERT [dbo].[Productos] ([Cod_Productos], [NombreProducto], [Precio], [Fecha_Expiracion], [ID], [Descuento]) VALUES (10, N'lana zola pmanualidad bl 7ad18-ky-25g-wh ', 13.92, N'2021-05-01', 13, 3)
GO
INSERT [dbo].[Productos] ([Cod_Productos], [NombreProducto], [Precio], [Fecha_Expiracion], [ID], [Descuento]) VALUES (12, N'escarcha barrilito surtida dya24m 10grms ', 14.52, N'2021-05-01', 13, 7)
GO
INSERT [dbo].[Productos] ([Cod_Productos], [NombreProducto], [Precio], [Fecha_Expiracion], [ID], [Descuento]) VALUES (13, N'Plastico Adhesivo', 37.43, N'2021-05-01', 14, 2)
GO
INSERT [dbo].[Productos] ([Cod_Productos], [NombreProducto], [Precio], [Fecha_Expiracion], [ID], [Descuento]) VALUES (14, N'Cartoon espuma', 205.62, N'2021-05-01', 14, 30)
GO
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedores] ON 
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (1, N'Isamar', 12, N'85689665', N'2da Entrada Las Colinas, de la estación de bomberos 1c al noroeste, casa No. 33.', N'Tetel222010@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (3, N'César', 12, N'22641438', N'Bolonia, Esquina sur Canal 12 TV 1/2c al sur', N'Cesar@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (4, N'Eduardo Molina', 13, N'22524025', N'Iglesia Las Palmas 2c abajo 1/2c al sur', N'eduardomolina@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (5, N'Alberto Gutiérrez', 14, N'22641438', N'Altagracia, antiguo Munich 1c arriba 1 1/2c al lago', N'albertogutierrez@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (6, N'Fernando Delgado', 15, N'22773606', N'De la aguja trasera de la uca 2 c al norte', N'fernandodelgado@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (7, N'Estafani Moraleso', 12, N'22719450', N'Centro Comercial Metrocentro, frente al Vívero Los Gorriones', N'estafani@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (8, N'Amy Treminio', 13, N'22777673', N'Multicentro Las Américas Módulo 40, oficinas de Multicentro', N'amytreminio@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (9, N'Juan José', 14, N'22765080', N'Carretera a Masaya km 7, Centro Comercial Galería Santo Domingo', N'juanjose@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (10, N'Winnie Tsai', 15, N'22227850', N'Costado Norte Hotel Crowne Plaza', N'winni@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (12, N'Alfonso José', 13, N'22707489', N'Rotonda El Periodista 100mts al este, Plaza Mirasol, frente al PLC', N'alfonso@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (13, N'William Kenneth', 14, N'22662514', N'Bolonia, portón principal antiguo Hospital Militar 2c norte 1/2c abajo', N'willian@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (14, N'Jesus Evera', 15, N'22705182', N'Ofiplaza El Retiro, Edificio No. 7, suite No. 712, planta baja', N'jesus@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (15, N'Ceciles Elvira', 12, N'83808346', N'Villa Fontana, Semáforos Enitel 2c este 1/2c norte casa #234', N'ceciles@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (16, N'Mario José', 13, N'22525770', N'Altamira, Calle Principal, contiguo a Ferretería Roberto Morales, ', N'Mario@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (17, N'Juan Ignacio', 14, N'22703145', N'Altamira DEste Calle Principa Frente a BDF ', N'juan@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (18, N'Emerson Bismarck', 15, N'22761741', N'Carretera Masaya Km 9.9, contiguo a Global Gypsum', N'emerson@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (19, N'Jorge Carlos', 12, N'22701696', N'Carretera norte, Parmalat 5c al lago 2c arriba, Jardines de Santa ', N'jorge@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (20, N'César Agusto', 13, N'22707406', N'Carretera Masaya Km 4, Alke 50mts al oeste, 50mts al sur', N'cesar@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (21, N'Gueorgui Lozev', 14, N'22661134', N'Bolonia, Esquina sur Canal 12 TV 1/2c al sur', N'gueorgui@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (22, N'Francisco Javier', 15, N'88560975', N'Iglesia Las Palmas 2c abajo 1/2c al sur', N'francisco@hotmail.com')
GO
INSERT [dbo].[Proveedores] ([Cod_Proveedor], [Nombre], [ID], [Telefono], [Direccion], [Email]) VALUES (23, N'María Iseldia', 12, N'22786305', N'Altamira, D Este casa #423, Sinsa Proyectos 1/2c oeste 20mts al sur', N'maria@hotmail.com')
GO
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([Id_Usuario], [Usuario], [Contraseña], [Tipo_Usuario]) VALUES (2, N'Admin', N'123', N'Administrador')
GO
INSERT [dbo].[Usuario] ([Id_Usuario], [Usuario], [Contraseña], [Tipo_Usuario]) VALUES (3, N'Cristhel', N'1234', N'Comprador')
GO
INSERT [dbo].[Usuario] ([Id_Usuario], [Usuario], [Contraseña], [Tipo_Usuario]) VALUES (4, N'Guadalupe', N'123', N'Vendedor')
GO
INSERT [dbo].[Usuario] ([Id_Usuario], [Usuario], [Contraseña], [Tipo_Usuario]) VALUES (5, N'Kenneth', N'123', N'Gerente')
GO
INSERT [dbo].[Usuario] ([Id_Usuario], [Usuario], [Contraseña], [Tipo_Usuario]) VALUES (6, N'Axel', N'123', N'Bodega')
GO
INSERT [dbo].[Usuario] ([Id_Usuario], [Usuario], [Contraseña], [Tipo_Usuario]) VALUES (7, N'Enoc', N'123', N'Gerente')
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD FOREIGN KEY([Cod_Inventario])
REFERENCES [dbo].[Inventario] ([Cod_Inventario])
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD FOREIGN KEY([Cod_Productos])
REFERENCES [dbo].[Productos] ([Cod_Productos])
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD FOREIGN KEY([CodEmpleado])
REFERENCES [dbo].[Empleados] ([CodEmpleado])
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[Categoria] ([ID])
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([Id_Cliente])
GO
ALTER TABLE [dbo].[Factura_Compras]  WITH CHECK ADD  CONSTRAINT [FK__Factura_C__Cod_I__73852659] FOREIGN KEY([Cod_Inventario])
REFERENCES [dbo].[Inventario] ([Cod_Inventario])
GO
ALTER TABLE [dbo].[Factura_Compras] CHECK CONSTRAINT [FK__Factura_C__Cod_I__73852659]
GO
ALTER TABLE [dbo].[Factura_Compras]  WITH CHECK ADD  CONSTRAINT [FK__Factura_C__Cod_P__719CDDE7] FOREIGN KEY([Cod_Proveedor])
REFERENCES [dbo].[Proveedores] ([Cod_Proveedor])
GO
ALTER TABLE [dbo].[Factura_Compras] CHECK CONSTRAINT [FK__Factura_C__Cod_P__719CDDE7]
GO
ALTER TABLE [dbo].[Factura_Compras]  WITH CHECK ADD  CONSTRAINT [FK__Factura_C__Cod_P__72910220] FOREIGN KEY([Cod_Productos])
REFERENCES [dbo].[Productos] ([Cod_Productos])
GO
ALTER TABLE [dbo].[Factura_Compras] CHECK CONSTRAINT [FK__Factura_C__Cod_P__72910220]
GO
ALTER TABLE [dbo].[Factura_Compras]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Compras_Categoria] FOREIGN KEY([ID])
REFERENCES [dbo].[Categoria] ([ID])
GO
ALTER TABLE [dbo].[Factura_Compras] CHECK CONSTRAINT [FK_Factura_Compras_Categoria]
GO
ALTER TABLE [dbo].[Historial_de_Empleados]  WITH CHECK ADD FOREIGN KEY([CodEmpleado])
REFERENCES [dbo].[Empleados] ([CodEmpleado])
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Categoria] FOREIGN KEY([ID])
REFERENCES [dbo].[Categoria] ([ID])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Categoria]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD CHECK  (([Cedula] like '[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][A-Z]'))
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD CHECK  (([Genero] like 'M' OR [Genero] like 'F'))
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD CHECK  (([Telefono]>=(0)))
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD CHECK  (([Telefono] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD CHECK  (([Genero] like 'M' OR [Genero] like 'F'))
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD CHECK  (([Telefono]>=(0)))
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD CHECK  (([Telefono] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD  CONSTRAINT [CK__Proveedor__Telef__4CA06362] CHECK  (([Telefono]>=(0)))
GO
ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [CK__Proveedor__Telef__4CA06362]
GO
ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD  CONSTRAINT [CK__Proveedor__Telef__4D94879B] CHECK  (([Telefono] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [CK__Proveedor__Telef__4D94879B]
GO
/****** Object:  StoredProcedure [dbo].[AccesoUsuario]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AccesoUsuario]
(
@Usuario nvarchar(20),
@Contraseña nvarchar(20)
)
as
begin
Select * from Usuario where Usuario=@Usuario and Contraseña=@Contraseña
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarCategoria]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarCategoria]
(
@Nombrecat nvarchar(50)
)
as
begin
Insert into Categoria(Nombrecat)
values (@Nombrecat)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarCliente]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertarCliente]
(
@Nombre nvarchar(30), 
@Apellidos nvarchar(30) ,
@Cedula nchar(16),
@FechaNac Nvarchar(15) ,
@Genero char(1) ,
@Direccion nvarchar(MAX),
@Telefono nvarchar(15)
)
as
begin
Insert into Clientes (Nombre, Apellidos, Cedula,FechaNac,Genero,Direccion, Telefono)
values(@Nombre,@Apellidos,@Cedula,@FechaNac,@Genero,@Direccion,@Telefono)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarDetalleCompra]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertarDetalleCompra]
(
@Cantidad int,
@MontoAnteIVA numeric(18,6),
@IVA numeric(18,6),
@Descuento numeric(18,6),
@Total numeric(18,6)
)
as
begin
Insert into DetalleCompra (Cantidad,MontoAnteIVA,IVA,Descuento,Total)
values(@Cantidad,@MontoAnteIVA,@IVA,@Descuento,@Total)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarDetalleFactura]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertarDetalleFactura]
@Cantidad int,
@MontoAnteIVA numeric(18,6),
@IVA numeric(18,6),
@Descuento numeric(18,6),
@Total numeric(18,6)
as
begin
Insert into DETALLEFACTURA(Cantidad,MontoAnteIVA,Descuento,Total)
values(@Cantidad,@MontoAnteIVA,@Descuento,@Total)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarEmpleados]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[InsertarEmpleados]
(
@Nombre nvarchar(30) ,
@Apellidos nvarchar(30) ,
@INSS nvarchar(12),
@FechaNac Nvarchar(15) ,
@Genero char(1) ,
@Direccion nvarchar(MAX),
@Telefono nvarchar(15),
@EstadoCivil nvarchar(12),
@Email nvarchar(80)
)
as
begin
Insert into Empleados ( Nombre, Apellidos, INSS,FechaNac,Genero,Direccion, Telefono,EstadoCivil,Email)
values(@Nombre,@Apellidos,@INSS,@FechaNac,@Genero,@Direccion,@Telefono,@EstadoCivil,@Email)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarFactura]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertarFactura]
(
@Id_Cliente int,
@Cod_Productos int,
@CodEmpleado int,
@ID int,
@Cod_Inventario int,
@Fecha Nvarchar(15),
@FormaPago nvarchar(10),
@Cantidad int,
@Subtotal numeric(18,6),
@IVA numeric(18,6),
@Descuento float,
@Total numeric(18,6)
)
as
begin
Insert into FACTURA(Id_Cliente,Cod_Productos,CodEmpleado,ID,Cod_Inventario,Fecha,FormaPago,Cantidad,Subtotal,IVA,Descuento,Total)
values(@Id_Cliente,@Cod_Productos,@CodEmpleado,@ID,@Cod_Inventario,@Fecha,@FormaPago,@Cantidad,@Subtotal,@IVA,@Descuento,@Total)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarFactura_Compra]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertarFactura_Compra]
(
@Cod_Proveedor int,
@Cod_Productos int,
@Cod_Inventario int,
@ID int,
@FechaCompra Nvarchar(15),
@Telefono Int,
@FormaPago nvarchar(20),
@Cantidad int,
@Subtotal float,
@IVA float,
@Descuento float,
@Total float
)
as
begin
Insert into Factura_Compras(Cod_Proveedor,Cod_Productos,Cod_Inventario,ID,FechaCompra,Telefono,FormaPago,Cantidad,Subtotal,IVA,Descuento,Total)
values(@Cod_Proveedor,@Cod_Productos,@Cod_Inventario,@ID,@FechaCompra,@Telefono,@FormaPago,@Cantidad,@Subtotal,@IVA,@Descuento,@Total)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarHistorial_Empleados]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertarHistorial_Empleados]
(
@Cargo nvarchar(20),
@Antiguedad datetime
)
as
begin
Insert into Historial_de_Empleados (Cargo,Antiguedad)
values(@Cargo,@Antiguedad)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarInventario]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertarInventario]
(
@Cod_Productos int,
@ID int,
@Fecha_Entrada Nvarchar(15),
@StockMaximo int,
@StockMinimo int,
@StockActual int,
@Garantia nvarchar(20)
)
as
begin
Insert into Inventario(Cod_Productos,ID,Fecha_Entrada,StockMaximo,StockMinimo,StockActual,Garantia)
values(@Cod_Productos,@ID,@Fecha_Entrada,@StockMaximo,@StockMinimo,@StockActual,@Garantia)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarProducto]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarProducto]
(
@NombreProducto nvarchar(50),
@Precio money,
@Fecha_Expiracion Nvarchar(15)
)
as
begin
insert into Productos(NombreProducto,Precio,Fecha_Expiracion)
Values (@NombreProducto,@Precio,@Fecha_Expiracion)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarProveedores]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertarProveedores]
(
@ID int,
@Nombre nvarchar(30),
@Telefono int,
@Direccion nvarchar(max),
@Email nvarchar(80)
)
as
begin
Insert into Proveedores (ID,Nombre,Telefono,Direccion,Email)
values(@ID,@Nombre,@Telefono,@Direccion,@Email)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuario]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertarUsuario]
(
@Usuario nvarchar(20),
@Contraseña nvarchar (20),
@Tipo_Usuario nvarchar(20)
)
as
begin
Insert into Usuario(Usuario,Contraseña,Tipo_Usuario)
values(@Usuario,@Contraseña,@Tipo_Usuario)
end
GO
/****** Object:  StoredProcedure [dbo].[ListarCategorias]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListarCategorias] 
as
select *from Categoria order by Nombrecat asc
GO
/****** Object:  StoredProcedure [dbo].[ListarProduc]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarProduc]
as
BEGIN
select *from Productos order by NombreProducto asc
END
GO
/****** Object:  StoredProcedure [dbo].[ListarProductosInventario]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListarProductosInventario]
as
select Cod_Inventario AS ID,Inventario.Codigo,Categoria.ID as IdCat, Categoria.Nombrecat,Productos.Cod_Productos, Productos.NombreProducto, Productos.Precio, 
Productos.Descuento ,Fecha_Entrada ,StockMaximo,StockMinimo,StockActual,Garantia
from Inventario 
INNER JOIN Categoria ON Inventario.ID=Categoria.ID
INNER JOIN Productos ON Inventario.Cod_Productos=Productos.Cod_Productos
GO
/****** Object:  StoredProcedure [dbo].[ModificarCategoria]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarCategoria]
(
@ID int,
@Nombrecat nvarchar(50)
)
as
begin
Update Categoria set Nombrecat=@Nombrecat where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarClientes]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ModificarClientes]
(
@Id_Cliente int, 
@Nombre nvarchar(30), 
@Apellidos nvarchar(30) ,
@Cedula nchar(16),
@FechaNac Nvarchar(15),
@Genero char(1) ,
@Direccion nvarchar(MAX),
@Telefono nvarchar(15)
)
as
begin
Update Clientes set Nombre=@Nombre,Apellidos=@Apellidos,Cedula=@Cedula,FechaNac=@FechaNac,Genero=@Genero,Direccion=@Direccion,Telefono=@Telefono where Id_Cliente=@Id_Cliente
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarDetalleCompra]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ModificarDetalleCompra]
(
@ID_DetalleC char(5),
@Cantidad int,
@MontoAnteIVA numeric(18,6),
@IVA numeric(18,6),
@Descuento numeric(18,6),
@Total numeric(18,6)
)
as
begin
Update DetalleCompra set Cantidad=@Cantidad,MontoAnteIVA=@MontoAnteIVA,IVA=@IVA, Descuento=@Descuento,Total=@Total where ID_DetalleC=@ID_DetalleC
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarDetalleFactura]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ModificarDetalleFactura]
@Id_Detalle char(5),
@Cantidad int,
@MontoAnteIVA numeric(18,6),
@IVA numeric(18,6),
@Descuento numeric(18,6),
@Total numeric(18,6)
as
begin
Update DETALLEFACTURA Set Cantidad=@Cantidad,MontoAnteIVA=@MontoAnteIVA,IVA=@IVA, Descuento=@Descuento,Total=@Total where Id_Detalle=@Id_Detalle
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarEmpleados]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[ModificarEmpleados]
(
@CodEmpleado int,
@Nombre nvarchar(30) ,
@Apellidos nvarchar(30) ,
@INSS nvarchar(12),
@FechaNac Nvarchar(15) ,
@Genero char(1) ,
@Direccion nvarchar(MAX),
@Telefono nvarchar(15),
@EstadoCivil nvarchar(12),
@Email nvarchar(80)
)
as
begin
Update Empleados set Nombre=@Nombre, Apellidos=@Apellidos, INSS=@INSS,FechaNac=@FechaNac,Genero=@Genero,Direccion=@Direccion,Telefono=@Telefono,EstadoCivil=@EstadoCivil,Email=@Email
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarFactura]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ModificarFactura]
(
@Id_Factura int,
@Fecha Nvarchar(15),
@Direccion nvarchar(MAX),
@FormaPago nvarchar(10),
@Cantidad int,
@Subtotal numeric(18,6),
@IVA numeric(18,6),
@Descuento numeric(18,6),
@Total numeric(18,6)
)
as
begin
Update FACTURA set Fecha=@Fecha,Direccion=@Direccion,FormaPago=@FormaPago, Cantidad=@Cantidad, 
Subtotal=@Subtotal, IVA=@IVA,Descuento=@Descuento, Total=@Total where Id_Factura=@Id_Factura
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarFactura_Compra]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ModificarFactura_Compra]
(
@ID_Compras  char(5),
@FechaCompra Nvarchar(15),
@Telefono Int,
@FormaPago numeric(18,6)
)
as
begin
Update Factura_Compras set FechaCompra=@FechaCompra,Telefono=@Telefono,FormaPago=@FormaPago where ID_Compras=@ID_Compras
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarHistorial_Empleados]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ModificarHistorial_Empleados]
(
@CodHistorial char(5),
@Cargo nvarchar(20),
@Antiguedad datetime
)
as
begin
Update Historial_de_Empleados set Cargo=@Cargo,Antiguedad=@Antiguedad where CodHistorial=@CodHistorial
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarInventario]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ModificarInventario]
(
@Cod_Inventario INT,
@Cod_Productos int,
@ID int,
@Fecha_Entrada Nvarchar(15),
@StockMaximo int,
@StockMinimo int,
@StockActual int,
@Garantia nvarchar(20)
)
as
begin
Update Inventario set Cod_Productos=@Cod_Productos, ID=@ID, Fecha_Entrada=@Fecha_Entrada,StockMaximo=@StockMaximo, 
StockMinimo=@StockMinimo, StockActual=@StockActual, Garantia=@Garantia where Cod_Inventario=@Cod_Inventario
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarProducto]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarProducto]
(
@Cod_Productos int,
@NombreProducto nvarchar(50),
@Precio money,
@Fecha_Expiracion Nvarchar(15)
)
as
begin
update Productos set NombreProducto=@NombreProducto,Precio=@Precio,Fecha_Expiracion=@Fecha_Expiracion where Cod_Productos=@Cod_Productos
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarProveedores]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ModificarProveedores]
(
@Cod_Proveedor int,
@Nombre nvarchar(30),
@Telefono int,
@Direccion nvarchar(max),
@Email nvarchar(80)
)
as
begin
Update Proveedores set Nombre=@Nombre,Telefono=@Telefono,Direccion=@Direccion,Email=@Email where Cod_Proveedor=@Cod_Proveedor
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarUsuario]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ModificarUsuario]
(
@Id_Usuario int,
@Usuario nvarchar(20),
@Contraseña nvarchar (20),
@Tipo_Usuario nvarchar (20)
)
as
begin
Update Usuario set Usuario=@Usuario, Contraseña=@Contraseña, Tipo_Usuario=@Tipo_Usuario where Id_Usuario= @Id_Usuario
end
GO
/****** Object:  StoredProcedure [dbo].[MostrarCatProduc]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[MostrarCatProduc]
as 
begin
select ID, NombreCat from Categoria
end
GO
/****** Object:  StoredProcedure [dbo].[MostrarClientes]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[MostrarClientes]
as
begin
select * from Clientes
end
GO
/****** Object:  StoredProcedure [dbo].[MostrarDetalle]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[MostrarDetalle]

as
begin
select * from DetalleFactura
end
GO
/****** Object:  StoredProcedure [dbo].[MostrarDetalleC]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[MostrarDetalleC]

as
begin
select * from DetalleCompra
end
GO
/****** Object:  StoredProcedure [dbo].[MostrarEmpleado]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[MostrarEmpleado]

as
begin
select * from Empleados
end
GO
/****** Object:  StoredProcedure [dbo].[MostrarFac_Comp]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[MostrarFac_Comp]

as
begin
select ID_Compras as ID, Proveedores.Nombre, Categoria.Nombrecat as Categoria, Productos.NombreProducto, FormaPago, Factura_Compras.Cantidad, Factura_Compras.Subtotal, 
Factura_Compras.IVA, Factura_Compras.Descuento,Factura_Compras.Total  
from Factura_Compras
inner join Productos on Factura_Compras.Cod_Productos=Productos.Cod_Productos
inner join Categoria on Factura_Compras.ID = Categoria.ID
inner join Proveedores on Factura_Compras.Cod_Proveedor= Proveedores.Cod_Proveedor
end
GO
/****** Object:  StoredProcedure [dbo].[MostrarFactura]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[MostrarFactura]

as
begin
select * from Factura
end
GO
/****** Object:  StoredProcedure [dbo].[MostrarHistorial_Empleados]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[MostrarHistorial_Empleados]

as
begin
select * from Historial_de_Empleados
end
GO
/****** Object:  StoredProcedure [dbo].[MostrarInventario]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[MostrarInventario]

as
begin
select * from Inventario
end
GO
/****** Object:  StoredProcedure [dbo].[MostrarProveedor]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[MostrarProveedor]
as
select Cod_Proveedor AS ID, Categoria.Nombrecat, Nombre,Telefono,Direccion,Email
 from Proveedores 
INNER JOIN Categoria ON Proveedores.ID=Categoria.ID
GO
/****** Object:  StoredProcedure [dbo].[MostrarProveedorBuscar]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[MostrarProveedorBuscar]
as
begin
select * from Proveedores
end
GO
/****** Object:  StoredProcedure [dbo].[MostrarUsuario]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[MostrarUsuario]

as
begin
select * from Usuario
end
GO
/****** Object:  StoredProcedure [dbo].[MostrarVenta]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarVenta]
as
select Id_Factura as ID,Empleados.Nombre as Empleado, Clientes.Nombre, Categoria.Nombrecat as Categoria, Productos.NombreProducto, FormaPago, FACTURA.Cantidad, FACTURA.Subtotal, FACTURA.IVA, FACTURA.Descuento,FACTURA.Total  
from FACTURA
inner join Productos on FACTURA.Cod_Productos=Productos.Cod_Productos
inner join Clientes on FACTURA.Id_Cliente=Clientes.Id_Cliente
inner join Empleados on FACTURA.CodEmpleado=Empleados.CodEmpleado
inner join Categoria on FACTURA.ID = Categoria.ID
GO
/****** Object:  StoredProcedure [dbo].[QuitarCompra]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[QuitarCompra]
(
@ID_Compras int
)
as
begin
delete  from  
Factura_Compras where ID_Compras=@ID_Compras
end
GO
/****** Object:  StoredProcedure [dbo].[QuitarVenta]    Script Date: 07/09/2019 19:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[QuitarVenta]
(
@Id_Factura int
)
as
begin
delete  from  
FACTURA where Id_Factura=@Id_Factura
end
GO
