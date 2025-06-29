
-- Step 1: Create the database and select it
CREATE DATABASE IF NOT EXISTS ShopDB;
USE ShopDB;

-- Step 2: Create the Products table
CREATE TABLE IF NOT EXISTS Products (
  ProductID INT PRIMARY KEY,
  ProductName VARCHAR(100),
  Category VARCHAR(100),
  Price DECIMAL(10, 2)
);

-- Step 3: Insert sample data into the Products table
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

-- Step 4: ROW_NUMBER() - Get top 3 products by price per category
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

-- Step 5: RANK() and DENSE_RANK() usage
SELECT
  ProductID,
  ProductName,
  Category,
  Price,
  RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankPos,
  DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankPos
FROM Products;
