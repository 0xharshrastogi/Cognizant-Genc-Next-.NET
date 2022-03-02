SELECT
  CONCAT(owners.owner_name, owners.owner_id) AS USERNAME,
  CONCAT(LEFT(owners.owner_name, 3), owners.owner_id) AS PASSWORD
FROM owners
ORDER BY USERNAME;