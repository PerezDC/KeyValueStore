using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections
{
    class Collections
    {
        public static List<string> ColorPalette()
        {
            List<string> colorList = new List<string>();

            foreach (string color in new string[] { "Red", "Green", "Blue", "Black", "White" })
            {
                colorList.Add(color);
            }

            return colorList;
        }

        public static LinkedList<string> FoodChoices()
        {
            LinkedList<string> foodList = new LinkedList<string>();

            foreach (string food in new string[] { "Blaze Pizza", "El Pollo Loco", "Buffalo Wild Wings", "Love Boat Sushi", "Applebee's" })
            {
                foodList.AddLast(food);
            }

            return foodList;
        }

        public static Queue<int> LinePosition()
        {
            Queue<int> lineNumber = new Queue<int>();

            foreach (int position in new int[] { 1, 2, 3, 4, 5 })
            {
                lineNumber.Enqueue(position);
            }

            return lineNumber;
        }

        public static Stack<string> OrderPriority()
        {
            Stack<string> rushedOrders = new Stack<string>();

            foreach (string orderName in new string[] { "David", "Hilda", "Winston", "Peaches", "Mikko" })
            {
                rushedOrders.Push(orderName);
            }

            return rushedOrders;
        }




    }
}
