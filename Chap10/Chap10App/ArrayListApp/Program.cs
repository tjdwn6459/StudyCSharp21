using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(80);  //사이즈 필요없이 array는 그냥 넣으면 댐
            array.Add(74);
            array.Add(81);
            array.Add(90);
            array.Add(34);

            var loc = array.IndexOf(81);
            array.Insert(loc, 50);

            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("90삭제");
            loc = array.IndexOf(90);
            array.RemoveAt(4); //90삭제


            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("정렬");
            array.Sort();
            foreach (var item in array);
            {
                Console.WriteLine($"");
            }
        }
    }
}
