using Newtonsoft.Json;
using System;
using System.IO;

namespace InventoryMangement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to inventory");
            InventoryManager m = new InventoryManager();
            // adding json file 
            string file = @"C:\Users\MOHSIN ZAHOOR PEER\Desktop\InventoryManagement\InventoryManagement\json1.json";
            //Deserialize
            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(file));
            Console.WriteLine("Display inventory Press 1-Rice Inventory 2-Wheat Inventory 3-Pulse Inventory ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    //Rice Inventory operations
                    var a = utility.RiceList;
                    Console.WriteLine("Enter which operation to perform\n 1-Add to Inventory\n 2-Remove from inventory\n3-Display Inventory");
                    int num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            m.AddInventory(a);
                            File.WriteAllText(file, JsonConvert.SerializeObject(utility));
                            m.DisplayInventory(a);
                            break;
                        case 2:
                            m.DeleteInventory(a);
                            File.WriteAllText(file, JsonConvert.SerializeObject(utility));
                            m.DisplayInventory(a);
                            break;
                        case 3:
                            m.DisplayInventory(a);
                            break;
                    }

                    break;
                case 2:
                    //Wheat Inventory operations
                    var a1 = utility.WheatList;
                    Console.WriteLine("Enter which operation to perform\n 1-Add to Inventory\n 2-Remove from inventory\n 3-Display Inventory");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    switch (num1)
                    {
                        case 1:
                            m.AddInventory(a1);
                            File.WriteAllText(file, JsonConvert.SerializeObject(utility));
                            m.DisplayInventory(a1);
                            break;
                        case 2:
                            m.DeleteInventory(a1);
                            File.WriteAllText(file, JsonConvert.SerializeObject(utility));
                            m.DisplayInventory(a1);
                            break;
                        case 3:
                            m.DisplayInventory(a1);
                            break;
                    }
                    break;
                case 3:
                    //Pulse Inventory operations
                    var a2 = utility.PulseList;
                    Console.WriteLine("Enter which operation to perform\n 1-Add to Inventory\n 2-Remove from inventory\n 3-Display Inventory");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    switch (num2)
                    {
                        case 1:
                            m.AddInventory(a2);
                            File.WriteAllText(file, JsonConvert.SerializeObject(utility));
                            m.DisplayInventory(a2);
                            break;
                        case 2:
                            m.DeleteInventory(a2);
                            File.WriteAllText(file, JsonConvert.SerializeObject(utility));
                            m.DisplayInventory(a2);
                            break;
                        case 3:
                            m.DisplayInventory(a2);
                            break;
                    }
                    break;
            }
        }
    }
}
