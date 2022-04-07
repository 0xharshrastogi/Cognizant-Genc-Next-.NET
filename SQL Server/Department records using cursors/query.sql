-------- Creating Cursor-------------
DECLARE dbcursor CURSOR 
FOR SELECT
  deptname, COUNT(*)
FROM
  Employee E,
  Department D
WHERE
    E.workdept=D.deptno
GROUP BY 
    deptname
HAVING 
      COUNT(workdept) > 1
ORDER BY 
      deptname
-------- Cursor Created-------------

DECLARE @name NVARCHAR(36)
DECLARE @count INT

OPEN dbcursor

FETCH NEXT FROM dbcursor INTO @name, @count

WHILE @@FETCH_STATUS=0
BEGIN
  PRINT CONCAT(@name, ' department has ', @count, ' employees')
  FETCH NEXT FROM dbcursor INTO @name, @count
END

CLOSE dbcursor
DEALLOCATE dbcursor
GO