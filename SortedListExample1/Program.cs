using System;
using System.Collections.Generic;


namespace SortedListExample1
{
     class Program
    {
        static void Main()
        {
            SortedList<int, string> employees = new SortedList<int, string>()
            {
                { 102, "Smith" },
                { 105, "James" },
                { 103, "Allen" },
                { 101, "Scott" },
                { 104, "Jones" }
            };
            //add the element
            employees.Add(106, "mets");
            //remove element 
            employees.Remove(103);
            //ContainsKey
            bool k = employees.ContainsKey(102);
            Console.WriteLine("Contains Key : "+k);
            bool v = employees.ContainsValue("smith");
            Console.WriteLine("Contains value : " + v);
            //index of key
            int x = employees.IndexOfKey(102);
            Console.WriteLine("index of 102 key : "+x);
            int y = employees.IndexOfValue("mets");
            Console.WriteLine("index of mets value : "+y);
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Key+","+employee.Value);

                
            }
            employees.Clear();

            Console.ReadKey();
        }
    }
}
