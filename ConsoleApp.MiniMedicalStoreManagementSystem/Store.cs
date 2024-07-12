using BetterConsoleTables;

public class Store
{
    private List<Medicine> inventory;

    public Store()
    {
        inventory = new List<Medicine>();
    }

    public void AddMedicine(Medicine medicine)
    {
        inventory.Add(medicine);
    }

    public bool SellMedicine(string name, int quantity)
    {
        foreach (var med in inventory)
        {
            if (med.Name == name && med.Quantity >= quantity)
            {
                med.Quantity -= quantity;
                return true;
            }
        }
        return false;
    }

    public void DisplayInventory()
    {
        Table table = new Table("Name", "Price", "Quantity");
        foreach (var med in inventory)
        {
            //Console.WriteLine(med);
            table.AddRow(med.Name, med.Price, med.Quantity);
        }
        Console.Write(table.ToString());
    }
}
