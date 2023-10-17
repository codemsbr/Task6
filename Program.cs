namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cevrenin Sahesi : " + CalculateArea(1.5f));
            Console.WriteLine("Duzbucaqlinin  Sahesi : " + CalculateArea(1.5f,3f));
            Console.WriteLine("Duzbucaqli Paralelpipedin Tam Sethinin Sahesi : " + CalculateArea(1.5f,2f,12));
            Console.WriteLine("Ucbucaqlinin Daxiline Cekilmis Cevrenin Sahesi : " + CalculateArea(1.5f,2f,3.5f,12f));
        }

        static float CalculateArea(float radius)
        {
            int pi = 3;
            return radius * radius * pi;
        }

        static float CalculateArea(float wide, float extent)
        {
            return wide * extent;
        }

        static float CalculateArea(float wide, float extent, float height)
        {
            return 2 * (wide * extent + wide * height + extent * height);
        }

        static float CalculateArea(float sideLeft, float sideRight, float seat, float radius)
        {
            float triangularPerimeter = (sideLeft + sideRight + seat) / 2;
            return radius * triangularPerimeter;
        }
    }
}