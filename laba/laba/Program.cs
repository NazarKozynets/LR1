// namespace Laba;
//
// public class Program
// {
//     public static void Main(string[] args)
//         {
//             Console.WriteLine("Input 3 numbers (can be int or float):");
//
//             float a = GetNumber("Enter side a: ");
//             float b = GetNumber("Enter side b: ");
//             float c = GetNumber("Enter side c: ");
//
//             var triangle = new Triangle(a, b, c);
//
//             while (true)
//             {
//                 Console.WriteLine("\nChoose an option:");
//                 Console.WriteLine("1. Calculate Perimeter");
//                 Console.WriteLine("2. Get Area");
//                 Console.WriteLine("3. Write All Sides");
//                 Console.WriteLine("4. Exit");
//
//                 string choice = Console.ReadLine();
//
//                 switch (choice)
//                 {
//                     case "1":
//                         Console.WriteLine($"Perimeter: {triangle.CalculatePerimeter()}");
//                         break;
//                     case "2":
//                         Console.WriteLine($"Area: {triangle.GetArea()}");
//                         break;
//                     case "3":
//                         triangle.WriteAllSides();
//                         break;
//                     case "4":
//                         Console.WriteLine("Exiting the program.");
//                         return; 
//                     default:
//                         Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
//                         break;
//                 }
//             }
//         }
//
//         private static float GetNumber(string prompt)
//         {
//             float number;
//             while (true)
//             {
//                 Console.Write(prompt);
//                 string input = Console.ReadLine();
//
//                 if (float.TryParse(input, out number))
//                 {
//                     return number;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Invalid input. Please enter a valid number.");
//                 }
//             }
//         }
// }