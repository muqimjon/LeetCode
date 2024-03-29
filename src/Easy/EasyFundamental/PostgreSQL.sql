-- 1677. Fix Names in a Table
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