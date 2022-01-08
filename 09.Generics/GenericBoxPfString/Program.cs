using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxPfString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box<double>> boxes = new List<Box<double>>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.Add(box);
            }

            double elementToConpare = double.Parse(Console.ReadLine());

            Counter(boxes, elementToConpare);

        }

        public static void Counter(List<Box<double>> boxes, double elementToCompare)
        {
            int count = 0;
            foreach (var element in boxes)
            {
                
                if(element.value > elementToCompare)
                {
                    count++;
                }

            }

            Console.WriteLine(count);
        }

        static void SwapBoxes<T>(int index1, int index2, List<Box<T>> boxes)
        {
            Box<T> temp = boxes[index1];
            boxes[index1] = boxes[index2];
            boxes[index2] = temp;
        }
    }
}
