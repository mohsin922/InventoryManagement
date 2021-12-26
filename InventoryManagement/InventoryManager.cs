using System;
using System.Collections.Generic;
using System.Text;
using static InventoryMangement.InventoryUtility;

namespace InventoryMangement
{
    class InventoryManager
    {
        public void DisplayInventory(List<Rice> ricelist)
        {
            Console.WriteLine("DISPLAYING RICE INVENTORY : ");
            foreach (Rice R in ricelist)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", R.Name, R.Kg, R.Price, R.Type);
            }

        }
        public void DisplayInventory(List<Wheat> wheatList)
        {
            Console.WriteLine("DISPLAYING WHEAT INVENTORY : ");

            foreach (Wheat W in wheatList)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", W.Name, W.Kg, W.Price, W.Type);
            }
        }
        public void DisplayInventory(List<Pulse> pulseList)
        {
            Console.WriteLine("DISPLAYING PULSE INVENTORY : ");

            foreach (Pulse P in pulseList)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", P.Name, P.Kg, P.Price, P.Type);
            }
        }

        
        //Add new Rice type
        public void AddInventory(List<Rice> ricelist)
        {
            Rice rice = new Rice();
            Console.WriteLine("Enter the rice name: ");
            rice.Name = Console.ReadLine();
            Console.WriteLine("Enter the rice price: ");
            rice.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rice weight (kg): ");
            rice.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rice type: ");
            rice.Type = Console.ReadLine();
            ricelist.Add(rice);

        }
        //Add new wheat type
        public void AddInventory(List<Wheat> wheatList)
        {
            Wheat wheat = new Wheat();
            Console.WriteLine("Enter the wheat name: ");
            wheat.Name = Console.ReadLine();
            Console.WriteLine("Enter the wheat price: ");
            wheat.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the wheat weight(in kg): ");
            wheat.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the wheat type: ");
            wheat.Type = Console.ReadLine();
            wheatList.Add(wheat);

        }
        //Add new Pulse Type
        public void AddInventory(List<Pulse> pulseList)
        {
            Pulse pulse = new Pulse();
            Console.WriteLine("Enter the pulse name: ");
            pulse.Name = Console.ReadLine();
            Console.WriteLine("Enter the pulse price: ");
            pulse.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the pulse weight(in kg): ");
            pulse.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the pulse type: ");
            pulse.Type = Console.ReadLine();
            pulseList.Add(pulse);

        }

        public void DeleteInventory(List<Rice> riceList)
        {

            Console.WriteLine("Enter rice name to be deleted");
            string temp = Console.ReadLine();
            riceList.Remove(riceList.Find(result => result.Name.Equals(temp)));
        }
        //Delete Pulse Type
        public void DeleteInventory(List<Pulse> pulseList)
        {

            Console.WriteLine("Enter Pulse name to be deleted");
            string temp = Console.ReadLine();
            pulseList.Remove(pulseList.Find(result => result.Name.Equals(temp)));
        }
        //Delete Wheat Type
        public void DeleteInventory(List<Wheat> wheatList)
        {

            Console.WriteLine("Enter Wheat name to be deleted");
            string temp = Console.ReadLine();
            wheatList.Remove(wheatList.Find(result => result.Name.Equals(temp)));
        }
    }
}
