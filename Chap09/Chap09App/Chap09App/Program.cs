using Chap09App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//set 접근자를 통해 데이터 멤버를 할당, get 접근자는 데이터 멤버 값을 검색 
namespace Chap09App
{
    class MyClass
    {
        //class안의 속성 모두 get, set접근자를 제공

        private int iValue; //0~120 값만 입력받는 멤버변수
        private double dZeta;
        private float fPng;
        private string strVal;
        private int inCode;

        //int 형의 IValue 속성 선언
        public int IValue
        {
            get
            {
                return this.iValue;
            }
            set
            {
                if (value < 0)

                    this.iValue = 0;
                else if (value > 120)
                    this.iValue = 120;
                else
                    this.iValue = value;
            }
        }


        public MyClass(int value)
        {
            IValue = iValue;
        }

        internal void PrintValue()
        {
            Console.WriteLine($"값은 {IValue}");
        }
        /* public int GetValue()
{
    return this.value;
}

public void SetValue(int value)
{
    if (value < 0)
    {
        this.value = 0;
    }
    else if (value > 120)
    {
        this.value = 120;
    }
    else
    {
        this.value = value;
    }*/

    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(1200);
            myClass.PrintValue();

            //myClass.SetValue(500) ;
            myClass.IValue = 1200;
            myClass.PrintValue();
            //Console.WriteLine($"현재온도는 {myClass.}℃ 입니다.");
        }
    }
}

