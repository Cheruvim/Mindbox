SELECT
  Product.Name,
  Cats.CatName
FROM Linker
JOIN Product
  ON Linker.ProdId = Product.Id
JOIN Cats
  ON Linker.CatId = Cats.Id;
