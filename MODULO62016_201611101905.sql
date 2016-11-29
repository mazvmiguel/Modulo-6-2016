USE [MODULO62016]
GO
/****** Object:  StoredProcedure [dbo].[proctPeriodoUpdate]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctPeriodoUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctPeriodoUpdate]
GO
/****** Object:  StoredProcedure [dbo].[proctPeriodoSelect]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctPeriodoSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctPeriodoSelect]
GO
/****** Object:  StoredProcedure [dbo].[proctPeriodoList]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctPeriodoList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctPeriodoList]
GO
/****** Object:  StoredProcedure [dbo].[proctPeriodoDelete]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctPeriodoDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctPeriodoDelete]
GO
/****** Object:  StoredProcedure [dbo].[proctMateriaUpdate]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMateriaUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctMateriaUpdate]
GO
/****** Object:  StoredProcedure [dbo].[proctMateriaSelect]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMateriaSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctMateriaSelect]
GO
/****** Object:  StoredProcedure [dbo].[proctMateriaSearch]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMateriaSearch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctMateriaSearch]
GO
/****** Object:  StoredProcedure [dbo].[proctMateriaList]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMateriaList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctMateriaList]
GO
/****** Object:  StoredProcedure [dbo].[proctMateriaDelete]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMateriaDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctMateriaDelete]
GO
/****** Object:  StoredProcedure [dbo].[proctMaestroUpdate]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMaestroUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctMaestroUpdate]
GO
/****** Object:  StoredProcedure [dbo].[proctMaestroSelect]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMaestroSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctMaestroSelect]
GO
/****** Object:  StoredProcedure [dbo].[proctMaestroSearchName]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMaestroSearchName]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctMaestroSearchName]
GO
/****** Object:  StoredProcedure [dbo].[proctMaestroSearchId]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMaestroSearchId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctMaestroSearchId]
GO
/****** Object:  StoredProcedure [dbo].[proctMaestroList]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMaestroList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctMaestroList]
GO
/****** Object:  StoredProcedure [dbo].[proctMaestroDelete]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMaestroDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctMaestroDelete]
GO
/****** Object:  StoredProcedure [dbo].[proctGrupoUpdate]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctGrupoUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctGrupoUpdate]
GO
/****** Object:  StoredProcedure [dbo].[proctGrupoSelect]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctGrupoSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctGrupoSelect]
GO
/****** Object:  StoredProcedure [dbo].[proctGrupoList]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctGrupoList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctGrupoList]
GO
/****** Object:  StoredProcedure [dbo].[proctGrupoDelete]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctGrupoDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctGrupoDelete]
GO
/****** Object:  StoredProcedure [dbo].[proctCursoUpdate]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctCursoUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctCursoUpdate]
GO
/****** Object:  StoredProcedure [dbo].[proctCursoSelect]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctCursoSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctCursoSelect]
GO
/****** Object:  StoredProcedure [dbo].[proctCursoList]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctCursoList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctCursoList]
GO
/****** Object:  StoredProcedure [dbo].[proctCursoDelete]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctCursoDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctCursoDelete]
GO
/****** Object:  StoredProcedure [dbo].[proctAlumnoUpdate]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctAlumnoUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctAlumnoUpdate]
GO
/****** Object:  StoredProcedure [dbo].[proctAlumnoSelect]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctAlumnoSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctAlumnoSelect]
GO
/****** Object:  StoredProcedure [dbo].[proctAlumnoList]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctAlumnoList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctAlumnoList]
GO
/****** Object:  StoredProcedure [dbo].[proctAlumnoDelete]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctAlumnoDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[proctAlumnoDelete]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tPeriodo_tPlan]') AND parent_object_id = OBJECT_ID(N'[dbo].[tPeriodo]'))
ALTER TABLE [dbo].[tPeriodo] DROP CONSTRAINT [FK_tPeriodo_tPlan]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tMateria_tPlan]') AND parent_object_id = OBJECT_ID(N'[dbo].[tMateria]'))
ALTER TABLE [dbo].[tMateria] DROP CONSTRAINT [FK_tMateria_tPlan]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tCurso_tMateria]') AND parent_object_id = OBJECT_ID(N'[dbo].[tCurso]'))
ALTER TABLE [dbo].[tCurso] DROP CONSTRAINT [FK_tCurso_tMateria]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tCurso_tMaestro]') AND parent_object_id = OBJECT_ID(N'[dbo].[tCurso]'))
ALTER TABLE [dbo].[tCurso] DROP CONSTRAINT [FK_tCurso_tMaestro]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tCurso_tGrupo]') AND parent_object_id = OBJECT_ID(N'[dbo].[tCurso]'))
ALTER TABLE [dbo].[tCurso] DROP CONSTRAINT [FK_tCurso_tGrupo]
GO
/****** Object:  Index [IX_tCurso]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[tCurso]') AND name = N'IX_tCurso')
DROP INDEX [IX_tCurso] ON [dbo].[tCurso]
GO
/****** Object:  Table [dbo].[user_]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[user_]') AND type in (N'U'))
DROP TABLE [dbo].[user_]
GO
/****** Object:  Table [dbo].[tPlan]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPlan]') AND type in (N'U'))
DROP TABLE [dbo].[tPlan]
GO
/****** Object:  Table [dbo].[tPeriodo]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPeriodo]') AND type in (N'U'))
DROP TABLE [dbo].[tPeriodo]
GO
/****** Object:  Table [dbo].[tMateria]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tMateria]') AND type in (N'U'))
DROP TABLE [dbo].[tMateria]
GO
/****** Object:  Table [dbo].[tMaestro]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tMaestro]') AND type in (N'U'))
DROP TABLE [dbo].[tMaestro]
GO
/****** Object:  Table [dbo].[tGrupo]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tGrupo]') AND type in (N'U'))
DROP TABLE [dbo].[tGrupo]
GO
/****** Object:  Table [dbo].[tCurso]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tCurso]') AND type in (N'U'))
DROP TABLE [dbo].[tCurso]
GO
/****** Object:  Table [dbo].[tAlumno]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tAlumno]') AND type in (N'U'))
DROP TABLE [dbo].[tAlumno]
GO
/****** Object:  UserDefinedFunction [dbo].[createInsertSP]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[createInsertSP]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[createInsertSP]
GO
USE [master]
GO
/****** Object:  Database [MODULO62016]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'MODULO62016')
DROP DATABASE [MODULO62016]
GO
/****** Object:  Database [MODULO62016]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'MODULO62016')
BEGIN
CREATE DATABASE [MODULO62016]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MODULO62016', FILENAME = N'D:\Bases\MODULO62016.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MODULO62016_log', FILENAME = N'D:\Bases\MODULO62016_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO
ALTER DATABASE [MODULO62016] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MODULO62016].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MODULO62016] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MODULO62016] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MODULO62016] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MODULO62016] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MODULO62016] SET ARITHABORT OFF 
GO
ALTER DATABASE [MODULO62016] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MODULO62016] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MODULO62016] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MODULO62016] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MODULO62016] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MODULO62016] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MODULO62016] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MODULO62016] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MODULO62016] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MODULO62016] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MODULO62016] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MODULO62016] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MODULO62016] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MODULO62016] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MODULO62016] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MODULO62016] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MODULO62016] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MODULO62016] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MODULO62016] SET  MULTI_USER 
GO
ALTER DATABASE [MODULO62016] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MODULO62016] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MODULO62016] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MODULO62016] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MODULO62016] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MODULO62016]
GO
/****** Object:  UserDefinedFunction [dbo].[createInsertSP]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[createInsertSP]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE FUNCTION [dbo].[createInsertSP]
(
	@spSchema varchar(200),
	@spTable varchar(200)
)
RETURNS varchar(max)
AS
BEGIN
 
	declare @SQL_DROP varchar(max)
	declare @SQL varchar(max)
	declare @COLUMNS varchar(max)
	declare @PK_COLUMN varchar(200)
 	
	set @SQL = ''''
	set @SQL_DROP = ''''
	set @COLUMNS = ''''
 	
	-- step 1: generate the drop statement and then the create statement
	set @SQL_DROP = @SQL_DROP + ''IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N''''['' + @spSchema + ''].[insert'' + @spTable + '']'''') AND type in (N''''P'''', N''''PC''''))'' + char(13)
	set @SQL_DROP = @SQL_DROP + ''DROP PROCEDURE ['' + @spSchema + ''].[insert'' + @spTable + '']''
 	
	set @SQL = @SQL + ''CREATE PROC ['' + @spSchema + ''].[insert'' + @spTable + '']'' + char(13)
	set @SQL = @SQL + ''('' + char(13)
 	
	-- step 2: ascertain what the primary key column for the table is
	set @PK_COLUMN = 
	(
	select c.column_name
	from information_schema.table_constraints pk 
	inner join information_schema.key_column_usage c 
		on c.table_name = pk.table_name 
		and c.constraint_name = pk.constraint_name
	where pk.TABLE_SCHEMA = @spSchema
		and pk.TABLE_NAME = @spTable
		and pk.constraint_type = ''primary key''
		and c.column_name in
			(
			select COLUMN_NAME
			from INFORMATION_SCHEMA.COLUMNS
			where columnproperty(object_id(quotename(@spSchema) + ''.'' + 
			quotename(@spTable)), COLUMN_NAME, ''IsIdentity'') = 1 -- ensure the primary key is an identity column
			group by COLUMN_NAME
			)
	group by column_name
	having COUNT(column_name) = 1 -- ensure there is only one primary key
	)
 	
 	-- step 3: now put all the table columns in bar the primary key (as this is an insert and it is an identity column)
	select @COLUMNS = @COLUMNS + ''@'' + COLUMN_NAME 
			+ '' as '' 
			+ (case DATA_TYPE when ''numeric'' then DATA_TYPE + ''('' + convert(varchar(10), NUMERIC_PRECISION) + '','' + convert(varchar(10), NUMERIC_SCALE) + '')'' else DATA_TYPE end)
			+ (case when CHARACTER_MAXIMUM_LENGTH is not null then ''('' + case when CONVERT(varchar(10), CHARACTER_MAXIMUM_LENGTH) = ''-1'' then ''max'' else CONVERT(varchar(10), CHARACTER_MAXIMUM_LENGTH) end + '')'' else '''' end)
			+ (case 
				when IS_NULLABLE = ''YES''
					then
						case when COLUMN_DEFAULT is null
							then '' = Null''
							else ''''
						end
					else
						case when COLUMN_DEFAULT is null
							then ''''
							else
								case when COLUMN_NAME = @PK_COLUMN
									then ''''
									else '' = '' + replace(replace(COLUMN_DEFAULT, ''('', ''''), '')'', '''')
								end
						end
				end)
			+ '','' + char(13) 
	from INFORMATION_SCHEMA.COLUMNS
	where TABLE_SCHEMA = @spSchema 
		and TABLE_NAME = @spTable
		and COLUMN_NAME <> @PK_COLUMN
	order by ORDINAL_POSITION
 	
	set @SQL = @SQL + left(@COLUMNS, len(@COLUMNS) - 2) + char(13)
 	
	set @SQL = @SQL + '')'' + char(13)
	set @SQL = @SQL + ''AS'' + char(13)
	set @SQL = @SQL + '''' + char(13)
 	
	-- step 4: add a modifications section
	set @SQL = @SQL + ''-- Author: Auto'' + char(13)
	set @SQL = @SQL + ''-- Created: '' + convert(varchar(11), getdate(), 106) + char(13)
	set @SQL = @SQL + ''-- Function: Inserts a '' + @spSchema + ''.'' + @spTable + '' table record'' + char(13)
	set @SQL = @SQL + '''' + char(13)
	set @SQL = @SQL + ''-- Modifications:'' + char(13)
	set @SQL = @SQL + '''' + char(13)
 	
	-- body here
 	
	-- step 5: begins a transaction
	set @SQL = @SQL + ''begin transaction'' + char(13) + char(13)
 	
 	-- step 6: begin a try
	set @SQL = @SQL + ''begin try'' + char(13) + char(13) 
 	
	set @SQL = @SQL + ''-- insert'' + char(13)
 		
	-- step 7: code the insert
	set @COLUMNS = ''''
 		
	select @COLUMNS = @COLUMNS + ''@'' + COLUMN_NAME + '',''
	from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = @spTable
		and COLUMN_NAME <> @PK_COLUMN
	order by ORDINAL_POSITION
 		
	set @COLUMNS = left(@COLUMNS, len(@COLUMNS) -1) -- trim off the last comma
 		
	set @SQL = @SQL + ''insert 	['' + @spSchema + ''].['' + @spTable + ''] ('' + replace(@COLUMNS, ''@'', '''') + '')'' + char(13)
	set @SQL = @SQL + ''values	('' + @COLUMNS + '')'' + char(13)
	set @SQL = @SQL + char(13) + char(13)
	set @SQL = @SQL + ''-- Return the new ID''  + char(13)
	set @SQL = @SQL + ''select SCOPE_IDENTITY();'' + char(13) + char(13)
 	
 	-- step 8: commit the transaction
	set @SQL = @SQL + ''commit transaction'' + char(13) + char(13)
 	
 	-- step 9: end the try
	set @SQL = @SQL + ''end try'' + char(13) + char(13)
 	
 	-- step 10: begin a catch
	set @SQL = @SQL + ''begin catch'' + char(13) + char(13)  
 	
 	-- step 11: raise the error
	set @SQL = @SQL + ''	declare @ErrorMessage NVARCHAR(4000);'' + char(13)
	set @SQL = @SQL + ''	declare @ErrorSeverity INT;'' + char(13)
	set @SQL = @SQL + ''	declare @ErrorState INT;'' + char(13) + char(13)
	set @SQL = @SQL + ''	select @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE();'' + char(13) + char(13)
	set @SQL = @SQL + ''	raiserror (@ErrorMessage, @ErrorSeverity, @ErrorState);'' + char(13) + char(13)
	set @SQL = @SQL + ''	rollback transaction'' + char(13) + char(13)
 	
 	-- step 11: end the catch
	set @SQL = @SQL + ''end catch;'' + char(13) + char(13)
 	
 	-- step 12: return both the drop and create statements
	RETURN @SQL_DROP + ''||'' + @SQL
 
END
' 
END

GO
/****** Object:  Table [dbo].[tAlumno]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tAlumno]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tAlumno](
	[AlumnoId] [varchar](10) NOT NULL,
	[Alumno] [varchar](200) NOT NULL,
 CONSTRAINT [PK_tAlumno] PRIMARY KEY CLUSTERED 
(
	[AlumnoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tCurso]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tCurso]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tCurso](
	[CursoId] [int] NOT NULL,
	[Curso] [varchar](100) NOT NULL,
	[MateriaId] [varchar](10) NOT NULL,
	[MaestroId] [varchar](10) NOT NULL,
	[GrupoId] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tCurso] PRIMARY KEY CLUSTERED 
(
	[CursoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tGrupo]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tGrupo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tGrupo](
	[GrupoId] [varchar](10) NOT NULL,
	[Grupo] [varchar](50) NULL,
 CONSTRAINT [PK_tGrupo] PRIMARY KEY CLUSTERED 
(
	[GrupoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tMaestro]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tMaestro]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tMaestro](
	[MaestroId] [varchar](10) NOT NULL,
	[Maestro] [varchar](100) NOT NULL,
 CONSTRAINT [PK_tMaestro] PRIMARY KEY CLUSTERED 
(
	[MaestroId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tMateria]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tMateria]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tMateria](
	[MateriaId] [varchar](10) NOT NULL,
	[Materia] [varchar](50) NOT NULL,
	[PlanId] [smallint] NOT NULL,
 CONSTRAINT [PK_tMateria] PRIMARY KEY CLUSTERED 
(
	[MateriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPeriodo]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPeriodo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tPeriodo](
	[PeriodoId] [varchar](10) NOT NULL,
	[Periodo] [varchar](100) NOT NULL,
	[FechaInicio] [smalldatetime] NOT NULL,
	[FechaFin] [smalldatetime] NOT NULL,
	[Activo] [bit] NOT NULL,
	[PlanId] [smallint] NOT NULL,
 CONSTRAINT [PK_tPeriodo] PRIMARY KEY CLUSTERED 
(
	[PeriodoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPlan]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPlan]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tPlan](
	[PlanId] [smallint] NOT NULL,
	[Plan] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tPlan] PRIMARY KEY CLUSTERED 
(
	[PlanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[user_]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[user_]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[user_](
	[u_id] [varchar](10) NOT NULL,
	[u_name] [varchar](50) NOT NULL,
	[pw] [varchar](10) NOT NULL,
 CONSTRAINT [PK_user_] PRIMARY KEY CLUSTERED 
(
	[u_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tAlumno] ([AlumnoId], [Alumno]) VALUES (N'1243176', N'ACOSTA GUEVARA CAROLINA BRISEIDI')
INSERT [dbo].[tGrupo] ([GrupoId], [Grupo]) VALUES (N'1011B', N'1011B')
INSERT [dbo].[tMaestro] ([MaestroId], [Maestro]) VALUES (N'16556', N'MIRNA ELIZABETH SANTOS LARA TESTING')
INSERT [dbo].[tMateria] ([MateriaId], [Materia], [PlanId]) VALUES (N'014', N'ALIMENTACION INSTITUCIONAL', 6)
INSERT [dbo].[tPeriodo] ([PeriodoId], [Periodo], [FechaInicio], [FechaFin], [Activo], [PlanId]) VALUES (N'ss', N'S', CAST(N'2016-11-09 15:28:00' AS SmallDateTime), CAST(N'2016-11-25 15:28:00' AS SmallDateTime), 1, 6)
INSERT [dbo].[tPeriodo] ([PeriodoId], [Periodo], [FechaInicio], [FechaFin], [Activo], [PlanId]) VALUES (N'test', N'TEST', CAST(N'2016-11-09 14:53:00' AS SmallDateTime), CAST(N'2016-11-24 14:53:00' AS SmallDateTime), 1, 4)
INSERT [dbo].[tPeriodo] ([PeriodoId], [Periodo], [FechaInicio], [FechaFin], [Activo], [PlanId]) VALUES (N'TEST2', N'TEST3', CAST(N'2016-11-09 15:06:00' AS SmallDateTime), CAST(N'2016-11-26 15:06:00' AS SmallDateTime), 1, 6)
INSERT [dbo].[tPeriodo] ([PeriodoId], [Periodo], [FechaInicio], [FechaFin], [Activo], [PlanId]) VALUES (N'TEST3', N'TEST3', CAST(N'2016-11-09 15:08:00' AS SmallDateTime), CAST(N'2016-11-30 15:08:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[tPeriodo] ([PeriodoId], [Periodo], [FechaInicio], [FechaFin], [Activo], [PlanId]) VALUES (N'test5', N'TEST5', CAST(N'2016-11-01 14:53:00' AS SmallDateTime), CAST(N'2016-12-31 14:53:00' AS SmallDateTime), 1, 3)
INSERT [dbo].[tPlan] ([PlanId], [Plan]) VALUES (1, N'Semanal')
INSERT [dbo].[tPlan] ([PlanId], [Plan]) VALUES (2, N'Mensual')
INSERT [dbo].[tPlan] ([PlanId], [Plan]) VALUES (3, N'Bimestral')
INSERT [dbo].[tPlan] ([PlanId], [Plan]) VALUES (4, N'Tetramestral')
INSERT [dbo].[tPlan] ([PlanId], [Plan]) VALUES (5, N'Semestral')
INSERT [dbo].[tPlan] ([PlanId], [Plan]) VALUES (6, N'Anual')
INSERT [dbo].[user_] ([u_id], [u_name], [pw]) VALUES (N'admin', N'adminstrator', N'123456')
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tCurso]    Script Date: 10-11-2016 07:06:45 p. m. ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[tCurso]') AND name = N'IX_tCurso')
CREATE UNIQUE NONCLUSTERED INDEX [IX_tCurso] ON [dbo].[tCurso]
(
	[MateriaId] ASC,
	[MaestroId] ASC,
	[GrupoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tCurso_tGrupo]') AND parent_object_id = OBJECT_ID(N'[dbo].[tCurso]'))
ALTER TABLE [dbo].[tCurso]  WITH CHECK ADD  CONSTRAINT [FK_tCurso_tGrupo] FOREIGN KEY([GrupoId])
REFERENCES [dbo].[tGrupo] ([GrupoId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tCurso_tGrupo]') AND parent_object_id = OBJECT_ID(N'[dbo].[tCurso]'))
ALTER TABLE [dbo].[tCurso] CHECK CONSTRAINT [FK_tCurso_tGrupo]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tCurso_tMaestro]') AND parent_object_id = OBJECT_ID(N'[dbo].[tCurso]'))
ALTER TABLE [dbo].[tCurso]  WITH CHECK ADD  CONSTRAINT [FK_tCurso_tMaestro] FOREIGN KEY([MaestroId])
REFERENCES [dbo].[tMaestro] ([MaestroId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tCurso_tMaestro]') AND parent_object_id = OBJECT_ID(N'[dbo].[tCurso]'))
ALTER TABLE [dbo].[tCurso] CHECK CONSTRAINT [FK_tCurso_tMaestro]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tCurso_tMateria]') AND parent_object_id = OBJECT_ID(N'[dbo].[tCurso]'))
ALTER TABLE [dbo].[tCurso]  WITH CHECK ADD  CONSTRAINT [FK_tCurso_tMateria] FOREIGN KEY([MateriaId])
REFERENCES [dbo].[tMateria] ([MateriaId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tCurso_tMateria]') AND parent_object_id = OBJECT_ID(N'[dbo].[tCurso]'))
ALTER TABLE [dbo].[tCurso] CHECK CONSTRAINT [FK_tCurso_tMateria]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tMateria_tPlan]') AND parent_object_id = OBJECT_ID(N'[dbo].[tMateria]'))
ALTER TABLE [dbo].[tMateria]  WITH CHECK ADD  CONSTRAINT [FK_tMateria_tPlan] FOREIGN KEY([PlanId])
REFERENCES [dbo].[tPlan] ([PlanId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tMateria_tPlan]') AND parent_object_id = OBJECT_ID(N'[dbo].[tMateria]'))
ALTER TABLE [dbo].[tMateria] CHECK CONSTRAINT [FK_tMateria_tPlan]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tPeriodo_tPlan]') AND parent_object_id = OBJECT_ID(N'[dbo].[tPeriodo]'))
ALTER TABLE [dbo].[tPeriodo]  WITH CHECK ADD  CONSTRAINT [FK_tPeriodo_tPlan] FOREIGN KEY([PlanId])
REFERENCES [dbo].[tPlan] ([PlanId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tPeriodo_tPlan]') AND parent_object_id = OBJECT_ID(N'[dbo].[tPeriodo]'))
ALTER TABLE [dbo].[tPeriodo] CHECK CONSTRAINT [FK_tPeriodo_tPlan]
GO
/****** Object:  StoredProcedure [dbo].[proctAlumnoDelete]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctAlumnoDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctAlumnoDelete] AS' 
END
GO
ALTER PROC [dbo].[proctAlumnoDelete]	@AlumnoId varchar(10)ASSET NOCOUNT ONDELETE FROM tAlumnoWHERE [AlumnoId] = @AlumnoIdSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctAlumnoList]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctAlumnoList]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctAlumnoList] AS' 
END
GO
ALTER PROC [dbo].[proctAlumnoList]ASSET NOCOUNT ONSELECT [AlumnoId], 	[Alumno]FROM tAlumnoSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctAlumnoSelect]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctAlumnoSelect]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctAlumnoSelect] AS' 
END
GO

ALTER PROC [dbo].[proctAlumnoSelect]	@AlumnoId varchar(10)ASSET NOCOUNT ONSELECT [AlumnoId], 	[Alumno]FROM tAlumnoWHERE [AlumnoId] = @AlumnoIdSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctAlumnoUpdate]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctAlumnoUpdate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctAlumnoUpdate] AS' 
END
GO
ALTER PROC [dbo].[proctAlumnoUpdate]	@AlumnoId varchar(10),	@Alumno varchar(200)ASSET NOCOUNT ONIF NOT EXISTS(SELECT TOP 1 AlumnoId FROM tAlumno WHERE AlumnoId=@AlumnoId) BEGIN	INSERT INTO tAlumno (		[AlumnoId],		[Alumno]	)	VALUES (		@AlumnoId,		@Alumno	)ENDELSE BEGIN	UPDATE tAlumno SET 		[Alumno] = @Alumno	WHERE [AlumnoId] = @AlumnoIdENDSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctCursoDelete]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctCursoDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctCursoDelete] AS' 
END
GO
ALTER PROC [dbo].[proctCursoDelete]	@CursoId intASSET NOCOUNT ONDELETE FROM tCursoWHERE [CursoId] = @CursoIdSET NOCOUNT OFF

GO
/****** Object:  StoredProcedure [dbo].[proctCursoList]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctCursoList]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctCursoList] AS' 
END
GO
ALTER PROC [dbo].[proctCursoList]ASSET NOCOUNT ONSELECT [CursoId], 	[Curso], 	[MateriaId], 	[MaestroId], 	[GrupoId]FROM tCursoSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctCursoSelect]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctCursoSelect]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctCursoSelect] AS' 
END
GO

ALTER PROC [dbo].[proctCursoSelect]	@CursoId intASSET NOCOUNT ONSELECT [CursoId], 	[Curso], 	[MateriaId], 	[MaestroId], 	[GrupoId]FROM tCursoWHERE [CursoId] = @CursoIdSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctCursoUpdate]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctCursoUpdate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctCursoUpdate] AS' 
END
GO
ALTER PROC [dbo].[proctCursoUpdate]	@CursoId int,	@Curso varchar(100),	@MateriaId varchar(10),	@MaestroId varchar(10),	@GrupoId varchar(10)ASSET NOCOUNT ONIF NOT EXISTS(SELECT TOP 1 CursoId FROM tCurso WHERE CursoId=@CursoId) BEGIN	INSERT INTO tCurso (		[Curso],		[MateriaId],		[MaestroId],		[GrupoId]	)	VALUES (		@Curso,		@MateriaId,		@MaestroId,		@GrupoId	)ENDELSE BEGIN	UPDATE tCurso SET 		[Curso] = @Curso,		[MateriaId] = @MateriaId,		[MaestroId] = @MaestroId,		[GrupoId] = @GrupoId	WHERE [CursoId] = @CursoIdENDSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctGrupoDelete]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctGrupoDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctGrupoDelete] AS' 
END
GO
ALTER PROC [dbo].[proctGrupoDelete]	@GrupoId varchar(10)ASSET NOCOUNT ONDELETE FROM tGrupoWHERE [GrupoId] = @GrupoIdSET NOCOUNT OFF

GO
/****** Object:  StoredProcedure [dbo].[proctGrupoList]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctGrupoList]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctGrupoList] AS' 
END
GO
ALTER PROC [dbo].[proctGrupoList]ASSET NOCOUNT ONSELECT [GrupoId], 	[Grupo]FROM tGrupoSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctGrupoSelect]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctGrupoSelect]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctGrupoSelect] AS' 
END
GO

ALTER PROC [dbo].[proctGrupoSelect]	@GrupoId varchar(10)ASSET NOCOUNT ONSELECT [GrupoId], 	[Grupo]FROM tGrupoWHERE [GrupoId] = @GrupoIdSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctGrupoUpdate]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctGrupoUpdate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctGrupoUpdate] AS' 
END
GO

ALTER PROC [dbo].[proctGrupoUpdate]	@GrupoId varchar(10),	@Grupo varchar(50)ASSET NOCOUNT ONIF NOT EXISTS(SELECT TOP 1 GrupoId FROM tGrupo WHERE GrupoId=@GrupoId) BEGIN	INSERT INTO tGrupo (		[GrupoId],		[Grupo]	)	VALUES (		@GrupoId,		@Grupo	)ENDELSE BEGIN	UPDATE tGrupo SET 		[Grupo] = @Grupo	WHERE [GrupoId] = @GrupoIdENDSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctMaestroDelete]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMaestroDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctMaestroDelete] AS' 
END
GO

ALTER PROC [dbo].[proctMaestroDelete]	@MaestroId varchar(10)ASSET NOCOUNT ONDELETE FROM tMaestroWHERE [MaestroId] = @MaestroIdSET NOCOUNT OFF

GO
/****** Object:  StoredProcedure [dbo].[proctMaestroList]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMaestroList]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctMaestroList] AS' 
END
GO
ALTER PROC [dbo].[proctMaestroList]
AS
SET NOCOUNT ON

SELECT [MaestroId], 
	[Maestro]
FROM tMaestro
order by MaestroId


SET NOCOUNT OFF

GO
/****** Object:  StoredProcedure [dbo].[proctMaestroSearchId]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMaestroSearchId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctMaestroSearchId] AS' 
END
GO
ALTER PROC [dbo].[proctMaestroSearchId]
	@MaestroId varchar(10)
AS
SET NOCOUNT ON

SELECT [MaestroId], 
	[Maestro]
FROM tMaestro
WHERE [MaestroId]  like '%'+@MaestroId+'%'
order by MaestroId

SET NOCOUNT OFF

GO
/****** Object:  StoredProcedure [dbo].[proctMaestroSearchName]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMaestroSearchName]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctMaestroSearchName] AS' 
END
GO
ALTER PROC [dbo].[proctMaestroSearchName]
	@Maestro varchar(50)
AS
SET NOCOUNT ON

SELECT [MaestroId], 
	[Maestro]
FROM tMaestro
WHERE [Maestro]  like '%'+@Maestro+'%'
order by Maestro

SET NOCOUNT OFF

GO
/****** Object:  StoredProcedure [dbo].[proctMaestroSelect]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMaestroSelect]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctMaestroSelect] AS' 
END
GO
ALTER PROC [dbo].[proctMaestroSelect]	@MaestroId varchar(10)ASSET NOCOUNT ONSELECT [MaestroId], 	[Maestro]FROM tMaestroWHERE [MaestroId] = @MaestroIdSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctMaestroUpdate]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMaestroUpdate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctMaestroUpdate] AS' 
END
GO

ALTER PROC [dbo].[proctMaestroUpdate]	@MaestroId varchar(10),	@Maestro varchar(100)ASSET NOCOUNT ONIF NOT EXISTS(SELECT TOP 1 MaestroId FROM tMaestro WHERE MaestroId=@MaestroId) BEGIN	INSERT INTO tMaestro (		[MaestroId],		[Maestro]	)	VALUES (		@MaestroId,		@Maestro	)ENDELSE BEGIN	UPDATE tMaestro SET 		[Maestro] = @Maestro	WHERE [MaestroId] = @MaestroIdENDSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctMateriaDelete]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMateriaDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctMateriaDelete] AS' 
END
GO
ALTER PROC [dbo].[proctMateriaDelete]	@MateriaId varchar(10)ASSET NOCOUNT ONDELETE FROM tMateriaWHERE [MateriaId] = @MateriaIdSET NOCOUNT OFF

GO
/****** Object:  StoredProcedure [dbo].[proctMateriaList]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMateriaList]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctMateriaList] AS' 
END
GO
ALTER PROC [dbo].[proctMateriaList]ASSET NOCOUNT ONSELECT [MateriaId], 	[Materia], 	M.[PlanId],	[Plan]FROM tMateria MINNER JOIN tPlan   P	ON P.PlanId=M.PlanIdSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctMateriaSearch]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMateriaSearch]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctMateriaSearch] AS' 
END
GO

ALTER PROC [dbo].[proctMateriaSearch]
	@Materia varchar(10)
AS
SET NOCOUNT ON

SELECT [MateriaId], 
	[Materia], 
	[PlanId]
FROM tMateria
WHERE [Materia] LIKE '%'+ @Materia +'%'


GO
/****** Object:  StoredProcedure [dbo].[proctMateriaSelect]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMateriaSelect]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctMateriaSelect] AS' 
END
GO

ALTER PROC [dbo].[proctMateriaSelect]	@MateriaId varchar(10)ASSET NOCOUNT ONSELECT [MateriaId], 	[Materia], 	[PlanId]FROM tMateriaWHERE [MateriaId] = @MateriaId
GO
/****** Object:  StoredProcedure [dbo].[proctMateriaUpdate]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctMateriaUpdate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctMateriaUpdate] AS' 
END
GO

ALTER PROC [dbo].[proctMateriaUpdate]	@MateriaId varchar(10),	@Materia varchar(50),	@PlanId smallintASSET NOCOUNT ONIF NOT EXISTS(SELECT TOP 1 MateriaId FROM tMateria WHERE MateriaId=@MateriaId) BEGIN	INSERT INTO tMateria (		[MateriaId],		[Materia],		[PlanId]	)	VALUES (		@MateriaId,		@Materia,		@PlanId	)ENDELSE BEGIN	UPDATE tMateria SET 		[Materia] = @Materia,		[PlanId] = @PlanId	WHERE [MateriaId] = @MateriaIdENDSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctPeriodoDelete]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctPeriodoDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctPeriodoDelete] AS' 
END
GO

ALTER PROC [dbo].[proctPeriodoDelete]	@PeriodoId varchar(10)ASSET NOCOUNT ONDELETE FROM tPeriodoWHERE [PeriodoId] = @PeriodoIdSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctPeriodoList]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctPeriodoList]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctPeriodoList] AS' 
END
GO
ALTER PROC [dbo].[proctPeriodoList]
AS
SET NOCOUNT ON

SELECT [PeriodoId], 
	[Periodo], 
	[FechaInicio], 
	[FechaFin], 
	[Activo], 
	per.[PlanId],
	pl.[Plan]
FROM tPeriodo per
inner join tPlan pl
	on pl.PlanId=per.PlanId

SET NOCOUNT OFF

GO
/****** Object:  StoredProcedure [dbo].[proctPeriodoSelect]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctPeriodoSelect]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctPeriodoSelect] AS' 
END
GO
ALTER PROC [dbo].[proctPeriodoSelect]	@PeriodoId varchar(10)ASSET NOCOUNT ONSELECT [PeriodoId], 	[Periodo], 	[FechaInicio], 	[FechaFin], 	[Activo], 	[PlanId]FROM tPeriodoWHERE [PeriodoId] = @PeriodoIdSET NOCOUNT OFF
GO
/****** Object:  StoredProcedure [dbo].[proctPeriodoUpdate]    Script Date: 10-11-2016 07:06:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proctPeriodoUpdate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proctPeriodoUpdate] AS' 
END
GO
ALTER PROC [dbo].[proctPeriodoUpdate]

	@PeriodoId varchar(10),
	@Periodo varchar(100),
	@FechaInicio smalldatetime,
	@FechaFin smalldatetime,
	@Activo bit,
	@PlanId smallint
AS
SET NOCOUNT ON
IF NOT EXISTS(SELECT TOP 1 PeriodoId FROM tPeriodo WHERE PeriodoId=@PeriodoId)
 BEGIN
	INSERT INTO tPeriodo (
		[PeriodoId],
		[Periodo],
		[FechaInicio],
		[FechaFin],
		[Activo],
		[PlanId]
	)
	VALUES (
		@PeriodoId,
		@Periodo,
		@FechaInicio,
		@FechaFin,
		@Activo,
		@PlanId
	)
END
ELSE BEGIN
	UPDATE tPeriodo SET 
		[Periodo] = @Periodo,
		[FechaInicio] = @FechaInicio,
		[FechaFin] = @FechaFin,
		[Activo] = @Activo,
		[PlanId] = @PlanId
	WHERE [PeriodoId] = @PeriodoId

END

SET NOCOUNT OFF

GO
USE [master]
GO
ALTER DATABASE [MODULO62016] SET  READ_WRITE 
GO
