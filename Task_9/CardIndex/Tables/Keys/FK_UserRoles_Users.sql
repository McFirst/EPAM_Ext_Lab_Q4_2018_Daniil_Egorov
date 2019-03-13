ALTER TABLE [dbo].[UserRoles]  ADD  CONSTRAINT [FK_UserRoles_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
