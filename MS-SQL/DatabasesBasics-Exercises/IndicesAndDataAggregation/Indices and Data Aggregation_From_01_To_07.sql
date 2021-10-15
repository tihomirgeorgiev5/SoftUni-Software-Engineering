USE [Gringotts]
-- 01. Records’ Count
SELECT COUNT(*) AS [Count]
FROM [WizzardDeposits] 

-- 02. Longest Magic Wand
SELECT TOP(1) MAX([MagicWandSize]) AS [LongestMagicWorld] 
FROM [WizzardDeposits]
GROUP BY [MagicWandSize]
ORDER BY [LongestMagicWorld] DESC

-- 03. Longest Magic Wand per Deposit Groups
SELECT [DepositGroup],
      MAX([MagicWandSize]) AS [LongestMagicWorld]
FROM [WizzardDeposits]
GROUP BY [DepositGroup]

-- 04. Smallest Deposit Group per Magic Wand Size 
SELECT TOP(2) [DepositGroup]     
FROM [WizzardDeposits]
GROUP BY [DepositGroup]
ORDER BY AVG([MagicWandSize])

-- 05. Deposits Sum
SELECT [DepositGroup],
      SUM([DepositAmount]) AS [TotalSum]
FROM [WizzardDeposits]
GROUP BY [DepositGroup]

-- 06. Deposits Sum for Ollivander Family
SELECT [DepositGroup],
      SUM([DepositAmount]) AS [TotalSum]
FROM [WizzardDeposits]
WHERE [MagicWandCreator] = 'Ollivander Family'
GROUP BY [DepositGroup]

-- 07. Deposits Filter
SELECT W.DepositGroup,
SUM(W.DepositAmount) AS TotalSum
FROM WizzardDeposits  AS W
WHERE W.MagicWandCreator = 'Ollivander family'
GROUP BY W.DepositGroup
HAVING SUM(W.DepositAmount) < 150000
ORDER BY TotalSum DESC





