using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AccountAppClassLibraryFramework.Service
{
    internal class DataSerialization
    {
        public static void BinarySerialize(string filePath, Account account)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, account);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error serializing data: {ex.Message}");
            }
        }

        public static Account BinaryDeserialize(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (Account)formatter.Deserialize(fs);
                }
            }
            catch (FileNotFoundException)
            {
                return null; // Data file does not exist.
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing data: {ex.Message}");
                return null;
            }
        }
    }
}
