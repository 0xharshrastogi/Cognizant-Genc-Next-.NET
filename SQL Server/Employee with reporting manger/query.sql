SELECT
  CONCAT(E.lastname, " works for ", M.lastname) [Hierarchy]
FROM
  Employee E
  JOIN Department D
  ON E.workdept = D.deptno
  JOIN Employee M
  ON D.mgrno = M.empno AND E.empno != M.empno
ORDER BY
  E.lastname
GO 
