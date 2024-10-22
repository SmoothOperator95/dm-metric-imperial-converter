using System;
using System.Collections.Generic;

public enum Category
{
    Appetizer,
    MainCourse,
    Dessert
}

public class MenuItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public Category ItemCategory { get; set; }
    public bool IsNew { get; set; }

    public MenuItem(string name, decimal price, string description, Category category, bool isNew)
    {
        Name = name;
        Price = price;
        Description = description;
        ItemCategory = category;
        IsNew = isNew;
    }

    public override string ToString()
    {
        return $"{Name} - {Description} - ${Price:F2} - {(IsNew ? "New!" : "")}";
    }
}

public class Menu
{
    private List<MenuItem> _menuItems;
    public DateTime LastUpdated { get; private set; }

    public Menu()
    {
        _menuItems = new List<MenuItem>();
        LastUpdated = DateTime.Now;
        LoadInitialItems();
    }

    private void LoadInitialItems()
    {
        _menuItems.Add(new MenuItem("Bruschetta", 8.99m, "Grilled bread topped with diced tomatoes and basil.", Category.Appetizer, true));
        _menuItems.Add(new MenuItem("Grilled Salmon", 19.99m, "Fresh salmon grilled to perfection, served with vegetables.", Category.MainCourse, false));
        _menuItems.Add(new MenuItem("Chocolate Lava Cake", 6.99m, "Warm chocolate cake with a molten center, served with ice cream.", Category.Dessert, true));
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Current Menu:");
        foreach (var item in _menuItems)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Last Updated: {LastUpdated}");
    }

    public void AddMenuItem(MenuItem item)
    {
        _menuItems.Add(item);
        LastUpdated = DateTime.Now;
    }
}
