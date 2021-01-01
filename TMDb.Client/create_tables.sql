BEGIN TRANSACTION;
GO

--Use Movies
--GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF SCHEMA_ID(N'tmdb') IS NULL EXEC(N'CREATE SCHEMA [tmdb];');
GO

CREATE TABLE [tmdb].[Movie] (
    [id] int NOT NULL IDENTITY,
    [collection_id] int NULL,
    [adult] bit NOT NULL DEFAULT CAST(0 AS bit),
    [video] bit NOT NULL DEFAULT CAST(0 AS bit),
    [popularity] decimal NULL,
    [vote_average] decimal NULL,
    [vote_count] int NULL,
    [revenue] decimal NULL,
    [runtime] smallint NULL,
    [budget] decimal NULL,
    [backdrop_path] nvarchar(2083) NULL,
    [imdb_id] nvarchar(20) NULL,
    [original_title] nvarchar(250) NULL,
    [overview] nvarchar(max) NULL,
    [poster_path] nvarchar(2083) NULL,
    [status] nvarchar(25) NULL,
    [tagline] nvarchar(250) NULL,
    [title] nvarchar(250) NULL,
    [original_language] nvarchar(2) NULL,
    [release_date] date NULL,
    [homepage] nvarchar(2083) NULL,
    CONSTRAINT [PK_Movie] PRIMARY KEY ([id]),
    CONSTRAINT [FK_Movie_Collection_collection_id] FOREIGN KEY ([collection_id]) REFERENCES [tmdb].[Collection] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [tmdb].[Genre] (
    [id] int NOT NULL IDENTITY,
    [name] nvarchar(100) NOT NULL,
    [MovieId] int NULL,
    CONSTRAINT [PK_Genre] PRIMARY KEY ([id]),
    CONSTRAINT [FK_Genre_Movie_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [tmdb].[Movie] ([id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [tmdb].[MovieGenres] (
    [GenreId] int NOT NULL,
    [MovieId] int NOT NULL,
    CONSTRAINT [PK_MovieGenres] PRIMARY KEY ([MovieId], [GenreId]),
    CONSTRAINT [FK_MovieGenres_Genre_GenreId] FOREIGN KEY ([GenreId]) REFERENCES [tmdb].[Genre] ([id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MovieGenres_Movie_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [tmdb].[Movie] ([id]) ON DELETE CASCADE
);
GO

CREATE TABLE [tmdb].[Collection] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(250) NOT NULL,
    [poster_path] nvarchar(2083) NULL,
    [backdrop_path] nvarchar(2083) NULL,
    CONSTRAINT [PK_Collection] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [tmdb].[Language] (
    [iso_639_1] nvarchar(2) NOT NULL,
    [english_name] nvarchar(25) NOT NULL,
    [name] nvarchar(100) NULL,
    [MovieId] int NULL,
    CONSTRAINT [PK_Language] PRIMARY KEY ([iso_639_1]),
    CONSTRAINT [FK_Language_Movie_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [tmdb].[Movie] ([id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [tmdb].[MovieLanguage] (
    [LanguageAbbreviation] nvarchar(2) NOT NULL,
    [MovieId] int NOT NULL,
    CONSTRAINT [PK_MovieLanguage] PRIMARY KEY ([MovieId], [LanguageAbbreviation]),
    CONSTRAINT [FK_MovieLanguage_Language_LanguageAbbreviation] FOREIGN KEY ([LanguageAbbreviation]) REFERENCES [tmdb].[Language] ([iso_639_1]) ON DELETE CASCADE,
    CONSTRAINT [FK_MovieLanguage_Movie_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [tmdb].[Movie] ([id]) ON DELETE CASCADE
);
GO

CREATE TABLE [tmdb].[AspNetUserMovieExclusions] (
    [MovieId] int NOT NULL,
    [UserId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_AspNetUserMovieExclusions] PRIMARY KEY ([UserId], [MovieId]),
    CONSTRAINT [FK_AspNetUserMovieExclusions_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE,
    --CONSTRAINT [FK_AspNetUserMovieExclusions_Movie_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [tmdb].[Movie] ([id]) ON DELETE CASCADE
);
GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
GO

CREATE INDEX [IX_AspNetUserMovieExclusions_MovieId] ON [tmdb].[AspNetUserMovieExclusions] ([MovieId]);
GO

CREATE INDEX [IX_Genre_MovieId] ON [tmdb].[Genre] ([MovieId]);
GO

CREATE INDEX [IX_Language_MovieId] ON [tmdb].[Language] ([MovieId]);
GO

CREATE INDEX [IX_Movie_collection_id] ON [tmdb].[Movie] ([collection_id]);
GO

CREATE INDEX [MovieTitleIndex] ON [tmdb].[Movie] ([title]);
GO

CREATE INDEX [IX_MovieGenres_GenreId] ON [tmdb].[MovieGenres] ([GenreId]);
GO

CREATE INDEX [IX_MovieLanguage_LanguageAbbreviation] ON [tmdb].[MovieLanguage] ([LanguageAbbreviation]);
GO

COMMIT;
GO