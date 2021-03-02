using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableApp
{
    class Program
    {
        private static IEnumerable<DictionaryEntry> hit;

        static void Main(string[] args)
        {
            Console.WriteLine("HashTable 예제");

            Hashtable ht = new Hashtable();
            ht["일"] = "One";
            ht["이"] = "Two";
            ht["삼"] = "Three";
            ht["사"] = "Four";

            Console.WriteLine(ht["일"]);//One

            foreach(DictionaryEntry item in hit)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            int[] arr = { 123, 456, 789 };
            ArrayList list = new ArrayList(arr);
            ArrayList list2 = new ArrayList();
        }
    }
}
