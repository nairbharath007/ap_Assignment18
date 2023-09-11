using GuitarAppFinal.Model;
using Type = GuitarAppFinal.Model.Type;

namespace GuitarAppFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpec whatErinLikes =
              new GuitarSpec(Builder.FENDER, "Stratocastor",
                             Type.ELECTRIC, 6, Wood.ALDER, Wood.ALDER);
            List<Guitar> matchingGuitars = inventory.Search(whatErinLikes);
            if (matchingGuitars.Count > 0)
            {
                Console.WriteLine("Erin, you might like these guitars:");
                foreach (Guitar guitar in matchingGuitars)
                {
                    GuitarSpec spec = guitar.Spec;
                    Console.WriteLine("  We have a " +
                      spec.builder + " " + spec.model + " " +
                      spec.type + " guitar:\n     " +
                      spec.backWood + " back and sides,\n     " +
                      spec.topWood + " top.\n  You can have it for only $" +
                      guitar.Price + "!\n  ----");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }
        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("11277", 3999.95,
      new GuitarSpec(Builder.COLLINGS, "CJ", Type.ACOUSTIC, 6,
                     Wood.INDIAN_ROSEWOOD, Wood.SITKA));
            inventory.AddGuitar("V95693", 1499.95,
              new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, 6,
                             Wood.ALDER, Wood.ALDER));
            inventory.AddGuitar("V9512", 1549.95,
              new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, 6,
                             Wood.ALDER, Wood.ALDER));
            inventory.AddGuitar("122784", 5495.95,
              new GuitarSpec(Builder.MARTIN, "D-18", Type.ACOUSTIC, 6,
                             Wood.MAHOGANY, Wood.ADIRONDACK));
            inventory.AddGuitar("76531", 6295.95,
              new GuitarSpec(Builder.MARTIN, "OM-28", Type.ACOUSTIC, 6,
                             Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK));
            inventory.AddGuitar("70108276", 2295.95,
              new GuitarSpec(Builder.GIBSON, "Les Paul", Type.ELECTRIC, 6,
                             Wood.MAHOGANY, Wood.MAHOGANY));
            inventory.AddGuitar("82765501", 1890.95,
              new GuitarSpec(Builder.GIBSON, "SG '61 Reissue", Type.ELECTRIC, 6,
                             Wood.MAHOGANY, Wood.MAHOGANY));
            inventory.AddGuitar("77023", 6275.95,
              new GuitarSpec(Builder.MARTIN, "D-28", Type.ACOUSTIC, 6,
                             Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK));
            inventory.AddGuitar("1092", 12995.95,
              new GuitarSpec(Builder.OLSON, "SJ", Type.ACOUSTIC, 12,
                             Wood.INDIAN_ROSEWOOD, Wood.CEDAR));
            inventory.AddGuitar("566-62", 8999.95,
              new GuitarSpec(Builder.RYAN, "Cathedral", Type.ACOUSTIC, 12,
                             Wood.COCOBOLO, Wood.CEDAR));
            inventory.AddGuitar("6 29584", 2100.95,
              new GuitarSpec(Builder.PRS, "Dave Navarro Signature", Type.ELECTRIC,
                             6, Wood.MAHOGANY, Wood.MAPLE));
        }
    }
    
}