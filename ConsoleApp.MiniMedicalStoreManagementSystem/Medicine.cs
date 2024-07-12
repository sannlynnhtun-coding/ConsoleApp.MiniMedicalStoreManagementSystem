//store.AddMedicine(new Medicine("Paracetamol", 0.50, 100));
//store.AddMedicine(new Medicine("Aspirin", 0.30, 200));



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

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}";
    }
}
