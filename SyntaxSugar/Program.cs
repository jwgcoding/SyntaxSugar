// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

namespace SyntaxSugar
{
    class Program
    {
        public static void Main()
        {
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);  
            }
        }
    }
//public static void Program();
//int answer = 4;
//string response;
//if (answer < 9)
//{
//    response = answer + " is less than nine";
//}
//else
//{
//    response = answer + " is greater than or equal to nine";
//}
