-- CREATE GEARHOST DB
-- INITALIZE PROJECT
-- DOTNET ADD PACKAGE (MySQLConnector, Dapper)
-- CREATE TABLES / MODELS
-- CONNECT DB
-- CREATE CONTROLLERS
-- CREATE REPOS



USE burgershack123;
-- DROP TABLE sides;
-- CREATE TABLE sides
-- (
--     id INT AUTO_INCREMENT,
--     name VARCHAR(255) NOT NULL,
--     description VARCHAR(255),
--     PRIMARY KEY (id)
-- );

-- CREATE TABLE drinks
-- (
--     id INT AUTO_INCREMENT,
--     name VARCHAR(255) NOT NULL,
--     sugarFree TINYINT DEFAULT 0,
--     PRIMARY KEY (id)
-- );

-- CREATE TABLE burgers
-- (
--     id INT AUTO_INCREMENT,
--     name VARCHAR(255) NOT NULL,
--     description VARCHAR(255) NOT NULL,
--     price DECIMAL NOT NULL DEFAULT 1,
--     PRIMARY KEY (id)
-- )




-- DELETE FROM burgers;
-- INSERT INTO burgers (name, description, price)
--     VALUES ( "Mark & Cheese", "Mac&Cheese on yo burger", 6.50),
--             ("Darryl", "Random Meat, mostly stuff from the woods, fancy sticks and stuff, and bacon, lots of bacon, and a single slice of PepperJack", 12.00),
--             ("Porter", "Made from water and veggies and rivers, tastes like a kayak, served on a paddle", 8.70);

-- INSERT INTO sides (name, description)
--     VALUES ( "Tots", "Freshly deep fried and salted"),
--             ("Onion Rings", "A delicious onion battered and deep fried");

-- SELECT * FROM sides; GET ALL

-- SELECT * FROM sides WHERE id = 1; GET ONE

-- DELETE FROM sides WHERE id = 5; DELETE BY ID

-- DELETE FROM sides WHERE id = 6 OR id = 3;

-- UPDATE sides   
-- SET id = 10
-- WHERE id = 2;



-- SELECT * FROM burgers;
