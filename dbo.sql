/*
 Navicat Premium Data Transfer

 Source Server         : DESKTOP-Q4OJVS5
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : DESKTOP-Q4OJVS5:1433
 Source Catalog        : TePeBrtDb
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 07/09/2022 15:05:06
*/


-- ----------------------------
-- Table structure for Patients
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Patients]') AND type IN ('U'))
	DROP TABLE [dbo].[Patients]
GO

CREATE TABLE [dbo].[Patients] (
  [Id] uniqueidentifier  NOT NULL,
  [Email] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [PhoneNumber] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Patients] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Patients
-- ----------------------------
INSERT INTO [dbo].[Patients] ([Id], [Email], [PhoneNumber]) VALUES (N'C9B85009-74AB-424E-9F57-08DA8E9D6E60', N'samuelpang73@gmail.com', N'+17182134799122')
GO

INSERT INTO [dbo].[Patients] ([Id], [Email], [PhoneNumber]) VALUES (N'58A15E48-4FED-45B6-9F58-08DA8E9D6E60', N'samuelpang73@gmail.com', N'+7182134799')
GO

INSERT INTO [dbo].[Patients] ([Id], [Email], [PhoneNumber]) VALUES (N'30267541-1E0B-46BE-9F59-08DA8E9D6E60', N'im.christopher.groe@gmail.com', N'+7182134799')
GO

INSERT INTO [dbo].[Patients] ([Id], [Email], [PhoneNumber]) VALUES (N'B39ABA67-0C83-4672-9F5A-08DA8E9D6E60', N'im.christopher.groe@gmail.com', N'+7182134799')
GO

INSERT INTO [dbo].[Patients] ([Id], [Email], [PhoneNumber]) VALUES (N'BF6F0A79-C130-4546-04F1-08DA8E9E622C', N'im.christopher.groe@gmail.com', N'+7182134799')
GO


-- ----------------------------
-- Table structure for RecoItems
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[RecoItems]') AND type IN ('U'))
	DROP TABLE [dbo].[RecoItems]
GO

CREATE TABLE [dbo].[RecoItems] (
  [Id] uniqueidentifier  NOT NULL,
  [Area] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Description] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [RecommendationID] uniqueidentifier  NULL,
  [Title] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[RecoItems] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of RecoItems
-- ----------------------------
INSERT INTO [dbo].[RecoItems] ([Id], [Area], [Description], [RecommendationID], [Title]) VALUES (N'52956CA8-17FC-4CB6-5077-08DA8E9D6ECF', N'Upper Row', N'1mm brush should be used for', N'AAF3DEC6-D7E6-4784-D37F-08DA8E9D6EB9', N'Cat 1')
GO

INSERT INTO [dbo].[RecoItems] ([Id], [Area], [Description], [RecommendationID], [Title]) VALUES (N'6BA27968-8F56-48BC-5078-08DA8E9D6ECF', N'Upper Row2', N'1mm brush should be used for2', N'AAF3DEC6-D7E6-4784-D37F-08DA8E9D6EB9', N'Cat 2')
GO

INSERT INTO [dbo].[RecoItems] ([Id], [Area], [Description], [RecommendationID], [Title]) VALUES (N'474CC61F-D4BA-4084-5079-08DA8E9D6ECF', N'11/21 11/12', N'brush 0.45mm Orange should be used for the gap between teeth: ', N'BD959837-7167-44BE-D380-08DA8E9D6EB9', N'Category 1')
GO

INSERT INTO [dbo].[RecoItems] ([Id], [Area], [Description], [RecommendationID], [Title]) VALUES (N'21FD67D4-5E7F-4AED-507A-08DA8E9D6ECF', N'23/24 24/25', N'brush 0.5mm Red should be used for the gap between teeth: ', N'BD959837-7167-44BE-D380-08DA8E9D6EB9', N'Category 1')
GO

INSERT INTO [dbo].[RecoItems] ([Id], [Area], [Description], [RecommendationID], [Title]) VALUES (N'8B7D8DCB-87DB-4B26-507B-08DA8E9D6ECF', N'11/21 11/12', N'brush 0.45mm Orange should be used for the gap between teeth: ', N'34B41965-FDB4-4DB6-D381-08DA8E9D6EB9', N'Category 1')
GO

INSERT INTO [dbo].[RecoItems] ([Id], [Area], [Description], [RecommendationID], [Title]) VALUES (N'8D615BC6-0EB2-45AF-507C-08DA8E9D6ECF', N'23/24 24/25', N'brush 0.5mm Red should be used for the gap between teeth: ', N'34B41965-FDB4-4DB6-D381-08DA8E9D6EB9', N'Category 1')
GO

INSERT INTO [dbo].[RecoItems] ([Id], [Area], [Description], [RecommendationID], [Title]) VALUES (N'8ED82DB8-BC7A-4F69-507D-08DA8E9D6ECF', N'11/21 11/12', N'brush 0.45mm Orange should be used for the gap between teeth: ', N'C51969CA-DEDB-46AC-D382-08DA8E9D6EB9', N'Category 1')
GO

INSERT INTO [dbo].[RecoItems] ([Id], [Area], [Description], [RecommendationID], [Title]) VALUES (N'A722FFB3-5BE3-40F1-507E-08DA8E9D6ECF', N'23/24 24/25', N'brush 0.5mm Red should be used for the gap between teeth: ', N'C51969CA-DEDB-46AC-D382-08DA8E9D6EB9', N'Category 1')
GO

INSERT INTO [dbo].[RecoItems] ([Id], [Area], [Description], [RecommendationID], [Title]) VALUES (N'76C2FE82-7A50-4970-13DC-08DA8E9E628A', N'11/21 11/12', N'brush 0.45mm Orange should be used for the gap between teeth: ', N'4310E8D5-1AAC-4D89-747E-08DA8E9E6277', N'Category 1')
GO

INSERT INTO [dbo].[RecoItems] ([Id], [Area], [Description], [RecommendationID], [Title]) VALUES (N'EF764DEC-6FB0-417C-13DD-08DA8E9E628A', N'23/24 24/25', N'brush 0.5mm Red should be used for the gap between teeth: ', N'4310E8D5-1AAC-4D89-747E-08DA8E9E6277', N'Category 1')
GO


-- ----------------------------
-- Table structure for Recommendations
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Recommendations]') AND type IN ('U'))
	DROP TABLE [dbo].[Recommendations]
GO

CREATE TABLE [dbo].[Recommendations] (
  [Id] uniqueidentifier  NOT NULL,
  [Bridge] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Comment] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Image] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Missing] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [PatientID] uniqueidentifier  NULL
)
GO

ALTER TABLE [dbo].[Recommendations] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Recommendations
-- ----------------------------
INSERT INTO [dbo].[Recommendations] ([Id], [Bridge], [Comment], [Image], [Missing], [PatientID]) VALUES (N'AAF3DEC6-D7E6-4784-D37F-08DA8E9D6EB9', N'1,3', N'This is comment', N'files/RecommendationImages/Screenshot_2022.07.17_06.49.52.629_e253.png', N'1,5', N'C9B85009-74AB-424E-9F57-08DA8E9D6E60')
GO

INSERT INTO [dbo].[Recommendations] ([Id], [Bridge], [Comment], [Image], [Missing], [PatientID]) VALUES (N'BD959837-7167-44BE-D380-08DA8E9D6EB9', N'17,18', N'This is comment', NULL, N'27,28', N'58A15E48-4FED-45B6-9F58-08DA8E9D6E60')
GO

INSERT INTO [dbo].[Recommendations] ([Id], [Bridge], [Comment], [Image], [Missing], [PatientID]) VALUES (N'34B41965-FDB4-4DB6-D381-08DA8E9D6EB9', N'17,18', N'This is comment', NULL, N'27,28', N'30267541-1E0B-46BE-9F59-08DA8E9D6E60')
GO

INSERT INTO [dbo].[Recommendations] ([Id], [Bridge], [Comment], [Image], [Missing], [PatientID]) VALUES (N'C51969CA-DEDB-46AC-D382-08DA8E9D6EB9', N'17,18', N'This is comment', N'files/RecommendationImages/blob_9c0a', N'27,28', N'B39ABA67-0C83-4672-9F5A-08DA8E9D6E60')
GO

INSERT INTO [dbo].[Recommendations] ([Id], [Bridge], [Comment], [Image], [Missing], [PatientID]) VALUES (N'4310E8D5-1AAC-4D89-747E-08DA8E9E6277', N'17,18', N'This is comment', N'files/RecommendationImages/blob_40bc.png', N'27,28', N'BF6F0A79-C130-4546-04F1-08DA8E9E622C')
GO

