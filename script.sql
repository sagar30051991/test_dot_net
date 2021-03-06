USE [master]
GO
/****** Object:  Database [DensityDB]    Script Date: 01/16/2016 12:31:38 ******/
CREATE DATABASE [DensityDB] ON  PRIMARY 
( NAME = N'DensityDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\DensityDB.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DensityDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\DensityDB.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DensityDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DensityDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DensityDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [DensityDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [DensityDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [DensityDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [DensityDB] SET ARITHABORT OFF
GO
ALTER DATABASE [DensityDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [DensityDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [DensityDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [DensityDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [DensityDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [DensityDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [DensityDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [DensityDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [DensityDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [DensityDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [DensityDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [DensityDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [DensityDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [DensityDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [DensityDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [DensityDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [DensityDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [DensityDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [DensityDB] SET  READ_WRITE
GO
ALTER DATABASE [DensityDB] SET RECOVERY SIMPLE
GO
ALTER DATABASE [DensityDB] SET  MULTI_USER
GO
ALTER DATABASE [DensityDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [DensityDB] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'DensityDB', N'ON'
GO
USE [DensityDB]
GO
/****** Object:  Table [dbo].[tblMstLogin]    Script Date: 01/16/2016 12:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMstLogin](
	[LoginId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblMstLogin] PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDescription]    Script Date: 01/16/2016 12:31:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDescription](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Particulars] [nvarchar](max) NULL,
	[Quantity] [int] NULL,
	[Rate] [int] NULL,
	[VAT_12] [nvarchar](50) NULL,
	[CST_2] [nvarchar](50) NULL,
	[TotalAmount] [nvarchar](50) NULL,
	[CustomerId] [nvarchar](50) NULL,
	[PurchaseOrderDate] [date] NULL,
 CONSTRAINT [PK_tblDescription] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomerInfo]    Script Date: 01/16/2016 12:31:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomerInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [nvarchar](50) NOT NULL,
	[CustomerName] [nvarchar](max) NULL,
	[Address1] [nvarchar](max) NULL,
	[Address2] [nvarchar](max) NULL,
	[City] [nvarchar](50) NULL,
	[Pincode] [nvarchar](50) NULL,
	[Vat_Tin] [nvarchar](50) NULL,
	[CST_No] [nvarchar](50) NULL,
	[ContactNo] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblCustomerInfo] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBillDetails]    Script Date: 01/16/2016 12:31:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBillDetails](
	[BillId] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseOrderDate] [datetime] NULL,
	[InvoiceDate] [datetime] NULL,
	[CST_VAT] [nvarchar](50) NULL,
	[NET_12] [nvarchar](50) NULL,
	[VAT_12] [nvarchar](50) NULL,
	[NET_2] [nvarchar](50) NULL,
	[CST_2] [nvarchar](50) NULL,
	[TotalAmount] [nvarchar](50) NULL,
	[CustomerId] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblBillDetails] PRIMARY KEY CLUSTERED 
(
	[BillId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBillData]    Script Date: 01/16/2016 12:31:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBillData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BillId] [nvarchar](50) NULL,
	[CustomerId] [nvarchar](50) NULL,
	[PurchaseOrderDate] [date] NULL,
	[CST_VAT] [bit] NULL,
 CONSTRAINT [PK_tblBillData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[uspmodifyDesc]    Script Date: 01/16/2016 12:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspmodifyDesc]

	@CustomerId nvarchar(50),

	@Particulars nvarchar(50),

	@Quantity int,

	@Rate int,

	@VAT_12 nvarchar(50),

	@CST_2 nvarchar(50),

	@TotalAmount nvarchar(50),

	@Flag integer,

	@ReturnVal int output ,

	@PurchaseOrderDate datetime



	AS

	BEGIN

	IF(@Flag=1)

	Begin

		Begin

			insert into tblDescription(CustomerId,Particulars,Quantity,Rate,VAT_12,CST_2,TotalAmount,PurchaseOrderDate) values(@CustomerId,@Particulars,@Quantity,@Rate,@VAT_12,@CST_2,@TotalAmount,@PurchaseOrderDate)

		end

		IF @@ERROR <>0

			BEGIN

				SET @ReturnVal = -2; -- if error occur

				RETURN @ReturnVal; 

			END

		ELSE 

			BEGIN

				SET @ReturnVal = 3; -- If record successfully inserted 

				RETURN @ReturnVal;

		END

	end

	IF(@Flag=2)

	Begin

		Begin

			Update tblDescription set Particulars=@Particulars,Quantity=@Quantity,VAT_12=@VAT_12,CST_2=@CST_2,TotalAmount=@TotalAmount where CustomerId=@CustomerId and PurchaseOrderDate =@PurchaseOrderDate

		end

		IF @@ERROR <>0

			BEGIN

				SET @ReturnVal = -2; -- if error occur

				RETURN @ReturnVal; 

			END

		ELSE 

			BEGIN

				SET @ReturnVal = 3; -- If record successfully inserted 

				RETURN @ReturnVal;

		END

	end

	IF(@Flag=3)

	Begin

		Begin

			Delete from tblDescription where CustomerId=@CustomerId

		end

		IF @@ERROR <>0

			BEGIN

				SET @ReturnVal = -2; -- if error occur

				RETURN @ReturnVal; 

			END

		ELSE 

			BEGIN

				SET @ReturnVal = 3; -- If record successfully inserted 

				RETURN @ReturnVal;

		END

	end

	END
GO
/****** Object:  StoredProcedure [dbo].[uspmodifycustomer]    Script Date: 01/16/2016 12:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================


CREATE procedure [dbo].[uspmodifycustomer]

	@CustomerId nvarchar(50),
	@CustomerName nvarchar(max),
	@Address1 nvarchar(max),
	@Address2 nvarchar(max),
	@City nvarchar(50),
	@Pincoode nvarchar(50),
	@Vat_Tin nvarchar(50),
	@CST_No nvarchar(50),
	@ContactNo nvarchar(50),
	@Flag integer,
	@ReturnVal int output 

	AS
	BEGIN
	IF(@Flag=1)
	Begin
		Begin
			insert into tblCustomerInfo(CustomerId,CustomerName,Address1,Address2,City,Pincode,Vat_Tin,CST_No,ContactNo) values(@CustomerId,@CustomerName,@Address1,@Address2,@City,@Pincoode,@Vat_Tin,@CST_No,@ContactNo)
		end
		IF @@ERROR <>0
			BEGIN
				SET @ReturnVal = -2; -- if error occur
				RETURN @ReturnVal; 
			END
		ELSE 
			BEGIN
				SET @ReturnVal = 3; -- If record successfully inserted 
				RETURN @ReturnVal;
		END
	end
	IF(@Flag=2)
	Begin
		Begin
			Update tblCustomerInfo set CustomerName=@CustomerName,Address1=@Address1,Address2=@Address2,City=@City,Pincode=@Pincoode,ContactNo=@ContactNo,Vat_Tin=@Vat_Tin,CST_No=@CST_No where CustomerId=@CustomerId 
		end
		IF @@ERROR <>0
			BEGIN
				SET @ReturnVal = -2; -- if error occur
				RETURN @ReturnVal; 
			END
		ELSE 
			BEGIN
				SET @ReturnVal = 3; -- If record successfully inserted 
				RETURN @ReturnVal;
		END
	end
	IF(@Flag=3)
	Begin
		Begin
			Delete from tblCustomerInfo where CustomerId=@CustomerId
		end
		IF @@ERROR <>0
			BEGIN
				SET @ReturnVal = -2; -- if error occur
				RETURN @ReturnVal; 
			END
		ELSE 
			BEGIN
				SET @ReturnVal = 3; -- If record successfully inserted 
				RETURN @ReturnVal;
		END
	end
	END
GO
/****** Object:  StoredProcedure [dbo].[uspmodifybilling]    Script Date: 01/16/2016 12:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================


CREATE procedure [dbo].[uspmodifybilling]

	@BillId int,
	@CustomerId nvarchar(50),
	@PurchaseOrderDate nvarchar(max),
	@InvoiceDate datetime,
	@CST_VAT nvarchar(max),
	@NET_12 nvarchar(50),
	@VAT_12 nvarchar(50),
	@NET_2 nvarchar(50),
	@CST_2 nvarchar(50),
	@TotalAmount nvarchar(50),
	@Flag integer,
	@ReturnVal int output 

	AS
	BEGIN
	IF(@Flag=1)
	Begin
		Begin
			insert into tblBillDetails(CustomerId,PurchaseOrderDate,InvoiceDate,CST_VAT,NET_12,VAT_12,NET_2,CST_2,TotalAmount) values(@CustomerId,@PurchaseOrderDate,@InvoiceDate,@CST_VAT,@NET_12,@VAT_12,@NET_2,@CST_2,@TotalAmount)
		end
		IF @@ERROR <>0
			BEGIN
				SET @ReturnVal = -2; -- if error occur
				RETURN @ReturnVal; 
			END
		ELSE 
			BEGIN
				SET @ReturnVal = 3; -- If record successfully inserted 
				RETURN @ReturnVal;
		END
	end
	IF(@Flag=2)
	Begin
		Begin
			Update tblBillDetails set PurchaseOrderDate=@PurchaseOrderDate,InvoiceDate=@InvoiceDate,CST_VAT=@CST_VAT,NET_12=@NET_12,VAT_12=@VAT_12,NET_2=@NET_2,CST_2=@CST_2,TotalAmount=@TotalAmount where CustomerId=@CustomerId AND BillId=@BillId 
		end
		IF @@ERROR <>0
			BEGIN
				SET @ReturnVal = -2; -- if error occur
				RETURN @ReturnVal; 
			END
		ELSE 
			BEGIN
				SET @ReturnVal = 3; -- If record successfully inserted 
				RETURN @ReturnVal;
		END
	end
	IF(@Flag=3)
	Begin
		Begin
			Delete from tblBillDetails where BillId=@BillId
		end
		IF @@ERROR <>0
			BEGIN
				SET @ReturnVal = -2; -- if error occur
				RETURN @ReturnVal; 
			END
		ELSE 
			BEGIN
				SET @ReturnVal = 3; -- If record successfully inserted 
				RETURN @ReturnVal;
		END
	end
	END
GO
/****** Object:  StoredProcedure [dbo].[uspmodifybilldata]    Script Date: 01/16/2016 12:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspmodifybilldata]



	@BillId nvarchar(50),

	@CustomerId nvarchar(50),	

	@CST_VAT bit,

	@PurchaseOrderDate datetime,

	@ReturnVal int output 



	AS

	BEGIN

		Begin

			insert into tblBillData(BillId,CustomerId,PurchaseOrderDate,CST_VAT) values(@BillId,@CustomerId,@PurchaseOrderDate,@CST_VAT)

		end

		IF @@ERROR <>0

			BEGIN

				SET @ReturnVal = -2; -- if error occur

				RETURN @ReturnVal; 

			END

		ELSE 

			BEGIN

				SET @ReturnVal = 3; -- If record successfully inserted 

				RETURN @ReturnVal;

	END

	end
GO
/****** Object:  StoredProcedure [dbo].[uspGetCustomerDetailById]    Script Date: 01/16/2016 12:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[uspGetCustomerDetailById]
	@Id nvarchar(50)
AS
BEGIN
	select * from tblCustomerInfo where Id=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[uspGetCustomerDetail]    Script Date: 01/16/2016 12:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[uspGetCustomerDetail]
	
AS
BEGIN
	select * from tblCustomerInfo
END
GO
/****** Object:  StoredProcedure [dbo].[NewUpdateCommand]    Script Date: 01/16/2016 12:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewUpdateCommand]
(
	@BillId nvarchar(50),
	@CustomerId nvarchar(50),
	@PurchaseOrderDate date,
	@CST_VAT bit,
	@Original_Id int,
	@Id int
)
AS
	SET NOCOUNT OFF;
UPDATE [tblBillData] SET [BillId] = @BillId, [CustomerId] = @CustomerId, [PurchaseOrderDate] = @PurchaseOrderDate, [CST_VAT] = @CST_VAT WHERE (([Id] = @Original_Id));
	
SELECT Id, BillId, CustomerId, PurchaseOrderDate, CST_VAT FROM tblBillData WHERE (Id = @Id)
GO
/****** Object:  StoredProcedure [dbo].[NewSelectCommand]    Script Date: 01/16/2016 12:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        tblCustomerInfo.CustomerId, tblCustomerInfo.CustomerName, tblCustomerInfo.Address1, tblCustomerInfo.Address2, tblCustomerInfo.City, tblCustomerInfo.Pincode, 
                         tblCustomerInfo.ContactNo, tblDescription.Id, tblDescription.Particulars, tblDescription.Quantity, tblDescription.Rate, tblDescription.TotalAmount, tblBillDetails.BillId, 
                         tblBillDetails.PurchaseOrderDate, tblBillDetails.NET_2, tblBillDetails.CST_2, tblBillDetails.NET_12, tblBillDetails.VAT_12, tblBillDetails.CST_VAT, 
                         tblBillDetails.TotalAmount AS Expr1
FROM            tblCustomerInfo INNER JOIN
                         tblCustomerInfo AS tblCustomerInfo_1 ON tblCustomerInfo.CustomerId = tblCustomerInfo_1.CustomerId INNER JOIN
                         tblBillDetails ON tblCustomerInfo.CustomerId = tblBillDetails.CustomerId INNER JOIN
                         tblDescription ON tblCustomerInfo.Id = tblDescription.Id
GO
/****** Object:  StoredProcedure [dbo].[NewInsertCommand]    Script Date: 01/16/2016 12:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewInsertCommand]
(
	@BillId nvarchar(50),
	@CustomerId nvarchar(50),
	@PurchaseOrderDate date,
	@CST_VAT bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO [tblBillData] ([BillId], [CustomerId], [PurchaseOrderDate], [CST_VAT]) VALUES (@BillId, @CustomerId, @PurchaseOrderDate, @CST_VAT);
	
SELECT Id, BillId, CustomerId, PurchaseOrderDate, CST_VAT FROM tblBillData WHERE (Id = SCOPE_IDENTITY())
GO
/****** Object:  StoredProcedure [dbo].[NewDeleteCommand]    Script Date: 01/16/2016 12:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewDeleteCommand]
(
	@Original_Id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [tblBillData] WHERE (([Id] = @Original_Id))
GO
/****** Object:  StoredProcedure [dbo].[Get_CustomerDetail]    Script Date: 01/16/2016 12:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_CustomerDetail]
	
AS
BEGIN
	select * from tblCustomerInfo
END
GO
