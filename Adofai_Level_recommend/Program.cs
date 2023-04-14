using System;

namespace AdofaiRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //랜덤 선언
            Random a = new Random();
            //봇 설명
            Console.WriteLine("얼불춤 맵 추천봇");
            //정해진 곳으로 이동
            Console.WriteLine("1번 입력: 난이도 설정");
            Console.WriteLine("2번 입력: 랜덤 포럼 번호 생성");
            //처음 이동할 값 입력
            int aa = int.Parse(Console.ReadLine());

            switch (aa)
            {
                //난이도
                case 1:
                    Console.WriteLine("사용법");
                    Console.WriteLine("1.adofai.gg/levels에 가서 난이도 설정");
                    Console.WritrLine("2.몇번째 레벨인지 확인 후 맞는 곳으로 이동");
                    Console.WriteLine("3.다운로드 후 얼불춤에서 열기");
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

                    //여러개 추천하는 코드
                    for (int i = 0; i < level; i++)
                    {
                        float b = a.Next(minLevel, maxLevel);
                        Console.WriteLine($"난이도 : {b} ");

                        int c = a.Next(1, curLevel);
                        Console.WriteLine($"{c}번째 레벨");

                    }
                    break;
                //레벨 번호
                case 2:
                    Random aaa = new Random();
                    Console.WriteLine("사용법");
                    Console.WriteLine("1.추천레벨 개수 입력 후 나오는 링크를 복사");
                    Console.WriteLine("2.복사한 링크를 주소창에 붙여넣기");
                    Console.WriteLine("3.나오는 사이트에 다운로드 버튼 클릭");
                    Console.WriteLine("4.다운로드한 파일 압축해제 한 후 얼불춤 레벨에디터에서 열기");
                    //레벨 개수
                    Console.WriteLine("추천 레벨 개수 입력");
                    int levels = int.Parse(Console.ReadLine());
                    //레벨 출력
                    for (int i = 0; i <= levels; i++)
                    {
                        int levelcur = aaa.Next(0, 5000);
                        Console.WriteLine($"추천레벨 {i} : {levelcur}");
                        Console.WriteLine("레벨 링크 : ");
                        Console.WriteLine($"adofai.gg/levels/{levelcur}");
                    }
                    break;
                default:
                    Console.WriteLine("잘못된 값을 입력했습니다.");
                    break;
            }
            
        }
    }
}
