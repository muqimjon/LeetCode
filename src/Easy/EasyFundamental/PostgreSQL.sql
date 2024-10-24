﻿-- 1677. Fix Names in a Table
-- https://leetcode.com/problems/fix-names-in-a-table/

-- Converts the first character of each name to uppercase and the rest to lowercase
-- Time Complexity: O(n log n)
-- Space Complexity: O(n)

SELECT
  user_id,
  CONCAT(
    UPPER(SUBSTRING(name, 1, 1)),
    LOWER(SUBSTRING(name, 2))
  ) AS name
FROM Users
ORDER BY user_id;
------------------------------------------------------------------------------------

-- 1527. Patients With a Condition
-- https://leetcode.com/problems/patients-with-a-condition/

-- Time Complexity: O(N*M)
-- Space Complexity: O(N)

SELECT * FROM Patients
WHERE conditions LIKE 'DIAB1%' 
OR conditions LIKE '% DIAB1%';
------------------------------------------------------------------------------------

-- 183. Customers Who Never Order
-- https://leetcode.com/problems/customers-who-never-order/

-- Time Complexity: O(N)
-- Space Complexity: O(1)

SELECT name Customers FROM Customers
WHERE id NOT IN (SELECT CustomerID FROM Orders);
------------------------------------------------------------------------------------

-- 1050. Actors and Directors who cooperated at least three times
-- https://leetcode.com/problems/actors-and-directors-who-cooperated-at-least-three-times/

-- Time Complexity: O(n log n)
-- Space Complexity: O(N)

SELECT actor_id, director_id
FROM ActorDirector
GROUP BY actor_id, director_id
HAVING COUNT(*) >= 3;
------------------------------------------------------------------------------------------------

-- 627. Swap Salary
-- https://leetcode.com/problems/swap-salary/

-- Time Complexity: O(N)
-- Space Complexity: O(1)

UPDATE Salary
SET sex = CASE 
            WHEN sex = 'm' THEN 'f'
            WHEN sex = 'f' THEN 'm'
          END;
--------------------------------------------------------------------------------------------

-- 1731. The Number of Employees Which Report to Each Employee
-- https://leetcode.com/problems/the-number-of-employees-which-report-to-each-employee/description/

-- Time complexity: O(n * m)
-- Space complexity: O(n)

SELECT e.employee_id, e.name, count(r.employee_id) reports_count, round(avg(r.age), 0) average_age
FROM Employees e
LEFT JOIN Employees r ON e.employee_id = r.reports_to
GROUP BY e.employee_id, e.name
HAVING COUNT(r.employee_id) >= 1
ORDER BY e.employee_id;

-- SELECT
--     e.employee_id,
--     e.name,
--     (
--         SELECT COUNT(*)
--         FROM Employees r
--         WHERE r.reports_to = e.employee_id
--     ) AS reports_count,
--     (
--         SELECT ROUND(AVG(r.age), 0)
--         FROM Employees r
--         WHERE r.reports_to = e.employee_id
--     ) AS average_age
-- FROM Employees e
-- WHERE EXISTS (
--     SELECT 1
--     FROM Employees r
--     WHERE r.reports_to = e.employee_id
-- )
-- ORDER BY e.employee_id;
--------------------------------------------------------------------------------------------

-- 1729. Find Followers Count
-- https://leetcode.com/problems/find-followers-count

-- Time complexity: O(n*log n)
-- Space complexity: O(n)

SELECT user_id, count(*) followers_count 
FROM followers
GROUP BY user_id
ORDER BY user_id;
--------------------------------------------------------------------------------------------

-- 1587. Bank Account Summary II
-- https://leetcode.com/problems/bank-account-summary-ii/

-- Time complexity: O(n*log n)
-- Space complexity: O(n)

SELECT u.name, SUM(t.amount) AS balance
FROM Users u
JOIN Transactions t ON u.account = t.account
GROUP BY u.name
HAVING SUM(t.amount) > 10000;
--------------------------------------------------------------------------------------------

-- 1741. Find Total Time Spent by Each Employee
-- https://leetcode.com/problems/find-total-time-spent-by-each-employee/

-- Time complexity: O(n)
-- Space complexity: O(n)

SELECT 
    event_day AS day, 
    emp_id, 
    SUM(out_time - in_time) AS total_time
FROM Employees
GROUP BY event_day, emp_id;
--------------------------------------------------------------------------------------------

-- 1795. Rearrange Products Table
-- https://leetcode.com/problems/rearrange-products-table/

-- Time complexity: O(n)
-- Space complexity: O(n)

SELECT product_id, 'store1' AS store, store1 AS price
FROM Products
WHERE store1 IS NOT NULL

UNION ALL

SELECT product_id, 'store2' AS store, store2 AS price
FROM Products
WHERE store2 IS NOT NULL

UNION ALL

SELECT product_id, 'store3' AS store, store3 AS price
FROM Products
WHERE store3 IS NOT NULL;
--------------------------------------------------------------------------------------------