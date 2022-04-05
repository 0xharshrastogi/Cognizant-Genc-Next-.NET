CREATE PROC EmployeeCount
  @deptno NVARCHAR(20),
  @total_employees INT OUT
AS
BEGIN
  SELECT
    @total_employees = count(*)
  FROM
    employee
  WHERE 
    workdept=@deptno
END
GO