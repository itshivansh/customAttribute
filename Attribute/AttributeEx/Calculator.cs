using System;
using System.Collections.Generic;
using System.Text;
using static AttributeEx.Program;

namespace AttributeEx
{
    [Author(Name = "Shivansh Tiwari", Email = "s@gmail.com", CreatedAt = "3-11-2020")]
    class Calculator
    {
        [Subroutine(Description = "Add")]
        public int Add(List<int> nums)
        {
            int sum = 0;
            foreach (int n in nums)
            {
                sum += n;
            }
            return sum;
        }
        [Subroutine(Description = "Subtract")]
        public int Subtract(int firstNum,int secondNum)
        {
            return firstNum - secondNum;
        }
        [Subroutine(Description = "Multiply")]
        public int Multtiply(List<int> nums)
        {
            int result = 1;
            foreach (int n in nums)
            {
                result *= n;
            }
            return result;
        }
        [Subroutine(Description = "Divide")]
        public int Divide(int firstNum, int secondNum)
        {            
            return firstNum / secondNum;
        }
    }
}
