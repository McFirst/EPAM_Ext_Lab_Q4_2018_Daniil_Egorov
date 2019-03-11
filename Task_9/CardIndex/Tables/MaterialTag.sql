CREATE TABLE [dbo].[MaterialTag](
	[MaterialID] [int] NOT NULL,
	[TagID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MaterialTag]  WITH CHECK ADD  CONSTRAINT [FK_MaterialTag_Materials] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Materials] ([MaterialID])
GO

ALTER TABLE [dbo].[MaterialTag] CHECK CONSTRAINT [FK_MaterialTag_Materials]
GO
ALTER TABLE [dbo].[MaterialTag]  WITH CHECK ADD  CONSTRAINT [FK_MaterialTag_Tags] FOREIGN KEY([TagID])
REFERENCES [dbo].[Tags] ([TagID])
GO

ALTER TABLE [dbo].[MaterialTag] CHECK CONSTRAINT [FK_MaterialTag_Tags]