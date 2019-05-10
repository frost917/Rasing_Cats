using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rasing_Cats
{
    class Cat : IBasicInfo
    {
        private int love;
        private int catPersona;

        enum Persona
        {
            Cool = 0,
            Laze,
            Active,
            Silence,
            Fast
        }

        private Dictionary<Persona, string> PersonaScript = new Dictionary<Persona, string>()
        {
            { Persona.Cool,
                "언제나 냉정침착.\r\n" +
                "겉으로는 매정하지만 속으로는 당신만을 바라보고 있다.\r\n" +
                "한밤중에 시선이 느껴진다면 이 아이 때문일지도?" },
            { Persona.Laze,
                "풍아하라\r\n" +
                "어떤 순간에서도 여유로움을 잃지 않는 성격이다.\r\n" +
                "별로 움직이지 않기에 몸무게에 주의하자." },
            { Persona.Active,
                "우당탕탕\r\n" +
                "언제나 명랑함을 잃지 않고 집을 쑥때밭으로 만든다.\r\n" +
                "많이 움직이는 만큼 밥을 많이 먹는다." },
            { Persona.Silence,
                "SSG, 집사 뒤에 있다냥.\r\n" +
                "이름을 부르지 말고 뒤를 돌아보세요.\r\n" +
                "낮이고 밤이고 항상 조용하다." },
            { Persona.Fast,
                "어딜 보시는거죠? 그건 제 잔상입니다만.\r\n" +
                "이 고양이는 고양이가 아니라 제트기입니다.\r\n" +
                "항상 빠르게 움직인다." }
        };

        private void SetPersona()
        {
            Random persona = new Random();

            catPersona = persona.Next(0, 4);
        }

        public int Love { get => love; set => love = value; }
        public int CatPersona { get => catPersona; }

        public Cat(string name)
        {
            Random weight = new Random();
            Name = name;
            Age = 0;
            Weight = weight.Next(80, 140);
            SetPersona();
        }

        public void Move()
        {
            Random moving = new Random();
        }
    }
}
