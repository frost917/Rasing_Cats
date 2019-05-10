using System;
using System.Collections.Generic;
using System.Timers;

namespace Rasing_Cats
{
    partial class Program
    {
        static bool isDead = false;
        static DateTime days = new DateTime(2019, 1, 1);

        static void Main()
        {
            string name;
            Console.WriteLine("현실에선 키우지 못하는 고양이를 키워봐요!");
            Console.WriteLine("먼저 당신의 이름을 알려주세요!");
            name = Console.ReadLine();
            Human servant = new Human(name);


            Console.Clear();
            Console.WriteLine("고양이의 이름을 알려주세요!");
            name = Console.ReadLine();
            Cat master = new Cat(name);

            string select;
            while(!isDead)
            {
                Console.WriteLine("정보창      자금: {0}", );
                Console.WriteLine("1. 고양이, 2. 당신, 3. 잠자기, 0. 게임 종료");
                select = Console.ReadLine();

                switch(select)
                {
                    case "1":
                        {
                            Console.WriteLine("당신의 주인ㄴ...아니 고양이에 대해!");
                            Console.WriteLine("1. 정보, 2. 놀아주기, 3. 밥주기, 0. 뒤로가기");
                            select = Console.ReadLine();


                            break;
                        }
                }

            }
        }
    }
}
