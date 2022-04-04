CREATE PROCEDURE AvailableDepartments
AS
BEGIN
  SELECT
    deptname [Name]
  FROM
    Department
END
GO