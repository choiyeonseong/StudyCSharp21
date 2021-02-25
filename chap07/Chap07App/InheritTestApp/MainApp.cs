using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTestApp
{
    class Parent
    {
        protected string Name;  // private : 자식class에서 접근할수없음, protected : 자식class에서만 접근 가능, 외부 class에서는 접근 불가능

        public Parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Parent() 생성자");
        }

        ~Parent()   //소멸자(없어도 컴파일러가 알아서 만들어줌) : 생성된 순서와 반대로 소멸됨 (ex) 생성순서 : 1 - 2 - 3 / 소멸순서 3 - 2 - 1)
        {
            Console.WriteLine($"{this.Name}.Parent() 소멸자");
        }
        public void ParentMethod()
        {
            //...
            Console.WriteLine($"{this.Name}.ParentMethod() 실행");
        }
    }
    class Child : Parent
    {
        public string Color;   // 색상

        // 부모 class : super, base / 자기 자신 class : this 
        public Child(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Child() 생성자");  
        }
     /*   ~Child()    //소멸자
        {
            Console.WriteLine($"{this.Name}.Child() 소멸자");
        }
     */
        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.ChildMethod() 실행");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent("부모");
            p.ParentMethod();   // 부모클래스 메서드 실행

            Child c = new Child("자식");
            //c.Color;    // 부모클래스에 없는 것을 만들 수 있음(부모클래스 + α)
            c.ParentMethod();   // 부모의 메서드 실행
            c.ChildMethod();    // 자식클래스 메서드 실행
        }
    }
}
