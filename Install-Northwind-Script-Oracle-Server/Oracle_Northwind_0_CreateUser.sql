-- Allow the creation of a common user
ALTER SESSION SET "_ORACLE_SCRIPT" = true;

-- Create the user
CREATE USER usr_northwind IDENTIFIED BY "northwind1234";

-- Grant privileges to the user
GRANT CONNECT, RESOURCE, DBA TO usr_northwind;

-- Switch to the new user's schema
ALTER SESSION SET CURRENT_SCHEMA = usr_northwind;
