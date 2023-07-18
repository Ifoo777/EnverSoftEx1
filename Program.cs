using System;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] list1 = new int[] { 1,2,3,4,5};
            int[] list2 = new int[] { 3,4,5,6,7};

            //a. Show the common elements in both lists. E.g the common elements are "3 4 5", because they are contained in both lists.

            var commonElements = list1.Intersect(list2);
            Console.WriteLine("A. Common Elements in both lists. Answer: " + string.Join(" ",commonElements));

           //b. Show the elements from list 1, but is not found in list2. E.g 1 2"

            var elementsInList1NotInList2 = list1.Except(list2);
           Console.WriteLine("B.Elements which appear in List 1 but do not appear in List 2. Answer: " + string.Join(" ",elementsInList1NotInList2));

            var elementsInList2NotInList1 = list2.Except(list1);
            Console.WriteLine("C. Elements which appear in List 2 but do not appear in List 1. Answer: " + string.Join(" ",elementsInList2NotInList1));

            Console.WriteLine("Press <Enter> to continue");
            Console.ReadLine();


        }
    }
}