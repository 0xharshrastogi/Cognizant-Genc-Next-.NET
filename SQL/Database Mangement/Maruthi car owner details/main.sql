SELECT owners.owner_id, owner_name, address, phone_no
FROM owners, cars
WHERE owners.owner_id=cars.owner_id AND car_name LIKE "Maruthi%"
ORDER BY owner_id;