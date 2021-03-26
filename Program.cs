using System;
using System.Collections.Generic;

namespace Algorithm_Practice
{
    class Program
    {
        static void Main()
        {
            // 문제 - 수학1 -벌집문제
            // 각 회당 벌집방 수가 얼마나 늘어나는지를 수식화
            // 가고싶은 방이 속해있는 단계 만큼이 최소거리

            //int x = int.Parse(Console.ReadLine());
            //double n = Math.Sqrt((x - 0.25) / 3) + 0.5;

            //Console.WriteLine(Math.Ceiling(n));
            //Console.ReadKey();



            // 수학1 - 분수찾기
            //int x = int.Parse(Console.ReadLine());
            //double n = Math.Ceiling(Math.Sqrt(2 * x + 0.25) - 0.5);
            //double i = x - n * (n - 1) / 2;

            //if(n%2 == 0)
            //{
            //    Console.WriteLine("{0}/{1}",i ,n - i + 1);
            //}else if(n%2 == 1)
            //{
            //    Console.WriteLine("{0}/{1}", n - i + 1,i);
            //}




            // 수학1 - 달팽이는 올라가고싶다.
            //string[] inputString = Console.ReadLine().Split(' ');
            //int a = int.Parse(inputString[0]);
            //int b = int.Parse(inputString[1]);
            //int v = int.Parse(inputString[2]);

            //double x = Math.Ceiling((v - a)/(double)(a - b)) + 1;

            //Console.WriteLine(x);

            //Console.ReadKey();




            // 수학1 - AMC호텔
            //기본 객체 생성
            int testCase = int.Parse(Console.ReadLine());
            List<double> H = new List<double>();
            List<double> W = new List<double>();
            List<double> N = new List<double>();

            //dataList에 testCase숫자를 제외한 Data값을 차례대로 입력
            for (int i =0; i<testCase; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                H.Add(double.Parse(data[0]));
                W.Add(double.Parse(data[1]));
                N.Add(double.Parse(data[2]));
            }

            //방번호 결정
            for(int i=0; i<H.Count; i++)
            {
                double floor = (N[i] % H[i]);
                if (N[i] % H[i] == 0)
                {
                    floor =  H[i];
                }
                double column = Math.Ceiling((N[i] / H[i]));

                Console.WriteLine("{0}{1}", floor.ToString() , column.ToString("00"));
            }



        }
    }
}
