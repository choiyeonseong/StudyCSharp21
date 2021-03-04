using System;
using System.Collections.Generic;

namespace AddressBookApp
{
    class AddressInfo
    {// 주소록 정보 클래스
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }

    class MainApp
    {
        static void PrintMenu()
        {
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine("1. 주소 입력");
            Console.WriteLine("2. 주소 검색");
            Console.WriteLine("3. 주소 수정");
            Console.WriteLine("4. 주소 삭제");
            Console.WriteLine("5. 주소 전체 출력");
            Console.WriteLine("6. 프로그램 종료");
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        }
        static int SelectMenu()
        {
            Console.Write("메뉴를 선택하세요 >>> ");
            string input = Console.ReadLine();
            int.TryParse(input, out int result);
            if (!(result > 0 && result < 7)) { result = 0; }

            return result;
        }
        private static void InputAddress()
        {
            Console.WriteLine("##주소 입력##");
            Console.WriteLine("------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            Console.Write("전화 입력 : ");
            string phone = Console.ReadLine();
            Console.Write("주소 입력 : ");
            string address = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                Console.WriteLine("빈값은 입력할수 없습니다.");
                Console.ReadLine();
            }
            else { listAddress.Add(new AddressInfo() { Name = name, Phone = phone, Address = address }); }
        }
        private static void SearchAddress()
        {
            Console.WriteLine("##주소 검색##");
            Console.WriteLine("------------------------------");
            Console.Write("이름 검색 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false;    // 검색을 성공했는지?(찾는 이름이 있는지?)
            
            foreach (var item in listAddress)
            {
                if (item.Name == name)
                {
                    isFind = true;  // 찾았음
                    Console.WriteLine($"[{idx}]---------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("------------------------------");
                    break;  // foreach 빠져나감
                }
                idx++;
            }

            if (isFind == false) { Console.WriteLine("검색 결과가 없습니다."); }

            Console.ReadLine(); // 화면 멈춤
        }
        private static void UpdateAddress()
        {
            Console.WriteLine("##주소 수정##");
            Console.WriteLine("------------------------------");
            Console.Write("이름 검색 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false;

            foreach (var item in listAddress)
            {
                if (item.Name == name)
                {
                    isFind = true; // 찾았다
                    Console.WriteLine($"[{idx}]---------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("------------------------------");
                    Console.Write("이름 재입력 : ");
                    string uName = Console.ReadLine();
                    Console.Write("전화 재입력 : ");
                    string uPhone = Console.ReadLine();
                    Console.Write("주소 재입력 : ");
                    string uAddress = Console.ReadLine();
                    item.Name = uName;
                    item.Phone = uPhone;
                    item.Address = uAddress;
                    break;  // foreach 빠져나감
                }
                idx++;
            }

            if (isFind == false) { Console.WriteLine("검색 결과가 없습니다."); }

            Console.ReadLine(); // 화면 멈춤
        }
        private static void DeleteAddress()
        {
            Console.WriteLine("##주소 삭제##");
            Console.WriteLine("------------------------------");
            Console.Write("이름 검색 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false;

            foreach (var item in listAddress)
            {
                if (item.Name == name)
                {
                    isFind = true;
                    Console.WriteLine($"[{idx}]---------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("------------------------------");
                    Console.Write("삭제하시겠습니까? [y/n]");
                    string answer = Console.ReadLine(); // y/n

                    if (answer.ToUpper() == "Y")
                    {
                        listAddress.RemoveAt(idx);
                        Console.WriteLine("삭제 완료!");
                    }
                    break;  // foreach 빠져나감
                }
                idx++;
            }

            if (isFind == false) { Console.WriteLine("검색 결과가 없습니다."); }

            Console.ReadLine(); // 화면 멈춤
        }
        private static void PrintAllAddress()
        {
            Console.WriteLine("##주소 전체 출력##");
            Console.WriteLine("------------------------------");
            int idx = 0;

            if (listAddress.Count == 0) { Console.WriteLine("주소록이 없습니다."); }
            else
            {
                foreach (var item in listAddress)
                {
                    Console.WriteLine($"[{idx}]---------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine();
                    idx++;
                }
            }

            Console.ReadLine(); // 화면 멈춤
        }

        static List<AddressInfo> listAddress = new List<AddressInfo>();    // 주소록을 담을 컬렉션
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                // 메뉴 출력
                PrintMenu();
                // 메뉴번호 입력
                int menuNum = SelectMenu();

                switch (menuNum)
                {
                    case 1: // 주소 입력 화면 전환
                        Console.Clear();
                        InputAddress();

                        break;
                    case 2: // 주소 검색
                        Console.Clear();
                        SearchAddress();

                        break;
                    case 3: // 주소 수정
                        Console.Clear();
                        UpdateAddress();

                        break;
                    case 4: // 주소 삭제
                        Console.Clear();
                        DeleteAddress();

                        break;
                    case 5: // 주소 전체 출력
                        Console.Clear();
                        PrintAllAddress();

                        break;
                    case 6: // 프로그램 종료
                        Environment.Exit(0);

                        break;
                    default: // 0은 여기서 처리
                        // 아무 로직 없음
                        break;
                }
            }
        }
    }
}