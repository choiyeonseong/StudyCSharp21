using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_QuizApp
{
    class Address
    {
        private string name;
        private string phone;
        private string addr;

        public string Name
        { get { return this.name; } set { this.name = value; } }
        public string Phone
        { get { return this.phone; } set { this.phone = value; } }
        public string Addr
        { get { return this.addr; } set { this.addr = value; } }

        public void modifyAddr()
        {
            Console.Write("이름 수정 : ");
            string tmpName = Console.ReadLine();
            if (!String.IsNullOrEmpty(tmpName))
            { Name = tmpName; }

            Console.Write("전화 수정 : ");
            string tmpPhone = Console.ReadLine();
            if (!String.IsNullOrEmpty(tmpPhone))
            { Phone = tmpPhone; }

            Console.Write("주소 수정 : ");
            string tmpAddr = Console.ReadLine();
            if (!String.IsNullOrEmpty(tmpAddr))
            { Addr = tmpAddr; }
        }

        public void printAddr()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"전화 : {phone}");
            Console.WriteLine($"주소 : {addr}");
        }
    }
    class AddressMenu
    {
        public static int arr = 0;
        public static Address[] address;

        public static int CompareAddr()
        {
            Console.Clear();
            Console.Write("이름 검색 : ");
            string searchName = Console.ReadLine();
            Console.WriteLine($"-------------------");

            for (int i = 0; i < arr; i++)
            {
                if (string.Compare(address[i].Name, searchName) == 0)
                { return i; }
            }
            return -1;
        }

        public static void insertAddr()
        {
            Console.Clear();
            Console.Write("이름 입력 : ");
            string tmpName = Console.ReadLine();

            Console.Write("전화 입력 : ");
            string tmpPhone = Console.ReadLine();

            Console.Write("주소 입력 : ");
            string tmpAddr = Console.ReadLine();

            address[arr] = new Address()
            {
                Name = tmpName,
                Phone = tmpPhone,
                Addr = tmpAddr
            };
            arr++;
        }

        public static void deleteAddr()
        {
            int deleteIdx = CompareAddr();

            if (deleteIdx < 0) { Console.WriteLine("찾는 값이 없습니다."); }
            else
            {
                for (int i = deleteIdx; i < arr; i++)
                { address[i] = address[i + 1]; }
                arr--;
                Console.WriteLine("삭제 완료");
            }
        }

        public static void searchAddr()
        {
            int searchIdx = CompareAddr();

            if (searchIdx < 0)
                Console.WriteLine("찾는 값이 없습니다.");
            else address[searchIdx].printAddr();
        }

        public static void replaceAddr()
        {
            int searchIdx = CompareAddr();
            address[searchIdx].printAddr();
            Console.WriteLine($"-------------------");
            if (searchIdx < 0)
                Console.WriteLine("찾는 값이 없습니다.");
            else address[searchIdx].modifyAddr();
        }

        public static void printAllAddr()
        {
            Console.Clear();
            if (arr == 0) { Console.WriteLine("주소록이 비었습니다."); }
            else
            {
                for (int i = 0; i < arr; i++)
                {
                    Console.WriteLine($"--------{i}--------");
                    address[i].printAddr();
                    Console.WriteLine($"-------------------");
                }
            }
        }
    }

    class Program : AddressMenu
    {
        static void Main(string[] args)
        {
            int menuIdx;

            address = new Address[10];

            while (true)
            {
                Console.WriteLine("---------------------\n" +
                          "0. 주소 입력\n" +
                          "1. 주소 검색\n" +
                          "2. 주소 수정\n" +
                          "3. 주소 삭제\n" +
                          "4. 주소 전체 출력\n" +
                          "5. 프로그램 종료\n" +
                          "---------------------");
                Console.Write("메뉴를 선택하세요 >> ");
                string strIdx = Console.ReadLine();

                if (Int32.TryParse(strIdx, out menuIdx))
                {
                    switch (menuIdx)
                    {
                        case 0://주소 입력
                            insertAddr();
                            break;
                        case 1://주소 검색
                            searchAddr();
                            break;
                        case 2://주소 수정
                            replaceAddr();
                            break;
                        case 3: //주소 삭제
                            deleteAddr();
                            break;
                        case 4://주소 전체 출력
                            printAllAddr();
                            break;
                        case 5: //프로그램 종료
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("다시 입력해주세요.");
                }
            }
        }
    }
}
