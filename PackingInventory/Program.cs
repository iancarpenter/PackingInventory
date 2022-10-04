using System.Runtime.CompilerServices;

namespace PackingInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack(10, 20, 30);

            while (true)
            {
                Console.WriteLine($"Pack is current at {pack.CurrentCount}/{pack.MaxCount} items, {pack.CurrentWeight}/{pack.MaxWeight} weight, and {pack.CurrentVolume}/{pack.MaxVolume} volume.");

                Console.WriteLine("What do you want to add?");
                Console.WriteLine("1 - Arrow");
                Console.WriteLine("2 - Bow");
                Console.WriteLine("3 - Rope");
                Console.WriteLine("4 - Water");
                Console.WriteLine("5 - Food");
                Console.WriteLine("6 - Sword");

                int choice = Convert.ToInt32(Console.ReadLine());

                InventoryItem newItem = choice switch
                {
                    1 => new Arrow(),
                    2 => new Bow(),
                    3 => new Rope(),
                    4 => new Water(),
                    5 => new Food(),
                    6 => new Sword()                    
                };

                Console.WriteLine($"{newItem.ToString()}");
                if (!pack.Add(newItem))
                    Console.WriteLine("Could not add this to the pack.");
            }
        }
    }
}