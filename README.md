# MindBoxApplication
Задание:

- [x] Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 
https://github.com/STaRiCHDED/MindBoxApplication/tree/main/GeometryFigures

Дополнительно к работоспособности оцениваются:
- [x] *Юнит-тесты
https://github.com/STaRiCHDED/MindBoxApplication/tree/main/UnitTest

- [x] *Легкость добавления других фигур

- [x] *Вычисление площади фигуры без знания типа фигуры в compile-time

- [x] *Проверку на то, является ли треугольник прямоугольным
```
public bool IsRectangular()
{
  var edges = new[] {_a, _b, _c};
  Array.Sort(edges);
  return Math.Pow(edges[2], 2) == Math.Pow(edges[0], 2) + Math.Pow(edges[1], 2);
}
```

- [x] В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.

Реализация базы данных с помощью EntityFramework: https://github.com/STaRiCHDED/MindBoxApplication/tree/main/MindBoxApp

Также есть реализация в SQL:
```
SELECT Products.Name, Category = 
CASE
WHEN CategoriesByProduct.ProductId = Products.Id THEN Categories.Name
ELSE ''
END
FROM Products full join CategoriesByProduct on Products.Id = CategoriesByProduct.ProductId 
full join Categories on Categories.Id = CategoriesByProduct.CategoryId
```
