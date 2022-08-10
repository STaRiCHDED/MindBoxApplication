using System.ComponentModel.DataAnnotations;

namespace MindBoxApp.SQLApplication;

public class Product
{
    [Key] public int Id { set; get; }
    public string Name { set; get; }

    public Product(string name)
    {
        Name = name;
    }
}