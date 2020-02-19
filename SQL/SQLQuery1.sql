CREATE TABLE products (
	Id INT PRIMARY KEY,
	"Product" TEXT
);

CREATE TABLE categories (
	Id INT PRIMARY KEY,
	"Category" TEXT
);

CREATE TABLE productsCategories (
	productId INT FOREIGN KEY REFERENCES products(Id),
	categoryId INT FOREIGN KEY REFERENCES categories(Id),
	PRIMARY KEY (productId, categoryId)
);

INSERT INTO products
VALUES
	(1, 'BMW'),
	(2, 'Mercedes'),
	(3, 'pullover'),
	(4, 'modulator');

INSERT INTO categories
VALUES
	(1, 'gift'),
	(2, 'car'),
	(3, 'clothes');

INSERT INTO productsCategories
VALUES
	(1, 1),
	(1, 2),
	(2, 1),
	(2, 2),
	(3, 1),
	(3, 3);

SELECT P."Product", C."Category" FROM products P
LEFT JOIN productsCategories PC
	ON P.Id = PC.productId
LEFT JOIN categories C
	ON PC.categoryId = C.Id;