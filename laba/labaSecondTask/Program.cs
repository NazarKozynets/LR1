// namespace LabaSecondTask;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Welcome to the Square and Cube Testing Program!");
//
//         TSquare square = null;
//         TCube cube = null;
//
//         while (true)
//         {
//             Console.WriteLine("\nChoose an option:");
//             Console.WriteLine("1. Create a Square");
//             Console.WriteLine("2. Create a Cube");
//             Console.WriteLine("3. Use Square Methods");
//             Console.WriteLine("4. Use Cube Methods");
//             Console.WriteLine("5. Exit");
//
//             string choice = Console.ReadLine();
//
//             switch (choice)
//             {
//                 case "1":
//                     square = CreateSquare();
//                     break;
//
//                 case "2":
//                     cube = CreateCube();
//                     break;
//
//                 case "3":
//                     UseSquareMethods(square);
//                     break;
//
//                 case "4":
//                     UseCubeMethods(cube);
//                     break;
//
//                 case "5":
//                     Console.WriteLine("Exiting the program.");
//                     return;
//
//                 default:
//                     Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
//                     break;
//             }
//         }
//     }
//
//     private static TSquare CreateSquare()
//     {
//         Console.Write("Enter the length of the side for the square: ");
//         float side = GetValidFloatInput();
//         TSquare square = new TSquare(side);
//         Console.WriteLine(square);
//         return square;
//     }
//
//     private static TCube CreateCube()
//     {
//         Console.Write("Enter the length of the side for the cube: ");
//         float side = GetValidFloatInput();
//         TCube cube = new TCube(side);
//         Console.WriteLine(cube);
//         return cube;
//     }
//
//     private static void UseSquareMethods(TSquare square)
//     {
//         if (square == null)
//         {
//             Console.WriteLine("Please create a square first.");
//             return;
//         }
//
//         Console.WriteLine("\nChoose a method for the Square:");
//         Console.WriteLine("1. Calculate Area");
//         Console.WriteLine("2. Calculate Perimeter");
//         Console.WriteLine("3. Input New Side Length");
//         Console.WriteLine("4. Display Side Length");
//         Console.WriteLine("5. Compare with Another Square");
//         Console.WriteLine("6. Add Another Square");
//         Console.WriteLine("7. Subtract Another Square");
//         Console.WriteLine("8. Multiply by a Factor");
//         Console.WriteLine("9. Back to Main Menu");
//
//         string choice = Console.ReadLine();
//
//         switch (choice)
//         {
//             case "1":
//                 Console.WriteLine($"Area: {square.CalculateArea()}");
//                 break;
//             case "2":
//                 Console.WriteLine($"Perimeter: {square.CalculatePerimeter()}");
//                 break;
//             case "3":
//                 square.Input();
//                 break;
//             case "4":
//                 square.Output();
//                 break;
//             case "5":
//                 //Console.Write("Enter the side length of another square to compare: ");
//                 //послеTSquare otherSquare = new TSquare(GetValidFloatInput());
//                 //Console.WriteLine($"Squares are equal: {square.Equals(otherSquare)}");
//                 break;
//             case "6":
//                 Console.Write("Enter the side length of another square to add: ");
//                 TSquare addSquare = new TSquare(GetValidFloatInput());
//                 TSquare addedSquare = square + addSquare;
//                 Console.WriteLine($"Result of addition: {addedSquare}");
//                 break;
//             case "7":
//                 Console.Write("Enter the side length of another square to subtract: ");
//                 TSquare subSquare = new TSquare(GetValidFloatInput());
//                 TSquare subtractedSquare = square - subSquare;
//                 Console.WriteLine($"Result of subtraction: {subtractedSquare}");
//                 break;
//             case "8":
//                 Console.Write("Enter a factor to multiply the square: ");
//                 float multiplier = GetValidFloatInput();
//                 TSquare multipliedSquare = square * multiplier;
//                 Console.WriteLine($"Result of multiplication: {multipliedSquare}");
//                 break;
//             case "9":
//                 return;
//             default:
//                 Console.WriteLine("Invalid choice.");
//                 break;
//         }
//     }
//
//     private static void UseCubeMethods(TCube cube)
//     {
//         if (cube == null)
//         {
//             Console.WriteLine("Please create a cube first.");
//             return;
//         }
//
//         Console.WriteLine("\nCube Methods:");
//         Console.WriteLine("1. Calculate Area");
//         Console.WriteLine("2. Calculate Perimeter");
//         Console.WriteLine("3. Display Cube Details");
//         Console.WriteLine("4. Calculate Volume");
//         Console.WriteLine("5. Back to Main Menu");
//
//         string choice = Console.ReadLine();
//
//         switch (choice)
//         {
//             case "1":
//                 Console.WriteLine($"Area: {cube.CalculateArea()}");
//                 break;
//             case "2":
//                 Console.WriteLine($"Perimeter: {cube.CalculatePerimeter()}");
//                 break;
//             case "3":
//                 Console.WriteLine(cube);
//                 break;
//             case "4":
//                 Console.WriteLine($"Volume of the cube: {cube.CalculateVolume()}");
//                 break;
//             case "5":
//                 return;
//             default:
//                 Console.WriteLine("Invalid choice.");
//                 break;
//         }
//     }
//
//     private static float GetValidFloatInput()
//     {
//         float value;
//         while (!float.TryParse(Console.ReadLine(), out value))
//         {
//             Console.WriteLine("Invalid input. Please enter a number.");
//         }
//         return value;
//     }
// }
