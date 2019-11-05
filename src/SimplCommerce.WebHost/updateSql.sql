IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

ALTER TABLE [StormyProduct] DROP CONSTRAINT [FK_StormyProduct_Category_CategoryId];

GO

DROP INDEX [IX_StormyProduct_CategoryId] ON [StormyProduct];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[StormyProduct]') AND [c].[name] = N'MetaDescription');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [StormyProduct] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [StormyProduct] DROP COLUMN [MetaDescription];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[StormyProduct]') AND [c].[name] = N'MetaKeywords');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [StormyProduct] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [StormyProduct] DROP COLUMN [MetaKeywords];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[StormyProduct]') AND [c].[name] = N'MetaTitle');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [StormyProduct] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [StormyProduct] DROP COLUMN [MetaTitle];

GO

CREATE TABLE [ProductCategory] (
    [Id] bigint NOT NULL,
    [LastModified] datetimeoffset NOT NULL,
    [IsDeleted] bit NOT NULL,
    [DisplayOrder] int NOT NULL,
    [CategoryId] bigint NOT NULL,
    [ProductId] bigint NOT NULL,
    CONSTRAINT [PK_ProductCategory] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ProductCategory_Category_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Category] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ProductCategory_StormyProduct_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [StormyProduct] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_ProductCategory_CategoryId] ON [ProductCategory] ([CategoryId]);

GO

CREATE INDEX [IX_ProductCategory_ProductId] ON [ProductCategory] ([ProductId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191103203240_AddProductCategory', N'2.2.6-servicing-10079');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191104180522_AlterModel', N'2.2.6-servicing-10079');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191104191437_AddingProductMediaAndMedia', N'2.2.6-servicing-10079');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191104192513_AddMedia', N'2.2.6-servicing-10079');

GO

