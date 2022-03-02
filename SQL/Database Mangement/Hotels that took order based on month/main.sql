SELECT DISTINCT hotel_details.hotel_id, hotel_name, rating
FROM hotel_details, orders
WHERE hotel_details.hotel_id = orders.hotel_id AND MONTH(orders.order_date)=7
ORDER BY hotel_details.hotel_id;