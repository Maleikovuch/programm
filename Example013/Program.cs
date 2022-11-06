// МЕТОДЫ

void Method1()
{
    Console.WriteLine("Автор: Малейкович М. А.");
}
Method1();

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i< count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Текст сообщения", 4);
// Method21(msg: "Текст сообщения", count: 4);
// Method21(count: 4, msg: "Текст");


// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "qwerty, ");
// Console.WriteLine(res);

// ЦИКЛЫ

// string Method4(int count, string text)
// {
    
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "qwerty, ");
// Console.WriteLine(res);

// ЦИКЛ В ЦИКЛЕ

// for (int i = 2; i <=10; i++)
// {
//     for (int j = 2; j <=10; j++)
//     {
//         Console.WriteLine($"{i} X {j} = {i*j}");
//     }
//     Console.WriteLine();
// }