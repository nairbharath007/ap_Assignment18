using GuitarAppEncapsulation.Model;
using Type = GuitarAppEncapsulation.Model.Type;

namespace GuitarAppEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set up Rick's guitar inventory
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpec whatErinLikes =
              new GuitarSpec(Builder.FENDER, "Stratocastor",
                             Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
            List<Guitar> matchingGuitars = inventory.Search(whatErinLikes);
            if (matchingGuitars.Count > 0)
            {
                Console.WriteLine("Erin, you might like these guitars:");
                foreach (Guitar guitar in matchingGuitars)
                {
                    GuitarSpec spec = guitar.GetSpec();
                    Console.WriteLine("  We have a " +
                      spec.GetBuilder() + " " + spec.GetModel() + " " +
                      spec.GetType() + " guitar:\n     " +
                      spec.GetBackWood() + " back and sides,\n     " +
                      spec.GetTopWood() + " top.\n  You can have it for only $" +
                      guitar.GetPrice() + "!\n  ----");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("11277", 3999.95, Builder.COLLINGS,
                                "CJ", Type.ACOUSTIC,
                                Wood.INDIAN_ROSEWOOD, Wood.SITKA);
            inventory.AddGuitar("V95693", 1499.95, Builder.FENDER,
                                "Stratocastor", Type.ELECTRIC,
                                Wood.ALDER, Wood.ALDER);
            inventory.AddGuitar("V9512", 1549.95, Builder.FENDER,
                                "Stratocastor", Type.ELECTRIC,
                                Wood.ALDER, Wood.ALDER);
            inventory.AddGuitar("122784", 5495.95, Builder.MARTIN,
                                "D-18", Type.ACOUSTIC,
                                Wood.MAHOGANY, Wood.ADIRONDACK);
            inventory.AddGuitar("76531", 6295.95, Builder.MARTIN,
                                "OM-28", Type.ACOUSTIC,
                                Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK);
            inventory.AddGuitar("70108276", 2295.95, Builder.GIBSON,
                                "Les Paul", Type.ELECTRIC,
                                Wood.MAHOGANY, Wood.MAHOGANY);
            inventory.AddGuitar("82765501", 1890.95, Builder.GIBSON,
                                "SG '61 Reissue", Type.ELECTRIC,
                                Wood.MAHOGANY, Wood.MAHOGANY);
            inventory.AddGuitar("77023", 6275.95, Builder.MARTIN,
                                "D-28", Type.ACOUSTIC,
                                Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK);
            inventory.AddGuitar("1092", 12995.95, Builder.OLSON,
                                "SJ", Type.ACOUSTIC,
                                Wood.INDIAN_ROSEWOOD, Wood.CEDAR);
            inventory.AddGuitar("566-62", 8999.95, Builder.RYAN,
                                "Cathedral", Type.ACOUSTIC,
                                Wood.COCOBOLO, Wood.CEDAR);
            inventory.AddGuitar("6 29584", 2100.95, Builder.PRS,
                                "Dave Navarro Signature", Type.ELECTRIC,
                                Wood.MAHOGANY, Wood.MAPLE);
        }
    }
    
}