-- select * from pizza_sales
-- SELECT SUM(total_price) AS Total_revenue from pizza_sales
-- SELECT SUM(total_price) / COUNT(DISTINCT order_id) AS Avg_Order_Value from pizza_sales
-- SELECT SUM(quantity) AS Total_pizza_sold FROM pizza_sales
-- SELECT COUNT(DISTINCT order_id) AS Total_orders FROM pizza_sales
-- SELECT CAST(CAST(SUM(quantity) AS DECIMAL(10,2)) / CAST(COUNT(DISTINCT order_id) AS DECIMAL(10,2)) AS DECIMAL(10,2)) AS Avg_pizzas_per_orders FROM pizza_sales
-- SELECT DATENAME(DW,order_date) AS order_day, COUNT(DISTINCT order_id) AS Total_orders FROM pizza_sales GROUP BY DATENAME(DW,order_date)
-- SELECT DATENAME(MONTH,order_date) AS Month_name, COUNT(DISTINCT order_id) AS Total_orders FROM pizza_sales GROUP BY DATENAME(MONTH,order_date) ORDER BY Total_orders DESC
-- SELECT pizza_category, SUM(Total_price) AS Total_sales, SUM(total_price) * 100 / (SELECT SUM(Total_price) FROM pizza_sales) AS PCT FROM pizza_sales AS Total_sales GROUP BY pizza_category
-- SELECT pizza_category, SUM(Total_price) AS Total_sales, SUM(total_price) * 100 / (SELECT SUM(Total_price) FROM pizza_sales WHERE MONTH(order_date) = 1) AS PCT FROM pizza_sales AS Total_sales WHERE MONTH(order_date) = 1 GROUP BY pizza_category
-- SELECT pizza_category, SUM(quantity) as Total_Quantity_Sold FROM pizza_sales GROUP BY pizza_category ORDER BY Total_Quantity_Sold DESC
-- SELECT pizza_size, CAST(SUM(Total_price) AS DECIMAL(10,2)) AS Total_sales, CAST(SUM(total_price) * 100 / (SELECT SUM(Total_price) FROM pizza_sales) AS DECIMAL(10,2)) AS PCT FROM pizza_sales AS Total_sales GROUP BY pizza_size ORDER BY PCT DESC
-- SELECT pizza_size, CAST(SUM(Total_price) AS DECIMAL(10,2)) AS Total_sales, CAST(SUM(total_price) * 100 / (SELECT SUM(Total_price) FROM pizza_sales WHERE DATEPART(QUARTER, order_date)=1) AS DECIMAL(10,2)) AS PCT FROM pizza_sales AS Total_sales WHERE DATEPART(QUARTER, order_date)=1 GROUP BY pizza_size ORDER BY PCT DESC
-- SELECT TOP 5 pizza_name, SUM(total_price) AS Total_revenue FROM pizza_sales GROUP BY pizza_name ORDER BY Total_revenue DESC
-- SELECT TOP 5 pizza_name, SUM(total_price) AS Total_revenue FROM pizza_sales GROUP BY pizza_name ORDER BY Total_revenue ASC
-- SELECT TOP 5 pizza_name, SUM(quantity) AS Total_quantity FROM pizza_sales GROUP BY pizza_name ORDER BY Total_quantity DESC
-- SELECT TOP 5 pizza_name, SUM(quantity) AS Total_quantity FROM pizza_sales GROUP BY pizza_name ORDER BY Total_quantity ASC
-- SELECT TOP 5 pizza_name, COUNT(DISTINCT order_id) AS Total_orders FROM pizza_sales GROUP BY pizza_name ORDER BY Total_orders DESC
-- SELECT TOP 5 pizza_name, COUNT(DISTINCT order_id) AS Total_orders FROM pizza_sales GROUP BY pizza_name ORDER BY Total_orders ASC

SELECT pizza_category, SUM(Total_price) AS Total_sales, SUM(total_price) * 100 /
(SELECT SUM(Total_price) FROM pizza_sales WHERE MONTH(order_date) = 1) AS PCT
FROM pizza_sales AS Total_sales WHERE MONTH(order_date) = 1 GROUP BY pizza_category