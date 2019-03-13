CREATE TABLE [dbo].[MaterialRaiting](
	[MaterialID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[RaitingID] [int] NOT NULL,
) ON [PRIMARY]
GO
<<<<<<< HEAD
=======
ALTER TABLE [dbo].[MaterialRaiting]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRaiting_Materials] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Materials] ([MaterialID])
GO

ALTER TABLE [dbo].[MaterialRaiting] CHECK CONSTRAINT [FK_MaterialRaiting_Materials]
GO
ALTER TABLE [dbo].[MaterialRaiting]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRaiting_Raitings] FOREIGN KEY([UserID])
REFERENCES [dbo].[Raitings] ([RaitingID])
GO

ALTER TABLE [dbo].[MaterialRaiting] CHECK CONSTRAINT [FK_MaterialRaiting_Raitings]
GO
ALTER TABLE [dbo].[MaterialRaiting]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRaiting_Users] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Users] ([UserID])
GO

ALTER TABLE [dbo].[MaterialRaiting] CHECK CONSTRAINT [FK_MaterialRaiting_Users]
>>>>>>> 4301ea3575872b72eadb2bb7e754407a40b20ada
