﻿CREATE TABLE [dbo].[Games]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(255) NOT NULL, 
    [Platform] NVARCHAR(50) NOT NULL, 
    [Price] DECIMAL(18, 2) NOT NULL,

)
