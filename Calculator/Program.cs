using System.ComponentModel.Design;

namespace Calculator_Program

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            
        }
    }
    public class Calculator
    {
        public Calculator()
        {

        }
        public void Menu()
        {
            string Option;
            int NumberOne;
            int NumberTwo;
            string[] Valid = {"A", "S", "M", "D"};
            while (true)
            {
                Console.WriteLine("Choose an Option(A,S,M,D)");
                Option = Console.ReadLine();
                if (Valid.Contains(Option))
                {
                    break;
                }
            }
            Console.WriteLine("Enter Your First Number");
            NumberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number");
            NumberTwo = int.Parse(Console.ReadLine());
            if (Option == "A")
            {
                Console.WriteLine(Add(NumberOne, NumberTwo));  
            }
            if (Option == "S")
            {
                Console.WriteLine(Subtract(NumberOne, NumberTwo));
            }
            if (Option == "D")
            {
                Console.WriteLine(Divide(NumberOne, NumberTwo));
            }
            if (Option == "M")
            {
                Console.WriteLine(Multiply(NumberOne, NumberTwo));
            }
        }
        public int Add(int NumberOne, int NumberTwo)
        {
            int Result;
            Result = NumberOne + NumberTwo;
            return Result;
        }
        public int Subtract(int NumberOne, int NumberTwo)
        {
            int Result;
            Result = NumberOne - NumberTwo;
            return Result;
        }
        public int Multiply(int NumberOne, int NumberTwo)
        {
            int Result;
            Result = NumberOne * NumberTwo;
            return Result;
        }
        public int Divide(int NumberOne, int NumberTwo)
        {
            int Result;
            Result = NumberOne / NumberTwo;
            return Result;
        }
    }
}
