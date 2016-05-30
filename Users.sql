USE [master]
GO
CREATE LOGIN [ANA\Diretor] FROM WINDOWS WITH DEFAULT_DATABASE=[master]
GO
ALTER SERVER ROLE [bulkadmin] ADD MEMBER [ANA\Diretor]
GO
USE [DB_Escola]
GO
CREATE USER [ANA\Diretor] FOR LOGIN [ANA\Diretor]
GO
USE [DB_Escola]
GO
ALTER ROLE [db_owner] ADD MEMBER [ANA\Diretor]
GO
USE [master]
GO
CREATE LOGIN [ANA\Secretario] FROM WINDOWS WITH DEFAULT_DATABASE=[master]
GO
ALTER SERVER ROLE [bulkadmin] ADD MEMBER [ANA\Secretario]
GO
USE [DB_Escola]
GO
CREATE USER [ANA\Secretario] FOR LOGIN [ANA\Secretario]
GO
USE [master]
GO
CREATE LOGIN [ANA\Professor] FROM WINDOWS WITH DEFAULT_DATABASE=[master]
GO
USE [DB_Escola]
GO
CREATE USER [ANA\Professor] FOR LOGIN [ANA\Professor]
GO
