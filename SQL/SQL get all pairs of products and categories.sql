SELECT
  Product.Name,
  Cats.CatName
FROM Product
JOIN Linker
  ON Product.Id = Linker.ProdId
JOIN Cats
  ON Linker.CatId = Cats.Id;
