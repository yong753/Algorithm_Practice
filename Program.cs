using System;

namespace Algorithm_Practice
{
    class Program
    {
        static void Main()
        {
            // 문제 - 수학1 -벌집문제
            // 각 회당 벌집방 수가 얼마나 늘어나는지를 수식화
            // 가고싶은 방이 속해있는 단계 - 1 만큼이 최소거리
            
            int x = int.Parse(Console.ReadLine());
            double n = Math.Sqrt((x - 0.25) / 3) + 0.5;

            Console.WriteLine(Math.Ceiling(n));
            Console.ReadKey();

        }
    }
}
