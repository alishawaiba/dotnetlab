using System;
namespace AlishaLab1
{
 internal class ArrToStr
 {
 static void Main(string[] args)
 {
 string[] strarr = { "Dog", "Cat", "Rat", "Tiger", "Lion"};
 string result = string.Join(", ", strarr);
 Console.WriteLine(result);
 Console.ReadLine();
 }
 }
}