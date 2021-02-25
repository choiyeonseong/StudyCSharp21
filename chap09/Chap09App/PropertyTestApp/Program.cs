using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    //생일 정보 클래스
    class BirthdayInfo
    {
        private string name;
        public DateTime birthday;

        //Property
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }  //value : 프로퍼티에서 사용, 무조건 value
        }
        public DateTime Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }

        //Getter,Setter
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
        public void SetBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("일반 get,set 메서드 사용");

            BirthdayInfo info = new BirthdayInfo();
            info.SetName("홍길동");    // 메서드처럼 값을 입력
            info.SetBirthday(new DateTime(1999, 1, 8));

            Console.WriteLine($"오늘은 {info.GetBirthday()}!!\n" +
                              $"{info.GetName()}의 생일을 축하합니다!!");

            Console.WriteLine("프로퍼티 사용");

            BirthdayInfo info2 = new BirthdayInfo();
            info2.Name = "홍길순"; // 멤버 변수에 접근하는 것 처럼 값을 입력
            info2.Birthday = new DateTime(1992, 8, 19);

            Console.WriteLine($"오늘은 {info2.Birthday}!!\n" +
                              $"{info2.Name}의 생일을 축하합니다!!");
        }
    }
}
