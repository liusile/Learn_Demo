##Êı¾İ¿âÇ¨ÒÆÃüÁî£º
Enable-Migrations -ContextTypeName Domain.ApplicationDbContext
Add-Migration InitialCreate
Update-Database -Verbose
update-database -script
Update-Database -Script -SourceMigration