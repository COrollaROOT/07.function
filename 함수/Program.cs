namespace 함수
{
    internal class Program
    {
        //  // void 공허 결과가 없다 빈박스                            // 변수는 소문자로 시작
        //   static void TripleShot(int first, int second, int third) // 함수 첫 시작은 대문자가 국룰 // 본문 매번 적기 힘드니 함수 사용
        //      // static void TripleShot(안에 변수 입력) 하면 따로 변화 할수있게 입력도 가능
        //  {
        //      //함수
        //      // 미리 정해진 동작을 수행하는 코드 묶음
        //      //어떤 처리를 미리 함수로 만들어 두면 다시 반복적으로 사용 가능
        //
        //      // 삼연타
        //  static void TripleShot(int first, int second, int third)
        //  {
        //
        //
        //      Console.WriteLine("찌르기! 데미지 {0}", first);   // 본문 작성
        //      Console.WriteLine("베기! 데미지 {0}", second);
        //      Console.WriteLine("때리기! 데미지 {0}", third);
        //  }
        //
        //  static void Main(string[] args) // static 함수는 static 에서만
        //  {
        //      TripleShot(30, 20, 10); // 함수 호출 // 입력도 가능
        //
        //  }

        //  static void Main(string[] args)
        //  {
        //      while (true)
        //      {
        //          switch (Console.ReadKey(true).Key) // 키입력 true 사용 가능 // 입력을 위한 변수가 매개 변수
        //          {
        //              case ConsoleKey.W:
        //                  Console.WriteLine("위로 이동!");
        //                  break;
        //              case ConsoleKey.A:
        //                  Console.WriteLine("왼쪽으로 이동!");
        //                  break;
        //              case ConsoleKey.S:
        //                  Console.WriteLine("아래로 이동!");
        //                  break;
        //              case ConsoleKey.D:
        //                  Console.WriteLine("오른쪽으로 이동!");
        //                  break;
        //          }
        //      }
        //      
        //  }

        //   static int GetPi() // GetPi() 가 10
        //   {
        //       return 10; // return 10 은 결과적으로 GetPi()가 10으로 바뀐다
        //   }
        //
        //   static void Main(string[] args)
        //   {
        //       int result = GetPi();
        //       Console.WriteLine(result); // resul가 10
        //   }

        // 레벨에 따른 총 데미지 예시
        //  static int TotalDamage(int basicAttack, int equipAttack, int level)
        //  {
        //      return level * basicAttack + equipAttack; // 리턴 뒤에 함수는 계산되지 않는다 // 리턴을 만나면 함수는 끝이 난다
        //  }
        //
        //  static void Main(string[] args)
        //  {
        //      int totalDamage = TotalDamage(10, 20, 3);
        //      Console.WriteLine("총 데미지는 {0} 입니다.", totalDamage);
        //  }


        //   static int Function()
        //   {
        //       Console.WriteLine("단계1");
        //       Console.WriteLine("단계2");
        //
        //       return 10;
        //
        //       Console.WriteLine("단계3");  // 데이터 반환
        //       Console.WriteLine("단계4"); // 함수 종료
        //   }
        //
        //
        //   static void Main(string[] args)
        //   {
        //       Function();
        //   }


        // 함수의 결과에 따라 static뒤 자료형(int) 을 선정
        // void 반환형의 함수는 


        // 나누기
        // 입력 : 나눠질 수, 나눌수
        // 출력 : 몫,나머지

        // 11/3
        //몫 3, 나머지 2
        //   static int Divide(int left, int right)
        //   {
        //       return left / right; // 몫
        //
        //       return left % right; // 나머지
        //   }
        //
        //
        //   static void Main(string[] args)
        //   { // int result = Divide(11, 3);
        //
        //   }

        // 디버깅
        //  static void Function()
        //  {
        //      Console.WriteLine("1");
        //      Console.WriteLine("2");
        //      Console.WriteLine("3");
        //  }
        //
        //  static void Function2()
        //  {
        //      Console.WriteLine("4");
        //      Console.WriteLine("5");
        //      Console.WriteLine("6");
        //  }
        //
        //  static void Function3()
        //  {
        //      Console.WriteLine("7");
        //      Console.WriteLine("8");
        //      Console.WriteLine("9");
        //  }
        //
        //  static void Main(string[] args)
        //  {
        //      Function();
        //      Function2();
        //      Function3();
        //  }


        //  // Ref 키워드 ref 참조 원본을 전달
        //  static void Main(string[] args)
        //  {
        //      // 두 숫자를 교체 하는 기능
        //      int a = 10;
        //      int b = 20;
        //
        //      int temp = a; // 임시 저장소인 temp에 a 즉 10 저장
        //      a = b;   // a : 20
        //               // b = a;   // b : 20 a가 20 으로 교체 되서 b도 20이 된다
        //      b = temp; // b를 temp로 지정 temp에 저장했던 a 즉 10을 가져옴 
        //      // a : 20, b : 10
        //      Console.WriteLine("a : {0}, b : {1}", a, b);
        //  }

        static void IntTest(int value)
        {
            value = value + 10;
        }

        static void ArrayTest(int[] array)
        {
            array[2] = 999;
        }
        static void Main(string[] args)
        {

            int[] test = { 1, 2, 3, 4 };
            Console.WriteLine("함수 전 값 : {0}", test[2]);
            ArrayTest(test);
            Console.WriteLine("함수 후 값 : {0}", test[2]);
        }
























    }
}
