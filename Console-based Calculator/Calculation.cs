using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculation
    {
        //private int _result = 0;
        public void Addition(int num1,int num2)
        {
            display("SUM", num1 + num2);
        }
        public void Subtraction(int num1,int num2) 
        {
            display("DIFFERENCE", num1 - num2);
        }
        public void Multiplication(int num1,int num2)
        {
            display("PRODUCT", num1 * num2);
        }
        public void Divide(int num1,int num2)
        {
            try
            {
                display("DIVISION", num1 / num2);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void display(string text, int result)
        {
            Console.WriteLine(text + ": " + result);
        }
    }
}
