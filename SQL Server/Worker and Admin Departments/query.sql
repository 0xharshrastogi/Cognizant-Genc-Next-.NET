SELECT
  D.deptname [Worker Department],
  D.Location,
  MD.deptname [Manager Department]
FROM
  Department D
  JOIN Department MD
  ON D.admrdept = MD.deptno AND D.deptno != D.admrdept
ORDER BY 
  [Worker Department]
GO