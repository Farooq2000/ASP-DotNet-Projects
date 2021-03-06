USE [POS]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 9/25/2021 5:51:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[CustomerType] [int] NULL,
	[Contact] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[ShopName] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](50) NULL,
	[InsertedOn] [datetime] NULL,
	[InsertedBy] [int] NULL,
	[DeletedOn] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemView]    Script Date: 9/25/2021 5:51:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemView](
	[CustomerId] [int] NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[ProductName] [nvarchar](50) NULL,
	[ProductQuantity] [int] NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[InsertedOn] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItem]    Script Date: 9/25/2021 5:51:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItem](
	[CustomerId] [int] NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[ProductName] [nvarchar](50) NULL,
	[ProductQuantity] [int] NULL,
	[Amount] [decimal](18, 2) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[InsertedOn] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 9/25/2021 5:51:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[RiderId] [int] NULL,
	[Items] [varchar](max) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[Profit] [decimal](18, 2) NULL,
	[IsDelete] [bit] NULL,
	[DeletedBy] [int] NULL,
	[DeletedOn] [datetime] NULL,
	[InsertedBy] [int] NULL,
	[InsertedOn] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [datetime] NULL,
	[DeliveryTime] [datetime] NULL,
 CONSTRAINT [PK__Orders__F1E4607B5D40313C] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersView]    Script Date: 9/25/2021 5:51:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersView](
	[OrderId] [int] NULL,
	[CustomerName] [nvarchar](50) NULL,
	[CustomerId] [int] NULL,
	[Address] [nchar](10) NULL,
	[ShopName] [nvarchar](50) NULL,
	[DeliveryTime] [nchar](10) NULL,
	[City] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[Contact] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Items] [varchar](max) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[TotalAmount] [decimal](18, 2) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 9/25/2021 5:51:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Weight] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[Pieces] [nvarchar](50) NULL,
	[NetPrice] [decimal](18, 2) NULL,
	[WholeSellerPrice] [decimal](18, 2) NULL,
	[RetailPrice] [decimal](18, 2) NULL,
	[ManufactedBy] [nvarchar](50) NULL,
	[ManufactureDate] [datetime] NULL,
	[ExpiryDate] [datetime] NULL,
	[Discount] [decimal](18, 2) NULL,
	[Stock] [int] NULL,
	[IsDelete] [bit] NULL,
	[DeletedOn] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[InsertedOn] [datetime] NULL,
	[InsertedBy] [int] NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerType], [Contact], [Email], [ShopName], [Country], [City], [Address], [State], [Zip], [InsertedOn], [InsertedBy], [DeletedOn], [DeletedBy], [UpdatedOn], [UpdatedBy], [IsDelete]) VALUES (1, N'Farooq', 1, N'43248932', N'mfarooq20feb@gmai.com', N'karsaz', N'LOndon', N'Karaxhi', N'11-B', N'sdgsd', N'23', CAST(N'2021-09-15T16:42:17.000' AS DateTime), 0, CAST(N'1900-01-01T01:01:00.000' AS DateTime), 0, CAST(N'1900-01-01T01:01:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [CustomerType], [Contact], [Email], [ShopName], [Country], [City], [Address], [State], [Zip], [InsertedOn], [InsertedBy], [DeletedOn], [DeletedBy], [UpdatedOn], [UpdatedBy], [IsDelete]) VALUES (2, N'Ali', 1, N'43248932', N'mfarooq20feb@gmai.com', N'karsaz', N'LOndon', N'Karaxhi', N'11-B', N'sdgsd', N'23', CAST(N'2021-09-15T16:43:35.000' AS DateTime), 0, CAST(N'1900-01-01T01:01:00.000' AS DateTime), 0, CAST(N'1900-01-01T01:01:00.000' AS DateTime), 0, 0)
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [CustomerId], [RiderId], [Items], [Amount], [Discount], [TotalAmount], [Profit], [IsDelete], [DeletedBy], [DeletedOn], [InsertedBy], [InsertedOn], [UpdatedBy], [UpdatedOn], [DeliveryTime]) VALUES (1, 1, 1, N'[{"ProductId":1,"ProductName":"Spreadable Processed Cheese","ProductQuantity":1},{"ProductId":2,"ProductName":"Tak Macroni","ProductQuantity":3}]', CAST(2030.00 AS Decimal(18, 2)), CAST(20.40 AS Decimal(18, 2)), CAST(2009.60 AS Decimal(18, 2)), CAST(1170.00 AS Decimal(18, 2)), 0, 0, CAST(N'1900-01-01T01:01:00.000' AS DateTime), 0, CAST(N'2021-09-15T17:25:02.000' AS DateTime), 0, CAST(N'1900-01-01T01:01:00.000' AS DateTime), CAST(N'1900-01-01T01:01:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [Name], [Weight], [Category], [Description], [Pieces], [NetPrice], [WholeSellerPrice], [RetailPrice], [ManufactedBy], [ManufactureDate], [ExpiryDate], [Discount], [Stock], [IsDelete], [DeletedOn], [DeletedBy], [InsertedOn], [InsertedBy], [UpdatedOn], [UpdatedBy]) VALUES (1, N'BBQ Sauce', N' 480 gram', N'Sauce', N'BBQ Sauce (480 gram)', N'1', CAST(140.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(230.00 AS Decimal(18, 2)), N'Disalvo', CAST(N'2021-06-18T05:50:00.000' AS DateTime), CAST(N'2022-06-18T05:50:00.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), 1, 0, CAST(N'1900-01-01T01:01:00.000' AS DateTime), 0, CAST(N'2021-09-15T16:46:41.000' AS DateTime), 0, CAST(N'2021-09-15T17:25:38.000' AS DateTime), 0)
INSERT [dbo].[Product] ([ProductId], [Name], [Weight], [Category], [Description], [Pieces], [NetPrice], [WholeSellerPrice], [RetailPrice], [ManufactedBy], [ManufactureDate], [ExpiryDate], [Discount], [Stock], [IsDelete], [DeletedOn], [DeletedBy], [InsertedOn], [InsertedBy], [UpdatedOn], [UpdatedBy]) VALUES (2, N'Cake', N'500 gram', N'Cake', N'Cake Sauce (500 gram)', N'4', CAST(240.00 AS Decimal(18, 2)), CAST(400.00 AS Decimal(18, 2)), CAST(600.00 AS Decimal(18, 2)), N'Disalvo', CAST(N'2021-06-18T05:50:00.000' AS DateTime), CAST(N'2022-06-18T05:50:00.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), 1, 0, CAST(N'1900-01-01T01:01:00.000' AS DateTime), 0, CAST(N'2021-09-15T16:46:41.000' AS DateTime), 0, CAST(N'2021-09-15T17:25:40.000' AS DateTime), 0)
INSERT [dbo].[Product] ([ProductId], [Name], [Weight], [Category], [Description], [Pieces], [NetPrice], [WholeSellerPrice], [RetailPrice], [ManufactedBy], [ManufactureDate], [ExpiryDate], [Discount], [Stock], [IsDelete], [DeletedOn], [DeletedBy], [InsertedOn], [InsertedBy], [UpdatedOn], [UpdatedBy]) VALUES (3, N'Ice Cream', N' 600 gram', N'Walls', N'Ice Cream (600 gram)', N'1', CAST(140.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(230.00 AS Decimal(18, 2)), N'Disalvo', CAST(N'2021-06-18T05:50:00.000' AS DateTime), CAST(N'2022-06-18T05:50:00.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), 2, 0, CAST(N'1900-01-01T01:01:00.000' AS DateTime), 0, CAST(N'2021-09-16T09:11:25.000' AS DateTime), 0, CAST(N'1900-01-01T01:01:00.000' AS DateTime), 0)
INSERT [dbo].[Product] ([ProductId], [Name], [Weight], [Category], [Description], [Pieces], [NetPrice], [WholeSellerPrice], [RetailPrice], [ManufactedBy], [ManufactureDate], [ExpiryDate], [Discount], [Stock], [IsDelete], [DeletedOn], [DeletedBy], [InsertedOn], [InsertedBy], [UpdatedOn], [UpdatedBy]) VALUES (4, N'Magnum', N' 600 gram', N'Walls', N'Ice Cream (600 gram)', N'1', CAST(140.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(230.00 AS Decimal(18, 2)), N'Disalvo', CAST(N'2021-06-18T05:50:00.000' AS DateTime), CAST(N'2022-06-18T05:50:00.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), 2, 0, CAST(N'1900-01-01T01:01:00.000' AS DateTime), 0, CAST(N'2021-09-16T19:00:53.000' AS DateTime), 0, CAST(N'1900-01-01T01:01:00.000' AS DateTime), 0)
INSERT [dbo].[Product] ([ProductId], [Name], [Weight], [Category], [Description], [Pieces], [NetPrice], [WholeSellerPrice], [RetailPrice], [ManufactedBy], [ManufactureDate], [ExpiryDate], [Discount], [Stock], [IsDelete], [DeletedOn], [DeletedBy], [InsertedOn], [InsertedBy], [UpdatedOn], [UpdatedBy]) VALUES (5, N'Chocolate', N' 600 gram', N'Cadberry', N'Ice Cream (600 gram)', N'1', CAST(140.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(230.00 AS Decimal(18, 2)), N'Disalvo', CAST(N'2021-06-18T05:50:00.000' AS DateTime), CAST(N'2022-06-18T05:50:00.000' AS DateTime), CAST(0.00 AS Decimal(18, 2)), 2, 0, CAST(N'1900-01-01T01:01:00.000' AS DateTime), 0, CAST(N'2021-09-19T06:56:01.000' AS DateTime), 0, CAST(N'1900-01-01T01:01:00.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Orders] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Orders]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateProduct]    Script Date: 9/25/2021 5:51:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateProduct]
@ProductId as int= null,
	@Name as nvarchar(50)= null,
	@Weight nvarchar(50)= null,
	@Category nvarchar(50)= null,
	@Description nvarchar(50)= null,
	@Pieces nvarchar(50)= null,
	@NetPrice decimal(18, 2)= null,
	@RetailPrice decimal(18, 2)= null,
	@ManufactedBy nvarchar(50)= null,
	@ManufactureDate datetime = null,
	@ExpiryDate datetime = null, 
	@Discount nvarchar(50)= null,
	@Stock int = null,
	@IsDelete bit= null,
	@DeletedOn datetime = null,
	@DeletedBy int= null,
	@InsertedOn datetime = null,
	@InsertedBy int= null,
	@UpdatedOn datetime =null,
	@UpdatedBy int= null,
	@Customer_Type nvarchar(50)= null

	
AS
BEGIN
	Update Product set Name = @Name ,Weight = @Weight, Category = @Category, Description = @Description, Pieces = @Pieces , NetPrice = @NetPrice,RetailPrice = @RetailPrice, ManufactedBy = @ManufactedBy,ManufactureDate = @ManufactureDate,ExpiryDate = @ExpiryDate, Discount = @Discount,  Stock = @Stock
	                   ,IsDelete = @IsDelete,DeletedOn = @DeletedOn, DeletedBy = @DeletedBy, InsertedOn = @InsertedOn, InsertedBy = @InsertedBy,@UpdatedOn= UpdatedOn, @UpdatedBy = UpdatedBy, @Customer_Type = @Customer_Type
	Where ProductId = @ProductId
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetCustomer]    Script Date: 9/25/2021 5:51:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[usp_GetCustomer]
(
@CustomerId as int = null,
@CustomerName as nvarchar(50) = null,
@CustomerType as int = null,
@ShopName as nvarchar(50) = null
)
AS
Select * from Customer
Where 
(CustomerId = @CustomerId OR @CustomerId is null)
AND (CustomerName = @CustomerName OR @CustomerName is null)
AND (CustomerType = @CustomerType OR @CustomerType is null)
AND (ShopName = @ShopName OR @ShopName is null)
GO
/****** Object:  StoredProcedure [dbo].[usp_GetOrderById]    Script Date: 9/25/2021 5:51:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[usp_GetOrderById]
(
@OrderId as int = null,
@CustomerName as nvarchar(50) = null,
@CustomerId as int = null,
@Address as nvarchar(50) = null,
@ShopName as nvarchar(50) = null,
@DeliveryTime as nvarchar(50) = null
)
As
Begin
select C.CustomerName,C.Address,C.City,C.Country,C.Contact,C.State,O.Items,O.Amount,O.Discount,O.TotalAmount
,O.DeliveryTime from Orders as O inner join Customer as C on C.CustomerId = O.CustomerId
where 
 (O.OrderId = @OrderId or @OrderId is null)
 AND (C.CustomerName = @CustomerName or @CustomerName is null)
 AND (C.CustomerId = @CustomerId or @CustomerId is null)
 AND (C.Address = @Address or @Address is null)
 AND (C.ShopName = @ShopName or @ShopName is null)
 AND (O.DeliveryTime = @DeliveryTime or @DeliveryTime is null)
End
GO
/****** Object:  StoredProcedure [dbo].[usp_GetOrderFromId]    Script Date: 9/25/2021 5:51:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[usp_GetOrderFromId]
(
@OrderId as int = null,
@CustomerName as nvarchar(50) = null,
@CustomerId as int = null,
@Address as nvarchar(50) = null,
@ShopName as nvarchar(50) = null,
@DeliveryTime as nvarchar(50) = null
)
As
Begin
select C.CustomerId,C.CustomerName,C.Address,C.ShopName,C.City,C.Country,C.Contact,C.State,O.Items,O.Amount,O.Discount,O.TotalAmount
,O.DeliveryTime,O.OrderId from Orders as O inner join Customer as C on C.CustomerId = O.CustomerId
where 
 (O.OrderId = @OrderId or @OrderId is null)
 AND (C.CustomerName = @CustomerName or @CustomerName is null)
 AND (C.CustomerId = @CustomerId or @CustomerId is null)
 AND (C.Address = @Address or @Address is null)
 AND (C.ShopName = @ShopName or @ShopName is null)
 AND (O.DeliveryTime = @DeliveryTime or @DeliveryTime is null)
End
GO
/****** Object:  StoredProcedure [dbo].[usp_GetOrderId]    Script Date: 9/25/2021 5:51:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[usp_GetOrderId]
(
@OrderId as int = null,
@CustomerName as nvarchar(50) = null,
@CustomerId as int = null,
@Address as nvarchar(50) = null,
@ShopName as nvarchar(50) = null,
@DeliveryTime as nvarchar(50) = null
)
As
Begin
select C.CustomerId,C.CustomerName,C.Address,C.City,C.Country,C.Contact,C.State,O.Items,O.Amount,O.Discount,O.TotalAmount
,O.DeliveryTime,O.OrderId from Orders as O inner join Customer as C on C.CustomerId = O.CustomerId
where 
 (O.OrderId = @OrderId or @OrderId is null)
 AND (C.CustomerName = @CustomerName or @CustomerName is null)
 AND (C.CustomerId = @CustomerId or @CustomerId is null)
 AND (C.Address = @Address or @Address is null)
 AND (C.ShopName = @ShopName or @ShopName is null)
 AND (O.DeliveryTime = @DeliveryTime or @DeliveryTime is null)
End
GO
/****** Object:  StoredProcedure [dbo].[usp_GetProduct]    Script Date: 9/25/2021 5:51:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetProduct] 
	@ProductId as int= null,
	@Name as nvarchar(50) = null,
	@NetPrice as decimal(18, 2) = null,
	@RetailPrice as decimal(18, 2) = null,
	@ManufactedBy as nvarchar(50) = null,
	@Category as nvarchar(50) = null
AS
BEGIN
	--if(@ProductId = 0 OR @ProductId = null)
	 --Select * from Product 	
	--else
	 Select * from Product 	
	 where 
	 (ProductId = @ProductId or @ProductId is null)
	 AND (Name = @Name or @Name is null)
	 AND (NetPrice = @NetPrice or @NetPrice is null)
	 AND (RetailPrice = @RetailPrice or @RetailPrice is null)
	 AND (ManufactedBy = @ManufactedBy or @ManufactedBy is null)
	 AND (Category = @Category or @Category is null)
END


GO
