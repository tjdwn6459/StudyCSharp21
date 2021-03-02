﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCopyArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 11, 21, 33, 45, 56 }; //5개 int 배열
            int[] target = new int[5];//위에 있는 소스의 갯수 /5개 int 배열 초기화

            CopyArray(source, target); // int 배열 복사(베열과 똑같은 사이즈)
            Console.WriteLine("배열복사");
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] target2 = new string[source2.Length];

            CopyArray(source2, target2);
            Console.WriteLine("string배열복사");
            foreach (var item in target2)
            {
                Console.WriteLine(item);
            }
        }

        private static void CopyArray<T>(T[] source,T[] target)//데이터 형식이 사용된부분을 T로 치환
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            };
        }
    }
}
