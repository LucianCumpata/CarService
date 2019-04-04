
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/04/2019 00:38:15
-- Generated from EDMX file: C:\Users\proal_000\Documents\GitHub\CarService\CarService\ModelCarService.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CarServiceDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AutoSasiu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AutoSet] DROP CONSTRAINT [FK_AutoSasiu];
GO
IF OBJECT_ID(N'[dbo].[FK_AutoClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AutoSet] DROP CONSTRAINT [FK_AutoClient];
GO
IF OBJECT_ID(N'[dbo].[FK_ComandaAuto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ComandaSet] DROP CONSTRAINT [FK_ComandaAuto];
GO
IF OBJECT_ID(N'[dbo].[FK_ComandaClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ComandaSet] DROP CONSTRAINT [FK_ComandaClient];
GO
IF OBJECT_ID(N'[dbo].[FK_ComandaDetaliuComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetaliuComandaSet] DROP CONSTRAINT [FK_ComandaDetaliuComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaMaterial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetaliuComandaSet] DROP CONSTRAINT [FK_DetaliuComandaMaterial];
GO
IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaOperatie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetaliuComandaSet] DROP CONSTRAINT [FK_DetaliuComandaOperatie];
GO
IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaMecanic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetaliuComandaSet] DROP CONSTRAINT [FK_DetaliuComandaMecanic];
GO
IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaImagine]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImagineSet] DROP CONSTRAINT [FK_DetaliuComandaImagine];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ClientSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientSet];
GO
IF OBJECT_ID(N'[dbo].[AutoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AutoSet];
GO
IF OBJECT_ID(N'[dbo].[SasiuSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SasiuSet];
GO
IF OBJECT_ID(N'[dbo].[MecanicSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MecanicSet];
GO
IF OBJECT_ID(N'[dbo].[MaterialSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MaterialSet];
GO
IF OBJECT_ID(N'[dbo].[ImagineSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ImagineSet];
GO
IF OBJECT_ID(N'[dbo].[OperatieSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OperatieSet];
GO
IF OBJECT_ID(N'[dbo].[ComandaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ComandaSet];
GO
IF OBJECT_ID(N'[dbo].[DetaliuComandaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetaliuComandaSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClientSet'
CREATE TABLE [dbo].[ClientSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL,
    [Adresa] nvarchar(50)  NOT NULL,
    [Localitate] nvarchar(10)  NOT NULL,
    [Judet] nvarchar(10)  NOT NULL,
    [Telefon] nvarchar(13)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'AutoSet'
CREATE TABLE [dbo].[AutoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NumarAuto] nvarchar(10)  NOT NULL,
    [SerieSasiu] nvarchar(25)  NOT NULL,
    [SasiuId] int  NOT NULL,
    [ClientId] int  NOT NULL
);
GO

-- Creating table 'SasiuSet'
CREATE TABLE [dbo].[SasiuSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodSasiu] nvarchar(2)  NOT NULL,
    [Denumire] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'MecanicSet'
CREATE TABLE [dbo].[MecanicSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'MaterialSet'
CREATE TABLE [dbo].[MaterialSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(50)  NOT NULL,
    [Cantitate] decimal(10,2)  NOT NULL,
    [Pret] decimal(10,2)  NOT NULL,
    [DataAprovizionare] datetime  NOT NULL
);
GO

-- Creating table 'ImagineSet'
CREATE TABLE [dbo].[ImagineSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Titlu] nvarchar(15)  NOT NULL,
    [Descriere] nvarchar(256)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Photo] varbinary(max)  NOT NULL,
    [DetaliuComandaId] int  NOT NULL
);
GO

-- Creating table 'OperatieSet'
CREATE TABLE [dbo].[OperatieSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(256)  NOT NULL,
    [TimpExecutie] decimal(6,2)  NOT NULL
);
GO

-- Creating table 'ComandaSet'
CREATE TABLE [dbo].[ComandaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AutoId] int  NOT NULL,
    [ClientId] int  NOT NULL,
    [StareComanda] nvarchar(25)  NOT NULL,
    [DataSystem] datetime  NOT NULL,
    [DataProgramare] datetime  NOT NULL,
    [DataFinalizare] datetime  NOT NULL,
    [KmBord] int  NOT NULL,
    [Descriere] nvarchar(1024)  NOT NULL,
    [ValoarePiese] decimal(10,2)  NOT NULL
);
GO

-- Creating table 'DetaliuComandaSet'
CREATE TABLE [dbo].[DetaliuComandaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ComandaId] int  NOT NULL,
    [MaterialId] int  NOT NULL,
    [OperatieId] int  NOT NULL,
    [MecanicId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ClientSet'
ALTER TABLE [dbo].[ClientSet]
ADD CONSTRAINT [PK_ClientSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AutoSet'
ALTER TABLE [dbo].[AutoSet]
ADD CONSTRAINT [PK_AutoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SasiuSet'
ALTER TABLE [dbo].[SasiuSet]
ADD CONSTRAINT [PK_SasiuSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MecanicSet'
ALTER TABLE [dbo].[MecanicSet]
ADD CONSTRAINT [PK_MecanicSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MaterialSet'
ALTER TABLE [dbo].[MaterialSet]
ADD CONSTRAINT [PK_MaterialSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ImagineSet'
ALTER TABLE [dbo].[ImagineSet]
ADD CONSTRAINT [PK_ImagineSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OperatieSet'
ALTER TABLE [dbo].[OperatieSet]
ADD CONSTRAINT [PK_OperatieSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ComandaSet'
ALTER TABLE [dbo].[ComandaSet]
ADD CONSTRAINT [PK_ComandaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetaliuComandaSet'
ALTER TABLE [dbo].[DetaliuComandaSet]
ADD CONSTRAINT [PK_DetaliuComandaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SasiuId] in table 'AutoSet'
ALTER TABLE [dbo].[AutoSet]
ADD CONSTRAINT [FK_AutoSasiu]
    FOREIGN KEY ([SasiuId])
    REFERENCES [dbo].[SasiuSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutoSasiu'
CREATE INDEX [IX_FK_AutoSasiu]
ON [dbo].[AutoSet]
    ([SasiuId]);
GO

-- Creating foreign key on [ClientId] in table 'AutoSet'
ALTER TABLE [dbo].[AutoSet]
ADD CONSTRAINT [FK_AutoClient]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[ClientSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutoClient'
CREATE INDEX [IX_FK_AutoClient]
ON [dbo].[AutoSet]
    ([ClientId]);
GO

-- Creating foreign key on [AutoId] in table 'ComandaSet'
ALTER TABLE [dbo].[ComandaSet]
ADD CONSTRAINT [FK_ComandaAuto]
    FOREIGN KEY ([AutoId])
    REFERENCES [dbo].[AutoSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaAuto'
CREATE INDEX [IX_FK_ComandaAuto]
ON [dbo].[ComandaSet]
    ([AutoId]);
GO

-- Creating foreign key on [ClientId] in table 'ComandaSet'
ALTER TABLE [dbo].[ComandaSet]
ADD CONSTRAINT [FK_ComandaClient]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[ClientSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaClient'
CREATE INDEX [IX_FK_ComandaClient]
ON [dbo].[ComandaSet]
    ([ClientId]);
GO

-- Creating foreign key on [ComandaId] in table 'DetaliuComandaSet'
ALTER TABLE [dbo].[DetaliuComandaSet]
ADD CONSTRAINT [FK_ComandaDetaliuComanda]
    FOREIGN KEY ([ComandaId])
    REFERENCES [dbo].[ComandaSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComandaDetaliuComanda'
CREATE INDEX [IX_FK_ComandaDetaliuComanda]
ON [dbo].[DetaliuComandaSet]
    ([ComandaId]);
GO

-- Creating foreign key on [MaterialId] in table 'DetaliuComandaSet'
ALTER TABLE [dbo].[DetaliuComandaSet]
ADD CONSTRAINT [FK_DetaliuComandaMaterial]
    FOREIGN KEY ([MaterialId])
    REFERENCES [dbo].[MaterialSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaMaterial'
CREATE INDEX [IX_FK_DetaliuComandaMaterial]
ON [dbo].[DetaliuComandaSet]
    ([MaterialId]);
GO

-- Creating foreign key on [OperatieId] in table 'DetaliuComandaSet'
ALTER TABLE [dbo].[DetaliuComandaSet]
ADD CONSTRAINT [FK_DetaliuComandaOperatie]
    FOREIGN KEY ([OperatieId])
    REFERENCES [dbo].[OperatieSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaOperatie'
CREATE INDEX [IX_FK_DetaliuComandaOperatie]
ON [dbo].[DetaliuComandaSet]
    ([OperatieId]);
GO

-- Creating foreign key on [MecanicId] in table 'DetaliuComandaSet'
ALTER TABLE [dbo].[DetaliuComandaSet]
ADD CONSTRAINT [FK_DetaliuComandaMecanic]
    FOREIGN KEY ([MecanicId])
    REFERENCES [dbo].[MecanicSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaMecanic'
CREATE INDEX [IX_FK_DetaliuComandaMecanic]
ON [dbo].[DetaliuComandaSet]
    ([MecanicId]);
GO

-- Creating foreign key on [DetaliuComandaId] in table 'ImagineSet'
ALTER TABLE [dbo].[ImagineSet]
ADD CONSTRAINT [FK_DetaliuComandaImagine]
    FOREIGN KEY ([DetaliuComandaId])
    REFERENCES [dbo].[DetaliuComandaSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaImagine'
CREATE INDEX [IX_FK_DetaliuComandaImagine]
ON [dbo].[ImagineSet]
    ([DetaliuComandaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------