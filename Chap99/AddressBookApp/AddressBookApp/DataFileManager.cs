using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AddressBookApp
{
    //주소록 정보 클래스
    class DataFileManager
    {
        //text 파일에서 저장된 주소록을 불러온다(로드) / list에데이터가 다 담겨있다
        string dataFileName = "address.dat";


        public List<AddressInfo> ReadData()
        {

            var listResult = new List<AddressInfo>();
            //D:\GitRepository\StudyCSharp21\Chap99\AddressBookApp\AddressBookApp\bin\Debug\netcoreapp3.1\address.dat
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName; //데이터 파일


            var sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));//open
            while (sr.EndOfStream == false)
            {
                var temp = sr.ReadLine(); //입력한 파일의 정보를 읽는다
                //temp 잘라서 manager.listAddress 할당
                //temp = 안성주|010-1111-2222|부산시 수영구 
                string[] splits = temp.Split("|"); //문자열을 |로 자른다 , 한번 돌때마다 세개 배열 만들어짐
                listResult.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
            }
            sr.Close(); //끝나면 while이니 계속 돌아서 값 입력

            return listResult;
        }


        public void WriteData(List<AddressInfo> list) //void 비어있는 출력값, 위에서 생성된 칸
        {
            //주소록을 다시 파일에 씀
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName;//데이터 파일
            //주소록을 다시 파일에 씀
            var sw = new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));

            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");//안에 들어가는 내용 만든다, |값을 구분하는 값
                }
            }

            sw.Close();
        }
    }
}
