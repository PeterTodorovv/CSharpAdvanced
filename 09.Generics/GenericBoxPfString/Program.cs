using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxPfString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box<int>> boxes = new List<Box<int>>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                boxes.Add(box);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SwapBoxes(indexes[0], indexes[1], boxes);

            foreach(var box in boxes)
            {
                Console.WriteLine(box.ToString());
            }

        }

        static void SwapBoxes<T>(int index1, int index2, List<Box<T>> boxes)
        {
            Box<T> temp = boxes[index1];
            boxes[index1] = boxes[index2];
            boxes[index2] = temp;
        }
    }
}
