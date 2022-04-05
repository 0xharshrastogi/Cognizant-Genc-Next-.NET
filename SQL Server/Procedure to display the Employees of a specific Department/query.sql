CREATE PROC EmployeesDept(@DeptNo NVARCHAR(3))
AS
BEGIN
  SELECT
    lastname [Name]
  FROM
    Employee
  WHERE
    workdept=@DeptNo
END
GO