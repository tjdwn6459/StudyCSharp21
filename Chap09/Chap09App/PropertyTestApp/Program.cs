﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    //생일정보 클래쓰
    class BirthdayInfo
    {
        //name, birthday속성을 접근자로 제공
        private string name;
        private DateTime birthday;

        //string타입의 name을 선언
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //datetime 타입의 Birthday를 선언
        public DateTime Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }
        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public DateTime GetBirthday()
        {
            return this.birthday;
                }

       
public void SetBirthday(DateTime dateTime)
        {
            this.birthday = birthday;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("일반 GET/SET 메서드 사용");

            BirthdayInfo info = new BirthdayInfo();
            info.SetName("홍길동");
            info.SetBirthday(new DateTime(1990, 1, 8));

            Console.WriteLine($"이름: {info.GetName()}");
            Console.WriteLine($"생일 : {info.GetBirthday()}");

            Console.WriteLine("프로퍼티 사용");

            BirthdayInfo info2 = new BirthdayInfo();
            info2.Name = "홍길순";
            info2.Birthday = new DateTime(1992, 3, 16);

            Console.WriteLine($"이름: {info2.GetName()}");
            Console.WriteLine($"생일 : {info2.GetBirthday()}");

        }
    }
}
