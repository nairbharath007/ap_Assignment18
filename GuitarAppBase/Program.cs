using GuitarAppBase.Model;

namespace GuitarAppBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set up Rick's guitar inventory
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            Guitar whatErinLikes = new Guitar("", 0, "fendor", "Stratocaster",
                                              "electric", "Alder", "Alder");
            Guitar guitar = inventory.Search(whatErinLikes);
            if (guitar != null)
            {
                Console.WriteLine("Erin, you might like this " +
                    guitar.Builder + " " + guitar.Model + " " +
                    guitar.Type + " guitar:\n   " +
                    guitar.BackWood + " back and sides,\n   " +
                    guitar.TopWood + " top.\nYou can have it for only $" +
                    guitar.Price + "!");
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("11277", 3999.95, "Collings", "CJ", "acoustic",
                                "Indian Rosewood", "Sitka");
            inventory.AddGuitar("V95693", 1499.95, "Fender", "Stratocaster", "electric",
                                "Alder", "Alder");
            inventory.AddGuitar("V9512", 1549.95, "Fender", "Stratocaster", "electric",
                                "Alder", "Alder");
            inventory.AddGuitar("122784", 5495.95, "Martin", "D-18", "acoustic",
                                "Mahogany", "Adirondack");
            inventory.AddGuitar("76531", 6295.95, "Martin", "OM-28", "acoustic",
                                "Brazilian Rosewood", "Adirondack");
            inventory.AddGuitar("70108276", 2295.95, "Gibson", "Les Paul", "electric",
                                "Mahogany", "Maple");
            inventory.AddGuitar("82765501", 1890.95, "Gibson", "SG '61 Reissue",
                                "electric", "Mahogany", "Mahogany");
            inventory.AddGuitar("77023", 6275.95, "Martin", "D-28", "acoustic",
                                "Brazilian Rosewood", "Adirondack");
            inventory.AddGuitar("1092", 12995.95, "Olson", "SJ", "acoustic",
                                "Indian Rosewood", "Cedar");
            inventory.AddGuitar("566-62", 8999.95, "Ryan", "Cathedral", "acoustic",
                                "Cocobolo", "Cedar");
            inventory.AddGuitar("6 29584", 2100.95, "PRS", "Dave Navarro Signature",
                                "electric", "Mahogany", "Maple");
        }
    }
}