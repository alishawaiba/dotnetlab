using System;
namespace AlishaLab1
{
 internal class Sum
 {
 static void Main(string[] args)
 {
 Console.WriteLine("Enter first no. : ");
 string num1 = Console.ReadLine();
 int Num1= Convert.ToInt32(num1);
 Console.WriteLine("Enter second no. : ");
 string num2 = Console.ReadLine();
 int Num2= Convert.ToInt32(num2);
 Console.WriteLine("Enter third no. : ");
 string num3 = Console.ReadLine();
 int Num3= Convert.ToInt32(num3);
 Console.WriteLine("Sum = " +(Num1+Num2+Num3));
 Console.ReadLine();
 }
 }
}