SELECT orders.order_id, customer_name, hotel_name, order_amount
FROM orders, customers, hotel_details
WHERE customers.customer_id=orders.customer_id AND orders.hotel_id=hotel_details.hotel_id
ORDER BY orders.order_id;