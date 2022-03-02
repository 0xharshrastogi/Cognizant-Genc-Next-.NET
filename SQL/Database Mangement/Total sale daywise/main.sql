SELECT order_date, SUM(order_amount)
FROM orders
GROUP BY order_date
ORDER BY order_date;