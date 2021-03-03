using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15App
{
    class Profile
    {

        public string Name { get; set; }
        public short Height { get; set; }

    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 }; // 10개배열래
            //LINQ를 안쓰는 방식
            /*List<int> result = new List<int>();

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
            }
            result.Sort();
            */
            //LINQ를 쓰는 방식
            var result = from item in numbers
                         where item % 2 == 0
                         orderby item
                         select item;

            foreach (var item in result)
            {
                Console.WriteLine($"짝수 : {item}");
            }

            //new로 인해 객체로 나타난다
            List<Profile> profiles = new List<Profile>();
            profiles.Add(new Profile() { Name = "정우성", Height = 186 });
            profiles.Add(new Profile() { Name = "김태희", Height = 158 });
            profiles.Add(new Profile() { Name = "고현정", Height = 172 });
            profiles.Add(new Profile() { Name = "이문세", Height = 178 });
            profiles.Add(new Profile() { Name = "하하", Height = 171 });

            List<Product> products = new List<Product>
            {
                new Product() {Title = "비트", Star = "정우성"},
                new Product() {Title = "cf다수", Star = "김태희"},
                new Product() {Title = "아이리스", Star = "김태희"},
                new Product() {Title = "모래시계", Star = "고현정"},
                new Product() {Title = "솔로예찬", Star = "이문세"},
            }; //밑에서 조인을 할때 하하의 데이터 값은 입력하지 않아서 하하는 안뜬다

            var resProfiles = from item in profiles
                              where item.Height < 175
                              orderby item.Height ascending /*descending*/
                              select new
                              {//익명의 새로운 형태의 값을 받아서 만들것이다.
                                  Name = item.Name,
                                  Height = item.Height,
                                  InchHeight = item.Height * 0.393
                              };

            foreach (var item in resProfiles)

            {
                Console.WriteLine($"{item.Name}, {item.Height}cm, {item.InchHeight}inch");
            }



            ;//위에랑 다른 new때문에 위에는 객체 밑엔 string로 나타난다
            var resProfiles2 = from item in profiles
                               where item.Height < 175
                               orderby item.Height ascending /*descending*/
                               select item.Name;

            foreach (var item in resProfiles2)
            {
                Console.WriteLine($"{item}");
            }

            //group by
            var resProfiles3 = from item in profiles
                               orderby item.Height
                               group item by item.Height < 175 into g //g는 grouping 된 값
                               select new
                               {
                                   GroupKey = g.Key,
                                   Items = g
                               };
            foreach (var group in resProfiles3)
            {
                Console.WriteLine($"175cm 미만 그룹 :{group.GroupKey}"); //그 그룹에서 해당하는 사람 과 아닌 사람을 나눈다 true, false

                foreach (var item in group.Items)
                {
                    Console.WriteLine($"  {item.Name}, {item.Height}"); //해당하데 속한 사람의 정보를 보여줌
                }
            }


            //inner 조인
            var joinProfiles = from p in profiles
                               join d in products
                               on p.Name equals d.Star
                               select new
                               {
                                   Name = p.Name,
                                   Work = d.Title,
                                   InchHeight = p.Height * 0.393
                               };
            Console.WriteLine("내부 조인 결과!");
            foreach (var item in joinProfiles)
            {
                Console.WriteLine($"이름:{item.Name}, 작품:{item.Work}, 키:{item.InchHeight}inch");
            }


            //outer 조인
            var joinProfiles2 = from p in profiles
                               join d in products
                               on p.Name equals d.Star into ps
                               from d2 in ps.DefaultIfEmpty(new Product() { Title = "작품없음"}) // 작품값이 없는곳에 새로운 product인 작품없음을 만든다
                               select new
                               {
                                   Name = p.Name,
                                   Work = d2.Title,
                                   InchHeight = p.Height * 0.393
                               };
            Console.WriteLine("외부 조인 결과!");//내부 조인된 결돠에서 d2를 가지고 조인한다
            foreach (var item in joinProfiles2)
            {
                Console.WriteLine($"이름:{item.Name}, 작품:{item.Work}, 키:{item.InchHeight}inch");
            }
        }
    }
    }

