SELECT car_id, car_name, car_type
FROM cars
WHERE car_id NOT IN (SELECT DISTINCT car_id
FROM rentals)
ORDER BY car_id;