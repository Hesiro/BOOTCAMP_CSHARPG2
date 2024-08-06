CREATE TABLE Account(
	Id INT PRIMARY KEY,
	Nombre VARCHAR(255),
	Balance INT
)

ALTER TABLE Account
ADD Telefono VARCHAR(50)

CREATE TABLE Account1(
	Id INT PRIMARY KEY,
	Nombre VARCHAR(255),
	Balance INT
)

DROP TABLE Account1

INSERT INTO Account(Id, Nombre, Balance) VALUES(1, 'Henry Sifuentes', 3200);

DROP TABLE Account

CREATE TABLE Account(
	Id INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(255),
	Balance INT
)

INSERT INTO Account(Nombre, Balance) VALUES('Henry Sifuentes', 3200);
INSERT INTO Account(Nombre, Balance) VALUES('Patricia Plaza', 2500);

UPDATE Account
SET
	Balance = 3600
WHERE Id=1

DELETE FROM Account
WHERE Id=1

SELECT * FROM Account