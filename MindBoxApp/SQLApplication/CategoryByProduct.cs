using System.ComponentModel.DataAnnotations;

namespace MindBoxApp.SQLApplication;

public class CategoryByProduct
{
    [Key] public int Id { set; get; }
    public int CategoryId { set; get; }
    public int ProductId { set; get; }

    public CategoryByProduct(int categoryId, int productId)
    {
        CategoryId = categoryId;
        ProductId = productId;
    }
}