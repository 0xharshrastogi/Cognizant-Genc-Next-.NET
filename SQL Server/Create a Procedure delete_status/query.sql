CREATE PROCEDURE delete_status
  @status_id INT
AS
BEGIN
  IF NOT EXISTS(SELECT *
  FROM
    claims
  WHERE
    status_id=@status_id)
  BEGIN
    DELETE FROM [status]
      WHERE id=@status_id
  END
  ELSE 
  BEGIN
    INSERT INTO [status_error_log]
    VALUES
      ('child records existing in claims table')
  END
END
GO