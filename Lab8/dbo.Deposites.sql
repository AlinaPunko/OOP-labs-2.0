CREATE TABLE [dbo].[Deposites] (
    [Number]  INT           NOT NULL,
    [Type]    NVARCHAR (50) NULL,
    [Balance] REAL          NULL,
    [Date]    DATE          NULL,
    [Owner]   INT           NULL,
    PRIMARY KEY CLUSTERED ([Number] ASC),
    CONSTRAINT [FK_Deposites_Owner] FOREIGN KEY ([Owner]) REFERENCES [dbo].[Owners] ([Passport])
);

