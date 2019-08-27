CREATE TABLE [dbo].[Owners] (
    [Passport]      INT           NOT NULL,
    [Name]          NVARCHAR (20) NULL,
    [Surname]       NVARCHAR (20) NULL,
    [Second_name]   NVARCHAR (20) NULL,
    [Date_of_birth] DATE          NULL,
    [Photo] IMAGE NULL, 
    PRIMARY KEY CLUSTERED ([Passport] ASC)
);

