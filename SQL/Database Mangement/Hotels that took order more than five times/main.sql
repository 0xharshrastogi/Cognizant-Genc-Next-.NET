SELECT hotel_details.hotel_id, hotel_name, count(*) AS NO_OF_ORDERS
FROM hotel_details, orders
WHERE hotel_details.hotel_id=orders.hotel_id
GROUP BY orders.hotel_id
HAVING count(*) > 5
ORDER BY hotel_details.hotel_id;