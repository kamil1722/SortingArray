using System;
using System.Linq;

namespace Lab3
{
    class MyArray
    {
        public static int[] GenerateArray() //Генерация массива
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++) array[i] = rnd.Next(0, 100);
            return array;
        }
        public static int CheckMaxIndex(int[] array)//Поиск индекса максимального элемента
        {
            int maxIndex = Array.IndexOf(array, array.Max());
            return maxIndex;
        }
        public static int CheckMinIndex(int[] array) //Поиск индекса минимального элемента
        {
            int minIndex = Array.IndexOf(array, array.Min());
            return minIndex;
        }
    }
    class Program
    {

        static void Main() //Сортировка 
        {
            for (int i = 0; i < 5; i++)
            {
                int[] arrayMaxVal = MyArray.GenerateArray();
                int[] arrayMinVal = arrayMaxVal;
                Console.WriteLine("Old array:"+ string.Join(" ", arrayMaxVal));
                Console.WriteLine("Максимальный элемент массива: " + arrayMaxVal.Max() + " с индексом " + Array.IndexOf(arrayMaxVal, arrayMaxVal.Max()));
                Console.WriteLine("Минимальный элемент массива: " + arrayMinVal.Min() + " с индексом " + Array.IndexOf(arrayMinVal, arrayMinVal.Min()));
                if (MyArray.CheckMaxIndex(arrayMaxVal) > MyArray.CheckMinIndex(arrayMinVal))
                {
                    Array.Sort<int>(arrayMaxVal, new Comparison<int>((i1, i2) => i1.CompareTo(i2)));
                    Console.WriteLine("New array: " + string.Join(" ", arrayMaxVal)  + "\n"); //Сортировка по возрастанию
                }
                else if (MyArray.CheckMaxIndex(arrayMaxVal) < MyArray.CheckMinIndex(arrayMinVal))
                {
                    Array.Sort<int>(arrayMaxVal, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
                    Console.WriteLine("New array: " + string.Join(" ", arrayMaxVal)  + "\n"); //Сортировка по убыванию                
                }
            }
        }
    }
}
