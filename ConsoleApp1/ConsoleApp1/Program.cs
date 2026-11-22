/*
 * int num1 = 7;
int num2 = 2;

int dan = 2;
Console.WriteLine(dan * 1);
Console.WriteLine(dan * 2);
Console.WriteLine(dan * 3);
Console.WriteLine(dan * 4);
Console.WriteLine(dan * 5);
Console.WriteLine(dan * 6);
Console.WriteLine(dan * 7);
Console.WriteLine(dan * 8);
Console.WriteLine(dan * 9);
*/

// 대입 연산자
/*
    a += 5 => a = a + 5
    a -= 5 => a = a - 5
    a *= 5 => a = a * 5
    a /= 5 => a = a / 5
    a %= 5 => a = a % 5


int num = 100;
num += 20;
Console.WriteLine(num);
num -= 30;
Console.WriteLine(num); 
*/

// 증감 연산자(++ or --)
/*
    전위 증감 연산자 ++a
    후의 증감 연산자 a++

    int a = 5;
    Console.WriteLine(a++);    // =5  값을 사용한 후 증감 처리
    Console.WriteLine(a);      // =6

    int b = 5;
    Console.WriteLine(++b);    // =6 증감 처리를 한 후에 값을 처리
    Console.WriteLine(b);      // =6 

    int c = 5;
    Console.WriteLine(c--);    // =5  값을 사용한 후 증감 처리
    Console.WriteLine(c);      // =4

    int d = 5;
    Console.WriteLine(--d);    // =4 증감 처리를 한 후에 값을 처리
    Console.WriteLine(d);      // =4
*/

// 주석
/*
    코드의 사용버이나 개념을 메모할때 
    너무 많거나 적으면 문제
    가능한 이름으로 표현하되 할 수 없는것을 주석으로 설명

    ex)
    int monster_hp = 100;
    
    // 몬스터 마다 구분을 위한 ID값 수정 x (<- 이럴때 사용)
    int monster_Id = 1;

    // <- 한줄
    // /* <- 여러줄 주석 
    
    단축키 
        ^/
        ^ + C + K   선택 영역 전체 주석
        ^ + U + K   선택 영역 전체 주석 해제
 */

// 비교 연산자
//  ㄴ 두 개 이상의 값을 비교하여 bool 값을 반환하는 연산자
/*
    bool =>  Ture, False

    ## ==과 = 차이

    ==          같다
    !=          같지 않다
    <, >        작다 or 크다
    <=, >=      작거나 같다 or 크거나 같다
    
    int age = 30;
    bool result = age > 30;
    Console.WriteLine(result);

    int hp = 100;
    bool isPinch = hp - 70 > 30;
*/

// 논리 연산자
//  ㄴ bool 값을 통하여 새로운 bool 값을 만들어 낸다
/*
    && : 그리고, 앞 뒤 조건이 모두 참일때
    || : 또는, 둘중 하나라도 참일때
    ! : 아니다, 뒤에 오는 것이 거짓일때

bool isOld = true;
bool isStudent = false;
bool result = isOld && isStudent;
Console.WriteLine(result);

bool result2 = isOld || isStudent;
Console.WriteLine(result2);

bool result3 = !isOld;
Console.WriteLine(result3);

*/

// 연산자 우선순위
/*
    1. !, ++, --
    2. *, /, %
    3, +, -
    4. <, >, <=, >=
    5. ==, !=
    6. &&
    7. ||
    8. =, += 대입
*/

// 아스키 코드값
/*
    char => 문자 하나를 저장하는 변수 UTF-16코드 단위의 1개(2바이트, 0 ~ 65,535)를 저장

    char a = 'A';
    char k = '가';        // 한글도 한 글자 저장 가능
    char u = '\u0041';    // 유니코드로 'A'
    char n = '\n';        // 줄바꿈 같은 이스케이프 문자
*/

// 형변환
/*
    ## 묵시적 변환   작은 범위 -> 큰 범위   값이 짤릴 이유가없음 그냥 변환
    int small = 5;
    long big = small;

    ## 명시적 변환   큰 범위 -> 작은 범위   값이 짤릴 수 도 있음 명시적 변환
    long huge = 300;
    int n = (int)huge
    
    char a = 'A';
    int numberA = (int)a;
*/

// 부동 소수점
//  ㄴ 소수점 위치가 고정되지 않고 움직이는 방식으로 실수를 저장하는 방법
/*
    
    float   4byte  06~09자리  f(접미사)
    double  8byte  15~17자리 d
    decimal 16byte 28~29자리 m

    float f = 3.14f;
    double d = 3.14; (기본이 double이여서 생략)
    decimal m = 3.14m;
    
    정수는 정상적으로 기재하지만 소수점은 그럴수없음
    (10진수) 1.2 * 10^8 = 120,000,000 인것 처럼
    (2진수)  1.101 * 2^2 = 110.1 임

    6.5 => 110.1(2진수) => 1.101 * 2^2

    ####### 0.1을 2진수로 바꾸면 0.0001100110011.... 으로 무한소수가 되어 근삿값으로 저장됨
    double a = 0.1 + 0.2;
    Console.WriteLine(a == 0.3);   // False
    Console.WriteLine(a.ToString("R")); // 0.30000000000000004

    decimal b = 0.1m + 0.2m;
    Console.WriteLine(b == 0.3m);  // True (decimal은 10진수라 정확)
    
    ##### 그래도 비교할때는 == 으로 비교하면 오류남
        ㄴ 게임등에서 이동할때 특정 지점에 도착했지만 미세한 오차로 인식을 못하는 경우가 있어 == 사용 금지
    double x = 0.1 + 0.2;
    double y = 0.3;

    bool same = Math.Abs(x - y) < 1e-9;   // True

    ## 특수 값(0등) 으로 나누어도 예외가 나지 않음
    double p = 1.0 / 0;     // ∞ (double.PositiveInfinity)
    double n = -1.0 / 0;    // -∞ (double.NegativeInfinity)
    double nan = 0.0 / 0;   // NaN (Not a Number)

    Console.WriteLine(nan == nan);        // False ← NaN은 자기 자신과도 다름!
    Console.WriteLine(double.IsNaN(nan)); // True  ← 이렇게 확인해야 함
*/