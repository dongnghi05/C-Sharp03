using System;

namespace Exercise7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Color color = new Color(4, 8, 10);
            Ball ball = new Ball(8, color);
            ball.Throw();
            ball.Throw();
            ball.Throw();
            ball.Throw();

            Console.WriteLine($"Befor Pop: {ball.numberofTimes()}");
            ball.Pop();
            ball.Throw();
            ball.Throw();
            Console.WriteLine($"After Pop: {ball.numberofTimes()}");
        }
    }
}
