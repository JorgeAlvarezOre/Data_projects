# PIZZA SALES REPORT (SQL + Power BI project)

## Intro
We have a year of sales data of a Pizza Store with fields like 'pizza name', 'quantity', 'order price', 'order date and time', etc.
We need to analyze the Key Performance Indicators (KPI) and some charts of the store to gain insights of our business Performance and understand key trends.

## Data
We have a \*.CSV file with every sale of the year divided as follows.
![Csv presentation](Images_README.md/01_CSV.jpg)

## KPIs
1. **Total revenue:** The sum of total price of all pizza
2. **Average order value:** The average amount spent per order calculated by dividing the total revenue by the total number of orders.
3. **Total pizzas sold:** The sum of the quantities of all pizzas sold.
4. **Total orders:** The total number of orders placed.
5. **Average pizzas per orders:** The average number of pizzas sold per order, calculated by dividing the total number of pizzas sold by the total number of orders.

## Charts requirement
6. **Daily trend for total orders:** Bar chart that will help us identify any patterns or fluctuations in order volumes on a daily basis.
7. **Monthy trend for total orders:** Line chart that will allow us to identify peak hours or periods of high order activity.
8. **Percentage of sales by pizza category:** Pie chart will provide insights into the popularity of various pizza categories and the contribution to overall sales.
9. **Percentage of sales by pizza size:** Pie chart that will help us understand customer preferences for pizza sizes and their impact on sales.
10. **Total pizzas sold by pizza category:** Funnel chart that will allow us to compare the sales performance of different pizza categories.
11. **Top 5 best sellers by revenue, total quantity and total orders:** Bar chart that will help us identify the most popular pizza options.
12. **Bottom 5 best sellers by revenue, total quantity and total orders:** Bar chart that will help us identify the less popular pizza options.

## SQL Queries
1. **Total revenue:**<br>
![SQL 1](Images_README.md/02_SQL_1.jpg)

2. **Average order value:**<br>
![SQL 2](Images_README.md/03_SQL_2.jpg)

3. **Total pizzas sold:**<br>
![SQL 3](Images_README.md/04_SQL_3.jpg)

4. **Total orders:**<br>
![SQL 4](Images_README.md/05_SQL_4.jpg)

5. **Average pizzas per orders:**<br>
![SQL 5](Images_README.md/06_SQL_5.jpg)

6. **Daily trend for total orders:**<br>
![SQL 6](Images_README.md/07_SQL_6.jpg)

7. **Monthy trend for total orders:**<br>
![SQL 7](Images_README.md/08_SQL_7.jpg)

8. **Percentage of sales by pizza category:**<br>
![SQL 8](Images_README.md/09_SQL_8.jpg)

9. **Percentage of sales by pizza size:**<br>
![SQL 9](Images_README.md/10_SQL_9.jpg)

10. **Total pizzas sold by pizza category:**<br>
![SQL 10](Images_README.md/11_SQL_10.jpg)

11. **Top 5 best sellers by revenue, total quantity and total orders:**<br>
Top 5 Pizzas by Revenue<br>
![SQL 11](Images_README.md/12_SQL_11.jpg)<br><br>
Top 5 Pizzas by Quantity<br>
![SQL 12](Images_README.md/13_SQL_12.jpg)<br><br>
Top 5 Pizzas by Total Orders<br>
![SQL 13](Images_README.md/14_SQL_13.jpg)<br><br>

12. **Bottom 5 best sellers by revenue, total quantity and total orders:**<br>
Bottom 5 Pizzas by Revenue<br>
![SQL 14](Images_README.md/15_SQL_14.jpg)<br><br>
Bottom 5 Pizzas by Quantity<br>
![SQL 15](Images_README.md/16_SQL_15.jpg)<br><br>
Bottom 5 Pizzas by Total Orders<br>
![SQL 16](Images_README.md/17_SQL_16.jpg)<br><br>

13. **Bonus:**<br>
If you want to apply the pizza_category or pizza_size filters to the above queries you can use WHERE clause. Example:<br>
![SQL 17](Images_README.md/18_SQL_17.jpg)<br><br>

## Power BI dashboard
[![Power BI preview](Images_README.md/19_Power_BI_preview.jpg)](https://app.powerbi.com/view?r=eyJrIjoiNWZkOTRhZGQtODgyYS00Zjc0LThlMGItMmIyOTE2NjJjMTVhIiwidCI6IjgzZGMwYzk0LWRkNTgtNDlmNC05YmI0LTU4NDhjMWM3NmYzYyJ9)
