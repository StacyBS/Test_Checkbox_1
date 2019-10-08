# 請先建立資料表:

## Create & Insert droplistItem Table 

CREATE TABLE [dbo].[droplistItem](
	[TypeItem] [varchar](10) NOT NULL,
	[TypePath] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[TypeItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


insert into droplistItem
values('BB','Programer/BB'),('BS','Programer/BS'),('Programer','Programer')
GO


## Create & Insert TestData_chk_droplist Table

CREATE TABLE [dbo].[TestData_chk_droplist](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Names] [varchar](10) NULL,
	[Content] [varchar](10) NULL,
	[TypeItem] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TestData_chk_droplist]  WITH CHECK ADD  CONSTRAINT [FK_PersonOrder] FOREIGN KEY([TypeItem])
REFERENCES [dbo].[droplistItem] ([TypeItem])
GO

ALTER TABLE [dbo].[TestData_chk_droplist] CHECK CONSTRAINT [FK_PersonOrder]
GO

insert into [TestData_chk_droplist](Names,Content,TypeItem)
values('Stacy','Great','BB'),('Bernie','GreatBB','BS'),('BS','GreatBS','Programer')
GO
