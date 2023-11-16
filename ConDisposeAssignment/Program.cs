using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDisposeAssignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LargeDataCollection dataCollection = new LargeDataCollection(new object[] { 1, "hello", new object() });

            dataCollection.Add(2);
            dataCollection.Add("world");
            dataCollection.Add(new object());

            Console.WriteLine(dataCollection[0]); // 1
            Console.WriteLine(dataCollection[1]); // "hello"
            Console.WriteLine(dataCollection[2]); // object instance

            dataCollection.Remove(1);
            dataCollection.Remove("world");
            dataCollection.Remove(new object());

            dataCollection.Dispose();
            Console.ReadKey();
        }
    }
}