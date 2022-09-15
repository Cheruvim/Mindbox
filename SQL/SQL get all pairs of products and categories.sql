SELECT
  Product.Name,
  Cats.CatName
FROM Product
left JOIN Linker
  ON Product.Id = Linker.ProdId
left JOIN Cats
  ON Linker.CatId = Cats.Id;
