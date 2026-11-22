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
       == => 비교 연산자 
        = => 대입 연산자

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
    ## 묵시적 변환   작은 범위 -> 큰 범위   값이 짤릴 이유가없음 그냥 변환(데이터 손실이 없을 때)
    int small = 5;
    long big = small;

    ## 명시적 변환(캐스팅)   큰 범위 -> 작은 범위   값이 짤릴 수 도 있음 명시적 변환
    long huge = 300;
    int n = (int)huge

    double d = 3.99;
    int i = (int)d;          // 3 (소수점 버림, 반올림 아님)

    long big = 5_000_000_000;
    int x = (int)big;        // 705032704 ← 범위를 넘어서 값이 깨짐

    int n = 66;
    char c = (char)n;        // 'B'

    float f = (float)3.14;   // double → float

    ## 오버 플로우(변수의 범위를 넘어서 음수로 변환되버림)
        ㄴ 오류를 띄우지 않음
        long big = 5_000_000_000;
        int x = checked((int)big);  => checked를 써야 OverFlowException이 나옴

    ## 문자열 <-> 숫자   일반적인 캐스팅으로는 바꿀수 없음
        
    # 숫자 -> 문자열
    int score = 100;
    string s1 = score.ToString();     // "100"
    string s2 = $"점수: {score}";     // 문자열 보간
    string s3 = 3.14159.ToString("F2"); // "3.14" (소수점 2자리)

    # 문자열 -> 숫자
    int.Parse("123")	            예외 발생	형식이 확실할 때
    int.TryParse("123", out int n)	false 반환	사용자 입력에 가장 추천
    Convert.ToInt32("123")	        예외 발생	null이면 0을 반환


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

    #### 형변환
    double d = 3.99;
    int i = (int)d;               // 3  ← 반올림이 아니라 소수점 아래를 버림
    int r = (int)Math.Round(d);   // 4

    int big = 123456789;
    float f = big;                // 123456792 ← 정밀도 부족으로 값이 바뀜
*/

// 문자열
/*
    string name = "hello";
    char first = name[0];

    name[0] = 'H';  => string은 읽기 정용이라고 오류남
    
    ## ToUpper()
    string name = "hello";
    name.ToUpper();                // 결과를 아무도 안 받음
    Console.WriteLine(name);       // hello  그대로

    string upper = name.ToUpper(); // 새 문자열을 받음
    Console.WriteLine(upper);      // HELLO
    Console.WriteLine(name);       // hello  원본은 여전히 그대로

    ## 대입 연산자
    name += "world"
    Console.WriteLine(name); => helloworld

    name -= "world"는 안됨

    name += 10; => 자연스럽게 "10"이라는 문자가 추가된다
*/

// 문자열 포멧
//  ㄴ 원하는 형태로 문자열 가공
/*
    ${} => 문자열 보간 
    문자열 내에 $"{}"를 사용하여 변수 혹은 다른 값을 넣어서 문자열로 사용가능
 
    stirng age = 10 + "살"   => 지루하고 현학적임

    string age = $"{10}살"   => 확실함
*/

// if 조건문
/*
    int hp = 30;

    if(hp <= 50)    => 조건
    {
        // 조건이 참일때 실행할 코드
        Console.WriteLine("체력이 절반 이하입니다")
    }
    else
    {
        // 조건 이외의 상황일때 실행할 코드
        Console.WriteLine("체력이 절반 이상입니다")
    }

    ## 점수가 90 이상이면 A, 80이상 B, 70이상 C, 60이상 D, 나머지 F

    int score = 77;

    if(score >= 90)
    {
        Console.WriteLine("A학점")
    }
    else if(score >= 80)
    {
        Console.WriteLine("B학점")
    }
    ....

*/

// switch 문
//  하나의 값을 여러 조건과 비교해서 조건에 맞다면 코드를 실행하고 이후 다른 조건은 비교하지 않는 문법
/*
int day = 3;

switch(day)
{
    case 1:
        Console.WriteLine("월요일");
        break;
    case 2:
        Console.WriteLine("화요일");
        break;
    case 3:
        Console.WriteLine("수요일");
        break;
    default:                                // 일치하는 case가 없을 경우 사용되는 코드
        Console.WriteLine("404 unfound");
        break;
}
*/

// const와 enum
/*
    const, enum => 상수 

    ## const
    선언시 값을 넣고 절대 바꿀 수 없는 상수
    
    const int MaxHp = 100;
    MaxHp = 200;   // 컴파일 에러! 상수는 바꿀 수 없음

    규칙 
    1. 선언과 동시에 값을 넣어야 됨
    2. 값은 컴파일시 상수여야함
        const int C = 10 * 2;              // OK (계산식도 상수면 가능)
        const int D = Random.Range(0, 10); // 에러 (실행해야 알 수 있는 값)

    ## enum(열거형)
        ㄴ 상수들을 묶은 하나의 리스트
        ㄴ 숫자에 이름을 붙이고 싶을때

    enum Weapon
    {
        Sword,   // 0
        Bow,     // 1
        Staff    // 2
    }

    Weapon myWeapon = Weapon.Bow;

    if (myWeapon == Weapon.Bow)
    {
        Console.WriteLine("활 장착");
    }

    조건
    1. 기본적으로 int, 0에서 시작하는 정수 값 지정도 가능함
    2. 내부 타입도 변경가능
    3. 단, 정의 되지 않은 숫자가 들어가도 에러발생하지 않음

enum Menu
{
    Dinner,     = 0
    Food,       = 1
    Drinking,   = 2
}

int menu = 2;

switch ((Menu)menu) // switch(주어진 값)
{
    case Menu.Dinner: // case (조건값)
        Console.WriteLine("저녁 메뉴입니다.");
        break;
    case Menu.Food:
        Console.WriteLine("음식 메뉴입니다.");
        break;
    case Menu.Drinking:
        Console.WriteLine("음료 메뉴입니다.");
        break;
    default:
        Console.WriteLine("존재하지 않는 메뉴입니다.");
        break;
}
*/


// Console에서 값을 읽는법 
/*
string input = Console.ReadLine();  
Console.WriteLine($"입력받은 값 : {input}");
*/

// 데이터 변환
/*
    ## string -> int

    // int.Parse("문자") '문자'에 들어가는 문자가 숫자로 변환될 수 없다면 에러
    int num = int.Parse("123"); 
*/


// 문제 1
// 점수를 입력 받고 그에 맞는 성적을 출력
// 90 a, 80 b, 70 c , 60 d, 나머지 f
/*
string score = Console.ReadLine();

if (score == "")
{
    Console.WriteLine("점수를 입력하세요");
    return;
}

int realscore = int.Parse(score);

if (realscore >= 90)
{
    Console.WriteLine("A학점");
}
else if (realscore >= 80)
{
    Console.WriteLine("B학점");
}
else if (realscore >= 70)
{
    Console.WriteLine("C학점");
}
else if (realscore >= 60)
{
    Console.WriteLine("D학점");
}
else
{
    Console.WriteLine("F학점");
}
*/

// 반복문
//  ㄴ 조건이 참일 경우 특정 코드를 반복해서 실행하는 문법
// 조건 => true or false
/*
    ## while(조건)
        ㄴ 이때 조건은 반드시 bool 형식
    
    int i = 1;
    while (i <= 5)
    {
        Console.WriteLine(i);
        i++;
    }

    int count = 0;
    while(count < 5)
    {
        if(count == 4)
        {
            break;
        }
        count++;

        if(count % 2 == 1)
        {
            continue;   // 이 밑의 코드들은 전부 실행하지 않고 다시 조건부터 검사하는 키워드+
        }

        Console.WriteLine(count);
    }

    // 무한 루프
    while(true)     // 조건이 항상 true여서 반복이 끝나지 않음
    {
        Console.WriteLine(count++);
    }

    int number = 10;
    while(number <= 9)
    {
        Console.WriteLine("Hello World");
    }
    
    ㄴ 이럴 경우 당연하지만 값이 나오지 않음
    ㄴ 이럴 경우 사용하는게 아래의 do-while 문

    ## do-while
        조건을 나중에 검사하여 최소 한번의 실행은 보장
    
    int i = 10;

    do
    {
        Console.WriteLine(i);
        i++;
    } while (i <= 5);
    
    입력을 받기에 사용하기 좋음

    int score;
    string input;

    do
    {
        Console.Write("점수 입력 (0~100): ");
        input = Console.ReadLine();
    } while (!int.TryParse(input, out score) || score < 0 || score > 100);

    Console.WriteLine($"입력한 점수: {score}");

    ## for(조건)
    // int i는 카운팅 할 변수 선언 및 할당 -> 기존 변수를 가져와도됨
    // i < 10 -> 조건 true일경우만 반복
    // i++ 후처리 반복이 될때마다 카운트 값의 처리방법

    for (int i = 0; i < 10; i++)
    {
        if (i == 0) break;
        Console.WriteLine(i);
    }

    for (int i = 10; i > 0; i += 2)
    {
        if (i == i*5) break;
        Console.WriteLine(i);
    }

Console.WriteLine("구구단 출력하기");
Console.WriteLine("단 수를 입력해 주세요");
string input = Console.ReadLine();
int n = int.Parse(input);

Console.WriteLine($"{n}단 출력");

for(int i = 1; i < 10; i++)
{
    Console.WriteLine(n * i);
}

// 구구단 전체 출력
for (int s = 1; s < 10; s++)
{
    Console.WriteLine($"{s}단 출력");
    for(int i = 1;i < 10; i++)
    {
        Console.WriteLine(s * i);
    }
}
*/

// 구구단 출력 예제
// 구구단 프로그램에 오신걸 환영합니다
// 구구단을 실행하고싶으시면 1. 종료하고싶다면 0번 입력

// 다시 구구단 프로그램에 오신걸 환영합니다 부터 출력해서 다시 처음부터

/*
Console.WriteLine("구구단 프로그램에 오신걸 환영합니다.");
Console.WriteLine("실행하고 싶으시면 1, 종료하고싶으시면 0번을 입력하세요");
int end = int.Parse(Console.ReadLine());

switch (end)
{
    case 0:
        break;
    case 1:
        Console.WriteLine("구구단 출력하기");
        Console.WriteLine("단 수를 입력해 주세요");
        string dan = Console.ReadLine();
        int aa = int.Parse(dan);

        Console.WriteLine($"{dan}단 출력");

        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(aa * i);
        }
        break;
}

//클로드 수정버전
Console.WriteLine("구구단 프로그램에 오신걸 환영합니다.");

while (true)
{
    Console.WriteLine();
    Console.WriteLine("실행: 1, 종료: 0");

    if (!int.TryParse(Console.ReadLine(), out int menu))
    {
        Console.WriteLine("숫자를 입력하세요.");
        continue;
    }

    if (menu == 0)
    {
        Console.WriteLine("프로그램을 종료합니다.");
        break;              // while 탈출
    }

    if (menu != 1)
    {
        Console.WriteLine("0 또는 1만 입력하세요.");
        continue;
    }

    Console.Write("단 수를 입력해 주세요 (2~9): ");
    if (!int.TryParse(Console.ReadLine(), out int dan) || dan < 2 || dan > 9)
    {
        Console.WriteLine("2~9 사이의 숫자를 입력하세요.");
        continue;
    }

    Console.WriteLine($"--- {dan}단 ---");
    for (int i = 1; i <= 9; i++)
    {
        Console.WriteLine($"{dan} x {i} = {dan * i}");
    }
}


// 선생님 버전


bool play = true;
do
{
    Console.WriteLine("구구단 프로그램");
    Console.WriteLine("실행을 원하면 1, 종료는 0");
    Console.WriteLine("입력 : ");
    string exit = Console.ReadLine();
    int exitValue = int.Parse(exit);

    switch (exitValue)
    {
        case 0:
            play = false;
            break;
        case 1:
            Console.WriteLine("구구단 출력하기");
            Console.WriteLine("단 수를 입력해 주세요");
            string dan = Console.ReadLine();
            int aa = int.Parse(dan);

            Console.WriteLine($"{dan}단 출력");

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(aa * i);
            }
            break;
        default:
            Console.WriteLine("뭐하노");
            break;
    }
}
while (play);
*/

// Debuging
// 코드의 흐름을 따라서 버그의 원인을 찾아서 수정하느 과정
/*
    ### 디버깅 방법 
    1. Break : 내가 원하는 코드라인에 Break를 걸어서 멈추게 하는것
        ㄴ 왼쪽에 회색 영역을 눌러서 빨간색 띄우면 거기서 break걸림
        ㄴ f11 : 코드를 한 줄씩 따라 갈 수 있음        
        ㄴ f10 : 코드를 실행단위(프로시저)단위로 넘어감
    2. 조사식 : 사용되는 변수의 메모리 값을 추적할 수 있다

*/
