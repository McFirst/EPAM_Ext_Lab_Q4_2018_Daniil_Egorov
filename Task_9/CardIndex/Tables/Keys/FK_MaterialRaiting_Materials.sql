ALTER TABLE [dbo].[MaterialRaiting]  ADD  CONSTRAINT [FK_MaterialRaiting_Materials] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Materials] ([MaterialID])
GO
