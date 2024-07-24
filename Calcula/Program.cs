using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculator");

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Error: Division by zero");
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }

        Console.WriteLine($"Result: {result}");
    }
}
// Hello anh em, toi la Ly Thai Cuong, va day la bai hoc dau tien ve lap trinh C# cua chung ta. Trong bai hoc nay, chung ta se tao ra mot chuong trinh may tinh co ban. Chung ta se nhap vao hai so va mot phep toan, sau do chuong trinh se tinh toan va in ra ket qua. Hay bat dau nhe!