/*
 Navicat Premium Data Transfer

 Source Server         : DESKTOP-Q4OJVS5
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : DESKTOP-Q4OJVS5:1433
 Source Catalog        : TeethManagement
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 30/08/2022 14:57:33
*/


-- ----------------------------
-- Table structure for patient
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[patient]') AND type IN ('U'))
	DROP TABLE [dbo].[patient]
GO

CREATE TABLE [dbo].[patient] (
  [UID] int  IDENTITY(1,1) NOT NULL,
  [Email] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Phone] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Comment] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [TeethPhoto] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Recommendation] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [BridgeAndMissingTeeth] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[patient] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Auto increment value for patient
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[patient]', RESEED, 3)
GO


-- ----------------------------
-- Primary Key structure for table patient
-- ----------------------------
ALTER TABLE [dbo].[patient] ADD CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED ([UID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

