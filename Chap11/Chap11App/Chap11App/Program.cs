using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11App
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

            float[] source3 = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f, 6.6f };
            float[] target3 = new float[source3.Length];
            CopyArray(source3, target3);
            Console.WriteLine("float배열복사");
            foreach (var item in target3)
            {
                Console.WriteLine(item);
            }


        }

        private static void CopyArray(float[] source3, float[] target3)
        {
            for (int i = 0; i < source3.Length; i++)
            {
                target3[i] = source3[i];
            }
        }

        private static void CopyArray(string[] source2, string[] target2)
        {
            for (int i = 0; i < source2.Length; i++)
            {
                target2[i] = source2[i];
            }
        }

        private static void CopyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)//소스를 넣으면서 값이 돈다
            {
                target[i] = source[i];
            }
        }
    }
}
