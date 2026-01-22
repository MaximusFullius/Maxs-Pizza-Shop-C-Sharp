CREATE TABLE [dbo].[Customers] (
    [CustPhone]    CHAR (10)    NOT NULL,
    [CustName]     VARCHAR (20) NOT NULL,
    [CustAddress1] VARCHAR (25) NOT NULL,
    [CustAddress2] VARCHAR (25) NULL,
    [CustCity]     VARCHAR (20) NOT NULL,
    [CustState]    CHAR (2)     NOT NULL,
    [CustZip]      VARCHAR (9)  NOT NULL,
    [CustOrderNum] INT NOT NULL, 
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustOrderNum])
);

