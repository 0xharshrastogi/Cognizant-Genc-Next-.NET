SELECT
  E.firstname,
  E.lastname,
  E.salary
FROM
  Employee E,
  Department D
WHERE
  E.workdept = D.deptno
  AND D.location="New York"
ORDER BY
  firstname
GO