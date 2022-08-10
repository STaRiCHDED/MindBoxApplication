using System.ComponentModel.DataAnnotations;

namespace MindBoxApp.SQLApplication;

public class Category
{
    [Key] public int Id { set; get; }
    public string Name { set; get; }

    public Category(string name)
    {
        Name = name;
    }
}