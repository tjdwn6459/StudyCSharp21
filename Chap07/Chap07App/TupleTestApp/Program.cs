﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple1 = (1, "안성주", "010-2740-5111", "부산시 수영구", true);

            var tuple2 = (Idx: 2, Name: "홍길동", phone: "010-9999-9999", Address: "경남 창원시 의창구", Marrige: false);

            Console.WriteLine($"{tuple1.Item1}/{tuple1.Item2}/ {tuple1.Item3}/ {tuple1.Item4}/ {tuple1.Item5}");
            Console.WriteLine($"{tuple2.Item1}/{tuple2.Item2}/ {tuple2.Item3}/ {tuple2.Item4}/ {tuple2.Item5}");
            Console.WriteLine($"{tuple2.Idx}/{tuple2.Name}/ {tuple2.phone}/ {tuple2.Address}/ {tuple2.Marrige}");
        }
    }
}
