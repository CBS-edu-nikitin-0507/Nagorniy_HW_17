using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    static class Calculator
    {
        public static double Add(this double[] arr, int index, ref double result)
        {
           return result += arr[index];
        }
        public static double Div(this double[] arr, int index, ref double result)
        {
           return result /= arr[index];
        }
        public static double Mul(this double[] arr, int index, ref double result)
        {
           return result *= arr[index];
        }
        public static double Sub(this double[] arr, int index, ref double result)
        {
           return result -= arr[index];
        }
    }
}
