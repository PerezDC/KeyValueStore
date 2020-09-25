using System;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX 3C - C# - Generic Collections");
            /* Instantiate an instance of each of the generic collection classes described in Chapter 18
             * List<T>, DONE
             * LinkedList<T>, DONE
             * Queue<T>, DONE
             * Stack<T>, DONE
             * Dictionary<TKey, TValue>, DONE
             * SortedList<TKey, TValue>, and
             * HashSet<T>).
             */

            Console.WriteLine("\nGenerating List. \nPrinting List contents:");
            foreach (var item in Collections.ColorPalette())
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine("\nGenerating LinkedList. \nPrinting LinkedList contents:");
            foreach (var item in Collections.FoodChoices())
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine("\nGenerating Queue. \nPrinting Queue contents:");
            foreach (var item in Collections.LinePosition())
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine("\nGenerating Stack. \nPrinting Stack contents:");
            foreach (var item in Collections.OrderPriority())
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine("\nGenerating Dictionary. \nPrinting Dictionary contents:");
            foreach (var item in Collections.OrderDetails())
            {
                Console.WriteLine($"\tName: {item.Key} \tPrice: ${item.Value}");
            }

        }
    }
}
