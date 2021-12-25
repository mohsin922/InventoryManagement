using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMangement
{
    class InventoryManager
    {
        public void DisplayInventory(List<InventoryUtility.Rice> Ricelist)
        {
            foreach (InventoryUtility.Rice R in Ricelist)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", R.Name, R.Kg, R.Price, R.Type);
            }

        }
        public void DisplayInventory(List<InventoryUtility.Wheat> WheatList)
        {
            foreach (InventoryUtility.Wheat W in WheatList)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", W.Name, W.Kg, W.Price, W.Type);
            }
        }
        public void DisplayInventory(List<InventoryUtility.Pulse> PulseList)
        {
            foreach (InventoryUtility.Pulse P in PulseList)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", P.Name, P.Kg, P.Price, P.Type);
            }
        }
    }
}