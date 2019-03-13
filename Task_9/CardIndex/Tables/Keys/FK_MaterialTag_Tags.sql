ALTER TABLE [dbo].[MaterialTag]  ADD  CONSTRAINT [FK_MaterialTag_Tags] FOREIGN KEY([TagID])
REFERENCES [dbo].[Tags] ([TagID])
GO
