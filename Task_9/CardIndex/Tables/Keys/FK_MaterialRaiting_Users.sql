ALTER TABLE [dbo].[MaterialRaiting]  ADD  CONSTRAINT [FK_MaterialRaiting_Users] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Users] ([UserID])
GO
