SELECT partner_id, partner_name, phone_no
FROM Delivery_partners
WHERE rating BETWEEN 3 AND 5
ORDER BY partner_id;