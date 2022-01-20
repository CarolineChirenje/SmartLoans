-- TRUNCATE TABLE [dbo].[RolePermissions]

SELECT TOP 1 * FROM Permissions 
SELECT TOP 1 * FROM RolePermissions 

INSERT INTO  RolePermissions
SELECT GETDATE(),'SuperUser', PermissionID,1
FROM Permissions

SELECT * FROM RolePermissions 