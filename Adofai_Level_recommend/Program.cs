using System;

namespace AdofaiRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            Console.WriteLine("얼불춤 맵 추천봇");
            Console.WriteLine("1번 입력: 난이도 설정");
            Console.WriteLine("2번 입력: 랜덤 포럼 번호 생성");
            int aa = int.Parse(Console.ReadLine());
            switch (aa)
            {
                case 1:
                    //난이도 설정
                    Console.WriteLine("최소 난이도를 입력하세요 : ");
                    int minLevel = int.Parse(Console.ReadLine());
                    Console.WriteLine("최대 난이도를 입력하세요 : ");
                    int maxLevel = int.Parse(Console.ReadLine());

                    //몇번째 레벨
                    Console.WriteLine("몇번째 레벨까지 추천합니까?");
                    int curLevel = int.Parse(Console.ReadLine());

                    //개수 추천
                    Console.WriteLine("추천 레벨의 개수를 입력하세요");
                    int level = int.Parse(Console.ReadLine());

                    for (int i = 0; i < level; i++)
                    {
                        float b = a.Next(minLevel, maxLevel);
                        Console.WriteLine($"난이도 : {b} ");

                        int c = a.Next(1, curLevel);
                        Console.WriteLine($"{c}번째 레벨");

                    }
                    break;
                case 2:
                    Random aaa = new Random();
                    Console.WriteLine("사용법");
                    Console.WriteLine("adofai.gg/levels/ 뒤에 숫자를 입력하면 된다");
                    //레벨 개수
                    Console.WriteLine("추천 레벨 개수 입력");
                    int levels = int.Parse(Console.ReadLine());

                    for (int i = 0; i <= levels; i++)
                    {
                        int levelcur = aaa.Next(0, 5000);
                        Console.WriteLine($"추천레벨 {i} : {levelcur}");
                    }
                    break;
                default:
                    Console.WriteLine("잘못된 값을 입력했습니다.");
                    break;
            }
            
        }
    }
}
