using System;


class Program
    {
        private static int _repeatCount = 0;

        static void Main(string[] args)
        {
            // Main 함수의 내용은 변경하지 않습니다.
            // Main 이외의 함수(IsZero, InputPlayerHealth, PrintRepeatCount)를 완성하시면 됩니다.
            int playerHealth;

            while (true)
            {
                _repeatCount++;

                playerHealth = InputPlayerHealth();

            

                if (IsZero(playerHealth))
                {
                    Console.WriteLine("Game Over - 게임 종료");
                    break;
                }
            }
        }
        static bool IsZero(int value)
        {
            // bool 타입의 데이터를 반환 (논리값을 저장하는 자료형) / true,false로 저장

            // 매개변수(int value)로 입력받은 데이터가 0 이하라면 true 반환  (value <= 0) = true
            return value <= 0;
            // 매개변수(int value)로 입력받은 데이터가 0 초과라면 false 반환 (value > 0) = false
        }

        static int InputPlayerHealth()
        {
            // Console.ReadLine()을 사용해 사용자 입력 받기
            int iw;
            while (true)
            {
                Console.WriteLine("플레이어의 체력을 입력하세요.");
                string input = Console.ReadLine();

            //[숫자 형식].TryParse(string[변환할 문자열], out [매개변수])

            PrintRepeatCount();
            if ((int.TryParse(input, out iw) && iw >= 0 && iw <= 100))
                {
                    ;
                    return iw;
                }
                // 0이상 100 이하의 숫자 외의 데이터가 입력된 경우 숫자를 입력받을 때 까지 반복(for/while)해서 입력 받기

                // 숫자가 정상적으로 입력된 경우 int 타입으로 변환(out)해 반환
            }
        
        static void PrintRepeatCount()
            {
                // 반복문이 몇 번 출력되었는지 출력한다
                // 출력 양식 : "반복문이 출력된 횟수는 {_repeatCount} 입니다."
                Console.WriteLine("반복문이 출력된 횟수는 {0} 입니다.", _repeatCount);
            }
        }
    }
