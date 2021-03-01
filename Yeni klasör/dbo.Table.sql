CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BrandID] INT NULL, 
    [ColorID] INT NULL, 
    [ModelYear] NCHAR(6) NULL, 
    [DailyPrice] MONEY NULL, 
    [Description] NCHAR(20) NULL
)
