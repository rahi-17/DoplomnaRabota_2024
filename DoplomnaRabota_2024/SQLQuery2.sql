CREATE TABLE [dbo].[produkti] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [product]       VARCHAR (MAX) NULL,
    [cena]    float(MAX) NULL,
    [kolichestvo]     int (MAX) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
