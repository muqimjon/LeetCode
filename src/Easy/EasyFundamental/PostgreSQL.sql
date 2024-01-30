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