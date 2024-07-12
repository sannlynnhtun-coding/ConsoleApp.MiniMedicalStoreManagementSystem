Console.WriteLine("Hello World!");

//Store store = new Store();
////store.AddMedicine(new Medicine("Paracetamol", 0.50, 100));
////store.AddMedicine(new Medicine("Aspirin", 0.30, 200));
//InitializeInventory(store);

//bool exit = false;

//while (!exit)
//{
//    Console.WriteLine("\nMenu:");
//    Console.WriteLine("1. Display Inventory");
//    Console.WriteLine("2. Add Medicine");
//    Console.WriteLine("3. Sell Medicine");
//    Console.WriteLine("4. Exit");
//    Console.Write("Choose an option: ");

//    int choice;
//    if (int.TryParse(Console.ReadLine(), out choice))
//    {
//        switch (choice)
//        {
//            case 1:
//                Console.WriteLine("\nCurrent Inventory:");
//                store.DisplayInventory();
//                break;
//            case 2:
//                Console.Write("Enter medicine name: ");
//                string name = Console.ReadLine()!;
//                Console.Write("Enter medicine price: ");
//                double price;
//                while (!double.TryParse(Console.ReadLine(), out price))
//                {
//                    Console.Write("Invalid price. Enter medicine price: ");
//                }
//                Console.Write("Enter medicine quantity: ");
//                int quantity;
//                while (!int.TryParse(Console.ReadLine(), out quantity))
//                {
//                    Console.Write("Invalid quantity. Enter medicine quantity: ");
//                }
//                store.AddMedicine(new Medicine(name, price, quantity));
//                Console.WriteLine($"{name} added to inventory.");
//                break;
//            case 3:
//                Console.Write("Enter medicine name to sell: ");
//                string sellName = Console.ReadLine()!;
//                Console.Write("Enter quantity to sell: ");
//                int sellQuantity;
//                while (!int.TryParse(Console.ReadLine(), out sellQuantity))
//                {
//                    Console.Write("Invalid quantity. Enter quantity to sell: ");
//                }
//                bool sold = store.SellMedicine(sellName, sellQuantity);
//                if (sold)
//                {
//                    Console.WriteLine($"{sellQuantity} {sellName} sold successfully!");
//                }
//                else
//                {
//                    Console.WriteLine($"Failed to sell {sellName}. Insufficient stock or medicine not found.");
//                }
//                break;
//            case 4:
//                exit = true;
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please choose a valid option.");
//                break;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid input. Please enter a number.");
//    }
//}

//void InitializeInventory(Store store)
//{
//    string[] medicineNames = { "Paracetamol", "Aspirin", "Ibuprofen", "Antacid", "Cough Syrup", "Vitamin C", "Antihistamine", "Antibiotic", "Antifungal", "Antiviral",
//                               "Pain Reliever", "Nasal Spray", "Eye Drops", "Allergy Medicine", "Antiseptic Cream", "Digestive Aid", "Laxative", "Diuretic", "Blood Thinner", "Cholesterol Medicine",
//                               "Blood Pressure Medicine", "Diabetes Medicine", "Heartburn Relief", "Cold Medicine", "Flu Medicine", "Sleep Aid", "Energy Supplement", "Iron Supplement", "Calcium Supplement", "Probiotic",
//                               "Anti-Inflammatory", "Asthma Inhaler", "Insulin", "Hormone Therapy", "Birth Control", "Thyroid Medication", "Antidepressant", "Antipsychotic", "Anti-Anxiety", "Mood Stabilizer",
//                               "Erectile Dysfunction", "Menopause Relief", "Hair Loss Treatment", "Weight Loss Aid", "Smoking Cessation", "Memory Enhancer", "Antiemetic", "Antispasmodic", "Steroid", "Nutritional Supplement" };

//    Random rand = new Random();
//    for (int i = 0; i < 50; i++)
//    {
//        double price = Math.Round(rand.NextDouble() * 20, 2); // Prices between 0 and 20
//        int quantity = rand.Next(1, 500); // Quantities between 1 and 500
//        store.AddMedicine(new Medicine(medicineNames[i % medicineNames.Length], price, quantity));
//    }
//}
