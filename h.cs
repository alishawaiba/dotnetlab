using System;
namespace AlishaLab1
{
 internal class OddEven
 {
 static void Main(string[] args)
 {
 Console.WriteLine("Enter a number : ");
 string a = Console.ReadLine();
 int A = Convert.ToInt32(a);
 int mod = A % 2;
 if (mod == 0)
 {
 Console.WriteLine("The number is even");
 }
 else
 {
Console.WriteLine("The number is odd");
 }
 Console.ReadLine();
 }
 }
}