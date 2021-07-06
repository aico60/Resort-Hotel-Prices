using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Resort_Hotel_Prices
{
    class Program
    {
        static void ListResorts()
        {
            Data data = new Data();
            List<string> resorts = data.resorts.ToList();
            resorts.Sort();
            for (int i = 0; i < resorts.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, resorts[i]);
            }
        }
        static void ListHotelsAndPrices(string resortName) 
        {
            Data data = new Data();
            Console.Clear();
            Console.WriteLine("You selected {0}.\n", resortName);
            foreach (var item in data.hotelsAndPrices.Where(key => key.Key == resortName))
            {
                foreach (var hotelNameAndPrice in item.Value)
                {
                    Console.WriteLine("Name: {0}, Price: {1}lv", hotelNameAndPrice.Key, hotelNameAndPrice.Value);
                }
            }
            while (true)
            {
                Console.Write("\nPress Enter or input 0 to go back: ");
                int goBack = int.Parse(Console.ReadLine());
                if (goBack == 0)
                {
                    Console.Clear();
                    break; 
                }
            }
        }

        static void Main(string[] args)
        { 
            Data data = new Data();
            List<string> resorts = data.resorts.ToList();
            resorts.Sort();

            while (true)
            {
                ListResorts();
                int selection = 0;
                try
                {
                    Console.Write("\nPlease select a resort or enter 0 to exit: ");
                    selection = int.Parse(Console.ReadLine());
                    while (selection < 0 || selection > resorts.Count)
                    {
                        Console.WriteLine("Please make a valid selection!");
                        Console.Write("\nPlease select a resort or enter 0 to exit: ");
                        selection = int.Parse(Console.ReadLine());
                    }
                    if (selection == 0)
                    {
                        break;
                    }
                    ListHotelsAndPrices(resorts[selection - 1]);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                }
            }           
        }
    }
}
