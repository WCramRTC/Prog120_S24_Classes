using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace Prog120_S24_Classes
{
    internal class Data
    {

        // Uncomment from here----------------
        public static FoodEntry[] ReadCsv(string relativePath)
        {
            string fullPath = Path.GetFullPath(relativePath);

            using (var reader = new StreamReader(fullPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = new List<FoodEntry>();
                records.AddRange(csv.GetRecords<FoodEntry>());
                return records.ToArray();
            }
        }

        // To Here------------------
    }
}
