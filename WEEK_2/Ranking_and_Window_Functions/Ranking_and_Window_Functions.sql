USE ShopDB;
DELETE FROM Products;
INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Laptop', 'Electronics', 75000),
(2, 'Mobile', 'Electronics', 30000),
(3, 'Tablet', 'Electronics', 25000),
(4, 'Fridge', 'Appliances', 45000),
(5, 'Oven', 'Appliances', 15000),
(6, 'AC', 'Appliances', 35000),
(7, 'Shoes', 'Fashion', 4000),
(8, 'Jacket', 'Fashion', 3000),
(9, 'Watch', 'Fashion', 6000),
(10, 'TV', 'Electronics', 40000);
WITH RankedProducts AS (
  SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
  FROM Products
)
SELECT *
FROM RankedProducts
WHERE RowNum <= 3;
SELECT
  ProductID,
  ProductName,
  Category,
  Price,
  RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankPos,
  DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankPos
FROM Products;
