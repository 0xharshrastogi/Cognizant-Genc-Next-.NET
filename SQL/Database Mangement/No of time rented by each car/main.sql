SELECT cars.car_id, count(*) AS NO_OF_TRIPS 
FROM cars, rentals
WHERE cars.car_id=rentals.car_id
GROUP BY rentals.car_id
ORDER BY cars.car_id;
