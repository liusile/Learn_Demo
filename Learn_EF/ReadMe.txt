##���ݿ�Ǩ�����
Enable-Migrations -ContextTypeName Domain.ApplicationDbContext
Add-Migration InitialCreate
Update-Database -Verbose
update-database -script
Update-Database -Script -SourceMigration