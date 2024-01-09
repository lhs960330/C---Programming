namespace _02._Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /********************************************************************
             * 연산자 (Operator)
             *
             * 프로그래밍 언어에서는 일반적인 수학 연산과 유사한 연산자들이 지원됨
             * C#는 여러 연산자를 제공하며 기본 연산을 수행할 수 있음
             *********************************************************************/

            //<산술 연산자>

            //<이진 연산자>
            int iValue;
            iValue = 2 + 5;  // + 더하기
            iValue = 7 - 1;  // - 빼기
            iValue = 2 * 4;  // * 곱하기
            iValue = 6 / 3;  // / 나누기 주의점: int는 정수받기 때문에 소수점으로 나오는 나누기는 정수 밑으로 다 버려진다.
            iValue = 12 % 3; // % 나머지 즉 12/3은 4에 남은건 0이기 때문에 0이 된다.

            // <단항 연산자>

            iValue = +iValue; //  +(iValue) : +(정수) 즉 iValue가 -5면 -5 
            iValue = -iValue; //  -(iValue) : -(정수) 즉 iValue가 -5면 5
            ++iValue;         // ++ : 전위 증가연산 : 값을 1 증가 
            iValue++;         // ++ : 후위 증가연산 : 값을 1 증가  
            --iValue;         // -- : 전위 감소연산 : 값을 1 감소
            iValue--;         // -- : 후위 감소연산 : 값을 1 감소

            //<전위와 후의의 차이점>
            // 전위는 값을 반환하기전에 연산
            iValue = 0;
            Console.WriteLine(iValue);   // output : 0
            Console.WriteLine(++iValue); // output : 1
            Console.WriteLine(iValue);   // output : 1
            // 후위는 값을 반환하고 연산
            iValue = 0;
            Console.WriteLine(iValue);   // output : 0
            Console.WriteLine(iValue++); // output : 0
            Console.WriteLine(iValue);   // output : 1

            //<대입연산자>
            //<복합 대입 연산자>
            iValue = 10;
            iValue -= 5;    // iValue = iValue - 5 와 동일
            iValue += 5;    // iValue = iValue + 5 와 동일

            //<비교연산자>
            bool bValue = false;
            bValue = 3 > 1;     // >  : 왼쪽 피연산자가 더 클 경우 true
            bValue = 3 < 1;     // <  : 왼쪽 피연산자가 더 작을 경우 true
            bValue = 3 >= 1;    // >= : 왼쪽 피연산자가 더 크거나 같은 경우 true
            bValue = 3 <= 1;    // <= : 왼쪽 피연산자가 더 작거나 같은 경우 true
            bValue = 3 == 1;    // == : 두 피연산자가 같은 경우 true
            bValue = 3 != 1;    // != : 두 피연산자가 다를 경우 true

            //<논리 연산자>
            bValue = !false;            // !(Not)  : 피연산자의 논리 부정을 반환
            bValue = true && false;     // &&(And) : 두 피연산자가 모두 true 일 경우 true
            bValue = true || false;     // ||(Or)  : 두 피연산자가 모두 false 일 경우 false
            bValue = true ^ false;      // ^(Xor)  : 두 피연산자가 다를 경우 true

            //<조건부 논리 연산자>
            // 조건부 논리 And 연산자 &&
            // 빠른 계산을 위해 false && x(논리자료형) 의 경우 어떠한 논리자료형이 있어도
            // 결과는 항상 false이기 때문에 false && x 에서 x는 무시하게 됨 (중요)
            // 만약 true이면 뒤에도 실행해줌
            iValue = 10;
            bValue = false && (++iValue > 5);
            Console.WriteLine(iValue);  // output : 10


            // 조건부 논리 Or 연산자 ||
            // 빠른 계산을 위해 true || x(논리자료형) 의 경우 어떠한 논리자료형이 있어도
            // 결과는 항상 true이기 때문에 true || x 에서 x는 무시하게 됨(중요)
            // 만약 false면 뒤에도 계산해줌
            iValue = 10;
            bValue = true || (++iValue > 5);
            Console.WriteLine(iValue);  // output : 10

            //<비트연산자>
            //<단항 연산자>
            iValue = ~0x35;         // ~(비트 보수) : 데이터를 비트단위로 보수 연산 (보수 : 0->1, 1->0)


            // <이진 연산자>
            iValue = 0x11 & 0x83;   // &(And) : 데이터를 비트단위로 And 연산
            iValue = 0x11 | 0x83;   // |(Or)  : 데이터를 비트단위로 Or 연산
            iValue = 0x11 ^ 0x83;   // ^(Xor) : 데이터를 비트단위로 Xor 연산


            // <비트 쉬프트 연산자>
            iValue = 0x20 << 2;     // << : 왼쪽의 피연산자의 비트를 오른쪽 피연산자만큼 왼쪽으로 이동
            iValue = 0x20 >> 2;     // >> : 왼쪽의 피연산자의 비트를 오른쪽 피연산자만큼 오른쪽으로 이동



            /****************************************************************
             * 연산자 우선순위
             *
             * 여러 연산자가 있는 식에서 우선 순위가 높은 연산자가 먼저 계산
             ****************************************************************/

            // <연산자 우선순위>
            // 1. 기본 연산        : a[i], x++, x--
            // 2. 단항 연산        : +x, -x, !x, ~x, ++x, --x, (Type)x
            // 3. 곱하기 연산      : x * y, x / y, x % y
            // 4. 더하기 연산      : x + y, x - y
            // 5. 시프트 연산      : x << y, x >> y
            // 6. 비교 연산        : x < y, x > y, x <= y, x >= y
            // 7. 같음 연산        : x == y, x != y
            // 8. 논리 AND 연산    : x & y, x && y
            // 9. 논리 XOR 연산    : x ^ y
            // 10. 논리 OR 연산    : x | y, x || y
            // 11. 대입 연산       : x = y, x op= y
        }
    }
}
