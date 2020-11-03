using System;
using System.Collections.Generic;

namespace AttributeEx
{
    class Program
    {
        [AttributeUsage(AttributeTargets.Class)]
        public class Author : System.Attribute
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string CreatedAt { get; set; }
        }

        [AttributeUsage(AttributeTargets.Method)]
        public class Subroutine : System.Attribute
        {
            public string Description { get; set; }
        }


        #region Main Region
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator();
            Console.WriteLine("How many numbers do you have for addition and multiplication ::");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operands::");
            List<int> nums = new List<int>();
            for (int i = 0; i < n; i++)
            {
                nums.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Enter the nums for subtraction and devision");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Addition result ::{calculator.Add(nums)}");
            Console.WriteLine($"Subtraction result ::{calculator.Subtract(first,second)}");
            Console.WriteLine($"Multiplication result ::{ calculator.Multtiply (nums)}");
            Console.WriteLine($"Division result ::{calculator.Divide(first,second)}");
        }
        #endregion
    }
}
