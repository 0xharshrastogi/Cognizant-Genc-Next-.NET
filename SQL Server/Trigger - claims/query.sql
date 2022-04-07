CREATE trigger claim_audits
ON claims
AFTER INSERT
AS
BEGIN
  INSERT INTO [claim_audit]
  SELECT
    C.first_name,
    SUM(I.amount_of_claim),
    'Updated customer claimed amount'
  FROM Inserted I
    JOIN [customer_policy] CP
    ON I.customer_policy_id=CP.ID
    JOIN [customer] C
    ON CP.customer_id=C.id
  GROUP BY C.first_name
END
GO

SELECT
  C.id,
  C.first_name,
  SUM(amount_of_claim) amount_of_claim
FROM
  customer C
  JOIN customer_policy CP
  ON CP.customer_id=C.id
  JOIN claims CL
  ON CL.customer_policy_id=CP.id
GROUP BY 
    C.id, C.first_name
GO

SELECT SUM(amount_of_claim)
FROM claims
GROUP BY id
