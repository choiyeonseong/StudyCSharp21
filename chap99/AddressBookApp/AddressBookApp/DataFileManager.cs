using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookApp
{
    class DataFileManager
    {
        // text파일에서 저장된 주소록을 불러온다(파일 로드)
        const string dataFileName = "address.dat";  // 절대 상수

        public List<AddressInfo> ReadData()
        {
            var listResult = new List<AddressInfo>();
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName;   // 만들려고하는 데이터 파일 위치와 파일명
            var sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));   // Open

            while (sr.EndOfStream == false) // 파일이 끝나면 true가 됨
            {
                var temp = sr.ReadLine();
                // temp 잘라서 manager.listAddress에 할당
                var splits = temp.Split("|");
                listResult.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
            }
            sr.Close();

            return listResult;
        }

        public void WriteData(List<AddressInfo> list)
        {
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName;   // 만들려고하는 데이터 파일 위치와 파일명
            var sw = new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));

            if (list.Count > 0)    // 리스트에 값이 존재할 때(주소록에 주소가 있을 때)
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");
                }
            }
            sw.Close();
        }
    }
}
