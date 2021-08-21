using System;

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tCalculator");
            Console.WriteLine("Rules: 1.Enter operation(+,-,/,*) after each number 2.To get the result, click 'R'");
            double result = System.Double.Parse(Console.ReadLine());
            string operation;
            double[] arr = new double[1];
            int index = 0;
        OneMoreNumber:
            operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 2] = System.Double.Parse(Console.ReadLine());
                        arr.Add(index, ref result);
                        index++;
                        goto OneMoreNumber;
                       
                    }
                case "-":
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 2] = System.Double.Parse(Console.ReadLine());
                        arr.Sub(index, ref result);
                        index++;
                        goto OneMoreNumber;
                        
                    }
                case "/":
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 2] = System.Double.Parse(Console.ReadLine());
                        arr.Div(index, ref result);
                        index++;
                        goto OneMoreNumber;
                        
                    }
                case "*":
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 2] = System.Double.Parse(Console.ReadLine());
                        arr.Mul(index, ref result);
                        index++;
                        goto OneMoreNumber;
                        
                    }

            }
            if (Console.ReadKey().Key == ConsoleKey.R)
            {
                Console.WriteLine("Result= " + result) ;
            }


            }
        }
}
