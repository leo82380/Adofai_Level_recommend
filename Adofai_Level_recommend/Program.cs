using System;

namespace AdofaiRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 봇 설명
            //랜덤 선언
            Random a = new Random();
            //봇 설명
            Console.WriteLine("얼불춤 맵 추천봇");
            Console.WriteLine("");
            //정해진 곳으로 이동
            Console.WriteLine("1번 입력: 난이도 설정(좀 불편)");
            Console.WriteLine("2번 입력: 랜덤 포럼 번호 생성(편리)");
            Console.WriteLine("");
            #endregion

            #region 봇 실행
            try
            {
                //처음 이동할 값 입력
                int aa = int.Parse(Console.ReadLine());

                switch (aa)
                {
                    #region 난이도 설정(1 선택)
                    //난이도
                    case 1:
                        #region 난이도설정 사용법
                        Console.WriteLine("사용법");
                        Console.WriteLine("");
                        Console.WriteLine("1. 최소 난이도와 최대 난이도를 설정한다.");
                        Console.WriteLine("2. 몇번째 맵을 플레이할건지, 몇개를 플레이할건지 입력한다.");
                        Console.WriteLine("3. 나오는 값을 adofai.gg에 가서 검색한다.");
                        Console.WriteLine("4. 다운로드 한 후 즐긴다.");
                        Console.WriteLine("레벨은 정수 형태만 가능, 1Lv ~ 21Lv 까지 가능");
                        Console.WriteLine("");
                        #endregion

                        #region 난이도 설정1
                        //난이도 설정
                        try
                        {
                            Console.WriteLine("최소 난이도를 입력하세요(소숫점 없이) : ");
                            int minLevel = int.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            Console.WriteLine("최대 난이도를 입력하세요(소숫점 없이) : ");
                            int maxLevel = int.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            if (minLevel > maxLevel)
                            {
                                Console.WriteLine("최소 난이도가 최대 난이도보다 큽니다.");
                                Console.WriteLine("값을 교환합니다.");
                                Console.WriteLine("");
                                int change = minLevel;
                                minLevel = maxLevel;
                                maxLevel = change;
                            }
                            if (maxLevel >= 22)
                            {
                                Console.WriteLine("잘못된 값을 입력하였습니다.");
                                Console.WriteLine("");
                                break;
                            }
                            #endregion

                            #region 레벨 개수
                            //몇번째 레벨
                            Console.WriteLine("몇번째 레벨까지 추천합니까?");
                            int curLevel = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if (curLevel <= 0)
                            {
                                Console.WriteLine("잘못된 값을 입력하였습니다.");
                                Console.WriteLine("");
                                break;
                            }

                            //개수 추천
                            Console.WriteLine("추천 레벨의 개수를 입력하세요");
                            int level = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if (level <= 0)
                            {
                                Console.WriteLine("잘못된 값을 입력하였습니다.");
                                Console.WriteLine("");
                                break;
                            }
                            #endregion

                            #region 레벨 추천 출력
                            //여러개 추천하는 코드
                            for (int i = 0; i < level; i++)
                            {
                                float b = a.Next(minLevel, maxLevel);
                                Console.WriteLine($"난이도 : {b} ");

                                int c = a.Next(1, curLevel);
                                Console.WriteLine($"{c}번째 레벨");

                                Console.WriteLine("");
                            }
                            #endregion
                        }
                        catch (FormatException e) {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("잘못된 값을 입력하였습니다.");
                            Console.WriteLine("");
                        }
                        catch(OverflowException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("오버플로우 발생");
                            Console.WriteLine("");
                        }
                        break;
                    #endregion

                    #region 포럼 번호(2 선택)
                    //레벨 번호
                    case 2:
                        Random aaa = new Random();
                        #region 사용법
                        Console.WriteLine("사용법");
                        Console.WriteLine("1.추천레벨 개수 입력 후 나오는 링크를 복사");
                        Console.WriteLine("2.복사한 링크를 주소창에 붙여넣기");
                        Console.WriteLine("3.나오는 사이트에 다운로드 버튼 클릭");
                        Console.WriteLine("4.다운로드한 파일 압축해제 한 후 얼불춤 레벨에디터에서 열기");
                        Console.WriteLine("만약 해당하는 레벨이 없는 경우 스킵");
                        Console.WriteLine("");
                        #endregion

                        #region 개수 입력
                        //레벨 개수
                        try
                        {
                            Console.WriteLine("추천 레벨 개수 입력(1~10개)");
                            int levels = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if (levels <= 0 || levels >= 11)
                            {
                                Console.WriteLine("잘못된 값을 입력하였습니다.");
                                Console.WriteLine("");
                                break;
                            }
                            #endregion

                            #region 레벨 출력
                            //레벨 출력
                            for (int i = 1; i <= levels; i++)
                            {
                                int levelcur = aaa.Next(0, 4734);
                                Console.WriteLine($"추천레벨 {i} : {levelcur}");
                                Console.WriteLine("레벨 링크 : ");
                                Console.WriteLine($"adofai.gg/levels/{levelcur}");
                                Console.WriteLine("");
                            }
                            #endregion
                        }
                        catch(FormatException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("잘못된 값을 입력하였습니다.");
                        }
                        catch(OverflowException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("오버플로우 발생");
                        }
                        break;
                    #endregion

                    #region 잘못된 값
                    default:
                        Console.WriteLine("잘못된 값을 입력했습니다.");
                        break;
                    #endregion
                }
            }
             catch(FormatException e)
              {
                   Console.WriteLine(e.Message);
                   Console.WriteLine("잘못된 값을 입력하였습니다");
              }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("오버플로우 발생");
            }
            }
        #endregion
        }
}

