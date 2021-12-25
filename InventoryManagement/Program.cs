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
                    m.DisplayInventory(utility.RiceList);
                    break;
                case 2:
                    m.DisplayInventory(utility.WheatList);
                    break;
                case 3:
                    m.DisplayInventory(utility.PulseList);
                    break;
            }
        }
    }
}