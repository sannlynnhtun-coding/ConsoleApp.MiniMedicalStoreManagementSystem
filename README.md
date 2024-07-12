## Mini Medical Store Management System

This program simulates a simple pharmacy store management system. It allows users to perform various operations such as displaying the inventory, adding new medicines, and selling medicines.

### Features

1. **Display Inventory**: Shows the current list of medicines available in the store along with their prices and quantities.
2. **Add Medicine**: Allows the user to add new medicines to the inventory.
3. **Sell Medicine**: Allows the user to sell a specified quantity of a medicine from the inventory.
4. **Exit**: Exits the program.

### Classes and Methods

#### Store Class

This class manages the inventory of medicines. It contains methods to add, display, and sell medicines.

```csharp
public class Store
{
    private List<Medicine> inventory = new List<Medicine>();

    public void AddMedicine(Medicine medicine)
    {
        inventory.Add(medicine);
    }

    public void DisplayInventory()
    {
        foreach (var medicine in inventory)
        {
            Console.WriteLine($"{medicine.Name} - ${medicine.Price} - {medicine.Quantity} units");
        }
    }

    public bool SellMedicine(string name, int quantity)
    {
        var medicine = inventory.FirstOrDefault(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (medicine != null && medicine.Quantity >= quantity)
        {
            medicine.Quantity -= quantity;
            return true;
        }
        return false;
    }
}
```

#### Medicine Class

This class represents a medicine with a name, price, and quantity.

```csharp
public class Medicine
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Medicine(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}
```

### Program Flow

1. **InitializeInventory**: The `InitializeInventory` method populates the store with a predefined list of medicines. Each medicine is given a random price between 0 and 20, and a random quantity between 1 and 500.

```csharp
void InitializeInventory(Store store)
{
    string[] medicineNames = { "Paracetamol", "Aspirin", "Ibuprofen", "Antacid", "Cough Syrup", ... };

    Random rand = new Random();
    for (int i = 0; i < 50; i++)
    {
        double price = Math.Round(rand.NextDouble() * 20, 2); // Prices between 0 and 20
        int quantity = rand.Next(1, 500); // Quantities between 1 and 500
        store.AddMedicine(new Medicine(medicineNames[i % medicineNames.Length], price, quantity));
    }
}
```

2. **Main Loop**: The main loop presents the user with a menu of options. Based on the user's choice, it calls the appropriate method on the `Store` instance.

```csharp
bool exit = false;

while (!exit)
{
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1. Display Inventory");
    Console.WriteLine("2. Add Medicine");
    Console.WriteLine("3. Sell Medicine");
    Console.WriteLine("4. Exit");
    Console.Write("Choose an option: ");

    int choice;
    if (int.TryParse(Console.ReadLine(), out choice))
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine("\nCurrent Inventory:");
                store.DisplayInventory();
                break;
            case 2:
                Console.Write("Enter medicine name: ");
                string name = Console.ReadLine()!;
                Console.Write("Enter medicine price: ");
                double price;
                while (!double.TryParse(Console.ReadLine(), out price))
                {
                    Console.Write("Invalid price. Enter medicine price: ");
                }
                Console.Write("Enter medicine quantity: ");
                int quantity;
                while (!int.TryParse(Console.ReadLine(), out quantity))
                {
                    Console.Write("Invalid quantity. Enter medicine quantity: ");
                }
                store.AddMedicine(new Medicine(name, price, quantity));
                Console.WriteLine($"{name} added to inventory.");
                break;
            case 3:
                Console.Write("Enter medicine name to sell: ");
                string sellName = Console.ReadLine()!;
                Console.Write("Enter quantity to sell: ");
                int sellQuantity;
                while (!int.TryParse(Console.ReadLine(), out sellQuantity))
                {
                    Console.Write("Invalid quantity. Enter quantity to sell: ");
                }
                bool sold = store.SellMedicine(sellName, sellQuantity);
                if (sold)
                {
                    Console.WriteLine($"{sellQuantity} {sellName} sold successfully!");
                }
                else
                {
                    Console.WriteLine($"Failed to sell {sellName}. Insufficient stock or medicine not found.");
                }
                break;
            case 4:
                exit = true;
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose a valid option.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
}
```

This program demonstrates basic CRUD operations in a console application, utilizing a simple menu-driven interface to interact with the user.
