CREATE TABLE [dbo].[Raitings](
	[RaitingID] [int] IDENTITY(1,1) NOT NULL,
	[RaitingValue] [int] NOT NULL,
 CONSTRAINT [PK_Raitings] PRIMARY KEY CLUSTERED 
(
	[RaitingID] ASC
)
)