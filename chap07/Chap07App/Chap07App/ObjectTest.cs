using System;

namespace Chap07App
{
    class ObjectTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("객체 사용");

            // 객체의 선언, 객체의 실체화
            Cat cat1 = new Cat();   // 고양이 객체의 실체(instance) 생성
            // 속성
            cat1.Name = "야통이";
            cat1.Color = "고등어";
            // 기능
            cat1.Meow();

            Cat cat2 = new Cat();
            cat2.Name = "삼색이";
            cat2.Color = "삼색";
            cat2.Meow();

            Cat cat3 = new Cat();
            cat3.Color = "고등어";
            cat3.Name = "무";
            cat3.Meow();

            Cat cat4 = new Cat("래기", "고등어");
            cat4.Meow();
            Cat cat5 = new Cat(_name: "Marilyn", _color: "젖소");
            cat5.Meow();
            Cat cat6 = new Cat("연님", "고등어", "암컷");
            cat6.Meow();
        }
    }

    // 객체, 클래스
    class Cat
    {
        // 기본 생성자 - defalut값 (안 만들어도 쓸 수 있음)
        public Cat() { }

        //~Cat() { } // 더이상 필요없음

        // 사용자 지정 생성자 - 기본 생성자를 만들어야 쓸 수 있음
        public Cat(string _name, string _color)
        {
            Name = _name;
            Color = _color;
        }

        // 생성자 오버로딩
        public Cat(string _name, string _color, string _gender)
        {
            Name = _name;
            Color = _color;
            Gender = _gender;
        }

        // 특성, 속성, 변수
        public string Name;
        public string Color;
        public string Gender;

        // 행위, 기능, 메소드
        public void Meow()
        {
            if (Color == "고등어")
                Console.WriteLine($"{Name} : 이얏호응");
            else if(Color == "삼색")
                Console.WriteLine($"{Name} : 삐약");
            else
                Console.WriteLine($"{Name} : 엙옹");
        }
    }
}
