ALTER TABLE [dbo].[MaterialRaiting]  ADD  CONSTRAINT [FK_MaterialRaiting_Raitings] FOREIGN KEY([UserID])
REFERENCES [dbo].[Raitings] ([RaitingID])
GO
