using Chap09App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap09App
{
    class MyClass
    {
        private int value; //0~120 값만 입력받는 멤버변수
        private double dZeta;
        private float fPng;
        private string strVal;
        private int inCode;

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


        public MyClass(int value) => IValue = iValue;

        internal void PrintValue()
        {
            throw new NotImplementedException();
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

        public void PrintValue()
        {
            Console.WriteLine($"값은 {this.value}");
        }
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

