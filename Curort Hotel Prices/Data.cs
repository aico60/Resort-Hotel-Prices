using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resort_Hotel_Prices
{
    class Data
    {
        public Data() { }

         public List<string> resorts { get; set; } = new List<string>() { "Albena", "Golden Sands", "Kiten", "Pomorie", "Sozopol" };
         public Dictionary<string, Dictionary<string, double>> hotelsAndPrices { get; set; } = new Dictionary<string, Dictionary<string, double>>()
        {
            {
                "Albena",
                new Dictionary<string, double>
                {
                    {"Flamingo Grand Hotel", 309 },
                    {"Dobrudzha Hotel", 108 },
                    {"Gergana", 307},
                    {"Sandy Beach", 285 },
                    {"Elitsa", 316 },
                    {"Compass", 190 }
                }
            },
            {
                "Sozopol",
                new Dictionary<string, double>
                {
                    {"Sunny", 131 },
                    {"Radik", 91 },
                    {"Santa Marina", 224},
                    {"Lozite", 90 },
                    {"Martinez", 171 },
                    {"Selena", 148 }
                }
            },
            {
                "Golden Sands",
                new Dictionary<string, double>
                {
                    {"Hotel Erma", 98 },
                    {"Liliya", 127 },
                    {"Detelina Hotel", 90},
                    {"Abasador", 92 },
                    {"Briz", 120 },
                    {"Admiral", 196 }
                }
            },
            {
                "Kiten",
                new Dictionary<string, double>
                {
                    {"Kremikovtsi", 75 },
                    {"Diamond Hotel", 96 },
                    {"Onyx", 100 },
                    {"Daniela Wellness", 140 },
                    {"Elmar", 142 },
                    {"Milev", 42 }
                }
            },
            {
                "Pomorie",
                new Dictionary<string, double>
                {
                    {"Paros 2", 55 },
                    {"Paros", 80 },
                    {"Paradise", 91},
                    {"Central Plaza", 132 },
                    {"Wave Resort", 469 },
                    {"Helios", 115 }
                }
            }
        };
    }
}