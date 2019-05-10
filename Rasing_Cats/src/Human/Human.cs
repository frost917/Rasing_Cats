using System;

namespace Rasing_Cats
{
    class Human : IBasicInfo
    {
        public Human(string name)
        {
            Random weight = new Random();
            Name = name;
            Age = 20;
            Weight = weight.Next(50, 100);
        }
    }
}
