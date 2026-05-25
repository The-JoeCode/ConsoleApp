// //   1
// Console.WriteLine("Hello, World! Enter your name");
// string name = Console.ReadLine() ?? "Guest";
// //null-coalescing operator(if name is null, uses Guest as a name)

// Console.WriteLine("Enter your age");
// // int age = int.Parse(Console.ReadLine()!);
// // int.TryParse(Console.ReadLine(), out int age);
// //Safer way to get number (no exception thrown invalid input)
// int age = int.TryParse(Console.ReadLine(), out int result)
//     ? result
//     : 0;
// Console.WriteLine($"Hello {name}, You are {age} years old!");

// //   2
// Console.Write("Enter a number:");
// // int num1 = int.Parse(Console.ReadLine()!);
// // int.TryParse(Console.ReadLine(), out int num1);
// //Safer way to get number (no exception thrown invalid input)
// int num1 = int.TryParse(Console.ReadLine(), out int result1)
//     ? result1
//     : 0;
// if (num1 > 0)
//     Console.WriteLine("Positive");
// else if (num1 < 0)
//     Console.WriteLine("Negative");
// else
//     Console.WriteLine("Zero");

// //   3
// for (int i = 2; i <= 10; i += 2)
//     Console.WriteLine(i);

// //  4
// int r = 2;
// while (r <= 10)
// {
//     Console.WriteLine(r);
//     r += 2;
// }