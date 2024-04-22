//using System.Collections.Generic;
//using System;
//using System.Text;

//다음 코드에서 구조체 매개 변수를 사용하여 전달하는 static void Print() 함수를 람다식으로 정의하시오.

//struct Member

//{

//    public string Name;

//    public int Age;

//}



//static void Main()

//{

//    Member m;

//    m.Name = "백두산";

//    m.Age = 50;

//    Print(m);

//}


////        static void Print()        정의     //    



//출력 결과: 
//이름: 백두산, 나이: 50



//2.
//다음 코드의 출력 결과를 적으시오.



//var colors = new List<string> { "Red", "Blue", "Green" };



//var sortedColors = colors.OrderByDescending(c => c);



//foreach (var color in sortedColors)

//{

//    Console.WriteLine(color);

//}



//3.
//    다음 코드의 실행 결과를 적으세요.



//List<string> names = new List<string> { ".NET", "C#", "TypeScript" };



//var results = names.Where(name => name.Length > 2).OrderBy(n => n);



//foreach (var name in results)

//{

//    Console.WriteLine(name);

//}


//4.

//    다음 코드에서 괄호안에 적합한 코드를 넣으세요.



//int[] arr = { 1, 2, 3, 4, 5 };

//// arr 배열에서 짝수 데이터만 배열로 가져오기



//((1))




//foreach (var i in q)

//{

//    Console.WriteLine($"{i}"); // 2, 4

//}



//5.

//    다음 코드의 출력 결과를 적으시오.



//var numbers = new List<int>() { 10, 20, 30, 40, 50 };

//numbers.Where(n => n <= 20).ToList().ForEach(n => Console.WriteLine(n));



//var names = new List<string>() { "VRGame", "Yuhan", "C#" };

//names.ForEach(n => Console.WriteLine(n));


//6.

//    다음은 가위, 바위, 보 게임의 코드이다. 괄호안을 채워 넣으시오. 



//int iRandom = 0; // 1(가위), 2(바위), 3(보)

//int iSelection = 0; // 사용자 입력(1~3)

//string[] choice = { "가위", "바위", "보" };



//// 컴퓨터의 랜덤값 지정

//iRandom = ((1))




//Console.Write("1(가위), 2(바위), 3(보) 입력 : _\b");

//iSelection = Convert.ToInt32(Console.ReadLine());



//Console.WriteLine("\n 사용자 : {0}", choice[iSelection - 1]);

//Console.WriteLine(" 컴퓨터 : {0}\n", choice[iRandom - 1]);



//// 결과 출력

//if (iSelection == iRandom)

//{

//    Console.WriteLine("비김");

//}

//else

//{

//    switch (iSelection)

//    {


//                      ((2))
//}

//}



//7.


//    다음의 출력 결과를 적으시오.



//StringBuilder sb = new StringBuilder();

//sb.Append("January\n");

//sb.Append("February\n");

//sb.AppendLine("March");

//Console.Write(sb.ToString());



//8.
//    다음은 TimeSpan 열거형을 사용하여 지난 날짜수를 구하는 프로그램 이다. 빈칸을 채워 적으세요. 단, 출력결과는 다음과 같습니다. 



//TimeSpan times =   ((                           1                          ))

//Console.WriteLine((                          2                           ))



//출력 결과: (예)

//내가 지금까지 살아온 날 : 5555



//    9.
//    다음 코드의 출력 결과를 적으시오.



//object s = "반갑습니다.";

//string r1 = s as string;

//Console.WriteLine($"[1] {r1}");



//object i = 1234;

//string r2 = i as string;

//Console.WriteLine($"[2] {r2}");




//10.
    
//    다음 코드는 예외처리를 하지 않는 경우, 처리되지 못한 예외처리에 대한 경고출력이 발생합니다. 다음과 같은 메시지를 출력할 수 있도록 try~catch문을 사용하여 예외처리를 추가하세요. (단, FormatException을 사용한 예외처리)

 

//string inputNumber = "3.14";

//int number = 0;



//number = Convert.ToInt32(inputNumber);

//Console.WriteLine($"입력한 값: {number}");



//출력 결과:

//에러 발생: 입력 문자열의 형식이 잘못되었습니다.

//3.14는 정수여야 합니다.


//11.

//    다음 코드의 출력 결과를 적으세요



//var numbers = Enumerable.Range(1, 5);

//foreach (var n in numbers)

//    Console.Write("{0}\t", n);



//12.

//    다음 코드의 출력 결과를 적으세요.



//IDictionary<string, string> data = new Dictionary<string, string>();



//data.Add("cs", "C#");

//data.Add("aspx", "ASP.NET");

//data.Remove("aspx");

//data["cshtml"] = "ASP.NET MVC";



//foreach (KeyValuePair<string, string> item in data)

//{

//    Console.WriteLine("{0}은(는) {1}의 확장자입니다.", item.Key, item.Value);

//}




//if (!data.ContainsKey("json"))

//{

//    data.Add("json", "JSON");

//    Console.WriteLine(data["json"]);

//}



//var values = data.Values;

//foreach (string item in values)

//{

//    Console.WriteLine(item);

//}



//var keys = data.Keys;

//foreach (string item in keys)

//{

//    Console.WriteLine(item);

//}




//13.

//    다음 코드에서 괄호안을 채워넣으세요.



//int[] arr = { 1, 2, 3, 4, 5 };



//// 배열에서 홀수만 추출: 람다식 사용. 배열의 Where 확장 메소드를 사용

//var q = ((1))

 

//foreach (var n in q)

//{

//Console.WriteLine(n); // 1, 3, 5

//}




//14.


//    다음 프로그램의 출력 결과를 적으시오.



//var data = Enumerable.Range(0, 100);

//var next = data.Skip(10).Take(5);

//foreach (var n in next)

//{

//    Console.WriteLine(n);

//}

