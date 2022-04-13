CREATE trigger claim_audits 
ON claims 
AFTER INSERT
AS
BEGIN
  INSERT INTO claim_audit
  SELECT CT.first_name, SUM(C.amount_of_claim), 'Updated customer claimed amount'
  FROM claims C
    JOIN customer_policy CP
    ON C.customer_policy_id=CP.id
    JOIN customer CT
    ON CP.customer_id=CT.id
  WHERE 
    C.customer_policy_id IN (SELECT customer_policy_id
  FROM inserted)
  GROUP BY CT.first_name
END
GO