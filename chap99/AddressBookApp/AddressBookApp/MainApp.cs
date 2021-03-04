using System;
using System.Collections.Generic;

namespace AddressBookApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                AddressManager manager = new AddressManager
                {
                    listAddress = new List<AddressInfo>()
                };

                DataFileManager fileManager = new DataFileManager();
                manager.listAddress = fileManager.ReadData();   // 파일을 읽어서 가져온 데이터를 list에 저장

                while (true)
                {
                    Console.Clear();
                    manager.PrintMenu();    // 메뉴 출력
                    int menuNum = manager.SelectMenu(); // 메뉴번호 입력

                    switch (menuNum)
                    {
                        case 1: // 주소 입력 화면 전환
                            Console.Clear();
                            manager.InputAddress();
                            break;
                        case 2: // 주소 검색
                            Console.Clear();
                            manager.SearchAddress();
                            break;
                        case 3: // 주소 수정
                            Console.Clear();
                            manager.UpdateAddress();
                            break;
                        case 4: // 주소 삭제
                            Console.Clear();
                            manager.DeleteAddress();
                            break;
                        case 5: // 주소 전체 출력
                            Console.Clear();
                            manager.PrintAllAddress();
                            break;
                        case 6: // 프로그램 종료
                                // 주소록을 다시 파일에 씀
                            fileManager.WriteData(manager.listAddress);
                            Environment.Exit(0);
                            break;
                        default: // 0은 여기서 처리
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
        }
    }
}