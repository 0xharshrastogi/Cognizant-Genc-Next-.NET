SELECT rental_id, car_id, customer_id, km_driven
FROM rentals
WHERE EXTRACT(YEAR_MONTH FROM pickup_date)="201908"
ORDER BY rental_id;