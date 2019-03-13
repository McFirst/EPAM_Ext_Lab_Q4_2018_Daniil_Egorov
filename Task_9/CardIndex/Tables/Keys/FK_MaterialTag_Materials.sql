ALTER TABLE [dbo].[MaterialTag]  ADD  CONSTRAINT [FK_MaterialTag_Materials] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Materials] ([MaterialID])
GO
