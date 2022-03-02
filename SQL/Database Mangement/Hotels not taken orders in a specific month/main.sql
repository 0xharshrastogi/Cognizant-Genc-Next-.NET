SELECT hotel_id, hotel_name, hotel_type
FROM hotel_details
WHERE hotel_id NOT IN (SELECT hotel_id
FROM orders
WHERE EXTRACT(YEAR_MONTH FROM order_date)='201905'
GROUP BY hotel_id)
ORDER BY hotel_id;