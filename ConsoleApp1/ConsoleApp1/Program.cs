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
*/

bool isOld = true;
bool isStudent = false;
bool result = isOld && isStudent;
Console.WriteLine(result);

bool result2 = isOld || isStudent;
Console.WriteLine(result2);

bool result3 = !isOld;
Console.WriteLine(result3);