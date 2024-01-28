-- 1677. Fix Names in a Table
-- https://leetcode.com/problems/fix-names-in-a-table/

-- Fixing names in the Users table
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