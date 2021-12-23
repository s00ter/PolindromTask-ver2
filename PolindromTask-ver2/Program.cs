using System;
using System.Linq;

namespace PolindromTask_ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            string? str;
            Console.WriteLine("Введите строку");
            str = Console.ReadLine();
            str = str.ToLower().Replace(" ", string.Empty);

            string str1 = new string(str.ToCharArray().Reverse().ToArray());
            if (str == str1)
            {
                Console.WriteLine("Введённая строка является полиндромом");
            }
            else
            {
                Console.WriteLine("Введённая строка не является полиндромом");
            }
            
        }
    }
}
