//odd or even

using System.Runtime.CompilerServices;

Console.WriteLine("Enter your number");
int a = Int32.Parse(Console.ReadLine());

int result = a % 2;
Console.WriteLine(result);

if (result == 0)
{
    Console.WriteLine("This is an even number");
}
else
{
    Console.WriteLine("This is an odd number");
}

//switch (result)
//{
//    case 0: Console.WriteLine("This is an even number");
//            break;
//        case 1: Console.WriteLine("This is an odd number");
//        break;
      
//}
