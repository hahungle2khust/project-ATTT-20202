CREATE TABLE [dbo].[users]
(
	[userId] varchar NOT NULL PRIMARY KEY,
	[username] varchar(50) not null,
	[firstname] nvarchar(50) not null,
	[lastname] nvarchar(50) not null,
	[dob] date not null,
	[gentle] nvarchar(5) not null,
	[email] varchar(100) not null,
	[topic1] nvarchar(MAX) not null,
	[question1] nvarchar(MAX) not null,
	[answer1] nvarchar(MAX) not null,
	[topic2] nvarchar(MAX),
	[question2] nvarchar(MAX),
	[answer2] nvarchar(MAX),
	[topic3] nvarchar(MAX),
	[question3] nvarchar(MAX),
	[answer3] nvarchar(MAX),
)
