using GuitarAppCohesive.Model;
using Type = GuitarAppCohesive.Model.Type;

namespace GuitarAppCohesive
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Set up Rick's inventory
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            Dictionary<string, object> properties = new Dictionary<string, object>
            {
                { "builder", Builder.GIBSON },
                { "backWood", Wood.MAPLE }
            };

            InstrumentSpec whatBryanLikes = new InstrumentSpec(properties);

            List<Instrument> matchingInstruments = inventory.Search(whatBryanLikes);
            if (matchingInstruments.Count > 0)
            {
                Console.WriteLine("Bryan, you might like these instruments:");
                foreach (Instrument instrument in matchingInstruments)
                {
                    InstrumentSpec spec = instrument.GetSpec();
                    Console.WriteLine("We have a " + spec.GetProperty("instrumentType") +
                        " with the following properties:");
                    foreach (string propertyName in spec.GetProperties().Keys)
                    {
                        if (propertyName.Equals("instrumentType"))
                            continue;
                        Console.WriteLine("    " + propertyName + ": " +
                            spec.GetProperty(propertyName));
                    }
                    Console.WriteLine("  You can have this " +
                        spec.GetProperty("instrumentType") + " for $" +
                        instrument.GetPrice() + "\n---");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Bryan, we have nothing for you.");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            Dictionary<string, object> properties = new Dictionary<string, object>
            {
                { "instrumentType", InstrumentType.GUITAR },
                { "builder", Builder.COLLINGS },
                { "model", "CJ" },
                { "type", Type.ACOUSTIC },
                { "numStrings", 6 },
                { "topWood", Wood.INDIAN_ROSEWOOD },
                { "backWood", Wood.SITKA }
            };

            inventory.AddInstrument("11277", 3999.95, new InstrumentSpec(properties));

            properties = new Dictionary<string, object>
            {
                { "builder", Builder.MARTIN },
                { "model", "D-18" },
                { "topWood", Wood.MAHOGANY },
                { "backWood", Wood.ADIRONDACK }
            };

            inventory.AddInstrument("122784", 5495.95, new InstrumentSpec(properties));

            properties = new Dictionary<string, object>
            {
                { "builder", Builder.FENDER },
                { "model", "Stratocastor" },
                { "type", Type.ELECTRIC },
                { "topWood", Wood.ALDER },
                { "backWood", Wood.ALDER }
            };

            inventory.AddInstrument("V95693", 1499.95, new InstrumentSpec(properties));
            inventory.AddInstrument("V9512", 1549.95, new InstrumentSpec(properties));

            properties = new Dictionary<string, object>
            {
                { "builder", Builder.GIBSON },
                { "model", "Les Paul" },
                { "topWood", Wood.MAPLE },
                { "backWood", Wood.MAPLE }
            };

            inventory.AddInstrument("70108276", 2295.95, new InstrumentSpec(properties));

            properties = new Dictionary<string, object>
            {
                { "model", "SG '61 Reissue" },
                { "topWood", Wood.MAHOGANY },
                { "backWood", Wood.MAHOGANY }
            };

            inventory.AddInstrument("82765501", 1890.95, new InstrumentSpec(properties));

            properties = new Dictionary<string, object>
            {
                { "instrumentType", InstrumentType.MANDOLIN },
                { "type", Type.ACOUSTIC },
                { "model", "F-5G" },
                { "backWood", Wood.MAPLE },
                { "topWood", Wood.MAPLE }
            };

            inventory.AddInstrument("9019920", 5495.99, new InstrumentSpec(properties));

            properties = new Dictionary<string, object>
            {
                { "instrumentType", InstrumentType.BANJO },
                { "model", "RB-3 Wreath" },
                { "numStrings", 5 }
            };

            inventory.AddInstrument("8900231", 2945.95, new InstrumentSpec(properties));
        }
    }

}
