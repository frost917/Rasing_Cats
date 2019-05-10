using System;
using System.Collections.Generic;

namespace Rasing_Cats
{
    public static class JobList
    {
        private static List<Job> jobs = new List<Job>()
        {
            new Job("무직", 10,
                "\r\n불속성 효자.\r\n" +
                "매월 부모님에게 받는 용돈으로 살고있다.\r\n" +
                "이쯤되면 매년 명절 잔소리 풀코스에도 면역이다."),
            new Job("편돌이", 45,
                "\r\n편의점 갤러리 네임드\r\n" +
                "한결같은 진상손님에게도 적응하기 시작했다.")
        };

        public static List<Job> Jobs { get => jobs; set => jobs = value; }
    }
}
