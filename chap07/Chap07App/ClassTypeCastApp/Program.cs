using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCastApp
{
    class 포유류
    {
        public void 키우다()
        {
            Console.WriteLine("키우다()");
        }
    }

    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍");
        }
    }

    class 고양이 : 포유류
    {
        public void 야옹()
        {
            Console.WriteLine("야옹");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            포유류 _포유류 = new 포유류();
            _포유류.키우다();

            _포유류 = new 강아지();   // 형변환(부모에 자식 넣음)
            _포유류.키우다();
            강아지 응팔이;

            if(_포유류 is 강아지)
            {
                응팔이 = _포유류 as 강아지;
                응팔이.멍멍();
            }

            /*//_포유류.멍멍();    // 불가능
            _포유류 = new 고양이();   // 형변환(부모 -> 자식) : 묵시적 형변환
            _포유류.키우다();
            //_포유류.야옹();    // 불가능*/

            강아지 뽀삐 = null;
            if(뽀삐 is 포유류)
            {
                Console.WriteLine("이부분이 실행");
                뽀삐 = new 포유류() as 강아지;
                뽀삐.키우다();
                뽀삐.멍멍();
            }

            /*//강아지 뽀삐 = new 포유류();        // 큰것(부모)에 작은것(자식)은 넣을수 있으나 작은것(자식)에 큰것(부모)을 넣기는 힘듬
            //강아지 뽀삐 = (강아지) new 포유류(); // -> (강아지)형변환을 추가 : 명시적 형변환 (*실행에러*)
            뽀삐.키우다();
            뽀삐.멍멍();    // 오류 : 포유류에는 멍멍()이 없기때문에
            //고양이 로미 = (고양이) new 포유류();
            로미.키우다();
            로미.야옹();    // 오류 : 포유류에는 야옹()이 없기때문에*/
        }
    }
}