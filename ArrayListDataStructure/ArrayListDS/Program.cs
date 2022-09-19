using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayListDataStructure;

namespace ArrayListDS
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Obj = new ArrayList();

            Obj.Add(4414);
            Obj.Add(23);
            Obj.Add(24);
            Obj.Add(25);
            Obj.Add(26);
            Obj.Add(27);
            Obj.Add(0);
            Obj.Add(4414);
            Obj.Add(12);
            Obj.Add(321);
            Obj.Add(12);
            Obj.Add(321);
            Obj.Add(12);
            Obj.Add(321);
            Obj.Add(321);
            Obj.Add(321);
            Obj.Add(12);
            Console.WriteLine("Add values");
            Console.WriteLine(Obj.Print());
            Console.WriteLine();

            Console.WriteLine("After set values");
            Obj.Set(2, 3456);
            Console.WriteLine(Obj.Print());
            Console.WriteLine();

            Console.WriteLine("After insert value");
            Obj.Insert(3, 9999);
            Console.WriteLine(Obj.Print());
            Console.WriteLine();

            Console.WriteLine("Check contains");
            Console.WriteLine(Obj.Contains(21));
            Console.WriteLine(Obj.Contains(27));
            Console.WriteLine();

            Console.WriteLine("Get Values");
            Console.WriteLine(Obj.Get(5));
            Console.WriteLine();

            Console.WriteLine("After delete Index Value");
            Obj.Delete(5);
            Console.WriteLine(Obj.Print());
            Console.WriteLine();

            Console.WriteLine("Count");
            Console.WriteLine(Obj.Count);
            Console.WriteLine();

            Console.WriteLine("IndexOf()");
            Console.WriteLine(Obj.IndexOf(12));
            Console.WriteLine();

            Console.WriteLine("Maximum Value in the ArrayList");
            Console.WriteLine(Obj.Max());
            Console.WriteLine();

            Console.WriteLine("Minimum Value in the ArrayList");
            Console.WriteLine(Obj.Min());
            Console.WriteLine();

            Console.WriteLine("After delete Index Value");
            Obj.Delete(5);
            Console.WriteLine(Obj.Print());
            Console.WriteLine();

            Console.WriteLine("Minimum Value in the ArrayList");
            Console.WriteLine(Obj.Min());
            Console.WriteLine();

            Console.WriteLine("Sum of All Elements in the ArrayList");
            Console.WriteLine(Obj.Sum());
            Console.WriteLine();

            Console.WriteLine("ArrayList in Reverse Order");
            Console.WriteLine(Obj.Reverse());
            Console.WriteLine();
            
            Console.WriteLine("New Array Containing the Elements of the ArrayList");
            Console.WriteLine(Obj.ToArray());
            Console.WriteLine();

            Console.WriteLine("New Array containing the Elements of the array list starting from the startIndex");
            Console.WriteLine(Obj.ToArray(3));
            Console.WriteLine();

            Console.WriteLine("New Array containing the elements of the array list from startIndex to endIndex");
            Console.WriteLine(Obj.ToArray(3,6));
            Console.WriteLine();

            Console.WriteLine("Last ArrayList Value IsEmpty");
            Console.WriteLine(Obj.lastIsEmpty());
            Console.WriteLine();

            Console.WriteLine("DeleteValue(int value, bool RemoveAll: false)");
            Obj.DeleteValue(12, false);
            Console.WriteLine(Obj.Print());

            Console.WriteLine("DeleteValue(int value, bool RemoveAll: true)");
            Obj.DeleteValue(4414, true);
            Console.WriteLine(Obj.Print());

            Console.WriteLine("Distinct Element InOrder:false");
            Console.WriteLine(Obj.Distinct(true));
            Console.WriteLine();

            Console.WriteLine("AddAll()");
            int[] values1 = new int[] { 2, 3, 1 };
            Obj.AddAll(values1);
            Console.WriteLine(Obj.Print());
            Console.WriteLine();

            Console.WriteLine("InsertAll()");
            int[] values2 = new int[] { 345, 2343, 124 };
            Obj.InsertAll(10, values2);
            Console.WriteLine(Obj.Print());
            Console.WriteLine();

            Console.WriteLine("Sort(bool InDescending:true)");
            Console.WriteLine(Obj.Sort(true));
            Console.WriteLine();
            
            Console.WriteLine("Sort(bool InDescending:false)");
            Console.WriteLine(Obj.Sort(false));
            Console.WriteLine();

            Console.WriteLine(Obj.Print());

            Obj.Clear();
            Console.WriteLine("Count: " + Obj.Count);
            Console.WriteLine(Obj.Print());

            Obj.Add(683);
            Obj.Add(763);
            Obj.Add(4414);
            Obj.Add(12);
            Obj.Add(321);
            Obj.Add(12);
            Obj.Add(321);
            Obj.Add(12);
            Obj.Add(321);
            Obj.Add(321);
            Obj.Add(321);
            Obj.Add(12);
            Console.WriteLine(Obj.Print());
            Console.WriteLine("Count: " + Obj.Count);

            //DOUBT!!!
            ArrayList gf = new ArrayList(2);
        }
    }
}
