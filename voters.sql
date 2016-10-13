CREATE TABLE [dbo].[voters] (
    [userid]  INT           NOT NULL IDENTITY,
    [uname]   VARCHAR (255) NOT NULL,
    [ustudno] VARCHAR (255) NOT NULL,
    [upass]   VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([userid] ASC)
);

