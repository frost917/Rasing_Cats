using System;
using System.Collections.Generic;
using System.Timers;

namespace Rasing_Cats
{
    partial class Program
    {
        static bool isDead = false;
        static DateTime days = new DateTime(2019, 1, 1);
        static Money money = new Money(100, 0);

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
                Console.WriteLine($"정보창      자금: {money.Balance}");
                Console.WriteLine("1. 고양이, 2. 당신, 3. 잠자기, 0. 게임 종료");
                select = Console.ReadLine();

                switch(select)
                {
                    case "1":
                        {
                            Console.WriteLine("당신의 주인ㄴ...아니 고양이에 대해!");
                            Console.WriteLine("1. 정보, 2. 놀아주기, 3. 밥주기, 0. 뒤로가기");
                            select = Console.ReadLine();

                            switch(select)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("당신의 고양이에 대한 정보에요!");
                                        Console.WriteLine($"이름: {master.Name}, " +
                                                            $"나이: {master.Age}, " +
                                                            $"몸무게: {master.Weight}");
                                        if(master.Age > 1)
                                        {
                                            Console.WriteLine($"고양이의 성격은 " +
                                                $"{master.GetPersona()}이에요!");
                                            Console.WriteLine(master.GetPersonaInfo());
                                        }
                                        else
                                            Console.WriteLine("고양이의 나이가 1살이 " +
                                                "넘기 전까진 볼 수 없어요!");

                                        break;
                                    }
                            }

                            break;
                        }
                }

            }
        }
    }
}
