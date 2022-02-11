using System;
namespace Exercise7
{
    public class Ball
    {
        int size;
        Color color;
        int times;

        public Ball(int s, Color c)
        {
            size = s;
            color = c;
        }
        public void Pop()
        {
            size = 0;
        }
        public void Throw()
        {
            if (size != 0) times++;
        }

        public int numberofTimes()
        {
            return times;
        }
    }
}
